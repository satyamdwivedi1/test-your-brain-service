using MongoDB.Driver;

namespace ExamVedaApp.Models
{
    public class SubCategoryRepository: ISubCategoryRepository
    {
        public readonly IMongoCollection<SubCategory> _subCategoryCollection;
        public SubCategoryRepository(IMongoDatabase mongoDatabase)
        {
            this._subCategoryCollection = mongoDatabase.GetCollection<SubCategory>("SubCategory");
        }

        public async Task<List<SubCategory>> GetCollectionAsync()
        {
            return await this._subCategoryCollection.Find(_ => true).ToListAsync();
        }

        public async Task<bool> Create(SubCategory subCategory)
        {
            await this._subCategoryCollection.InsertOneAsync(subCategory);
            return true;
        }
    }
}
