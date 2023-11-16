using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace store_project_api.Controllers
{
    [Route("api/customer")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        public static List<Customer> customers = new List<Customer>();
        // GET: api/<CustomersController>
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return customers;
        }

        // GET api/<CustomersController>/5
        [HttpGet("{id}")]
        public Customer Get(int id)
        {
            Customer c = customers.Find(i => i.Id == id);
            return c != null ? c : null;
        }

        // POST api/<CustomersController>
        [HttpPost]
        public void Post([FromBody] Customer c)
        {
            customers.Add(c);
        }

        // PUT api/<CustomersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Customer c)
        {
            Customer c2 = customers.Find(i => i.Id == id);
            if (c2 != null)
            {
                c2.Address = c.Address;
                c2.Phone = c.Phone;
                c2.Name = c.Name;
            }
        }

        // DELETE api/<CustomersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Customer c2 = customers.Find(i => i.Id == id);
            customers.Remove(c2);
        }
    }
}
