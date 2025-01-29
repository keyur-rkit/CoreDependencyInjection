namespace DependencyInjection.Services
{
    /// <summary>
    /// Defines the contract for a singleton service.
    /// </summary>
    public interface ISingletonService
    {
        #region Methods

        /// <summary>
        /// Gets the unique operation ID associated with the service.
        /// </summary>
        /// <returns>Operation ID of the service instance.</returns>
        Guid GetOperationId();

        #endregion
    }
}
