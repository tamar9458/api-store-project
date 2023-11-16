using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace store_project_api.Controllers
{
    [Route("api/worker")]
    [ApiController]
    public class WorkersController : ControllerBase
    {
        public static List<Worker> workers = new List<Worker>();
        // GET: api/<WorkersController>
        [HttpGet]
        public IEnumerable<Worker> Get()
        {
            return workers;
        }

        // GET api/<WorkersController>/5
        [HttpGet("{id}")]
        public Worker Get(int id)
        {
            Worker w = workers.Find(i => i.Id == id);
            return w!=null?w:null;
        }

        // POST api/<WorkersController>
        [HttpPost]
        public void Post([FromBody] Worker w)
        {
            workers.Add(w);
        }

        // PUT api/<WorkersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Worker w)
        {
            Worker w2 = workers.Find(i => i.Id == id);
            if (w2 != null)
            {
                w2.Address = w.Address;
                w2.Phone = w.Phone;
                w2.Salary = w.Salary;
                w2.Name = w.Name;
            }
        }

        // DELETE api/<WorkersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
