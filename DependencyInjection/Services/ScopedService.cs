namespace DependencyInjection.Services
{
    /// <summary>
    /// Represents a scoped service with a unique operation ID.
    /// </summary>
    public class ScopedService : IScopedService
    {
        #region Fields

        /// <summary>
        /// Unique identifier for the service instance.
        /// </summary>
        private Guid _operationId;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ScopedService"/> class with a new operation ID.
        /// </summary>
        public ScopedService()
        {
            _operationId = Guid.NewGuid();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Returns the unique operation ID associated with this instance.
        /// </summary>
        /// <returns>Operation ID of the service instance.</returns>
        public Guid GetOperationId()
        {
            Console.WriteLine($"ScopedService {_operationId}");
            return _operationId;
        }

        #endregion
    }
}
