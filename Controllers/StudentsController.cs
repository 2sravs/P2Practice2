using Microsoft.AspNetCore.Mvc;

namespace RainBowSchoolEF.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
