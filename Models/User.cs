using Microsoft.AspNetCore.DataProtection.KeyManagement;
using PersonsInfoV2Api.Entities;
using PersonsInfoV2Api.Repository;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonsInfoV2Api.Entities
{
    public partial class User
    {
        [NotMapped]
        public string UserTypeName
        {
            get
            {
                if (UserTypeId != null)
                return new LookUpValueRepo().GetLookUpValueNameById((int)UserTypeId);
                else return null;
            }
            set
            {

            }
        }

    }
}
