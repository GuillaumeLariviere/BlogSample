using BlogSampleApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlogSampleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RootController<M> : ControllerBase where M : Model
    {
        private readonly AppDbContext _context;

        public RootController(AppDbContext context){
     
            _context = context;
        }


        private DbSet<M> GetModels()
        {
            return (DbSet<M>)(typeof(AppDbContext).GetProperty(typeof(M).Name + "s").GetValue(_context, null));
        }
        // GET: api/<RootController>
        [HttpGet]
        public virtual async Task<ActionResult<IEnumerable<M>>> GetAll()
        {
            
            return await GetModels().ToListAsync();
        }

        // GET api/<RootController>/5
        [HttpGet("{id}")]
        public virtual async Task<ActionResult<M>> GetOne(int id)
        {
            var entity = await GetModels().FindAsync(id);

            if(entity == null)
            {
                return NotFound();
            }
            return entity;
        }

        // POST api/<RootController>
        [HttpPost]
        public virtual async Task<ActionResult<M>> PostOne(M entity)
        {
            GetModels().Add(entity);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // PUT api/<RootController>/5
        [HttpPut("{id}")]
        public virtual async Task<IActionResult> PutOne(int id, M entity)
        {
            if(id != entity.Id)
            {
                return BadRequest();
            }
            _context.Entry(entity).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EntityExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return NoContent();
        }

        // DELETE api/<RootController>/5
        [HttpDelete("{id}")]
        public virtual async Task<IActionResult> DeleteOne(int id)
        {
            var entity = await GetModels().FindAsync(id);
            if(entity == null)
            {
                return NotFound();
            }
            GetModels().Remove(entity);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EntityExists(int id)
        {
            return GetModels().Any(e => e.Id == id);
        }
    }
}
