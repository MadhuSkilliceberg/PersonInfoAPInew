using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class FamilyEducationDetailBusinessLogic: IFamilyEducationDetailBusinessLogic
    {
        IFamilyEducationDetailRepository detailRepository;

        public FamilyEducationDetailBusinessLogic (IFamilyEducationDetailRepository Repo)
        {
            detailRepository = Repo;
        }

        public int DeleteFamilyEducationDetail(int id)
        {
            return detailRepository.DeleteFamilyEducationDetail(id);
        }

        public FamilyEducationDetail GetById(int id)
        {
            return detailRepository.GetById(id); 
        }

        public List<FamilyEducationDetail> GetFamilyEducationDetail()
        {
            return detailRepository.GetFamilyEducationDetail();
        }

        public int InsertFamilyEducationDetail(FamilyEducationDetail detail)
        {
             return detailRepository.InsertFamilyEducationDetail(detail);
        }

        public int UpdateFamilyEducationDetail(FamilyEducationDetail detail)
        {
            return detailRepository.UpdateFamilyEducationDetail(detail);
        }
    }
}
