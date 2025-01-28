using DependencyInjection.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
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
