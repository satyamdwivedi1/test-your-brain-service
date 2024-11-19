using AutoMapper;
using Examveda.Repository;
using ExamVedaApp.Models;
using MongoDB.Bson;

namespace Examveda.Service
{
    public class QuestionService : IQuestionService
    {

        public readonly IQuestionsRepository questionRepository;
        private readonly IMapper mapper;

        public QuestionService(IQuestionsRepository questionRepository, IMapper mapper) {
            this.questionRepository = questionRepository;
            this.mapper = mapper;
        }

        public async Task<List<Questions>> GetAllQuestions()
        {
            var questions = new List<Questions>();
            questions = await this.questionRepository.GetCollectionAsync();
            return questions;
        }

        public async Task<bool> CreateQuestion(CreateQuestionRequest questionRequest)
        {
            var question = this.mapper.Map<Questions>(questionRequest);
            await this.questionRepository.Create(question);
            return true;
        }
    }
}
