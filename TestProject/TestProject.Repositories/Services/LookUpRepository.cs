using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Interfaces;
using TestProject.Repositories.Queries;

namespace TestProject.Repositories.Services
{
    public class LookUpRepository:ILookUpRepository
    {
        /// <summary>
        /// Gets the list of users.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="System.ApplicationException">Repository Get List Of Users</exception>
        public IList<IPerson> GetListOfUsers()
        {
            try
            {
                var list = LookUpQueries.getListOfUsers();
                    return list;
            }
            catch (Exception e)
            {
                throw new ApplicationException("Repository Get List Of Users", e);
            }
        }
    }
}
