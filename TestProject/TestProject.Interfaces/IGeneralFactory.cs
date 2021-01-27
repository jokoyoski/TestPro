using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.Interfaces
{
   public  interface IGeneralFactory
    {
        IPersonView CreateItemListView(IList<IPerson> userList);
    }
}
