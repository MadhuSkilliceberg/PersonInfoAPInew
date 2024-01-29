using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IBussinessLogic
{
  public  interface IMenuBusinessLogic
    {
        public List<Menu> GetMenus();
        public int InsertMenu(Menu Menu);

        public bool UpdateMenu(Menu Menu);

        public int DeleteMenu(int id);

        public Menu GetByMenuId(int id);

    }
}
