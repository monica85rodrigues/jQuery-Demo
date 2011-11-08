using System.Collections.Generic;
using System.Linq;
using BookStore.Model.Entities;
using BookStore.Model.Repositories;

namespace BookStore.Model.ServicesImplementation
{
    public class BooksService : IBooksService
    {
        private readonly IBooksRepository _repository;

        public BooksService(IBooksRepository repository)
        {
            _repository = repository;
        }

        public BooksService()
        {
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _repository.GetAll();
        }

        public void AddBook(Book book)
        {
            _repository.Add(book);
        }

        public void UpdateBook(Book book)
        {
            _repository.Update(book);
        }

        public void RemoveBook(int key)
        {
            _repository.Remove(key);
        }

        public IList<object> GetPercentages()
        {
            IList<Book> books = _repository.GetAll().ToList();
            IList<object> result = new List<object>();
            result.Add(new { Name = "Preços inferiores a 20€", Value = books.Where(b => b.Price < 20).Count() });
            result.Add(new { Name = "Preços superiores a 40€", Value = books.Where(b => b.Price > 40).Count() });
            result.Add(new { Name = "Preços entre 20€ e 40€", Value = books.Where(b => b.Price >= 20 && b.Price <= 40).Count() });
            return result;
        }
    }
}
