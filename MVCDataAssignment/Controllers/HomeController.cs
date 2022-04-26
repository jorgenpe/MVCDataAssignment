using Microsoft.AspNetCore.Mvc;

namespace MVCDataAssignment.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
