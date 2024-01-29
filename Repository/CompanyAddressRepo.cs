using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Repository
{
    public class CompanyAddressRepo : ICompanyAddressRepo
    {
        PersonsInfoV3NewContext Context = new PersonsInfoV3NewContext();



        public List<CompanyAddress> GetCompanyAddressIdByCompanyId(int companyid)
        {
            var data = Context.CompanyAddresses.Where(a => a.CompanyId == companyid).ToList();
            return data;
        }


        public List<int> AddCompanyAddress(List<CompanyAddress> companyAddresses)
        {

            try
            {
                if (companyAddresses != null)
                {
                    Context.CompanyAddresses.AddRange(companyAddresses);
                    Context.SaveChanges();
                    return companyAddresses.Select(ca => ca.Id).ToList();
                }
                else
                {
                    return new List<int>();
                }
            }
            catch (Exception ex)
            {
                return new List<int>();
            }

        }


        public bool UpdateCompanyAddress(List<CompanyAddress> companyAddresses)
        {

            try
            {
                if (companyAddresses != null)
                {
                    Context.CompanyAddresses.UpdateRange(companyAddresses);
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




        public int DeleteCompanyAddress(int id)
        {
            var k = Context.CompanyAddresses.Where(a => a.Id == id).FirstOrDefault();
            Context.CompanyAddresses.Remove(k);
            Context.SaveChanges();
            return 1;
        }

        public CompanyAddress GetByCompanyAddressId(int id)
        {
            var k = Context.CompanyAddresses.Where(a => a.Id == id).FirstOrDefault();
            return k;
        }

        public List<CompanyAddress> GetCompanyAddresss()
        {
            return Context.CompanyAddresses.ToList();
        }

        public int InsertCompanyAddress(CompanyAddress companyAddress)
        {
            Context.CompanyAddresses.Add(companyAddress);
            Context.SaveChanges();
            return companyAddress.Id;
        }

        public bool UpdateCompanyAddress(CompanyAddress companyAddress)
        {
            Context.CompanyAddresses.Update(companyAddress);
            Context.SaveChanges();
            return true;
        }
    }


}
