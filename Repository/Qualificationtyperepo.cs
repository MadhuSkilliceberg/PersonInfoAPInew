using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Repository
{
   
    public class Qualificationtyperepo : IQualificationtypeRepo
    {
        PersonsInfoV3NewContext Context = new PersonsInfoV3NewContext();
        public int DeleteUser(int id)
        {
            var k = Context.QulificationTypes.Where(a => a.Id == id).FirstOrDefault();
            Context.QulificationTypes.Remove(k);
            Context.SaveChanges();
            return 1;
        }

        public QulificationType GetByUserId(int id)
        {
            var k = Context.QulificationTypes.Where(a => a.Id == id).FirstOrDefault();
            return k;
        }

        public List<QulificationType> GetUsers()
        {
            return Context.QulificationTypes.ToList();
        }

        public int InsertUser(QulificationType  qualificationtype)
        {
            Context.QulificationTypes.Add(qualificationtype);
            Context.SaveChanges();
            return qualificationtype.Id;
        }

        public int UpdateUser(QulificationType qualificationtype)
        {
            Context.QulificationTypes.Update(qualificationtype);
            Context.SaveChanges();
            return qualificationtype.Id;
        }
    }
}
