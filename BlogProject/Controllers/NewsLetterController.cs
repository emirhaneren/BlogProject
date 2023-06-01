using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntitiyLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.Controllers
{
    public class NewsLetterController : Controller
    {
        NewsLetterManager nm= new NewsLetterManager(new EfNewsLetterRepository());
        [HttpGet]
        public PartialViewResult SubscribeMail()
        {
            return PartialView();
        }
        [HttpPost]
        public IActionResult SubscribeMail(NewsLetter p)
        {
            p.MailStatus = true;
            nm.AddNewsLetter(p);
            return RedirectToAction("Index", "Blog");
        }
    }
}
