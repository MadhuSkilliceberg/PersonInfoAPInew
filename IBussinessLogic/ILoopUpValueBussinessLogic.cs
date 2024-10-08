﻿using PersonsInfoV2Api.Entities;
using PersonsInfoV2Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IBussinessLogic
{
  public  interface ILookUpValueBussinessLogic
    {
        public List<LookUpValue> GetLookUpValues();
        public bool InsertLookUpValue(LookUpValue LookUpValue);

        public bool UpdateLookUpValue(LookUpValue LookUpValue);

        public int DeleteLookUpValue(int id);

        public LookUpValue GetByLookUpValueId(int id);

        public List<LookUpValue> GetLookUpValueByCode(List<string> codes);

        public List<LookUpValue> GetLookUpValueByLId(int Id);
        public List<LookUpValue> GetLookUpValueByRoleCategory(int DepartmentId);
        public List<LookUpValue> GetLookUpSearch(LookUpSearch lookUpSearch);


    }
}
