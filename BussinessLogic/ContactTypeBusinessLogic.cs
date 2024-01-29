using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class ContactTypeBusinessLogic: IContactTypeBusinessLogic
    {
        IContactTypeRepo ContactTypeRepo;

        public  ContactTypeBusinessLogic(IContactTypeRepo Repo)
        {
            ContactTypeRepo = Repo;
        }

        public int DeleteContactType(int id)
        {
            return ContactTypeRepo.DeleteContactType(id);
        }

        public ContactType GetByContactTypeId(int id)
        {
            return ContactTypeRepo.GetByContactTypeId(id);
        }

        public List<ContactType> GetContactTypes()
        {
            return ContactTypeRepo.GetContactTypes();
        }

        public bool InsertContactType(ContactType ContactType)
        {
            return ContactTypeRepo.InsertContactType(ContactType);
        }

        public bool UpdateContactType(ContactType ContactType)
        {
            return ContactTypeRepo.UpdateContactType(ContactType);
        }
    }
}
