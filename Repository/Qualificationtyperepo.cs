using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Repository
{
   
    public class QualificationTyperepo : IQualificationTypeRepo
    {
        PersonsInfoV3NewContext Context = new PersonsInfoV3NewContext();
        public int DeleteQualificationType(int id)
        {
            var k = Context.QulificationTypes.Where(a => a.Id == id).FirstOrDefault();
            Context.QulificationTypes.Remove(k);
            Context.SaveChanges();
            return 1;
        }

        public QulificationType GetQualificationTypeById(int id)
        {
            var k = Context.QulificationTypes.Where(a => a.Id == id).FirstOrDefault();
            return k;
        }

        public List<QulificationType> GetQualificationTypes()
        {
            return Context.QulificationTypes.ToList();
        }

        public int InsertQualificationType(QulificationType  qualificationtype)
        {
            Context.QulificationTypes.Add(qualificationtype);
            Context.SaveChanges();
            return qualificationtype.Id;
        }

        public int UpdateQualificationType(QulificationType qualificationtype)
        {
            Context.QulificationTypes.Update(qualificationtype);
            Context.SaveChanges();
            return qualificationtype.Id;
        }
    }
}
