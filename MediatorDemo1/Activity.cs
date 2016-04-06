using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDemo1
{
    public class Activity : IActivity
    {
        /// <summary>
        /// Gets the activity identifier.
        /// </summary>
        /// <value>
        /// The activity identifier.
        /// </value>
        public string ActivityId { get; }

        /// <summary>
        /// Gets the name of the activity.
        /// </summary>
        /// <value>
        /// The name of the activity.
        /// </value>
        public string ActivityName { get; }

        /// <summary>
        /// Gets the seller.
        /// </summary>
        /// <value>
        /// The seller.
        /// </value>
        public UserColleague Seller { get; }

        /// <summary>
        /// Gets the buyers.
        /// </summary>
        /// <value>
        /// The buyers.
        /// </value>
        /// <remarks>Initialzers for auto properties</remarks>
        public ICollection<UserColleague> Buyers { get; } = new List<UserColleague>();

        /// <summary>
        /// Gets the bids.
        /// </summary>
        /// <value>
        /// The bids.
        /// </value>
        /// <remarks>Initialzers for auto properties</remarks>
        public IDictionary<float, UserColleague> Bids { get; } = new Dictionary<float, UserColleague>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Activity"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        /// <remarks>Getter only auto properties (ActivityId, ActivityName, Seller)</remarks>
        public Activity(string id, String name, UserColleague user)
        {
            ActivityId = id;
            ActivityName = name;
            Seller = user;
        }
    }

    public interface IActivity
    {
        /// <summary>
        /// Gets the activity identifier.
        /// </summary>
        /// <value>
        /// The activity identifier.
        /// </value>
        string ActivityId { get; }

        /// <summary>
        /// Gets the name of the activity.
        /// </summary>
        /// <value>
        /// The name of the activity.
        /// </value>
        string ActivityName { get; }

        /// <summary>
        /// Gets the seller.
        /// </summary>
        /// <value>
        /// The seller.
        /// </value>
        UserColleague Seller { get; }

        /// <summary>
        /// Gets the buyers.
        /// </summary>
        /// <value>
        /// The buyers.
        /// </value>
        ICollection<UserColleague> Buyers { get; }

        /// <summary>
        /// Gets the bids.
        /// </summary>
        /// <value>
        /// The bids.
        /// </value>
        IDictionary<float, UserColleague> Bids { get; }
    }
}
