using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDemo1
{
    using static System.Console;

    /// <summary>
    /// Mediates between the users handling the actions for activity.
    /// </summary>
    public class ActivityMediator
    {
        /// <summary>
        /// Gets the activities.
        /// </summary>
        /// <value>
        /// The activities.
        /// </value>
        public IDictionary<string,Activity> Activities { get; } = new Dictionary<string,Activity>();

        /// <summary>
        /// Gets the users.
        /// </summary>
        /// <value>
        /// The users.
        /// </value>
        public IDictionary<string,UserColleague> Users { get; } = new Dictionary<string,UserColleague>();

        /// <summary>
        /// Registers the user.
        /// </summary>
        /// <param name="user">The user.</param>
        public void RegisterUser(UserColleague user)
        {
            if (Users.ContainsKey(user.Id))
            {
                WriteLine($"User with id - {user.Id} already registered");
            }
            else
            {
                Users.Add(user.Id, user);
                WriteLine($"User with id - {user.Id} has been registered");
            }            
        }

        /// <summary>
        /// Creates the activity.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="user">The user.</param>
        public void CreateActivity(string id, String name, UserColleague user)
        {
            if (!Users.ContainsKey(user.Id))
            {
                throw new ApplicationException("User not yet registred");
            }

            var newActivity = new Activity(id, name, user);
            Activities.Add(id, newActivity);

            var usersToBeNotified = Users.Where(uc => !uc.Key.Equals(user.Id)).Select(uc=>uc.Value);

            foreach (var userToBeNotified in usersToBeNotified)
            {
                userToBeNotified.NotifyActivity(newActivity);
            }
        }

        /// <summary>
        /// Registers for bid.
        /// </summary>
        /// <param name="activityId">The activity identifier.</param>
        /// <param name="user">The user.</param>
        public void RegisterForBid(string activityId, UserColleague user)
        {
            Activity activity = null;
            if (!Activities.TryGetValue(activityId, out activity))
            {
                WriteLine($"Activity with activity id: {activityId} doesn't exist");
            }
            else
            {
                if (!activity.Buyers.Any(uc=>uc.Id.Equals(user.Id)))
                {
                    activity.Buyers.Add(user);
                    activity.Seller.NotifyOnNewBuyerRegistration(user, activity);
                    //WriteLine($"User with user id: {user.Id} has been added as buyer for activity with id: {activityId}.");
                }
                else
                {
                    WriteLine($"User with user id: {user.Id} is already buyer for activity with id: {activityId}.");
                }
                
            }
        }

        /// <summary>
        /// Bids the specified activity identifier.
        /// </summary>
        /// <param name="activityId">The activity identifier.</param>
        /// <param name="user">The user.</param>
        /// <param name="bidValue">The bid value.</param>
        public void Bid(string activityId, UserColleague user, float bidValue)
        {
            Activity activity = null;
            if (!Activities.TryGetValue(activityId, out activity))
            {
                WriteLine($"Activity with activity id: {activityId} doesn't exist");
            }
            else
            {
                if (!activity.Buyers.Any(uc=>uc.Id.Equals(user.Id)))
                {
                    WriteLine($"User with user id: {user.Id} is not a valid buyer for activity with id: {activityId}.");
                }
                else
                {
                    activity.Bids.Add(bidValue, user);
                    activity.Seller.NotifyOnBid(user, activity, bidValue);
                }
            }
        }

    }
}
