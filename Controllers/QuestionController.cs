using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using PersonsInfoV2Api.Models;

namespace PersonsInfoV2Api.Controllers
{
    [Authorize]
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        IQuestionBussinessLogic QuestionRepository;
        public QuestionController(IQuestionBussinessLogic Repo)
        {
            QuestionRepository = Repo;
        }


        [Route("DeleteQuestions/{Id}")]
        [HttpDelete]
        public int DeleteQuestion(int id)
        {
            return QuestionRepository.DeleteQuestion(id);
        }


        [Route("GetQuestionsById/{Id}")]
        [HttpGet]
        public Question GetByQuestionId(int id)
        {
            return QuestionRepository.GetQuestionById(id);
        }


        [Route("GetQuestions")]
        [HttpGet]
        public List<Question> GetQuestions()
        {
            return QuestionRepository.GetQuestions();
        }


        [Route("AddQuestions")]
        [HttpPost]
        public int InsertQuestion(Question Question)
        {
            return QuestionRepository.InsertQuestion(Question);
        }


        [Route("UpdateQuestions")]
        [HttpPut]
        public int UpdateQuestion(Question Question)
        {
            return QuestionRepository.UpdateQuestion(Question);
        }

        [Route("GetExams")]
        [HttpGet]
        public List<Exam> GetExams()
        {
            return QuestionRepository.GetExams();
        }
          [Route("GetExamsById/{id}")]
        [HttpGet]
        public List<Exam> GetExams(int id)
        {
            return QuestionRepository.GetExams(id);
        }

        [Route("GetUserExamQuestionsByExamId/{id}")]
        [HttpGet]
        public object GetUserExamQuestionsByExamId(int id)
        {
            return QuestionRepository.GetUserExamQuestionsByExamId(id);
        }

        [Route("InsertUserExamQuestionRange")]
        [HttpPost]
        public int InsertUserExamQuestionRange(List<UserExamQuestion> userExamQuestion)
        {
            return QuestionRepository.InsertUserExamQuestionRange(userExamQuestion);
        }
        [Route("UpdateUserExamQuestionRange")]
        [HttpPost]
        public int UpdateUserExamQuestionRange(List<UserExamQuestion> userExamQuestion)
        {
            return QuestionRepository.UpdateUserExamQuestionRange(userExamQuestion);
        }

        [Route("SaveUserExamQuestionsAudit")]
        [HttpPost]
        public int SaveUserExamQuestionsAudit(UserExamQuestionsAudit userExamQuestionsAudit)
        {
            return QuestionRepository.SaveUserExamQuestionsAudit(userExamQuestionsAudit);
        }

         
    }
}
