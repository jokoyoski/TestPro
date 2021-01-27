using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.Interfaces
{
    public interface IGeneralService
    {
        /// <summary>
        /// Gets the list of users.
        /// </summary>
        /// <returns></returns>
        IPersonView GetListOfUsers();
    }
}
