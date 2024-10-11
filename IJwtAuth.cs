using PersonsInfoV2Api.CoustumModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api
{
   public interface IJwtAuth
    {
        AuthenticatedResponse Authentication(UserCredential userCredential);
    }
}
