using Microsoft.AspNetCore.Mvc;
using System.IO;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace ecommerce
{
    [ApiController]
    [Route("api/v1/[controller]")]
    // endpoint: api/v1/Products
    public class ProductsController : ControllerBase
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
            // Get the controller name dynamically
            string controllerName = ControllerContext.ActionDescriptor.ControllerName;

            // Construct the full route based on the Route attribute and controller name
            string fullRoute = $"api/v1/{controllerName}";

            // Print to the console
            Console.WriteLine($"Route to {fullRoute}");
            return Ok(products);
        }

        // GET: get product by id
        [HttpGet("{id}")]
        public ActionResult GetProductById(int id)
        {
            // step 1: find the product by id
            Product? foundProduct = products.FirstOrDefault(p => p.Id == id);
            // step 2: if product not found
            if (foundProduct == null)
            {
                return NotFound();
            }
            else
            {
                // foundProduct.Name = updatedProduct.Name;
                return Ok(foundProduct);
            }
            return Ok(products);
        }
    }
}