using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using PersonsInfoV2Api.Models;

namespace PersonsInfoV2Api.Repository
{
    public class LookUpValueRepo : ILookUpValueRepo
    {
        PersonsInfoV3NewContext Context = new PersonsInfoV3NewContext();

        public int DeleteLookUpValue(int id)
        {
            var k = Context.LookUpValues.Where(a => a.Id == id).FirstOrDefault();
            Context.LookUpValues.Remove(k);
            Context.SaveChanges();
            return 1;
        }

        public LookUpValue GetByLookUpValueId(int id)
        {
            var k = Context.LookUpValues.Where(a => a.Id == id).FirstOrDefault();
            return k;
        }

        public List<LookUpValue> GetLookUpValues()
        {
            return Context.LookUpValues.ToList();
        }

        public bool InsertLookUpValue(LookUpValue LookUpValue)
        {
            Context.LookUpValues.Add(LookUpValue);
            Context.SaveChanges();
            return true;
        }

        public bool UpdateLookUpValue(LookUpValue LookUpValue)
        {
            Context.LookUpValues.Update(LookUpValue);
            Context.SaveChanges();
            return true;
        }


        public string GetLookUpValueNameById(int id)
        {
            return Context.LookUpValues.Where(a => a.Id == id).FirstOrDefault().Name;
        }


        public List<LookUpValue> GetLookUpValueByCode(List<string> codes)
        {
            var data = Context.LookUps.Where(a => codes.Contains(a.Code)).ToList();


            var query =
               from lookUp in Context.LookUps.Where(a => codes.Contains(a.Code)).ToList()
               join value in Context.LookUpValues on lookUp.Id equals value.LookUpId

               //  where post.ID == id
               select new LookUpValue
               {
                   Id = value.Id,
                   LookUpId = value.LookUpId,
                   Name = value.Name,
                   Code = value.Code,
                   IsDeleted = value.IsDeleted,
                   CreatedOn = value.CreatedOn,
                   CreatedBy = value.CreatedBy,
                   UpdatedOn = value.UpdatedOn,
                   UpdatedBy = value.UpdatedBy,
                   LookUpCode = lookUp.Code,
                   ParentId = value.ParentId
               };
            return query.ToList();
            // return data;
        }

        public List<LookUpValue> GetLookUpValueByRoleCategory(int DepartmentId)
        {
             var query =
               from lookUp in Context.LookUpValues.Where(a => a.LookUpId == DepartmentId).ToList()
               join value in Context.LookUpValues on lookUp.Id equals value.LookUpId

               //  where post.ID == id
               select new LookUpValue
               {
                   Id = value.Id,
                   LookUpId = value.LookUpId,
                   Name = value.Name,
                   Code = value.Code,
                   IsDeleted = value.IsDeleted,
                   CreatedOn = value.CreatedOn,
                   CreatedBy = value.CreatedBy,
                   UpdatedOn = value.UpdatedOn,
                   UpdatedBy = value.UpdatedBy,
                   LookUpCode = lookUp.Code,
               };
            return query.ToList();
            // return data;
        }


        public List<LookUpValue> GetLookUpSearch(LookUpSearch lookUpSearch)
        {
            var k = Context.LookUpValues.Where(a => a.Name.Contains(lookUpSearch.Name) && lookUpSearch.Ids.Contains(a.LookUpId)).ToList();
            return k;
        }
    }
}
