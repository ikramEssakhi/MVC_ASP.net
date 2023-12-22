using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class ErrorController : Controller
    {
        [HttpGet("/Error/AccessDenied")]
        public IActionResult AccessDenied()
        {
            return View("AccessDenied");
        }
    }
}
