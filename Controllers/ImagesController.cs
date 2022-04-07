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
    public class ImagesController : RootController<Image>
    {
  

        public ImagesController(AppDbContext context) : base(context)
        {

        }
        // GET: api/Image
        [HttpGet]
        public override async Task<ActionResult<IEnumerable<Image>>> GetAll()
        {
            return await base.GetAll();
        }

        // GET: api/Image/5
        [HttpGet("{id}")]
        public override async Task<ActionResult<Image>> GetOne(int id)
        {
            return await base.GetOne(id);

        }

        // PUT: api/Image/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public override async Task<IActionResult> PutOne(int id, Image image)
        {
            return await base.PutOne(id, image);
        }

        // POST: api/Image
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public override async Task<ActionResult<Image>> PostOne(Image image)
        {
            return await base.PostOne(image);
        }

        // DELETE: api/Image/5
        [HttpDelete("{id}")]
        public override async Task<IActionResult> DeleteOne(int id)
        {
            return await base.DeleteOne(id);
        }
    }
}
