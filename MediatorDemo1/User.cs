using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDemo1
{
    /// <summary>
    /// Holds the edtails of the user.
    /// </summary>
    public class User : UserColleague
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="User"/> class.
        /// </summary>
        /// <param name="mediator">The mediator.</param>
        public User(ActivityMediator mediator) : base(mediator)
        {
        }
    }
}
