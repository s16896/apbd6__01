using Microsoft.AspNetCore.Mvc;

namespace apbd6.Repositories.Implementations
{
    public class HospitalDbRepository : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
