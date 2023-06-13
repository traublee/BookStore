using BookStore.Models.Models;

namespace BookStore.BL.Interfaces
{
    public interface IBookService
    {
        Task<IEnumerable<Book>> GetAll();
        Task<Book?> GetById(Guid id);
        Task<Book?> Add(Book book);
        Task Delete(Guid id);
        Task Update(Book book);
    }
}