using AutoMapper;
using Examveda.Repository;
using ExamVedaApp.Models;

namespace Examveda.Service
{
    public class CategoryService: ICategoryService
    {

        public readonly ICategoryRepository categoryRepository;
        private readonly IMapper mapper;

        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper) {
            this.categoryRepository = categoryRepository;
            this.mapper = mapper;
        }

        public async Task<List<Category>> GetAllCategories()
        {
            var categories = new List<Category>();
            categories = await this.categoryRepository.GetCollectionAsync();
            return categories;
        }

        public async Task<bool> CreateCategory(CreateCategoryRequest categoryRequest)
        {
            var category = this.mapper.Map<Category>(categoryRequest);
            await this.categoryRepository.Create(category);
            return true;
        }
    }
}
