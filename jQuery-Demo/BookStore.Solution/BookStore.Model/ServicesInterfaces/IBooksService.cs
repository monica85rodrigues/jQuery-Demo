using System.Collections.Generic;
using BookStore.Model.Entities;

namespace BookStore.Model
{
     public interface IBooksService
     {
         IEnumerable<Book> GetAllBooks();
         void AddBook(Book book);
         void UpdateBook(Book book);
         void RemoveBook(int key);
         IList<object> GetPercentages();
     }
}
