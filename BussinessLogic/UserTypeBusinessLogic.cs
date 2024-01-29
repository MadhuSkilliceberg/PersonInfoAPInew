using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class UserTypeBusinessLogic: IUserTypeBusinessLogic
    {
        IUserTypeRepo UserTypeRepo;

        public  UserTypeBusinessLogic(IUserTypeRepo Repo)
        {
            UserTypeRepo = Repo;
        }

        public int DeleteUserType(int id)
        {
            return UserTypeRepo.DeleteUserType(id);
        }

        public UserType GetByUserTypeId(int id)
        {
            return UserTypeRepo.GetByUserTypeId(id);
        }

        public List<UserType> GetUserTypes()
        {
            return UserTypeRepo.GetUserTypes();
        }

        public bool InsertUserType(UserType UserType)
        {
            return UserTypeRepo.InsertUserType(UserType);
        }

        public bool UpdateUserType(UserType UserType)
        {
            return UserTypeRepo.UpdateUserType(UserType);
        }
    }
}
