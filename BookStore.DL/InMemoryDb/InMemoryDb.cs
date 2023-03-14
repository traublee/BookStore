using BookStore.Models.Base;
using System.Data;

namespace BookStore.DL.InMemoryDb
{
    public static class InMemoryDb
    {
        public static List<Author> Authors = new List<Author>()
        {
            new Author()
            {
                Id = 1,
                Name = "Peter"
            },
            new Author()
            {
                Id = 2,
                Name = "Steven"
            }
        };
        public static List<Book> Books = new List<Book>()
        {
            new Book()
            {
                Id = 1,
                Title = "Dracula",
                AuthorId = 1,
            },
            new Book()
            {
                Id = 2,
                Title = "Shadow and Bones",
                AuthorId = 2,
            }
        };
    }
}
