using BookStore.DL.Interfaces;
using BookStore.Models.Base;
using BookStore.Models.Configurations;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace BookStore.DL.Repositories.MongoDb
{
    public class BookMongoRepository : IBookRepository
    {
        private readonly IMongoCollection<Book> _book;
        public BookMongoRepository(IOptionsMonitor<MongoDbConfiguration> mongoConfig)
        {
            var client = new MongoClient(mongoConfig.CurrentValue.ConnectionString);
            var database = client.GetDatabase(mongoConfig.CurrentValue.DatabaseName);

            _book = database.GetCollection<Book>(nameof(Book));
        }
        public async Task <IEnumerable<Book>> GetAll()
        {
            return await _book.Find(book => true).ToListAsync();
        }

        public async Task <Book> GetById(int id)
        {
            return await _book.Find(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task Add(Book book)
        {
            await _book.InsertOneAsync(book);
        }

        public Task Delete(int id)
        {
            return _book.DeleteOneAsync(x => x.Id == id);
        }

        public Task Update(Book book)
        {
            var filter = Builders<Book>.Filter.Eq(s => s.Id, book.Id);
            var update = Builders<Book>.Update.Set(s => s.Title, book.Title);
            return _book.UpdateOneAsync(filter, update);
        }

        public async Task<IEnumerable<Book>> GetAllByAuthorId(int authorId)
        {
            return await _book.Find(book => true).ToListAsync();
        }
    }
}
