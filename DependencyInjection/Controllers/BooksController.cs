using DependencyInjection.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    /// <summary>
    /// Controller for handling book-related operations.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        #region Fields

        private readonly BookServiceFactory _bookServiceFactory;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes the controller with the book service factory.
        /// </summary>
        /// <param name="bookServiceFactory">Factory for creating book services.</param>
        public BooksController(BookServiceFactory bookServiceFactory)
        {
            _bookServiceFactory = bookServiceFactory;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Retrieves books from either the database or in-memory service based on the flag.
        /// </summary>
        /// <param name="useDatabase">Flag to choose service type.</param>
        /// <returns>List of books.</returns>
        [HttpGet("GetBooks")]
        public IActionResult GetBooksFromDatabase(bool useDatabase)
        {
            var service = _bookServiceFactory.GetService(useDatabase);
            return Ok(service.GetAllBooks());
        }

        #endregion
    }
}
