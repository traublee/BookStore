﻿using BookStore.BL.Interfaces;
using BookStore.DL.Interfaces;
using BookStore.Models.Base;
using System.Runtime.CompilerServices;

namespace BookStore.BL.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<IEnumerable<Book>> GetAll()
        {
            return await _bookRepository.GetAll();
        }
        public async Task <Book> GetById(int id)
        {
            return await _bookRepository.GetById(id);
        }
        public async Task Add(Book book)
        {
            await _bookRepository.Add(book);
        }

        public async Task Delete(int id)
        {
            await _bookRepository.Delete(id);
        }
        public async Task Update(Book book)
        {
            await _bookRepository.Update(book);
        }
    }
}