using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Repository
{
    public class DepartmentRepository : IDepartmentRepo
    {
        PersonsInfoV3NewContext person = new PersonsInfoV3NewContext();
        public int DeleteDepartment(int id)
        {
            var a = person.Departments.Where(c => c.Id == id).FirstOrDefault();
            person.Departments.Remove(a);
            person.SaveChanges();
            return 1;
        }

        public Department GetByDepartmentId(int id)
        {
            return person.Departments.Where(c => c.Id == id).FirstOrDefault();
        }

        public List<Department> GetDepartment()
        {
            return person.Departments.ToList();
        }

       

        public int InsertDepartment(Department Department)
        {
            person.Departments.Add(Department);
            person.SaveChanges();
            return Department.Id;

        }

        public bool UpdateDepartment(Department Department)
        {
            person.Departments.Update(Department);
            person.SaveChanges();
            return true;
        }
    }
}
