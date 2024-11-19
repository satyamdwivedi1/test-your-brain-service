using MongoDB.Driver;

namespace ExamVedaApp.Models
{
    public class QuestionsRepository: IQuestionsRepository
    {
        public readonly IMongoCollection<Questions> _questionCollection;
        public QuestionsRepository(IMongoDatabase mongoDatabase)
        {
            this._questionCollection = mongoDatabase.GetCollection<Questions>("Questions");
        }
        public async Task<List<Questions>> GetCollectionAsync()
        {
            return await this._questionCollection.Find(_ => true).ToListAsync();
        }

        public async Task<bool> Create(Questions question)
        {
            await this._questionCollection.InsertOneAsync(question);
            return true;
        }
    }
}
