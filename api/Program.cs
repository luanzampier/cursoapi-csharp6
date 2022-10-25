var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


app.MapGet("/", () => "Hello World!2");

app.MapPost("/", () => new {Name = "Luan Zampier", Age = 26});

app.MapGet("/AddHeader", (HttpResponse response) => {
    response.Headers.Add("teste", "Luan");
} );

app.MapGet("/AddHeader2", (HttpResponse response2) => {
    response2.Headers.Add("usuario2","paulo");
    response2.Headers.Add("usuario3","fael");
    response2.Headers.Add("usuario4","loredo");
    return "usuarios adicionados";
});



app.Run();

