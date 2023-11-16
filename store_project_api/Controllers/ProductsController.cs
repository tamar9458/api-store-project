using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace store_project_api.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public static List<Product> products = new List<Product>();

        // GET: api/<ProductsController>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return products;
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            Product p = products.Find(i => i.Id == id);
            return p!=null?p:null;
        }

        // POST api/<ProductsController>
        [HttpPost]
        public void Post([FromBody] Product p)
        {
            products.Add(p);
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Product p)
        {
            Product p2 = products.Find(i => i.Id == id);
            if (p2 == null)
            {
                p2.Price = p.Price;
                p2.Name = p.Name;
            }
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Product p2 = products.Find(i => i.Id == id);
            products.Remove(p2);
        }
    }
}
