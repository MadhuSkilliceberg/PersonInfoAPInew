using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IBussinessLogic
{
  public  interface IQuestionCategoryBussinessLogic
    {
        public List<QuestionCategory> GetQuestionCategories();
        public int InsertQuestionCategory(QuestionCategory questionCategory);

        public int UpdateQuestionCategory(QuestionCategory questionCategory);

        public int DeleteQuestionCategory(int id);

        public QuestionCategory GetQuestionCategoryById(int id);
    }
}
