using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IBussinessLogic
{
   public  interface IFamilyEmailbusinessLogic
    {
        public List<FamilyEmail> GetFamilyEmails();
        public int InsertFamilyEmail(FamilyEmail email);
        public int UpdateFamilyEmail(FamilyEmail email);
        public int DeleteFamilyEmail(int id);
        public FamilyEmail GetById(int id);
    }
}
