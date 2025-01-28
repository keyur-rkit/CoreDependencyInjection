using DependencyInjection.Models;

namespace DependencyInjection.Services
{
    public interface IBookService
    {
        IEnumerable<Book> GetAllBooks();
    }
}
