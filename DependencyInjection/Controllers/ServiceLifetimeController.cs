using DependencyInjection.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    /// <summary>
    /// Controller to demonstrate service lifetimes (Transient, Scoped, Singleton).
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceLifetimeController : ControllerBase
    {
        private readonly ITransientService _transientService1;
        private readonly ITransientService _transientService2;
        private readonly IScopedService _scopedService1;
        private readonly IScopedService _scopedService2;
        private readonly ISingletonService _singletonService1;
        private readonly ISingletonService _singletonService2;

        /// <summary>
        /// Initializes the controller with services.
        /// </summary>
        /// <param name="transientService1"></param>
        /// <param name="transientService2"></param>
        /// <param name="singletonService1"></param>
        /// <param name="singletonService2"></param>
        /// <param name="scopedService1"></param>
        /// <param name="scopedService2"></param>
        public ServiceLifetimeController(
            ITransientService transientService1,
            ITransientService transientService2,
            ISingletonService singletonService1,
            ISingletonService singletonService2,
            IScopedService scopedService1,
            IScopedService scopedService2)
        {
            _transientService1 = transientService1;
            _transientService2 = transientService2;
            _singletonService1 = singletonService1;
            _singletonService2 = singletonService2;
            _scopedService1 = scopedService1;
            _scopedService2 = scopedService2;
        }

        /// <summary>
        /// Gets operation IDs for Transient services.
        /// </summary>
        /// <returns>Ok response with 2 instance Id</returns>
        [HttpGet("Transient")]
        public IActionResult GetTransientOperationId()
        {
            var transient = new
            {
                Instance1 = _transientService1.GetOperationId(),
                Instance2 = _transientService2.GetOperationId()
            };
            return Ok(transient);
        }

        /// <summary>
        /// Gets operation IDs for Scoped services.
        /// </summary>
        /// <returns>Ok response with 2 instance Id</returns>
        [HttpGet("Scoped")]
        public IActionResult GetScopedOperationId()
        {
            var scoped = new
            {
                Instance1 = _scopedService1.GetOperationId(),
                Instance2 = _scopedService2.GetOperationId()
            };
            return Ok(scoped);
        }

        /// <summary>
        /// Gets operation IDs for Singleton services.
        /// </summary>
        /// <returns>Ok response with 2 instance Id</returns>
        [HttpGet("Singleton")]
        public IActionResult GetSingletonOperationId()
        {
            var singleton = new
            {
                Instance1 = _singletonService1.GetOperationId(),
                Instance2 = _singletonService2.GetOperationId()
            };
            return Ok(singleton);
        }
    }
}
