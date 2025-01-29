namespace DependencyInjection.Services
{
    /// <summary>
    /// Factory class for creating instances of <see cref="IBookService"/>.
    /// </summary>
    public class BookServiceFactory
    {
        #region Fields

        /// <summary>
        /// The service provider used to resolve dependencies.
        /// </summary>
        private readonly IServiceProvider _serviceProvider;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BookServiceFactory"/> class.
        /// </summary>
        /// <param name="serviceProvider">The service provider used to resolve services.</param>
        public BookServiceFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Creates an instance of <see cref="IBookService"/> based on the specified condition.
        /// </summary>
        /// <param name="useDatabase">Determines which implementation of <see cref="IBookService"/> to return.</param>
        /// <returns>An instance of <see cref="IBookService"/>.</returns>
        public IBookService GetService(bool useDatabase)
        {
            return useDatabase
                ? _serviceProvider.GetRequiredService<DatabaseService>()  // Resolve DatabaseService
                : _serviceProvider.GetRequiredService<InMemoryService>(); // Resolve InMemoryService
        }

        #endregion
    }
}
