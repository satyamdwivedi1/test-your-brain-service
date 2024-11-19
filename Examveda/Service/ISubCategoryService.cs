using ExamVedaApp.Models;

namespace Examveda.Service
{
    public interface ISubCategoryService
    {
        Task<List<SubCategory>> GetAllSubCategories();
        Task<bool> CreateSubCategory(CreateSubCategoryRequest subCategory);
    }
}
