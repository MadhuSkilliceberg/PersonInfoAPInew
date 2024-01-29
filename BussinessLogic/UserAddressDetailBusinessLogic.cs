using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class UserAddressDetailBusinessLogic: IUserAddressDetailBusinessLogic
    {
        IUserAddressDetailRepo detailRepo;

      public  UserAddressDetailBusinessLogic(IUserAddressDetailRepo Repo)
        {
            detailRepo= Repo;
        }

        public int DeleteUser(int id)
        {
            return detailRepo.DeleteUser(id);
        }

        public UserAddressDetail GetByUserId(int id)
        {
            return detailRepo.GetByUserId(id);

        }

        public List<UserAddressDetail> GetUsers()
        {
            return detailRepo.GetUsers();
        }

        public bool InsertUser(UserAddressDetail user)
        {
            return detailRepo.InsertUser(user);
        }

        public bool UpdateUser(UserAddressDetail user)
        {
            return detailRepo.UpdateUser(user);
        }
    }
}
