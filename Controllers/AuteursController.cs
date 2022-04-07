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
    public class AuteursController : RootController<Auteur>
    {
 

        public AuteursController(AppDbContext context) : base(context)
        {
        
        }
        // GET: api/Auteur
        [HttpGet]
        public override async Task<ActionResult<IEnumerable<Auteur>>> GetAll()
        {
            return await base.GetAll();
        }

        // GET: api/Auteur/5
        [HttpGet("{id}")]
        public override async Task<ActionResult<Auteur>> GetOne(int id)
        {
            return await base.GetOne(id);

        }

        // PUT: api/Auteur/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public override async Task<IActionResult> PutOne(int id, Auteur auteur)
        {
            return await base.PutOne(id, auteur);
        }

        // POST: api/Auteur
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public override async Task<ActionResult<Auteur>> PostOne(Auteur auteur)
        {
            return await base.PostOne(auteur);
        }

        // DELETE: api/Auteur/5
        [HttpDelete("{id}")]
        public override async Task<IActionResult> DeleteOne(int id)
        {
            return await base.DeleteOne(id);
        }
    }
}
