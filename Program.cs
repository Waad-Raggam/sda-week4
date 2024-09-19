using System.Net.Http.Headers;
using ecommerce;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();
// endpoint: http://localhost:5212
app.MapGet("", () =>
{
    return Results.Ok("Hello, World");
});

// endpoints

// method: Get
// endpoint: http://localhost:5212/greeting
app.MapGet("/greeting", () =>
{
    return "Hello, World from greeting";
});

// method: POST
// endpoint: http://localhost:5212/
app.MapPost("", () =>
{
    return "This is from post method";
});

// method: PUT
// endpoint: http://localhost:5212/
app.MapPut("", () =>
{
    return "This is from put method";
});

// method: DELETE
// endpoint: http://localhost:5212/
app.MapDelete("", () =>
{
    return "This is from delete method";
});

// Product
// in memory database product list

List<Product> products = new List<Product>
{
    new Product {Id = 1, Name = "Laptop"},
    new Product {Id = 2, Name = "Smartphone"},
    new Product {Id = 3, Name = "Tablet"},
};

// get return list of products
// method: get
// endpoint: http://localhost:5212/api/v1/products
// v1: backend returns list of products
// best practice: api/v1/products => add versioning
app.MapGet("/api/v1/products", () =>
{
    return Results.Ok(products);
});

// Create new product
// method: POST
// endpoint: http://localhost:5212/api/v1/products
app.MapPost("/api/v1/products", (Product newProduct) =>
{
    products.Add(newProduct);
    // list has 4 items now
    // return Results.Ok(products);
    return Results.Created("New Product", newProduct);
});


// method: DELETE
// endpoint: http://localhost:5212/api/v1/products
app.MapDelete("/api/v1/products/{id}", (int id) =>
{
    // step 1: find the product
    var foundProduct = products.FirstOrDefault(p => p.Id == id);
    // step 2: if product not found
    if (foundProduct == null)
    {
        return Results.NotFound();
    }
    else
    {
        // step 3: remove product if found
        products.Remove(foundProduct);
        return Results.NoContent();
    }
});

app.Run();