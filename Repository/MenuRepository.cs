using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Repository
{
    public class MenuRepository : IMenuRepo
    {
        PersonsInfoV3NewContext person = new PersonsInfoV3NewContext();
        public int DeleteMenu(int id)
        {
            var a = person.Menus.Where(c => c.Id == id).FirstOrDefault();
            person.Menus.Remove(a);
            person.SaveChanges();
            return 1;
        }

        public Menu GetByMenuId(int id)
        {
            return person.Menus.Where(c => c.Id == id).FirstOrDefault();
        }

        public List<Menu> GetMenus()
        {
            return person.Menus.ToList();
        }

        public int InsertMenu(Menu Menu)
        {
            person.Menus.Add(Menu);
            person.SaveChanges();
            return Menu.Id;

        }

        public bool UpdateMenu(Menu Menu)
        {
            person.Menus.Update(Menu);
            person.SaveChanges();
            return true;
        }
    }
}
