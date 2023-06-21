using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Language.Intermediate;
using Newtonsoft.Json;

namespace BlogProject.Controllers
{
    public class ApiTestController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var httpClient= new HttpClient();
            var responseMesssage = await httpClient.GetAsync("https://localhost:7001/api/Default");
            var jsonString=await responseMesssage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<tempEmployeeClass>>(jsonString);
            return View(values);
        }
    }
    public class tempEmployeeClass
    {
        public int ID { get; set; }
        public string? Name { get; set; }
    }
}
