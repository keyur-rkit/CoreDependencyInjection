using DependencyInjection.Models;

namespace DependencyInjection.Services
{
    public class DatabaseService : IBookService
    {
        public IEnumerable<Book> GetAllBooks()
        {
            return new List<Book>
            {
            new Book { Id = 1, Title = "Database Book 1", Author = "Database Author" },
            new Book { Id = 2, Title = "Database Book 2", Author = "Database Author" }
            };

        }
    }
}
