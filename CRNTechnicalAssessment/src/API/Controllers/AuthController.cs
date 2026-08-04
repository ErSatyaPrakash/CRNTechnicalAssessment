using Microsoft.AspNetCore.Mvc;

namespace CRNTechnicalAssessment.src.API.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
