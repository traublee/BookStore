﻿using BookStore.Models.Base;

namespace BookStore.BL.Interfaces
{
    public interface IBookService
    {
        Task<IEnumerable<Book>> GetAll();

        Task<Book> GetById(int id);

        Task Add(Book book);

        Task Delete(int id);

        Task Update(Book book);
    }
}