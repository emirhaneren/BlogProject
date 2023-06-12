using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.Controllers
{
    //13. Step controllers
    public class CategoryController : Controller
    {
        //add categorymanager
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        public IActionResult Index()
        {
            //category list
            var values = cm.GetList();
            return View(values);
        }
    }
}
