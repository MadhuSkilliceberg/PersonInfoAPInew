using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IBussinessLogic
{
    public interface IFamilyContactBusinessLogic
    {
        public List<FamilyContact> GetUsers();
        public bool InsertUser(FamilyContact user);

        public bool UpdateUser(FamilyContact user);

        public int DeleteUser(int id);

        public FamilyContact GetByUserId(int id);
    }
}
