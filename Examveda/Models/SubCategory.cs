using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ExamVedaApp.Models
{
    public class SubCategory
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string CategoryId { get; set; }
        public List<string>? QuestionIds { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string? CreatedBy { get; set; }
        public string? ModifiedBy { get; set; }
    }

    public class CreateSubCategoryRequest
    {
        public List<string>? QuestionIds { get; set; }
        public string CategoryId { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string? CreatedBy { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
