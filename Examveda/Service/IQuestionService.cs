using ExamVedaApp.Models;

namespace Examveda.Service
{
    public interface IQuestionService
    {
        Task<List<Questions>> GetAllQuestions();
        Task<bool> CreateQuestion(CreateQuestionRequest question);
    }
}
