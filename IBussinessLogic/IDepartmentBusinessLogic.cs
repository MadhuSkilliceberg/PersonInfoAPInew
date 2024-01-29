using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IBussinessLogic
{
  public  interface IDepartmentBusinessLogic
    {
        public List<Department> GetDepartment();
        public int InsertDepartment(Department Department);

        public bool UpdateDepartment(Department Department);

        public int DeleteDepartment(int id);

        public Department GetByDepartmentId(int id);

    }
}
