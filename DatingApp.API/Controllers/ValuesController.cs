using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Controllers
{
    //GET http://localhost:5000/api/values/5
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext _context;
        public ValuesController(DataContext context)
        {
            _context = context;
        }


        // GET api/values
        [HttpGet]
        public async Task<IActionResult> GetValues()
        {
            var values=await _context.Values.ToListAsync();
            return Ok(values);

            //throw new Exception ("Test exception sting :) ");
            //return new string[] { "value1", "value3" };
        }

        // GET api/values/5
        // np.: http://localhost:5000/api/values/5

        [HttpGet("{id}")]
        public async Task<IActionResult> GetValue(int id)
        {
            var value=await _context.Values.FirstOrDefaultAsync(x => x.ID == id);
            return Ok(value);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]


        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
