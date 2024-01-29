using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IRepository
{
   public interface IInstitutionEmailRepo
    {
        public List<InstitutionEmail> GetInstitutionEmails();
        public int UpdateInstitutionEmail(InstitutionEmail institutionEmail);
        public int InsertInstitutionEmail(InstitutionEmail institutionEmail);

        public int DeleteInstitutionEmail(int id);

        public InstitutionEmail GetByInstitutionEmailId(int id);
      //  public bool institutionEmailDetails(List<InstitutionEmail> institutionEmails);
        public List<InstitutionEmail> GetInstitutionEmailsByAddressId(int addressId);

        public bool UpdateinstitutionEmailDetails(List<InstitutionEmail> institutionEmails);
        public bool AddinstitutionEmailDetails(List<InstitutionEmail> institutionEmails);

        public bool DeleteinstitutionEmailDetails(List<InstitutionEmail> institutionEmails);
    }
}
