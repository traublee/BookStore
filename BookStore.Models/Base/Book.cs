namespace BookStore.Models.Base
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
    }
}