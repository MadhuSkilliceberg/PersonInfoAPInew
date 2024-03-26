using PersonsInfoV2Api.Entities;
using PersonsInfoV2Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IRepository
{
  public  interface IQuestionRepo
    {
        public List<Question> GetQuestions();
        public int InsertQuestion(Question user);

        public int UpdateQuestion(Question user);

        public int DeleteQuestion(int id);

        public Question GetQuestionById(int id);

        public List<Exam> GetExams();

        public List<Exam> GetExams(int id);

        public object GetUserExamQuestionsByExamId(int id);


        public List<ExamQuestion> GetExamQuestionByExamId(int id);

        public int InsertUserExamQuestion(UserExamQuestion userExamQuestion);

        public int UpdateUserExamQuestion(UserExamQuestion userExamQuestion);

        public List<UserExamQuestion> GetUserExamQuestionsByUExamQId(int UserId, int ExamId, int QuestionId);

        public int InsertUserExamQuestionRange(List<UserExamQuestion> userExamQuestion);
        public int UpdateUserExamQuestionRange(List<UserExamQuestion> userExamQuestion);

        public int SaveUserExamQuestionsAudit(UserExamQuestionsAudit userExamQuestionsAudit);
    }
}
