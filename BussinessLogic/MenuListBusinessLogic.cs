using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class MenuListBusinessLogic: IMenuListBusinessLogic
    {
        IMenuListRepo MenuListRepo;

        public  MenuListBusinessLogic(IMenuListRepo Repo)
        {
            MenuListRepo = Repo;
        }

        public int DeleteMenuList(int id)
        {
            return MenuListRepo.DeleteMenuList(id);
        }

        public MenuList GetByMenuListId(int id)
        {
            return MenuListRepo.GetByMenuListId(id);
        }

        public List<MenuList> GetMenuLists()
        {
            return MenuListRepo.GetMenuLists();
        }

        public int InsertMenuList(MenuList MenuList)
        {
            return MenuListRepo.InsertMenuList(MenuList);
        }

        public bool UpdateMenuList(MenuList MenuList)
        {
            return MenuListRepo.UpdateMenuList(MenuList);
        }
    }
}
