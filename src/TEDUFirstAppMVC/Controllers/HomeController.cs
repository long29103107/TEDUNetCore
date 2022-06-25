using Microsoft.AspNetCore.Mvc;
using TEDUFirstAppMVC.Models;

namespace TEDUFirstAppMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var indexModel = new IndexModel();
            indexModel.Message = "Hello from index model";
            return View(model);
        }
    }
}
