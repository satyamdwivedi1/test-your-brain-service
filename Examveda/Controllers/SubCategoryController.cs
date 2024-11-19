using Examveda.Service;
using ExamVedaApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExamVedaApp.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class SubCategoryController : Controller
    {
        private readonly ISubCategoryService subCategoryService;
        public SubCategoryController(ISubCategoryService subCategoryService)
        {
            this.subCategoryService = subCategoryService;
        }

        [HttpGet]
        public async Task<List<SubCategory>> GetAllSubCategories()
        {
            var subCategories = await this.subCategoryService.GetAllSubCategories();
            return subCategories;
        }

        [HttpPost]
        public async Task<bool> CreateSubCategory([FromBody] CreateSubCategoryRequest subCategory)
        {
            await this.subCategoryService.CreateSubCategory(subCategory);
            return true;
        }
    }
}
