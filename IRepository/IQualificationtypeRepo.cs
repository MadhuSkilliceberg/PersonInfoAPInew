using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IRepository
{
 public   interface IQualificationtypeRepo
    {
        public List<QulificationType> GetUsers();
        public int InsertUser(QulificationType qualificationtype);

        public int UpdateUser(QulificationType qualificationtype);

        public int DeleteUser(int id);

        public QulificationType GetByUserId(int id);


    }
}
