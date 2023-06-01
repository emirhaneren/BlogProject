using DataAccessLayer.Concrete;
using EntitiyLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Elfie.Serialization;

namespace BlogProject.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
        public IActionResult Index(Writer p)
        {
			Context c = new Context();
			var datavalue = c.Writers.FirstOrDefault(x => x.WriterMail == p.WriterMail && x.WriterPassword == p.WriterPassword);
			if (datavalue != null)
			{
				HttpContext.Session.SetString("username", p.WriterMail);
				return RedirectToAction("WriterProfile","Writer");
			}
			else
			{
				return View();
			}
        }
    }
}
