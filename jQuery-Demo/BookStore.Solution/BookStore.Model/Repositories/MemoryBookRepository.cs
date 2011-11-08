using System;
using System.Collections.Generic;
using BookStore.Model.Data;
using BookStore.Model.Entities;

namespace BookStore.Model.Repositories
{
    /// <summary>
    /// Basic Implementation
    /// </summary>
    public class MemoryBookRepository : IBooksRepository
    {
        public static int ID = BooksData.Books.Count;

        public IEnumerable<Book> GetAll()
        {
            return BooksData.Books.Values;
        }

        public Book Get(int key)
        {
            return BooksData.Books.ContainsKey(key) ? BooksData.Books[key] : null;
        }

        public void Add(Book entity)
        {
            entity.Id = ID;
            BooksData.Books.Add(ID++, entity);
        }

        public void Update(Book entity)
        {
            if (BooksData.Books.ContainsKey(entity.Id))
                BooksData.Books[entity.Id] = entity;
        }

        public void Remove(int key)
        {
            if (BooksData.Books.ContainsKey(key))
                BooksData.Books.Remove(key);
        }
    }
}
