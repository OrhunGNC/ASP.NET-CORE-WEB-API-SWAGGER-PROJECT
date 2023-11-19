using coremvcproject.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;

namespace coremvcproject.Controllers
{
    public class GamesController : Controller
    {
        public IActionResult Index()
        {
            HttpClient client=new HttpClient();
            var response = client.GetAsync("https://localhost:44390/api/Games/GetGames").Result;
            List<Games> games;
            games = JsonConvert.DeserializeObject<List<Games>>(response.Content.ReadAsStringAsync().Result);
            return View(games);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new Games());
        }
        [HttpPost]
        public IActionResult Create(Games games)
        {
            HttpClient client = new HttpClient();
            StringContent content = new StringContent(JsonConvert.SerializeObject(games),System.Text.Encoding.UTF8,"application/json");
            var response = client.PostAsync("https://localhost:44390/api/Games/AddGames", content).Result;
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            HttpClient client = new HttpClient();
            var response = client.GetAsync($"https://localhost:44390/api/Games/GetGamesbyId/{id}").Result;
            var games = JsonConvert.DeserializeObject<Games>(response.Content.ReadAsStringAsync().Result);
            return View(games);
        }
        [HttpPost]
        public IActionResult Edit(Games games)
        {
            HttpClient client = new HttpClient();
            StringContent content = new StringContent(JsonConvert.SerializeObject(games), System.Text.Encoding.UTF8, "application/json");
            var response = client.PutAsync($"https://localhost:44390/api/Games/UpdateGames/{games.GamesId}",content).Result;
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            HttpClient client = new HttpClient();
            var response = client.DeleteAsync($"https://localhost:44390/api/Games/DeleteGames/{id}").Result;
            return RedirectToAction("Index");
        }
    }
}
