using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntitiyLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using BusinessLayer.ValidationRules;
using FluentValidation.Results;

namespace BlogProject.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {
        BlogManager bm=new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            var values = bm.GetBlogListWithCategory();
            return View(values);
        }
        public IActionResult BlogReadAll(int id)
        {
            //Transfer BlogID
            ViewBag.id= id;
            var values = bm.GetBlogByID(id);
            return View(values);
        }
        [Authorize]
        public IActionResult BlogListByWriter()
        {
            var values =bm.GetBlogListByWriter(1);
            return View(values);
        }
        [Authorize]
        [HttpGet]
        public IActionResult AddBlog()
        {
            return View();
        }
        [HttpPost]
        [Authorize]
        public IActionResult AddBlog(Blog p)
        {
            BlogValidator bv = new BlogValidator();
            ValidationResult result = bv.Validate(p);
            if(result.IsValid)
            {
                p.BlogStatus = true;
                p.BlogCreateDate=DateTime.Parse(DateTime.Now.ToShortDateString());
                p.WriterID = 1;
                bm.AddT(p);
                return RedirectToAction("BlogListByWriter","Blog");
            }
            else
            {
                foreach(var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
            }
            return View();
        }
        
    }
}
