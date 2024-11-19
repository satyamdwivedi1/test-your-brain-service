using Examveda.Service;
using ExamVedaApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExamVedaApp.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class QuestionsController : Controller
    {
        private readonly IQuestionService questionService;
        public QuestionsController(IQuestionService questionService)
        {
            this.questionService = questionService;
        }

        [HttpGet]
        public async Task<List<Questions>> GetAllQuestions()
        {
            var questions = await this.questionService.GetAllQuestions();
            return questions;
        }

        [HttpPost]
        public async Task<bool> CreateCategory([FromBody] CreateQuestionRequest question)
        {
            await this.questionService.CreateQuestion(question);
            return true;
        }
    }
}
