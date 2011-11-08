using BookStore.Model.Entities;

namespace BookStore.Model.Repositories
{
    /// <summary>
    /// Specific repository for Books
    /// This interface includes methods specifics for books reporitory
    /// </summary>
    public interface IBooksRepository : IRepository<Book, int>
    {
    }
}
