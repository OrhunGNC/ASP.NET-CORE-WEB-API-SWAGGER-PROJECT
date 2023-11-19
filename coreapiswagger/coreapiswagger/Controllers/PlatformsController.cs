using coreapiswagger.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient.DataClassification;
using Microsoft.EntityFrameworkCore;

namespace coreapiswagger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlatformsController : ControllerBase
    {
        public readonly ApplicationDbContext dbcontext;
        public PlatformsController(ApplicationDbContext dbcontext)
        {
            this.dbcontext=dbcontext;
        }
        [HttpGet]
        [Route("GetPlatforms")]
        public async Task<IEnumerable<Platforms>> GetPlatforms()
        {
            return await dbcontext.Platformss.ToListAsync();
        }
        [HttpPost]
        [Route("AddPlatforms")]
        public async Task<Platforms> AddPlatforms(Platforms platforms)
        {
            dbcontext.Add(platforms);
            await dbcontext.SaveChangesAsync();
            return platforms;
        }
        [HttpGet]
        [Route("GetPlatformsbyId/{id}")]
        public async Task<Platforms> GetPlatformsbyId(int id)
        {
            return await dbcontext.FindAsync<Platforms>(id);
        }
        [HttpPut]
        [Route("UpdatePlatforms/{id}")]
        public async Task<Platforms> UpdatePlatforms(Platforms platforms)
        {
            dbcontext.Update(platforms);
            await dbcontext.SaveChangesAsync();
            return platforms;
        }
        [HttpDelete]
        [Route("DeletePlatforms/{id}")]
        public bool DeletePlatforms(int id)
        {
            var islem = false;
            var result = dbcontext.Platformss.Find(id);
            if (result != null)
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
