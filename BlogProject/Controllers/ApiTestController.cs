using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Language.Intermediate;
using Newtonsoft.Json;
using System.Text;

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
        [HttpGet]
        public IActionResult AddEmployee()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddEmployee(tempEmployeeClass p) 
        { 
            var httpClient=new HttpClient();
            var jsonEmployee = JsonConvert.SerializeObject(p);
            StringContent content = new StringContent(jsonEmployee,Encoding.UTF8,"application/json");
            var responseMessage = await httpClient.PostAsync("https://localhost:7001/api/Default", content);
            if(responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View(p);
        }
        [HttpGet]
        public async Task<IActionResult> EditEmployee(int id)
        {
            var httpClient=new HttpClient();
            var responseMessage = await httpClient.GetAsync("https://localhost:7001/api/Default/"+id);
            if(responseMessage.IsSuccessStatusCode)
            {
                var jsonEmployee=await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<tempEmployeeClass>(jsonEmployee);
                return View(values);
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> EditEmployee(tempEmployeeClass p)
        {
            var httpClient=new HttpClient();
            var jsonEmployee=JsonConvert.SerializeObject(p);
            var content = new StringContent(jsonEmployee,Encoding.UTF8,"application/json");
            var responseMessage = await httpClient.PutAsync("https://localhost:7001/api/Default/", content);
            if(responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View(p);
        }
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var httpClient=new HttpClient();
            var responseMessage = await httpClient.DeleteAsync("https://localhost:7001/api/Default/"+id);
            if(responseMessage.IsSuccessStatusCode )
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
    public class tempEmployeeClass
    {
        public int ID { get; set; }
        public string? Name { get; set; }
    }
}
