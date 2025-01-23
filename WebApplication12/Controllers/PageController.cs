using Microsoft.AspNetCore.Mvc;

namespace WebApplication12.Controllers
{
    public class PageController : Controller
    {
        public IActionResult Welcome()
        {
            ViewBag.Message = "Добро пожаловать на страницу!";
            ViewBag.CurrentDate = DateTime.Now.ToString("F");
            return View();
        }

        public IActionResult Greet(string name)
        {
            ViewBag.Message = $"Привет!";
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(string message)
        {
            ViewBag.Message = message;
            return View("DisplayMessage");
        }
    }
}
