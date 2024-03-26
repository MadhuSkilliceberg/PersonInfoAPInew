using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PersonsInfoV2Api.Models;
using System.Security.Cryptography.Xml;
using System.Net;

namespace PersonsInfoV2Api.Repository
{

    public class QuestionRepo : IQuestionRepo
    {
        PersonsInfoV3NewContext Context = new PersonsInfoV3NewContext();
        public int DeleteQuestion(int id)
        {
            var k = Context.Questions.Where(a => a.Id == id).FirstOrDefault();
            Context.Questions.Remove(k);
            Context.SaveChanges();
            return 1;
        }

        public Question GetQuestionById(int id)
        {
            var k = Context.Questions.Where(a => a.Id == id).FirstOrDefault();
            return k;
        }

        public List<Question> GetQuestions()
        {
            return Context.Questions.ToList();
        }

        public int InsertQuestion(Question questions)
        {
            Context.Questions.Add(questions);
            Context.SaveChanges();
            return questions.Id;
        }

        public int UpdateQuestion(Question question)
        {
            Context.Questions.Update(question);
            Context.SaveChanges();
            return question.Id;
        }


        public List<Exam> GetExams()
        {
            return Context.Exams.ToList();
        }


        public List<Exam> GetExams(int id)
        {
            return Context.Exams.Where(t => t.Id == id).ToList();
        }

        public object GetUserExamQuestionsByExamId(int id)
        {

            var query =
   (from eq in Context.UserExamQuestions
    join q in Context.Questions on eq.QuestionId equals q.Id
    where eq.ExamId == id
    select new UserExamQuestionModel { Id = eq.Id, ExamId = eq.ExamId, QuestionId = q.Id, QuestionName = q.Question1,UserId=eq.UserId,IsActive=eq.IsActive ,MarkAsReview=eq.MarkAsReview,Answer=eq.Answer  }).ToList();
           

            foreach(var da in query)
            {
                da.QuestionOption= Context.QuestionOptions.Where(t => t.QuestionId == da.QuestionId).ToList();

            }
                return query;

            //       var data= from eq in query
            //        join qo in Context.QuestionOptions //Right Data Source
            //                          on eq.QuestionId equals qo.QuestionId //Inner Join Condition
            //                          into QuestionGroup //Performing LINQ Group Join
            //from questionOptions in QuestionGroup.DefaultIfEmpty() //Performing Left Outer Join
            //                          select new  { eq, questionOptions }; //Projecting the Result to

            //        return data;
            //return Context.UserExamQuestions.Where(t => t.ExamId == id).ToList();
        }


        public List<ExamQuestion> GetExamQuestionByExamId(int id)
        {

            return Context.ExamQuestions.Where(t => t.Id == id).ToList();
        }

        public int InsertUserExamQuestion(UserExamQuestion userExamQuestion)
        {
            Context.UserExamQuestions.Add(userExamQuestion);
            Context.SaveChanges();
            return userExamQuestion.Id;
        }

        public int UpdateUserExamQuestion(UserExamQuestion userExamQuestion)
        {
            Context.UserExamQuestions.Update(userExamQuestion);
            Context.SaveChanges();
            return userExamQuestion.Id;
        }

        public int InsertUserExamQuestionRange(List<UserExamQuestion> userExamQuestion)
        {
            Context.UserExamQuestions.AddRange(userExamQuestion);
            Context.SaveChanges();
            return 1;
        }

        public int UpdateUserExamQuestionRange(List<UserExamQuestion> userExamQuestion)
        {
            Context.UserExamQuestions.UpdateRange(userExamQuestion);
            Context.SaveChanges();
            return userExamQuestion[0].Id;
        }


        public List<UserExamQuestion> GetUserExamQuestionsByUExamQId(int UserId, int ExamId, int QuestionId)
        {

            return Context.UserExamQuestions.Where(t => t.UserId == UserId && t.ExamId == ExamId && t.QuestionId == QuestionId).ToList();

        }


        public int SaveUserExamQuestionsAudit(UserExamQuestionsAudit userExamQuestionsAudit)
        {
            Context.UserExamQuestionsAudits.Add(userExamQuestionsAudit);
            Context.SaveChanges();
            return userExamQuestionsAudit.Id;
        }

    }
}
