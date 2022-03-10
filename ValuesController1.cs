using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController1 : ControllerBase
    {
        public static List<string> data = new List<string>();
        

        //GET: api/<ValuesController1>
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return data.ToList();
        }
        
        // after calling get the output is an empty array like this []
        
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return data[id];
        }
        
        
        // POST api/<ValuesController1>
        // using post req added some data as follows 
        //"hello"
        //"hello"
        //"hello"
        //"world"
        //and again called the get req to see the data added
        
        [HttpPost]
        public void Post([FromBody] string value)
        {
            data.Add(value);
            
        }

        
        // PUT api/<ValuesController1>/5
        // used put to update 
        // after applying put request updated the data at index 1
        // output as follows
        //"hello"
        //"asp dot net"
        //"hello"
        //"world"
       
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            data[id] = value;
        }



        // DELETE api/<ValuesController1>
        // deleting data at index 2
        //"hello"
        //"asp dot net"
        //"world"
   
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            data.RemoveAt(id);
        }
    }
}
