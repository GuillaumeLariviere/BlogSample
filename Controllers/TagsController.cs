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
    public class TagsController : RootController<Tag>
    {
        public TagsController(AppDbContext context) : base(context)
        {

        }

        // GET: api/Tags
        [HttpGet]
        public override async Task<ActionResult<IEnumerable<Tag>>> GetAll()
        {
            return await base.GetAll();
        }

        // GET: api/Tags/5
        [HttpGet("{id}")]
        public override async Task<ActionResult<Tag>> GetOne(int id)
        {
            return await base.GetOne(id);

        }

        // PUT: api/Tags/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public override async Task<IActionResult> PutOne(int id, Tag tag)
        {
            return await base.PutOne(id, tag);
        }

        // POST: api/Tags
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public override async Task<ActionResult<Tag>> PostOne(Tag tag)
        {
            return await base.PostOne(tag);
        }

        // DELETE: api/Tags/5
        [HttpDelete("{id}")]
        public override async Task<IActionResult> DeleteOne(int id)
        {
            return await base.DeleteOne(id);
        }
    }
}
