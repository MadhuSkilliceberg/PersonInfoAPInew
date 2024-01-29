using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Repository
{
    public class InstitutionContactRepo : IInstitutionContactRepo
    {
        PersonsInfoV3NewContext Context = new PersonsInfoV3NewContext();

        public int DeleteInstitutionContact(int id)
        {
            var k = Context.InstitutionContacts.Where(a => a.Id == id).FirstOrDefault();
            Context.InstitutionContacts.Remove(k);
            Context.SaveChanges();
            return 1;
        }

        public InstitutionContact GetByInstitutionContactId(int id)
        {
            return Context.InstitutionContacts.Where(a => a.Id == id).FirstOrDefault();

        }

        public List<InstitutionContact> GetInstitutionContacts()
        {
            return Context.InstitutionContacts.ToList();
        }

        public int InsertInstitutionContact(InstitutionContact institutionContact)
        {
            Context.InstitutionContacts.Add(institutionContact);
            Context.SaveChanges();
            return institutionContact.Id;
        }

        public int UpdateInstitutionContact(InstitutionContact institutionContact)
        {
            Context.InstitutionContacts.Update(institutionContact);
            Context.SaveChanges();
            return institutionContact.Id;
        }
        public bool AddinstitutionContactsDetails(List<InstitutionContact> institutionContacts)
        {
            try
            {
                if (institutionContacts != null)
                {
                    Context.InstitutionContacts.AddRange(institutionContacts);
                    Context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public bool UpdateinstitutionContactsDetails(List<InstitutionContact> institutionContacts)
        {
            try
            {
                if (institutionContacts != null)
                {
                    Context.InstitutionContacts.UpdateRange(institutionContacts);
                    Context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public bool DeleteinstitutionContactsDetails(List<InstitutionContact> institutionContacts)
        {
            try
            {
                if (institutionContacts != null)
                {
                    Context.InstitutionContacts.RemoveRange(institutionContacts);
                    Context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public List<InstitutionContact> GetInstitutionContactsByAddressId(int AddressId)
        {
            return Context.InstitutionContacts.Where(i => i.InstitutionAddressId == AddressId).ToList();
        }
    }
}
