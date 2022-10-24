var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


app.MapGet("/", () => "Hello World!");
app.MapPost("/", () => new {Name = "Luan Zampier", Age = 26});
app.MapGet("/AddHeader", (HttpResponse response) => {
    response.Headers.Add("teste", "Luan");
} );

app.Run();
