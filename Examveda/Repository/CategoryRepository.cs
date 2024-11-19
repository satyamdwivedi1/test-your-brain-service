using Examveda.Repository;
using MongoDB.Driver;

namespace ExamVedaApp.Models
{
    public class CategoryRepository: ICategoryRepository
    {
        public readonly IMongoCollection<Category> _categoryCollection;
        public CategoryRepository(IMongoDatabase mongoDatabase)
        {
            this._categoryCollection = mongoDatabase.GetCollection<Category>("Category");
        }

        public async Task<List<Category>> GetCollectionAsync()
        {
            return await this._categoryCollection.Find(_ => true).ToListAsync();
        }

        public async Task<bool> Create(Category category)
        {
            await this._categoryCollection.InsertOneAsync(category);
            return true;
        }
    }
}
