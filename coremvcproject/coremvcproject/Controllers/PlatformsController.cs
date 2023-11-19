using coremvcproject.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace coremvcproject.Controllers
{
    public class PlatformsController : Controller
    {
        public IActionResult Index()
        {
            HttpClient client = new HttpClient();
            var response = client.GetAsync("https://localhost:44390/api/Platforms/GetPlatforms").Result;
            List<Platforms> platforms = JsonConvert.DeserializeObject<List<Platforms>>(response.Content.ReadAsStringAsync().Result);
            return View(platforms);
        }
        public IActionResult Create()
        {
            return View(new Platforms());
        }
        [HttpPost]
        public IActionResult Create(Platforms platforms)
        {
            HttpClient client = new HttpClient();
            StringContent content = new StringContent(JsonConvert.SerializeObject(platforms),System.Text.Encoding.UTF8,"application/json");
            var response = client.PostAsync("https://localhost:44390/api/Platforms/AddPlatforms", content).Result;
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            HttpClient client = new HttpClient();
            var response = client.GetAsync($"https://localhost:44390/api/Platforms/GetPlatformsbyId/{id}").Result;
            var platforms = JsonConvert.DeserializeObject<Platforms>(response.Content.ReadAsStringAsync().Result);
            return View(platforms);
        }
        [HttpPost]
        public IActionResult Edit(Platforms platforms)
        {
            HttpClient client = new HttpClient();
            StringContent content = new StringContent(JsonConvert.SerializeObject(platforms),System.Text.Encoding.UTF8,"application/json");
            var response = client.PutAsync($"https://localhost:44390/api/Platforms/UpdatePlatforms/{platforms.PlatformsId}",content).Result;
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id,Platforms platforms)
        {
            HttpClient client = new HttpClient();
            var response = client.DeleteAsync($"https://localhost:44390/api/Platforms/DeletePlatforms/{id}").Result;
            return RedirectToAction("Index");
        }
    }
}
