﻿using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IBussinessLogic
{
  public  interface IbussiUserData
    {
        public List<User> GetUserDatasss();
    }
}
