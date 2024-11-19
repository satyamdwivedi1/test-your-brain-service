using ExamVedaApp.Models;

namespace Examveda.Repository
{
    public interface ICategoryRepository
    {
        Task<List<Category>> GetCollectionAsync();
        Task<bool> Create(Category category);
    }
}
