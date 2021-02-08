using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace AuthWebApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RandomController : ControllerBase
    {
        private readonly ILogger<RandomController> _logger;

        public RandomController(ILogger<RandomController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public Guid Get()
        {
            var guid = Guid.NewGuid();
            _logger.Log(LogLevel.Information, guid.ToString());
            return guid;
        }
    }
}