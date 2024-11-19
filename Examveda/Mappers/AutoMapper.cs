using AutoMapper;
using ExamVedaApp.Models;

namespace Examveda.Mappers
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Category, CreateCategoryRequest>().ReverseMap();
            CreateMap<SubCategory, CreateSubCategoryRequest>().ReverseMap();
            CreateMap<Questions, CreateQuestionRequest>().ReverseMap();

        }
    }
}
