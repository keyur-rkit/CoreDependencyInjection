namespace DependencyInjection.Services
{
    public class ScopedService : IScopedService
    {
        private Guid _operationId;

        public ScopedService()
        {
            _operationId = Guid.NewGuid();
        }


        public Guid GetOperationId()
        {
            Console.WriteLine($"ScopedService {_operationId}");
            return _operationId;
        }
    }
}
