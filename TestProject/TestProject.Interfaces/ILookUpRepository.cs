using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.Interfaces
{
   public interface ILookUpRepository
    {
        /// <summary>
        /// Gets the list of users.
        /// </summary>
        /// <returns></returns>
        IList<IPerson> GetListOfUsers();
    }
}
