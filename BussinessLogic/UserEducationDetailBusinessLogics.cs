using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class UserEducationDetailBusinessLogics : IUserEducationDetailLogics
    {
        IUserEducationDetailRepo Educaton;
        public UserEducationDetailBusinessLogics(IUserEducationDetailRepo Repo)
        {
            Educaton = Repo;
        }
        public int DeleteUser(int id)
        {
            return Educaton.DeleteUser(id);
        }

        public UserEducationDetail GetByUserId(int id)
        {
            return Educaton.GetByUserId(id);
        }

        public List<UserEducationDetail> GetUsers()
        {
            return Educaton.GetUsers();
        }

        public int InsertUser(UserEducationDetail user)
        {
            return Educaton.InsertUser(user);
        }

        public int UpdateUser(UserEducationDetail user)
        {
            return Educaton.UpdateUser(user);
        }
    }
}
