using Microsoft.AspNetCore.Mvc;

namespace workshop.Controllers
{
    public class studentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
