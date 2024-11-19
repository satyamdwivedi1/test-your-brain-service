namespace ExamVedaApp.Models
{
    public interface ISubCategoryRepository
    {
        Task<List<SubCategory>> GetCollectionAsync();
        Task<bool> Create(SubCategory subCategory);
    }
}
