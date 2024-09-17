var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();
// endpoint: http://localhost:5212
app.MapGet("", () =>{
    return "Hello, World";
});

// endpoints

// method: Get
// endpoint: http://localhost:5212/greeting
app.MapGet("/greeting", () =>{
    return "Hello, World from greeting";
});

app.Run();