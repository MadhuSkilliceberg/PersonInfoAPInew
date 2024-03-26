using PersonsInfoV2Api.Entities;
using PersonsInfoV2Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IBussinessLogic
{
  public  interface IQuestionBussinessLogic
    {
        public List<Question> GetQuestions();
        public int InsertQuestion(Question skill);

        public int UpdateQuestion(Question skill);

        public int DeleteQuestion(int id);

        public Question GetQuestionById(int id);


        public List<Exam> GetExams();

        public List<Exam> GetExams(int id);


        public object GetUserExamQuestionsByExamId(int id);

        public int GetMoveExamQuestionsUserExamQuestionsByExamId(int id);

        public int InsertUserExamQuestionRange(List<UserExamQuestion> userExamQuestion);

        public int UpdateUserExamQuestionRange(List<UserExamQuestion> userExamQuestion);

        public int SaveUserExamQuestionsAudit(UserExamQuestionsAudit userExamQuestionsAudit);


    }
}
