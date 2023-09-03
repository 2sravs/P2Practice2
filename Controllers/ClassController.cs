using Microsoft.AspNetCore.Mvc;

namespace RainBowSchoolEF.Controllers
{
    public class ClassController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
