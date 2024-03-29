﻿/*using BookStore.DL.Interfaces;
using BookStore.Models.Models;

namespace BookStore.DL.Repositories.InMemoryRepositories
{
    public class AuthorInMemoryRepository
    {
        public IEnumerable<Author> GetAll()
        {
            return InMemoryDb.InMemoryDb.Authors;
        }
        public Author GetById(Guid id)
        {
            return InMemoryDb.InMemoryDb.Authors.SingleOrDefault(x => x.Id == id);
        }
        public void Add(Author author)
        {
            InMemoryDb.InMemoryDb.Authors.Add(author);
        }
        public void Delete(Guid id)
        {
            var author = InMemoryDb.InMemoryDb.Authors.FirstOrDefault(x => x.Id == id);
            if (author != null)
            {
                InMemoryDb.InMemoryDb.Authors.Remove(author);
            }
        }
        public void Update(Author author)
        {
            var authorForUpdate = InMemoryDb.InMemoryDb.Authors.FirstOrDefault(x => x.Id == author.Id);

            if (authorForUpdate != null)
            {
                authorForUpdate.Name = author.Name;
            }
        }
    }
}
*/