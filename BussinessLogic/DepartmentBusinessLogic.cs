using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class DepartmentBusinessLogic: IDepartmentBusinessLogic
    {
        IDepartmentRepo DepartmentRepo;

        public  DepartmentBusinessLogic(IDepartmentRepo Repo)
        {
            DepartmentRepo = Repo;
        }

        public int DeleteDepartment(int id)
        {
            return DepartmentRepo.DeleteDepartment(id);
        }

        public Department GetByDepartmentId(int id)
        {
            return DepartmentRepo.GetByDepartmentId(id);
        }

        public List<Department> GetDepartment()
        {
            return DepartmentRepo.GetDepartment();
        }

        public int InsertDepartment(Department Department)
        {
            return DepartmentRepo.InsertDepartment(Department);
        }

        public bool UpdateDepartment(Department Department)
        {
            return DepartmentRepo.UpdateDepartment(Department);
        }
    }
}
