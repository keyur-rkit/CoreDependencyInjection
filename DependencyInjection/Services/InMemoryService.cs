using DependencyInjection.Models;

namespace DependencyInjection.Services
{
    public class InMemoryService : IBookService
    {
        private readonly Guid _guid;

        public InMemoryService(GuidGenerationService guidService)
        {
            _guid = guidService.GetGuid();  // Each InMemoryService instance uses the same GUID from Singleton.
        }
        public IEnumerable<Book> GetAllBooks()
        {
            return new List<Book>
            {
            new Book { Id = 1, Title = "InMemory Book 1", Author = "InMemory Author" },
            new Book { Id = 2, Title = "InMemory Book 2", Author = "InMemory Author" }
            };
        }

        public Guid GetGuid() => _guid;
    }
}
