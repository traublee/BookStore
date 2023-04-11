using BookStore.Models.Base;

namespace BookStore.DL.Interfaces
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetAll();

        Task <Book> GetById(int id);

        Task Add(Book book);

        Task Delete(int id);

        Task Update(Book book);

        Task<IEnumerable<Book>> GetAllByAuthorId(int authorId);

    }
}