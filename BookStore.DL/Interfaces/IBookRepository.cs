using BookStore.Models.Base;

namespace BookStore.DL.Interfaces
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetAll();

        Book GetById(int id);

        void Add(Book book);

        void Delete(int id);

        void Update(Book book);

        IEnumerable<Book> GetAllByAuthorId(int authorId);

    }
}