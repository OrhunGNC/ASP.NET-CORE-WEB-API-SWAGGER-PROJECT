using coremvcproject.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Security.Policy;

namespace coremvcproject.Controllers
{
    public class PublishersController : Controller
    {
        public IActionResult Index()
        {
            HttpClient client = new HttpClient();
            var response = client.GetAsync("https://localhost:44390/api/Publishers/GetPublishers").Result;
            List<Publishers> publishers = JsonConvert.DeserializeObject<List<Publishers>>(response.Content.ReadAsStringAsync().Result);
            return View(publishers);
        }
        public IActionResult Create()
        {
            return View(new Publishers());
        }
        [HttpPost]
        public IActionResult Create(Publishers publishers)
        {
            HttpClient client = new HttpClient();
            StringContent content = new StringContent(JsonConvert.SerializeObject(publishers),System.Text.Encoding.UTF8,"application/json");
            var response = client.PostAsync("https://localhost:44390/api/Publishers/AddPublishers", content).Result;
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            HttpClient client=new HttpClient();
            var response = client.GetAsync($"https://localhost:44390/api/Publishers/GetPublishersbyId/{id}").Result;
            var publishers = JsonConvert.DeserializeObject<Publishers>(response.Content.ReadAsStringAsync().Result);
            return View(publishers);
        }
        [HttpPost]
        public IActionResult Edit(Publishers publishers)
        {
            HttpClient client = new HttpClient();
            StringContent content = new StringContent(JsonConvert.SerializeObject(publishers), System.Text.Encoding.UTF8, "application/json");
            var response = client.PutAsync($"https://localhost:44390/api/Publishers/UpdatePublishers/{publishers.PublishersId}",content).Result;
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            HttpClient client = new HttpClient();
            var response = client.DeleteAsync($"https://localhost:44390/api/Publishers/DeletePublishers/{id}").Result;
            return RedirectToAction("Index");

        }
    }
} 
