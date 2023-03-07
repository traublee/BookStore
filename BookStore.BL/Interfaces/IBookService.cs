using BookStore.Models.Base;

namespace BookStore.BL.Interfaces
{
    public interface IBookService
    {
        IEnumerable<Book> GetAll();

        Book GetById(int id);

        void Add(Book book);

        void Delete(int id);

        void Update(Book book);
    }
}