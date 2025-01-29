using DependencyInjection.Models;

namespace DependencyInjection.Services
{
    /// <summary>
    /// Defines the contract for a book service.
    /// </summary>
    public interface IBookService
    {
        #region Methods

        /// <summary>
        /// Retrieves all books from the service.
        /// </summary>
        /// <returns>A collection of <see cref="Book"/> objects.</returns>
        IEnumerable<Book> GetAllBooks();

        #endregion
    }
}
