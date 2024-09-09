using Microsoft.AspNetCore.Mvc;

namespace Blog_de_Insectos.Controllers
{
    public class PageController : Controller
    {
        public IActionResult About() { return View(); }
        public IActionResult Contact() { return View(); }
        public IActionResult PrivacyPolicy() { return View(); }
    }
}
