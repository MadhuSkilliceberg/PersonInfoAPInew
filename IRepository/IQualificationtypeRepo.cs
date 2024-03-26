using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IRepository
{
    public interface IQualificationTypeRepo
    {
        public List<QulificationType> GetQualificationTypes();
        public int InsertQualificationType(QulificationType qualificationtype);

        public int UpdateQualificationType(QulificationType qualificationtype);

        public int DeleteQualificationType(int id);

        public QulificationType GetQualificationTypeById(int id);


    }
}
