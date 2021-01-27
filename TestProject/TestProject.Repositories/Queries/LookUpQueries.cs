using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Interfaces;

namespace TestProject.Repositories.Queries
{
    public class LookUpQueries
    {
        /// <summary>
        /// Gets the list of users.
        /// </summary>
        /// <returns></returns>
        internal static IList<IPerson> getListOfUsers()
        {
            var person = new List<IPerson>() {
                new PersonModel(){ Id = 1, Name="Joko"},
                new PersonModel(){ Id = 2, Name="Timothy"},
                new PersonModel(){ Id = 3, Name="Moses"},
            };
            return person;
        }
    }
}
