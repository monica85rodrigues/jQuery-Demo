using System.Collections.Generic;
using BookStore.Model.Entities;

namespace BookStore.Model.Data
{
    internal class BooksData
    {
        public static Dictionary<int, Book> Books = new Dictionary<int, Book>();

        static BooksData()
        {
            Books.Add(0, new Book
                             {
                                 Id = 0, 
                                 Author = "Luís Abreu", 
                                 Title = "Javascript", 
                                 Price = 15.17,
                                 Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit"
                             });
            Books.Add(1, new Book
                             {
                                 Id = 1, 
                                 Author = "Luís Abreu / João Carreiro", 
                                 Title = "Html5", 
                                 Price = 18.82,
                                 Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit"
                             });
            Books.Add(2, new Book
                             {
                                 Id = 2, 
                                 Author = "F. Mário Martins", 
                                 Title = "JAVA 5 e Programação por Objectos", 
                                 Price = 28.52,
                                 Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit"
                             });
            Books.Add(3, new Book
                            {
                                Id = 3,
                                Author = "Jonathan Chaffer/Karl Swedberg",
                                Title = "Learning jQuery",
                                Price = 33.85,
                                Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit"
                            });
            Books.Add(4, new Book
                            {
                                Id = 4,
                                Author = "Bear Bibeault and Yehuda Katz",
                                Title = "jQuery In ACTION",
                                Price = 45.00,
                                Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit"
                            });
            Books.Add(5, new Book
                            {
                                Id = 5,
                                Author = "Dan Wellman",
                                Title = "jQuery 1.4 Animation Techniques",
                                Price = 25.00,
                                Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit"
                            });
        }
    }
}
