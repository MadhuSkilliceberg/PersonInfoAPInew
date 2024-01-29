using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Repository
{
    public class RelationTypeRepository : IRelationTypeRepo
    {
        PersonsInfoV3NewContext Context = new PersonsInfoV3NewContext();
        public int DeleteUser(int id)
        {
            var k = Context.RelationTypes.Where(a => a.Id == id).FirstOrDefault();
            Context.RelationTypes.Remove(k);
            Context.SaveChanges();
            return 1;
        }

        public RelationType GetByUserId(int id)
        {
            var k = Context.RelationTypes.Where(a => a.Id == id).FirstOrDefault();
            return k;
        }

        public List<RelationType> GetUsers()
        {
            return Context.RelationTypes.ToList();
        }

        public int InsertUser(RelationType relationType)
        {
            Context.RelationTypes.Add(relationType);
            Context.SaveChanges();
            return relationType.Id;
        }

        public int UpdateUser(RelationType relationType)
        {
            Context.RelationTypes.Update(relationType);
            Context.SaveChanges();
            return relationType.Id;
        }
    }
}
