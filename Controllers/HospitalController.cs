using Microsoft.AspNetCore.Mvc;

namespace apbd6.Controllers
{
    public class HospitalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
