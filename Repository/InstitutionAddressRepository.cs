using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Repository
{
    public class InstitutionAddressRepository : IInstitutionAddressRepo
    {
        PersonsInfoV3NewContext Context = new PersonsInfoV3NewContext();
        public int DeleteInstitutionAddress(int id)
        {
            var k = Context.InstitutionAddresses.Where(a => a.Id == id).FirstOrDefault();
            Context.InstitutionAddresses.Remove(k);
            Context.SaveChanges();
            return 1;
        }

        public InstitutionAddress GetByInstitutionAddressId(int id)
        {

            return Context.InstitutionAddresses.Where(a => a.Id == id).FirstOrDefault();
          
        }

        public List<InstitutionAddress> GetInstitutionAddress()
        {
            return Context.InstitutionAddresses.ToList();
        }

        public int InsertInstitutionAddress(InstitutionAddress  institutionAddress)
        {
            Context.InstitutionAddresses.Add(institutionAddress);
            Context.SaveChanges();
            return institutionAddress.Id;
        }

        public int UpdateinstitutionAddress(InstitutionAddress institutionAddress)
        {
            Context.InstitutionAddresses.Update(institutionAddress);
            Context.SaveChanges();
            return institutionAddress.Id;
        }

        public bool AddinstitutionAddressDetails(List<InstitutionAddress> institutionAddresses)
        {
            try
            {
                if (institutionAddresses != null)
                {
                    Context.InstitutionAddresses.AddRange(institutionAddresses);
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

        public bool DeleteinstitutionAddressDetails(List<InstitutionAddress> institutionAddresses)
        {
            try
            {
                if (institutionAddresses != null && institutionAddresses.Count>0)
                {
                    Context.InstitutionAddresses.RemoveRange(institutionAddresses);
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

        public bool UpdateinstitutionAddressDetails(List<InstitutionAddress> institutionAddresses)
        {
            try
            {
                if (institutionAddresses != null)
                {
                    Context.InstitutionAddresses.UpdateRange(institutionAddresses);
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

        public List<InstitutionAddress> GetInstitutionAddressByInstituteId(int instituteId)
        {
            return Context.InstitutionAddresses.Where(i =>i.InstitutionId == instituteId ).ToList();
        }
    }
}
