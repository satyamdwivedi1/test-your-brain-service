using ExamVedaApp.Models;

namespace Examveda.Service
{
    public interface ICategoryService
    {
        Task<List<Category>> GetAllCategories();
        Task<bool> CreateCategory(CreateCategoryRequest category);
    }
}
