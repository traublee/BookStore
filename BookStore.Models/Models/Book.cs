﻿namespace BookStore.Models.Models
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Guid AuthorId { get; set; }
    }
}