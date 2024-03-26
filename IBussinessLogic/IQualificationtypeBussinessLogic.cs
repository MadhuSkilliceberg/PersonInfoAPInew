using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IBussinessLogic
{
    public interface IQualificationtypeBussinessLogic
    {
        public List<QulificationType> GetQulificationTypes();
        public int InsertQulificationType(QulificationType qualificationtype);

        public int UpdateQulificationType(QulificationType qulificationType);

        public int DeleteQulificationType(int id);

        public QulificationType GetQulificationTypeById(int id);
    }
}
