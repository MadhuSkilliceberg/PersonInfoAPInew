using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PersonsInfoV2Api.Models;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class QuestionBussinessLogic : IQuestionBussinessLogic
    {
        IQuestionRepo questionRepository;
        public QuestionBussinessLogic(IQuestionRepo Repo)
        {
            questionRepository = Repo;
        }

        public int DeleteQuestion(int id)
        {
            return questionRepository.DeleteQuestion(id);
        }

        public Question GetQuestionById(int id)
        {

            return questionRepository.GetQuestionById(id);
        }

        public List<Question> GetQuestions()
        {
            return questionRepository.GetQuestions();
        }

        public int InsertQuestion(Question question)
        {
            return questionRepository.InsertQuestion(question);
        }

        public int UpdateQuestion(Question question)
        {
            return questionRepository.UpdateQuestion(question);
            
        }


        public List<Exam> GetExams()
        {
            return questionRepository.GetExams();
        }


        public List<Exam> GetExams(int id )
        {
            return questionRepository.GetExams(id);
        }

        public object GetUserExamQuestionsByExamId(int id)
         {
            return questionRepository.GetUserExamQuestionsByExamId(id);
        }

        public int GetMoveExamQuestionsUserExamQuestionsByExamId(int id)
        {

            var examQuestions = questionRepository.GetExamQuestionByExamId(id);
            foreach (var eqdata in examQuestions)
            {
                var data = questionRepository.GetUserExamQuestionsByUExamQId(1, (int)eqdata.ExamId,(int)eqdata.QuestionId);
                UserExamQuestion userExamQuestion = new UserExamQuestion();
                userExamQuestion.ExamId = eqdata.ExamId;
                userExamQuestion.Question = eqdata.Question;
                userExamQuestion.QuestionId = eqdata.QuestionId;
                //userExamQuestion.Question = eqdata.Question;
                //userExamQuestion.Question = eqdata.Question;
                //userExamQuestion.Question = eqdata.Question;
                if (data != null)
                    questionRepository.InsertUserExamQuestion(userExamQuestion);
                else
                {
                    questionRepository.UpdateUserExamQuestion(userExamQuestion);
                }

                //  questionRepository.InsertUserExamQuestion(eqdata);
            }
           

            return 1;
        }

        public int InsertUserExamQuestionRange(List<UserExamQuestion> userExamQuestion)
        {
            return questionRepository.InsertUserExamQuestionRange(userExamQuestion);
        }

        public int UpdateUserExamQuestionRange(List<UserExamQuestion> userExamQuestion)
        {
            return questionRepository.UpdateUserExamQuestionRange(userExamQuestion);
        }

        public int SaveUserExamQuestionsAudit(UserExamQuestionsAudit userExamQuestionsAudit)
        {
            return questionRepository.SaveUserExamQuestionsAudit(userExamQuestionsAudit);
        }


    }
}
