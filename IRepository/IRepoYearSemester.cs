﻿using PersonsInfoV2Api.Entities;
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IRepository
{
    public interface IRepoYearSemester
    {
        public List<YearSemester> GetYearSemester();
        public int InsertYearSemester(YearSemester yearSemester);

        public int UpdateYearSemester(YearSemester yearSemester);

        public int DeleteYearSemester(int id);

        public YearSemester GetByYearSemesterId(int id);


    }
}
