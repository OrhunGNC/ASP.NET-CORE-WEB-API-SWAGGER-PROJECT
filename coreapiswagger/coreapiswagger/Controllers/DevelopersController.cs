using coreapiswagger.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace coreapiswagger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DevelopersController : ControllerBase
    {
        public readonly ApplicationDbContext dbcontext;
        public DevelopersController(ApplicationDbContext dbcontext)
        {
            this.dbcontext= dbcontext;
        }
        [HttpGet]
        [Route("GetDevelopers")]
        public async Task<IEnumerable<Developers>> GetDevelopers()
        {
            return await dbcontext.Developerss.ToListAsync();
        }
        [HttpPost]
        [Route("AddDevelopers")]
        public async Task<Developers> AddDevelopers(Developers developers)
        {
            dbcontext.Add(developers);
            await dbcontext.SaveChangesAsync();
            return developers;
        }
        [HttpGet]
        [Route("GetDevelopersbyId/{id}")]
        public async Task<Developers> GetDevelopersbyId(int id)
        {
            return await dbcontext.FindAsync<Developers>(id);
        }
        [HttpPut]
        [Route("UpdateDevelopers/{id}")]
        public async Task<Developers> UpdateDevelopers(Developers developers)
        {
            dbcontext.Update(developers);
            await dbcontext.SaveChangesAsync();
            return developers;
        }
        [HttpDelete]
        [Route("DeleteDevelopers/{id}")]
        public bool DeleteDevelopers(int id)
        {
            var islem = false;
            var result = dbcontext.Developerss.Find(id);
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
