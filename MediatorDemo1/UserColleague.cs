namespace MediatorDemo1
{
    using static System.Console;

    /// <summary>
    /// Handles the functionalities w.r.t activity mediator.
    /// </summary>
    public abstract class UserColleague
    {        
        /// <summary>
        /// Initializes a new instance of the <see cref="UserColleague"/> class.
        /// </summary>
        /// <param name="mediator">The mediator.</param>
        public UserColleague(ActivityMediator mediator)
        {
            this.Mediator = mediator;
        }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Id { get; set; }

        /// <summary>
        /// Gets the mediator.
        /// </summary>
        /// <value>
        /// The mediator.
        /// </value>
        protected ActivityMediator Mediator { get; }

        /// <summary>
        /// Notifies the activity.
        /// </summary>
        /// <param name="activity">The activity.</param>
        public void NotifyActivity(IActivity activity)
        {
            WriteLine($"Activity notified to user with id: {Id}");
        }

        /// <summary>
        /// Notifies the on new buyer registration.
        /// </summary>
        /// <param name="buyer">The buyer.</param>
        /// <param name="activity">The activity.</param>
        public void NotifyOnNewBuyerRegistration(UserColleague buyer, IActivity activity)
        {
            WriteLine($"Seller {Id} has been notified about the buyer {buyer.Id} for activity {activity.ActivityId}.");
        }

        /// <summary>
        /// Notifies the on bid.
        /// </summary>
        /// <param name="buyer">The buyer.</param>
        /// <param name="activity">The activity.</param>
        /// <param name="bidValue">The bid value.</param>
        public void NotifyOnBid(UserColleague buyer, IActivity activity, float bidValue)
        {
            WriteLine($"Seller {Id} has been notified about the bid {bidValue} by buyer {buyer.Id} for activity {activity.ActivityId}.");
        }

        /// <summary>
        /// Registers the current user.
        /// </summary>
        public void RegisterMe()
        {
            this.Mediator.RegisterUser(this);
        }

        /// <summary>
        /// Creates the activity.
        /// </summary>
        /// <param name="activityId">The activity identifier.</param>
        /// <param name="activityName">Name of the activity.</param>
        public void CreateActivity(string activityId, string activityName)
        {
            this.Mediator.CreateActivity(activityId, activityName, this);
        }

        /// <summary>
        /// Registers for bid.
        /// </summary>
        /// <param name="activityId">The activity identifier.</param>
        public void RegisterForBid(string activityId)
        {
            this.Mediator.RegisterForBid(activityId, this);
        }

        /// <summary>
        /// Applies the bid.
        /// </summary>
        /// <param name="activityId">The activity identifier.</param>
        /// <param name="bidValue">The bid value.</param>
        public void ApplyBid(string activityId, float bidValue)
        {
            this.Mediator.Bid(activityId, this, bidValue);
        }
    }
}
