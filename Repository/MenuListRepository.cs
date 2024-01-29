using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Repository
{
    public class MenuListRepository : IMenuListRepo
    {
        PersonsInfoV3NewContext person = new PersonsInfoV3NewContext();
        public int DeleteMenuList(int id)
        {
            var a = person.MenuLists.Where(c => c.MId == id).FirstOrDefault();
            person.MenuLists.Remove(a);
            person.SaveChanges();
            return 1;
        }

        public MenuList GetByMenuListId(int id)
        {
            return person.MenuLists.Where(c => c.MId == id).FirstOrDefault();
        }

        public List<MenuList> GetMenuLists()
        {
            return person.MenuLists.ToList();
        }

        public int InsertMenuList(MenuList MenuList)
        {
            person.MenuLists.Add(MenuList);
            person.SaveChanges();
            return MenuList.MId;

        }

        public bool UpdateMenuList(MenuList MenuList)
        {
            person.MenuLists.Update(MenuList);
            person.SaveChanges();
            return true;
        }
    }
}
