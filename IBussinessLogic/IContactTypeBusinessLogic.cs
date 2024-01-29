using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IBussinessLogic
{
  public  interface IContactTypeBusinessLogic
    {
        public List<ContactType> GetContactTypes();
        public bool InsertContactType(ContactType ContactType);

        public bool UpdateContactType(ContactType ContactType);

        public int DeleteContactType(int id);

        public ContactType GetByContactTypeId(int id);

    }
}
