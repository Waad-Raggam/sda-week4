using System.Net.Http.Headers;
using ecommerce;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();
// endpoint: http://localhost:5212
app.MapGet("", () =>{
    return Results.Ok("Hello, World");
});

// endpoints

// method: Get
// endpoint: http://localhost:5212/greeting
app.MapGet("/greeting", () =>{
    return "Hello, World from greeting";
});

// method: POST
// endpoint: http://localhost:5212/
app.MapPost("", () => {
    return "This is from post method";
});

// method: PUT
// endpoint: http://localhost:5212/
app.MapPut("", () => {
    return "This is from put method";
});

// method: DELETE
// endpoint: http://localhost:5212/
app.MapDelete("", () => {
    return "This is from delete method";
});

// Product
// in memory database product list

List<Product> products = new List<Product>
{

}

app.Run();