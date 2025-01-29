namespace DependencyInjection.Models
{
    /// <summary>
    /// Represents a book with properties for Id, Title, and Author.
    /// </summary>
    public class Book
    {
        #region Properties

        /// <summary>
        /// Gets or sets the unique id for the book.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the title of the book.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the author of the book.
        /// </summary>
        public string Author { get; set; }

        #endregion
    }
}
