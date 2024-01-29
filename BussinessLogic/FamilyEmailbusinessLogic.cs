using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class FamilyEmailbusinessLogic : IFamilyEmailbusinessLogic
    {
        IFamilyEmailRepo emailRepo;
        public FamilyEmailbusinessLogic(IFamilyEmailRepo Bhanu)
        {
           emailRepo=Bhanu;

        }
        public int DeleteFamilyEmail(int id)
        {
            return emailRepo.DeleteFamilyEmail(id);
        }

        public FamilyEmail GetById(int id)
        {
            return emailRepo.GetById(id);
        }

        public List<FamilyEmail> GetFamilyEmails()
        {
            return emailRepo.GetFamilyEmails();
        }

        public int InsertFamilyEmail(FamilyEmail email)
        {
            return emailRepo.InsertFamilyEmail(email);
        }

        public int UpdateFamilyEmail(FamilyEmail email)
        {
            return emailRepo.UpdateFamilyEmail(email);
        }
    }
}
