using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class QualificationtypeBussinessLogic: IQualificationtypeBussinessLogic
    {

        IQualificationTypeRepo qualificationTypeRepo     ;

      public   QualificationtypeBussinessLogic(IQualificationTypeRepo Repo)
        {
            qualificationTypeRepo = Repo;
        }

        public int DeleteQulificationType(int id)
        {
            return qualificationTypeRepo.DeleteQualificationType(id);
        }

        public QulificationType GetQulificationTypeById(int id)
        {

            return qualificationTypeRepo.GetQualificationTypeById(id);
        }

        public List<QulificationType> GetQulificationTypes()
        {

            return qualificationTypeRepo.GetQualificationTypes();
        }

        public int InsertQulificationType(QulificationType qualificationTypeRepontype)
        {

            return qualificationTypeRepo.InsertQualificationType(qualificationTypeRepontype);
        }

        public int UpdateQulificationType(QulificationType qualificationTypeRepontype)
        {

            return qualificationTypeRepo.UpdateQualificationType(qualificationTypeRepontype);
        }
    }
}
