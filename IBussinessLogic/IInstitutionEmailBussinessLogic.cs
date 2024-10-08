﻿using PersonsInfoV2Api.CoustumModels;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IBussinessLogic
{
  public  interface IInstitutionEmailBussinessLogic
    {
        public Task<List<InstitutionEmail>> GetInstitutionEmails();
        public Task<int> UpdateInstitutionEmail(InstitutionEmail institutionEmail);
        public Task<int> AddInstitutionEmail(InstitutionEmail institutionEmail);

        public Task<int> DeleteInstitutionEmailByInstitutionEmailId(int institutionEmailId);


        public Task<InstitutionEmail> GetInstitutionEmailIdByinstitutionEmailId(int institutionEmailId);
        //  public bool institutionEmailDetails(List<InstitutionEmail> institutionEmails);
        public Task<List<InstitutionEmail>> GetInstitutionEmailsByAddressId(int addressId);

        public Task<bool> UpdateRangeInstitutionEmails(List<InstitutionEmail> institutionEmails);
        public Task<bool> AddRangeInstitutionEmails(List<InstitutionEmail> institutionEmails);

        public Task<bool> DeleteRangeInstitutionEmails(List<InstitutionEmail> institutionEmails);

        Task<List<InstitutionEmailList>> GetInstitutionEmailList();

    }
}
 