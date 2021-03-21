using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MyNotesController : ControllerBase
    {
        private readonly DataContext _context;
        public MyNotesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MyNote>>> GetMyNotes()
        {
            return await _context.MyNotes.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MyNote>> GetMyNoteById(int id)
        {
            return await _context.MyNotes.FindAsync(id);
        }

        /*[HttpPut]
        public ActionResult EditMyNote(MyNote myNote)
        {
            _context.MyNotes.Update(myNote);
        }*/
    }
}