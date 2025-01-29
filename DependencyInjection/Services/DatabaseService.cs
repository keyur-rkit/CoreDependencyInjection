using DependencyInjection.Models;

namespace DependencyInjection.Services
{
    /// <summary>
    /// Provides a database-based implementation of the <see cref="IBookService"/> interface.
    /// </summary>
    public class DatabaseService : IBookService
    {
        #region Methods

        /// <summary>
        /// Retrieves all books from the database (in this case, an in-memory list).
        /// </summary>
        /// <returns>A list of <see cref="Book"/> objects.</returns>
        public IEnumerable<Book> GetAllBooks()
        {
            return new List<Book>
            {
                new Book { Id = 1, Title = "Database Book 1", Author = "Database Author" },
                new Book { Id = 2, Title = "Database Book 2", Author = "Database Author" }
            };
        }

        #endregion
    }
}
