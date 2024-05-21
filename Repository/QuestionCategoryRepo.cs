using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Repository
{

    public class QuestionCategoryRepo : IQuestionCategoryRepo
    {
        //PersonsInfoV3NewContext Context = new PersonsInfoV3NewContext();
        //public int DeleteQuestionCategory(int id)
        //{
        //    var k = Context.QulificationTypes.Where(a => a.Id == id).FirstOrDefault();
        //    Context.QulificationTypes.Remove(k);
        //    Context.SaveChanges();
        //    return 1;
        //}

        //public QuestionCategory GetQuestionCategoryById(int id)
        //{
        //    var k = Context.QuestionCategories.Where(a => a.Id == id).FirstOrDefault();
        //    return k;
        //}

        //public List<QuestionCategory> GetQuestionCategories()
        //{
        //    return Context.QuestionCategories.ToList();
        //}

        //public int InsertQuestionCategory(QuestionCategory questionCategory)
        //{
        //    Context.QuestionCategories.Add(questionCategory);
        //    Context.SaveChanges();
        //    return questionCategory.Id;
        //}

        //public int UpdateQuestionCategory(QuestionCategory questionCategory)
        //{
        //    Context.QuestionCategories.Update(questionCategory);
        //    Context.SaveChanges();
        //    return questionCategory.Id;
        //}


    }
}
