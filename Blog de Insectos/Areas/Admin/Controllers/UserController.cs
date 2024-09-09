using Microsoft.AspNetCore.Mvc;

namespace Blog_de_Insectos.Areas.Admin.Controllers
{
    public class UserController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("Login")]
        public IActionResult Login()
        {
            return View();
        }
    }
}
