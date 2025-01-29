using DependencyInjection.Models;

namespace DependencyInjection.Services
{
    /// <summary>
    /// Provides an in-memory implementation of the <see cref="IBookService"/> interface.
    /// </summary>
    public class InMemoryService : IBookService
    {
        #region Methods

        /// <summary>
        /// Retrieves all books from the in-memory collection.
        /// </summary>
        /// <returns>A list of <see cref="Book"/> objects.</returns>
        public IEnumerable<Book> GetAllBooks()
        {
            return new List<Book>
            {
                new Book { Id = 1, Title = "InMemory Book 1", Author = "InMemory Author" },
                new Book { Id = 2, Title = "InMemory Book 2", Author = "InMemory Author" }
            };
        }

        #endregion
    }
}
