namespace DependencyInjection.Services
{
    // singleton
    public class GuidGenerationService : IGuidGenerationService
    {
        private readonly Guid _guid;

        public GuidGenerationService()
        {
            // Generates a new GUID when the service is first created.
            _guid = Guid.NewGuid();
        }

        public Guid GetGuid() => _guid;
    }
}
