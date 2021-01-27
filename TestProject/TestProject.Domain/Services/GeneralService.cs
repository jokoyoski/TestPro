using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Interfaces;

namespace TestProject.Domain.Services
{
   public class GeneralService:IGeneralService
    {
        private readonly ILookUpRepository lookUpRepository;
        private readonly IGeneralFactory generalFactory;

        public GeneralService(ILookUpRepository lookUpRepository, IGeneralFactory generalFactory)
        {
            this.lookUpRepository = lookUpRepository;
            this.generalFactory = generalFactory;
        }

        /// <summary>
        /// Gets the list of users.
        /// </summary>
        /// <returns></returns>
        public IPersonView GetListOfUsers()
        {
            var userlist = this.lookUpRepository.GetListOfUsers();

            return this.generalFactory.CreateItemListView(userlist);
        }
    }
}
