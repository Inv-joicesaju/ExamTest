using Microsoft.AspNetCore.Mvc;

namespace TestSamble.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
