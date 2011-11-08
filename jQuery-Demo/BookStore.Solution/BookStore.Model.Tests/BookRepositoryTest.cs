using System;
using System.Linq;
using BookStore.Model.Entities;
using BookStore.Model.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BookStore.Model.Tests
{
    [TestClass]
    public class BookRepositoryTest
    {
        [TestMethod]
        public void GetAllBooksTest()
        {
            IBooksRepository repository = new MemoryBookRepository();
            Assert.AreEqual(8,repository.GetAll().Count());
        }

        [TestMethod]
        public void GetBookTest()
        {
            IBooksRepository repository = new MemoryBookRepository();
            Book book = repository.Get(2);
            Assert.AreEqual("JAVA 5 e Programação por Objectos",book.Title);
        }

        [TestMethod]
        public void AddBookTest()
        {
            IBooksRepository repository = new MemoryBookRepository();
            repository.Add(new Book
                               {
                                   Author = "alguem",
                                   Title = "Jquery In Action",
                                   Price = 30
                               });
            Assert.AreEqual(9, repository.GetAll().Count());
        }

        [TestMethod]
        public void UpdateBookTest()
        {
            IBooksRepository repository = new MemoryBookRepository();
            const string newTitle = "Changed Title";
            Book book = repository.Get(1);
            book.Title = newTitle;
            repository.Update(book);
            Assert.AreEqual(newTitle, repository.Get(1).Title);
        }

        [TestMethod]
        public void Remove()
        {
            IBooksRepository repository = new MemoryBookRepository();
            Assert.AreEqual(8, repository.GetAll().Count());
            repository.Remove(3);
            Assert.AreEqual(7, repository.GetAll().Count());
            repository.Add(new Book{Title = "Book 1",Price = 30});
            Assert.AreEqual(8, repository.GetAll().Count());
        }
    }
}
