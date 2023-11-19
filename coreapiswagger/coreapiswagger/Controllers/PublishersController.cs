using coreapiswagger.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace coreapiswagger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublishersController : ControllerBase
    {
        public readonly ApplicationDbContext dbcontext;
        public PublishersController(ApplicationDbContext dbcontext)
        {
            this.dbcontext=dbcontext;
        }
        [HttpGet]
        [Route("GetPublishers")]
        public async Task<IEnumerable<Publishers>> GetPublishers()
        {
            return await dbcontext.Publisherss.ToListAsync();
        }
        [HttpPost]
        [Route("AddPublishers")]
        public async Task<Publishers> AddPublishers(Publishers publishers)
        {
            dbcontext.Add(publishers);
            await dbcontext.SaveChangesAsync();
            return publishers;
        }
        [HttpGet]
        [Route("GetPublishersbyId/{id}")]
        public async Task<Publishers> GetPublishersbyId(int id)
        {
            return await dbcontext.FindAsync<Publishers>(id);
        }
        [HttpPut]
        [Route("UpdatePublishers/{id}")]
        public async Task<Publishers> UpdatePublishers(Publishers publishers)
        {
            dbcontext.Update(publishers);
            await dbcontext.SaveChangesAsync(); 
            return publishers;
        }
        [HttpDelete]
        [Route("DeletePublishers/{id}")]
        public bool DeletePublishers(int id)
        {
            var islem = false;
            var result = dbcontext.Publisherss.Find(id);
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
