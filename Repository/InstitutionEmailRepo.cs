using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Repository
{
    public class InstitutionEmailRepo : IInstitutionEmailRepo
    {
        PersonsInfoV3NewContext Context = new PersonsInfoV3NewContext();

        public int DeleteInstitutionEmail(int id)
        {
            var k = Context.InstitutionEmails.Where(a => a.Id == id).FirstOrDefault();
            Context.InstitutionEmails.Remove(k);
            Context.SaveChanges();
            return 1;
        }

        public InstitutionEmail GetByInstitutionEmailId(int id)
        {
            var k = Context.InstitutionEmails.Where(a => a.Id == id).FirstOrDefault();
            return k;
        }

        public List<InstitutionEmail> GetInstitutionEmails()
        {
            return Context.InstitutionEmails?.ToList();
        }

        public int InsertInstitutionEmail(InstitutionEmail institutionEmail)
        {
            Context.InstitutionEmails.Add(institutionEmail);
            Context.SaveChanges();
            return institutionEmail.Id;
        }

        public int UpdateInstitutionEmail(InstitutionEmail institutionEmail)
        {
            Context.InstitutionEmails.Update(institutionEmail);
            Context.SaveChanges();
            return institutionEmail.Id;
        }


        public bool AddinstitutionEmailDetails(List<InstitutionEmail> institutionEmails)
        {
            try
            {
                if (institutionEmails != null)
                {
                    Context.InstitutionEmails.AddRange(institutionEmails);
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

        public bool UpdateinstitutionEmailDetails(List<InstitutionEmail> institutionEmails)
        {
            try
            {
                if (institutionEmails != null)
                {
                    Context.InstitutionEmails.UpdateRange(institutionEmails);
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


        public bool DeleteinstitutionEmailDetails(List<InstitutionEmail> institutionEmails)
        {
            try
            {
                if (institutionEmails != null)
                {
                    Context.InstitutionEmails.RemoveRange(institutionEmails);
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

        public List<InstitutionEmail> GetInstitutionEmailsByAddressId(int addressId)
        {
            return Context.InstitutionEmails.Where(i =>i.InstitutionAddressId ==  addressId).ToList();
        }


    }
}
