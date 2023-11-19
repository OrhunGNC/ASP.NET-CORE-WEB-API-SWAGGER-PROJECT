using coreapiswagger.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
namespace coreapiswagger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        public readonly ApplicationDbContext dbcontext;
        public GamesController(ApplicationDbContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }
        [HttpGet]
        [Route("GetGames")]
        public async Task<IEnumerable<Games>> GetGames()
        {
            return await dbcontext.Gamess.ToListAsync();
        }
        [HttpGet]
        [Route("GetGamesbyId/{id}")]
        public async Task<Games> GetGamesbyId(int id)
        {
            return await dbcontext.FindAsync<Games>(id);
        }
        [HttpPost]
        [Route("AddGames")]
        public async Task<Games> AddGames(Games games)
        {
            dbcontext.Add(games);
            await dbcontext.SaveChangesAsync();
            return games;
        }
        [HttpPut]
        [Route("UpdateGames/{id}")]
        public async Task<Games> UpdateGames(Games games)
        {
            dbcontext.Update(games);
            await dbcontext.SaveChangesAsync();
            return games;
        }
        [HttpDelete]
        [Route("DeleteGames/{id}")]
        public bool DeleteGames(int id)
        {
            var islem = false;
            var result = dbcontext.Gamess.Find(id);
            if(result != null)
            {
                islem = true;
                dbcontext.Remove(result);
                dbcontext.SaveChanges();
            }
            else
            {
                return islem;
            }
            return islem;
        }
    }
}
