using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Editing;
using System.Xml.Linq;

namespace BlogProject.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic1 : ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = bm.GetList().Count();
            ViewBag.v2=c.Contacts.Count();
            ViewBag.v3=c.Comments.Count();
            string ApiKey = "eae424ef70dbab7f5a9c925f2c1a10a3";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&units=metric&lang=tr&appid=" + ApiKey;
            XDocument document = XDocument.Load(connection);
            ViewBag.v4=document.Descendants("temperature")
                .ElementAt(0)
                .Attribute("value").Value;
            ViewBag.v5 = document.Descendants("weather")
                .ElementAt(0)
                .Attribute("value").Value;
            return View();
        }
    }
}
