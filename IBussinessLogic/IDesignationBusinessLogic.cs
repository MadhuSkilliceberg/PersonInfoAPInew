using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IBussinessLogic
{
    public interface IDesignationBusinessLogic
    {
        public List<Designation> GetUsers();
        public int InsertUser(Designation user);

        public int UpdateUser(Designation user);

        public int DeleteUser(int id);

        public Designation GetByUserId(int id);
    }
}
