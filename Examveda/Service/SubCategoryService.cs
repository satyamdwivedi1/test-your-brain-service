using AutoMapper;
using Examveda.Repository;
using ExamVedaApp.Models;

namespace Examveda.Service
{
    public class SubCategoryService : ISubCategoryService
    {

        public readonly ISubCategoryRepository subCategoryRepository;
        private readonly IMapper mapper;

        public SubCategoryService(ISubCategoryRepository subCategoryRepository, IMapper mapper) {
            this.subCategoryRepository = subCategoryRepository;
            this.mapper = mapper;
        }

        public async Task<List<SubCategory>> GetAllSubCategories()
        {
            var subCategories = new List<SubCategory>();
            subCategories = await this.subCategoryRepository.GetCollectionAsync();
            return subCategories;
        }

        public async Task<bool> CreateSubCategory(CreateSubCategoryRequest subCategoryRequest)
        {
            var subCategory = this.mapper.Map<SubCategory>(subCategoryRequest);
            await this.subCategoryRepository.Create(subCategory);
            return true;
        }
    }
}
