using DependencyInjection.Services;

namespace DependencyInjection.Extensions
{
    /// <summary>
    /// Extension methods for registering services.
    /// </summary>
    public static class ServiceExtensions
    {
        #region Methods

        /// <summary>
        /// Registers book-related services with appropriate lifetimes.
        /// </summary>
        /// <param name="services">The service collection.</param>
        public static void AddBookServices(this IServiceCollection services)
        {
            services.AddTransient<DatabaseService>();  // Transient service
            services.AddTransient<InMemoryService>();  // Transient service

            services.AddSingleton<BookServiceFactory>(); // Singleton service
        }

        #endregion
    }
}
