using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Repository
{
    public class ContactTypeRepository : IContactTypeRepo
    {
        PersonsInfoV3NewContext person = new PersonsInfoV3NewContext();
        public int DeleteContactType(int id)
        {
            var a = person.ContactTypes.Where(c => c.Id == id).FirstOrDefault();
            person.ContactTypes.Remove(a);
            person.SaveChanges();
            return 1;
        }

        public ContactType GetByContactTypeId(int id)
        {
            return person.ContactTypes.Where(c => c.Id == id).FirstOrDefault();
        }

        public List<ContactType> GetContactTypes()
        {
            return person.ContactTypes.ToList();
        }

        public bool InsertContactType(ContactType ContactType)
        {
            person.ContactTypes.Add(ContactType);
            person.SaveChanges();
            return true;

        }

        public bool UpdateContactType(ContactType ContactType)
        {
            person.ContactTypes.Update(ContactType);
            person.SaveChanges();
            return true;
        }
    }
}
