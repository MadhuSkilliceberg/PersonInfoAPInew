using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonsInfoV2Api.Entities;
using PersonsInfoV2Api.IBussinessLogic;
using System.Collections.Generic;

namespace PersonsInfoV2Api.Controllers
{
    [Authorize]
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionCategoryController : ControllerBase { 

            IQuestionCategoryBussinessLogic QuestionCategoryRepository;

    public QuestionCategoryController(IQuestionCategoryBussinessLogic Repo)
    {
        QuestionCategoryRepository = Repo;
    }


    [Route("DeleteQuestionCategorys/{Id}")]
    [HttpDelete]
    public int DeleteQuestionCategory(int id)
    {
        return QuestionCategoryRepository.DeleteQuestionCategory(id);
    }


    [Route("GetQuestionCategorysById/{Id}")]
    [HttpGet]
    public QuestionCategory GetByQuestionCategoryId(int id)
    {
        return QuestionCategoryRepository.GetQuestionCategoryById(id);
    }


    [Route("GetQuestionCategories")]
    [HttpGet]
    public List<QuestionCategory> GetQuestionCategories()
    {
        return QuestionCategoryRepository.GetQuestionCategories();
    }


    [Route("AddGetQuestionCategories")]
    [HttpPost]
    public int AddGetQuestionCategories(QuestionCategory QuestionCategory)
    {
        return QuestionCategoryRepository.InsertQuestionCategory(QuestionCategory);
    }


    [Route("UpdateGetQuestionCategories")]
    [HttpPut]
    public int UpdateGetQuestionCategories(QuestionCategory QuestionCategory)
    {
        return QuestionCategoryRepository.UpdateQuestionCategory(QuestionCategory);
    }
}
}

