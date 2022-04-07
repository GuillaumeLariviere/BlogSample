#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BlogSampleApi.Models;

namespace BlogSampleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUsersController : RootController<AppUser>
    {
   

        public AppUsersController(AppDbContext context): base(context)
        {

        }

        // GET: api/AppUsers
        [HttpGet]
        public override async Task<ActionResult<IEnumerable<AppUser>>> GetAll()
        {
            return await base.GetAll();
        }

        // GET: api/AppUsers/5
        [HttpGet("{id}")]
        public override async Task<ActionResult<AppUser>> GetOne(int id)
        {
            return await base.GetOne(id);

        }

        // PUT: api/AppUsers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public override async Task<IActionResult> PutOne(int id, AppUser appUser)
        {
            return await base.PutOne(id, appUser);
        }

        // POST: api/AppUsers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public override async Task<ActionResult<AppUser>> PostOne(AppUser appUser)
        {
            return await base.PostOne(appUser);
        }

        // DELETE: api/AppUsers/5
        [HttpDelete("{id}")]
        public override async Task<IActionResult> DeleteOne(int id)
        {
            return await base.DeleteOne(id);
        }
    }
}
