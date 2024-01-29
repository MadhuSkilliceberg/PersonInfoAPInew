using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IRepository
{
   public interface IUserEducationDetailRepo
    {
        public List<UserEducationDetail> GetUsers();
        public int InsertUser(UserEducationDetail user);

        public int UpdateUser(UserEducationDetail user);

        public int DeleteUser(int id);

        public UserEducationDetail GetByUserId(int id);

        public bool AddUserEducationDetails(List<UserEducationDetail> userEducationDetails);


    }
}
