using Examveda.Service;
using ExamVedaApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExamVedaApp.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        [HttpGet]
        public async Task<List<Category>> GetAllCategories()
        {
            var categories = await this.categoryService.GetAllCategories();
            return categories;
        }

        [HttpPost]
        public async Task<bool> CreateCategory([FromBody] CreateCategoryRequest category)
        {
            await this.categoryService.CreateCategory(category);
            return true;
        }
    }
}
