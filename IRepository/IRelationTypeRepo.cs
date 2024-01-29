using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IRepository
{
   public interface IRelationTypeRepo
    {
        public List<RelationType> GetUsers();
        public int InsertUser(RelationType relationType);

        public int UpdateUser(RelationType relationType);

        public int DeleteUser(int id);

        public RelationType GetByUserId(int id);


    }
}
