using BookStore.Models.Responses;

namespace BookStore.BL.Interfaces
{
    public interface ILibraryService
    {
        GetAllBooksByAuthorResponse GetAllBooksByAuthorId(int authorId);
        GetAllBooksByAuthorResponse GellAllBooksByReleaseDate(int releaseDate);
    }
}
