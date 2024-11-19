using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ExamVedaApp.Models
{
    public class Questions
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string? CategoryId { get; set; }
        public string? SubCategoryId { get; set; }
        public Level Level { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string? CreatedBy { get; set; }
        public string? ModifiedBy { get; set; }
        public Options Options { get; set; }
        public string CorrectOption { get; set; }
        public string Answer { get; set; }
    }

    public class CreateQuestionRequest
    {
        public Level Level { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string? CreatedBy { get; set; }
        public string? ModifiedBy { get; set; }
        public Options Options { get; set; }
        public string CorrectOption { get; set; }
        public string Answer { get; set; }
    }

    public class Options
    {
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }
    }

    public enum Level
    {
        Easy = 1,
        Medium,
        Hard
    }
}
