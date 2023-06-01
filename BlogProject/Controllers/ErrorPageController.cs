using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.Controllers
{
    public class ErrorPageController : Controller
    {
        [AllowAnonymous]
        public IActionResult Error1(int code)
        {

            return View();
        }
    }
}
