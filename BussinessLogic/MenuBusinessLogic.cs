using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class MenuBusinessLogic: IMenuBusinessLogic
    {
        IMenuRepo MenuRepo;

        public  MenuBusinessLogic(IMenuRepo Repo)
        {
            MenuRepo = Repo;
        }

        public int DeleteMenu(int id)
        {
            return MenuRepo.DeleteMenu(id);
        }

        public Menu GetByMenuId(int id)
        {
            return MenuRepo.GetByMenuId(id);
        }

        public List<Menu> GetMenus()
        {
            return MenuRepo.GetMenus();
        }

        public int InsertMenu(Menu Menu)
        {
            return MenuRepo.InsertMenu(Menu);
        }

        public bool UpdateMenu(Menu Menu)
        {
            return MenuRepo.UpdateMenu(Menu);
        }
    }
}
