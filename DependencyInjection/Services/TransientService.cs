namespace DependencyInjection.Services
{
    public class TransientService : ITransientService
    {
        private Guid _operationId;

        public TransientService()
        {
            _operationId = Guid.NewGuid();
        }


        public Guid GetOperationId()
        {
            Console.WriteLine($"TransientService {_operationId}");
            return _operationId;
        }
    }
}
