using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IRepository
{
    public interface IEmploymentTypeRepo
    {
        public List<EmploymentType> GetEmploymentTypes();
        public int InsertEmploymentType(EmploymentType EmploymentType);

        public bool UpdateEmploymentType(EmploymentType EmploymentType);

        public int DeleteEmploymentType(int id);

        public EmploymentType GetByEmploymentTypeId(int id);


    }
}
