using Microsoft.AspNetCore.Mvc;
using TEDUDI.Services;

namespace TEDUDI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITransientService _transientService;
        private readonly IScopedService _scopedService;
        private readonly ISingletonService _singletonService;
        private readonly ITransientService _transientService2;
        private readonly IScopedService _scopedService2;
        private readonly ISingletonService _singletonService2;

        public HomeController(ITransientService transientService,
            IScopedService scopedService,
            ISingletonService singletonService,
            ITransientService transientService2,
            IScopedService scopedService2,
            ISingletonService singletonService2)
        {
            _transientService = transientService;
            _scopedService = scopedService;
            _singletonService = singletonService;
            _transientService2 = transientService2;
            _scopedService2 = scopedService2;
            _singletonService2 = singletonService2;
        }

        public IActionResult Index()
        {
            ViewBag.Message1 = _scopedService.GetById().ToString();
            ViewBag.Message2 = _scopedService2.GetById().ToString();
            ViewBag.Message3 = _transientService.GetById().ToString();
            ViewBag.Message4 = _transientService2.GetById().ToString();
            ViewBag.Message5 = _singletonService.GetById().ToString();
            ViewBag.Message6 = _singletonService2.GetById().ToString();
            return View();
        }
    }
}
