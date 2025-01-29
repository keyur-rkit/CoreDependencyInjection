namespace DependencyInjection.Services
{
    /// <summary>
    /// Defines the contract for a transient service.
    /// </summary>
    public interface ITransientService
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
