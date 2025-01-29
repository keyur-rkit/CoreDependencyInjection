namespace DependencyInjection.Services
{
    /// <summary>
    /// A service that is registered with transient lifetime. 
    /// </summary>
    public class TransientService : ITransientService
    {
        #region Fields

        /// <summary>
        /// Unique identifier for each operation of the service.
        /// </summary>
        private Guid _operationId;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="TransientService"/> class with a new operation ID.
        /// </summary>
        public TransientService()
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
            Console.WriteLine($"TransientService {_operationId}");
            return _operationId;
        }

        #endregion
    }
}
