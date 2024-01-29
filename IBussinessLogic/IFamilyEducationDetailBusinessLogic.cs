using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IBussinessLogic
{
     public interface IFamilyEducationDetailBusinessLogic
    {
        public List<FamilyEducationDetail> GetFamilyEducationDetail();
        public int InsertFamilyEducationDetail(FamilyEducationDetail detail);
        public int UpdateFamilyEducationDetail(FamilyEducationDetail detail);
        public int DeleteFamilyEducationDetail(int id);
        public FamilyEducationDetail GetById(int id);
    }
}
