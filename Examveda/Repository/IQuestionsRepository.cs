namespace ExamVedaApp.Models
{
    public interface IQuestionsRepository
    {
        Task<List<Questions>> GetCollectionAsync();
        Task<bool> Create(Questions question);
    }
}
