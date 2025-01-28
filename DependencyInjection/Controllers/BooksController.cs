using DependencyInjection.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly DatabaseService _databaseService;
        //private readonly InMemoryService _inMemoryService;


        public BooksController(
            DatabaseService databaseService) 
        { 
            _databaseService = databaseService;
        }

        [HttpGet("GetBookFromDatabase")]
        public IActionResult GetBooksFromDatabase()
        {
            return Ok(_databaseService.GetAllBooks());
        }

        //[HttpGet("GetBookFromMemory")]
        //public IActionResult GetBooksFromMemory()
        //{
        //    return Ok(_inMemoryService.GetAllBooks());
        //}

    }
}
