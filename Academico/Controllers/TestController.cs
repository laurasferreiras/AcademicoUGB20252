using Microsoft.AspNetCore.Mvc;

namespace Academico.Controllers
{
    public class TestController : Controller
    {
        private readonly ILogger<TestController> _logger;

        public TestController(ILogger<TestController> logger)
        {
            _logger = logger;
        }
        public IActionResult Aula()
        {
            return View();
        }

    }
}
