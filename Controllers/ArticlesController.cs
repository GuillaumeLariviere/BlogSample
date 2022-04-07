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
    public class ArticlesController : RootController<Article>
    {

        public ArticlesController(AppDbContext context):base(context)
        {
        }

        // GET: api/Articles
        [HttpGet]
        public override async Task<ActionResult<IEnumerable<Article>>> GetAll()
        {
            return await base.GetAll();
        }

        // GET: api/Articles/5
        [HttpGet("{id}")]
        public override async Task<ActionResult<Article>> GetOne(int id)
        {
            return await base.GetOne(id);

        }

        // PUT: api/Articles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public override async Task<IActionResult> PutOne(int id, Article article)
        {
            return await base.PutOne(id, article);
        }

        // POST: api/Articles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public override async Task<ActionResult<Article>> PostOne(Article article)
        {
            return await base.PostOne(article);
        }

        // DELETE: api/Articles/5
        [HttpDelete("{id}")]
        public override async Task<IActionResult> DeleteOne(int id)
        {
            return await base.DeleteOne(id);
        }
    }
}
