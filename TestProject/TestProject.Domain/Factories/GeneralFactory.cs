using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Domain.Model;
using TestProject.Interfaces;

namespace TestProject.Domain.Factories
{
    public class GeneralFactory: IGeneralFactory
    {
        /// <summary>
        /// Creates the item ListView.
        /// </summary>
        /// <param name="userList">The user list.</param>
        /// <returns></returns>
        public IPersonView CreateItemListView(IList<IPerson> userList)
        {
            var viewModel = new PersonView
            {
                UserCollection = userList,
            };

            return viewModel;
        }
    }
}
