using BlogSampleApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlogSampleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RootController<C> : ControllerBase where C : RootController<C>
    {
        private readonly AppDbContext _context;
        
        string controllerName = typeof(C).Name.Replace("Controller","");
        string modelsName = typeof(C).Name.Replace("sController", "");

        public RootController(AppDbContext context, string controllerName, string modelsName){
            this.controllerName = controllerName;
            this.modelsName = modelsName;
            _context = context;
        }



        // GET: api/<RootController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RootController<C>.modelsName>>> GetAll()
        {
            
            return await _context.controllerName.ToListAsync();
        }

        // GET api/<RootController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<RootController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<RootController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RootController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
