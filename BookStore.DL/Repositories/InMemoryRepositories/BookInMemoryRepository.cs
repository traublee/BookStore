using BookStore.DL.Interfaces;
using BookStore.Models.Base;

namespace BookStore.DL.Repositories.InMemoryRepositories
{ 
    public class BookInMemoryRepository
    {
        public IEnumerable<Book> GetAll()
        {
            return InMemoryDb.InMemoryDb.Books;
        }
        public Book GetById(int id)
        {
            return InMemoryDb.InMemoryDb.Books.SingleOrDefault(x => x.Id == id);
        }
        public void Add(Book book)
        {
            InMemoryDb.InMemoryDb.Books.Add(book);
        }
        public void Delete(int id)
        {
            var book = InMemoryDb.InMemoryDb.Books.FirstOrDefault(x => x.Id == id);
            if (book != null)
            {
                InMemoryDb.InMemoryDb.Books.Remove(book);
            }
        }
        public void Update(Book book)
        {
            var bookForUpdate = InMemoryDb.InMemoryDb.Books.FirstOrDefault(x => x.Id == book.Id);

            if (bookForUpdate != null)
            {
                bookForUpdate.Title = book.Title;
            }
        }

        public IEnumerable<Book> GetAllByAuthorId(int authorId)
        {
            return InMemoryDb.InMemoryDb.Books.Where(book => book.AuthorId == authorId);
        }
    }
}
