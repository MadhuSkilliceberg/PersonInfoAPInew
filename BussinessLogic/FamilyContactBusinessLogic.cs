using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class FamilyContactBusinessLogic : IFamilyContactBusinessLogic
    {
        IFamilyContactRepo family;
      public  FamilyContactBusinessLogic(IFamilyContactRepo Repo)
        {
            family = Repo;
        }


        public int DeleteUser(int id)
        {
            return family.DeleteUser(id);
        }

        public FamilyContact GetByUserId(int id)
        {
            return family.GetByUserId(id);
        }

        public List<FamilyContact> GetUsers()
        {
            return family.GetUsers();
        }

        public bool InsertUser(FamilyContact user)
        {
            return family.InsertUser(user);
        }

        public bool UpdateUser(FamilyContact user)
        {
            return family.UpdateUser(user);
        }
    }
}
