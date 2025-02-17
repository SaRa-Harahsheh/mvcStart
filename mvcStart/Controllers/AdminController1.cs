using Microsoft.AspNetCore.Mvc;

namespace mvcStart.Controllers
{
    public class AdminController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
