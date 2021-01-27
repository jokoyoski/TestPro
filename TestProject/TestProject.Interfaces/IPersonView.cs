using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.Interfaces
{
    public interface IPersonView
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
         int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
         string Name { get; set; }

        /// <summary>
        /// Gets or sets the user collection.
        /// </summary>
        /// <value>
        /// The user collection.
        /// </value>
         IList<IPerson> UserCollection { get; set; }
    }
}
