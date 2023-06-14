using BlogProject.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BlogProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class WriterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult WriterList()
        {
            var jsonWriters = JsonConvert.SerializeObject(Writers);
            return Json(jsonWriters);
        }
        public static List<WriterClass> Writers = new List<WriterClass>()
        {
            new WriterClass()
            {
                Id = 1,
                Name="Şenol"
            },
            new WriterClass()
            {
                Id=2,
                Name="Sergen"
            },
            new WriterClass()
            {
                Id=3,
                Name="Atiba"

            },
            new WriterClass()
            {
                Id=4,
                Name="Baba Hakkı"
            }
        };
    }
}
