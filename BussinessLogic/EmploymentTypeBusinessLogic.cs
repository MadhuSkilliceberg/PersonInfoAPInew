using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class EmploymentTypeBusinessLogic: IEmploymentTypeBusinessLogic
    {
        IEmploymentTypeRepo EmploymentTypeRepo;

        public  EmploymentTypeBusinessLogic(IEmploymentTypeRepo Repo)
        {
            EmploymentTypeRepo = Repo;
        }

        public int DeleteEmploymentType(int id)
        {
            return EmploymentTypeRepo.DeleteEmploymentType(id);
        }

        public EmploymentType GetByEmploymentTypeId(int id)
        {
            return EmploymentTypeRepo.GetByEmploymentTypeId(id);
        }

        public List<EmploymentType> GetEmploymentTypes()
        {
            return EmploymentTypeRepo.GetEmploymentTypes();
        }

        public int InsertEmploymentType(EmploymentType EmploymentType)
        {
            return EmploymentTypeRepo.InsertEmploymentType(EmploymentType);
        }

        public bool UpdateEmploymentType(EmploymentType EmploymentType)
        {
            return EmploymentTypeRepo.UpdateEmploymentType(EmploymentType);
        }
    }
}
