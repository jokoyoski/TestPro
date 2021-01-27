using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Interfaces;

namespace TestProject.Domain.Model
{
    public class PersonView:IPersonView
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the user collection.
        /// </summary>
        /// <value>
        /// The user collection.
        /// </value>
        public IList<IPerson> UserCollection {get; set;}
    }
}
