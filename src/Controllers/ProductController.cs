using Microsoft.AspNetCore.Mvc;

namespace ecommerce
{
    [ApiController]
    [Route("api/v1/[controller]")]
    // base endpoint: api/v1/products
    class ProductController : ControllerBase
    {

        public List<Product> products = new List<Product>
        {
            new Product {Id = 1, Name = "Laptop"},
            new Product {Id = 2, Name = "Smartphone"},
            new Product {Id = 3, Name = "Tablet"},
        };

        // ActionResult class: return status of http method
        // method: GET
        [HttpGet]
        public ActionResult GetProducts()
        {
            return Ok(products);
        }

    }
}