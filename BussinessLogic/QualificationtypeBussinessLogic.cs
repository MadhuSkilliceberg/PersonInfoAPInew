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

        IQualificationtypeRepo qualificatio;

      public   QualificationtypeBussinessLogic(IQualificationtypeRepo Repo)
        {
            qualificatio = Repo;
        }

        public int DeleteUser(int id)
        {
            return qualificatio.DeleteUser(id);
        }

        public QulificationType GetByUserId(int id)
        {

            return qualificatio.GetByUserId(id);
        }

        public List<QulificationType> GetUsers()
        {

            return qualificatio.GetUsers();
        }

        public int InsertUser(QulificationType qualificationtype)
        {

            return qualificatio.InsertUser(qualificationtype);
        }

        public int UpdateUser(QulificationType qualificationtype)
        {

            return qualificatio.UpdateUser(qualificationtype);
        }
    }
}
