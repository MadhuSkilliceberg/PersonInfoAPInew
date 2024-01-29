using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Repository
{
    public class EmploymentTypeRepository : IEmploymentTypeRepo
    {
        PersonsInfoV3NewContext person = new PersonsInfoV3NewContext();
        public int DeleteEmploymentType(int id)
        {
            var a = person.EmploymentTypes.Where(c => c.Id == id).FirstOrDefault();
            person.EmploymentTypes.Remove(a);
            person.SaveChanges();
            return 1;
        }

        public EmploymentType GetByEmploymentTypeId(int id)
        {
            return person.EmploymentTypes.Where(c => c.Id == id).FirstOrDefault();
        }

        public List<EmploymentType> GetEmploymentTypes()
        {
            return person.EmploymentTypes.ToList();
        }

        public int InsertEmploymentType(EmploymentType EmploymentType)
        {
            person.EmploymentTypes.Add(EmploymentType);
            person.SaveChanges();
            return EmploymentType.Id;

        }

        public bool UpdateEmploymentType(EmploymentType EmploymentType)
        {
            person.EmploymentTypes.Update(EmploymentType);
            person.SaveChanges();
            return true;
        }
    }
}
