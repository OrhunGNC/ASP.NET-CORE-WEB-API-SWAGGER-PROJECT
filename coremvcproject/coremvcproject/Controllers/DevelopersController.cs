using coremvcproject.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace coremvcproject.Controllers
{
    public class DevelopersController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            HttpClient client = new HttpClient();
            var response = client.GetAsync("https://localhost:44390/api/Developers/GetDevelopers").Result;
            List<Developers> developers = JsonConvert.DeserializeObject<List<Developers>>(response.Content.ReadAsStringAsync().Result);
            return View(developers);
        }
        public IActionResult Create()
        {
            return View(new Developers());
        }
        [HttpPost]
        public IActionResult Create(Developers developers)
        {
            HttpClient client = new HttpClient();
            StringContent content = new StringContent(JsonConvert.SerializeObject(developers), System.Text.Encoding.UTF8, "application/json");
            var response = client.PostAsync("https://localhost:44390/api/Developers/AddDevelopers", content).Result;
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            HttpClient client = new HttpClient();
            var response = client.GetAsync($"https://localhost:44390/api/Developers/GetDevelopersbyId/{id}").Result;
            var developers = JsonConvert.DeserializeObject<Developers>(response.Content.ReadAsStringAsync().Result);
            return View(developers);
        }
        [HttpPost]
        public IActionResult Edit(Developers developers)
        {
            HttpClient client = new HttpClient();
            StringContent content = new StringContent(JsonConvert.SerializeObject(developers), System.Text.Encoding.UTF8, "application/json");
            var response = client.PutAsync($"https://localhost:44390/api/Developers/UpdateDevelopers/{developers.DevelopersId}", content).Result;
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            HttpClient client =new HttpClient();
            var response = client.DeleteAsync($"https://localhost:44390/api/Developers/DeleteDevelopers/{id}").Result;
            return RedirectToAction("Index");
        }
    }
}
