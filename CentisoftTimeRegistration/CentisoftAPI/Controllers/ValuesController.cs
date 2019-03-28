using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dapper;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;


namespace CentisoftAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public static SqlConnection connection = new SqlConnection("Server=kraka.ucn.dk;Database=dmaj0917_1067696;User Id=dmaj0917_1067696;Password=Password1!;");
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<dynamic>> Get()
        {
            string query = "SELECT * FROM Client";
            var result = connection.Query(query).ToList();
            return result;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
