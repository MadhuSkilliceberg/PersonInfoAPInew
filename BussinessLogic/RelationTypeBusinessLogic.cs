using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class RelationTypeBusinessLogic: IRelationTypeBusinessLogic
    {
        IRelationTypeRepo relation;

       public RelationTypeBusinessLogic (IRelationTypeRepo Repo)
        {
            relation = Repo;
        }

        public int DeleteUser(int id)
        {
            return relation.DeleteUser(id);
        }

        public RelationType GetByUserId(int id)
        {
            return relation.GetByUserId(id);
        }

        public List<RelationType> GetUsers()
        {
            return relation.GetUsers();
        }

        public int InsertUser(RelationType relationType)
        {
            return relation.InsertUser(relationType);
        }

        public int UpdateUser(RelationType relationType)
        {
            return relation.UpdateUser(relationType);
        }
    }
}
