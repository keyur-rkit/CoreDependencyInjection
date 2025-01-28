namespace DependencyInjection.Services
{
    public class SingletonService : ISingletonService
    {
        private Guid _operationId;

        public SingletonService()
        {
            _operationId = Guid.NewGuid();
        }


        public Guid GetOperationId()
        {
            Console.WriteLine($"SingletonService {_operationId}");
            return _operationId;
        }
    }
}
