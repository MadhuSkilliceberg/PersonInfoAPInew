using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Repository
{
    public class CompanyEmailRepo : ICompanyEmailRepo
    {
        PersonsInfoV3NewContext Context = new PersonsInfoV3NewContext();


        public CompanyEmail GetCompanyEmailById(int id)
        {
            var data = Context.CompanyEmails.Where(a => a.Id == id).FirstOrDefault();
            return data;
        }

        public bool AddCompanyEmail(List<CompanyEmail> companyEmails)
        {
            try
            {
                if (companyEmails != null)
                {
                    Context.CompanyEmails.AddRange(companyEmails);
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


        public int DeleteCompanyEmail(int id)
        {
            var k = Context.CompanyEmails.Where(a => a.Id == id).FirstOrDefault();
            Context.CompanyEmails.Remove(k);
            Context.SaveChanges();
            return 1;
        }

        public List<CompanyEmail> GetCompanyEmailByCompanyAddressId(int companyaddressId)
        {
            return Context.CompanyEmails.Where(a => a.CompanyAddressId == companyaddressId).ToList();
        }

        public List<CompanyEmail> GetCompanyEmails()
        {
            return Context.CompanyEmails.ToList();
        }

        public int InsertCompanyEmail(CompanyEmail companyEmail)
        {
            Context.CompanyEmails.Add(companyEmail);
            Context.SaveChanges();
            return companyEmail.Id;
        }

        public bool UpdateCompanyEmail(CompanyEmail companyEmail)
        {
            Context.CompanyEmails.Update(companyEmail);
            Context.SaveChanges();
            return true;
        }
    }
}
