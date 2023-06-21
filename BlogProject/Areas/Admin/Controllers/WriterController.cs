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
        public ActionResult GetWriterByID(int writerid)
        {
            var findWriter = Writers.FirstOrDefault(x => x.Id == writerid);
            var jsonWriters = JsonConvert.SerializeObject(findWriter);
            return Json(jsonWriters);
        }
        public ActionResult AddWriter (WriterClass w)
        {
            Writers.Add(w);
            var jsonWriters = JsonConvert.SerializeObject(w);
            return Json(jsonWriters);
        }
        public ActionResult DeleteWriter(int id)
        {
            var writer = Writers.FirstOrDefault(x=>x.Id == id);
            Writers.Remove(writer);
            return Json(writer);
        }
        public ActionResult UpdateWriter(WriterClass w)
        {
            var writer=Writers.FirstOrDefault(x=>x.Id == w.Id);
            writer.Name = w.Name;
            var jsonWriter=JsonConvert.SerializeObject(writer);
            return Json(jsonWriter);
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
