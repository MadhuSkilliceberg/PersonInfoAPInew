using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class DesignationBusinessLogic : IDesignationBusinessLogic
    {
        IDesignationRepo designation;

     public   DesignationBusinessLogic(IDesignationRepo Repo)
        {
            designation = Repo;
        }

        public int DeleteUser(int id)
        {
            return designation.DeleteUser(id);
        }

        public Designation GetByUserId(int id)
        {
            return designation.GetByUserId(id);
        }

        public List<Designation> GetUsers()
        {
            return designation.GetUsers();
        }

        public int InsertUser(Designation user)
        {
            return designation.InsertUser(user);
        }

        public int UpdateUser(Designation user)
        {
            return designation.UpdateUser(user);
        }
    }
}
