using Microsoft.AspNetCore.Mvc;
using System.Text;
using TEDUFirstAppMVC.Models;
using TEDUFirstAppMVC.ViewModels;

namespace TEDUFirstAppMVC.Controllers
{
    [Route("[controller]")]
    public class HomeController : Controller
    {
        [Route("index")]
        //[Route("index2")]
        //[Route("index3")]
        //[ActionName("index")]
        [HttpGet]
        public IActionResult Index()
        {
            var student = new Student()
            {
                Id = 1,
                Name = "Long",
                Class = new Class()
                {
                    Id = 1,
                    Name = "12"
                }
            };

            var studentViewModel = new StudentViewModel()
            {
                Id = student.Id,
                Name = student.Name,
                ClassName = student.Class.Name
            };

            return View(studentViewModel);
        }

        //public IActionResult Index()
        //{
        //_context.Response.StatusCode = StatusCodes.Status200OK;
        //_context.Response.ContentType = "text/html";
        //_context.Response.Headers.Add("key", "value");
        //byte[] content = Encoding.ASCII.GetBytes($"<html><body>Hello world</body></html>");
        //await _context.Response.Body.WriteAsync(content,0,content.Length);
        //}
    }
}
