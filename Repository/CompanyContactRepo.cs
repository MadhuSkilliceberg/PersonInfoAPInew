using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Repository
{
    public class CompanyContactRepo : ICompanyContactRepo
    {
        PersonsInfoV3NewContext Context = new PersonsInfoV3NewContext();

        public bool AddCompanyContact(List<CompanyContact> companyContacts)
        {
            try
            {
                if (companyContacts != null)
                {
                    Context.CompanyContacts.AddRange(companyContacts);
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

        public bool UpdateCompanyContact(List<CompanyContact> companyContacts)
        {
            try
            {
                if (companyContacts != null)
                {
                    Context.CompanyContacts.UpdateRange(companyContacts);
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

        public int DeleteCompanyContact(int id)
        {

            var k = Context.CompanyContacts.Where(a => a.Id == id).FirstOrDefault();
            Context.CompanyContacts.Remove(k);
            Context.SaveChanges();
            return 1;
        }


        public List<CompanyContact> GetCompanyContacts()
        {
            return Context.CompanyContacts.ToList();
        }

        public int InsertCompanyContact(CompanyContact companyContact)
        {
            Context.CompanyContacts.Add(companyContact);
            Context.SaveChanges();
            return companyContact.Id;
        }

        public bool UpdateCompanyContact(CompanyContact companyContact)
        {
            Context.CompanyContacts.Update(companyContact);
            Context.SaveChanges();
            return true;
        }



        public List<CompanyContact> GetCompanyContactsByCompanyAddressId(int companyaddressId)
        {
            return Context.CompanyContacts.Where(i => i.CompanyAddressId == companyaddressId).ToList();
        }

        public CompanyContact GetCompanyContactsById(int id)
        {
            var data = Context.CompanyContacts.Where(a => a.Id == id).FirstOrDefault();
            return data;
        }

    }
}
