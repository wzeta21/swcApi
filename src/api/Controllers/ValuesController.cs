using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Api.Database;
using Api.Database.Entity.Threats;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly ApiContext _context;

        public ValuesController(ApiContext context)
        {
            _context = context;
        }

        /// <summary>
        ///  Returns a collection of values
        /// </summary>
        ///<remarks>
        /// This is a remark to add additional information about this method
        ///  GET /get
        /// {
        ///    "value1", 
        ///    "value2"
        /// }
        ///</remarks>
        [HttpGet("[action]")]
        public IEnumerable<Threat> Get()
        {
           return _context.Threats.AsEnumerable();
        }

        /// <summary>
        ///  Returns an item from a collection of values based on ID
        /// </summary>
        [HttpGet("[action] {id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
