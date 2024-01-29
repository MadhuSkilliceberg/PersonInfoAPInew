using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IBussinessLogic
{
  public  interface IMenuListBusinessLogic
    {
        public List<MenuList> GetMenuLists();
        public int InsertMenuList(MenuList MenuList);

        public bool UpdateMenuList(MenuList MenuList);

        public int DeleteMenuList(int id);

        public MenuList GetByMenuListId(int id);

    }
}
