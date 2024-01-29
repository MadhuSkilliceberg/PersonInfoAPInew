using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class FamilyBusinessLogic: IFamilyBusinessLogic
    {
        IFamilyRepo family123;

       public FamilyBusinessLogic(IFamilyRepo Repo)
        {
            family123 = Repo;
        }

        public bool DeleteFamily(int id)
        {
            return family123.DeleteFamily(id);
        }

        public Family GetById(int id)
        {
            return family123.GetById(id);
        }

        public List<Family> GetFamilies()
        {
            return family123.GetFamilies();
            
        }

        public bool InsertFamily(Family family)
        {
            return family123.InsertFamily(family);
        }

        public bool UpdateFamily(Family family)
        {
            return family123.UpdateFamily(family);
        }
    }
}
