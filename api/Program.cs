using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


app.MapGet("/", () => "Hello World!2");

app.MapPost("/", () => new {Name = "Luan Zampier", Age = 26});


//adicionando parametros ao header

app.MapGet("/AddHeader", (HttpResponse response) => {
    response.Headers.Add("teste", "Luan");
} );

app.MapGet("/AddHeader2", (HttpResponse response2) => {
    response2.Headers.Add("usuario2","paulo");
    response2.Headers.Add("usuario3","fael");
    response2.Headers.Add("usuario4","loredo");
    return "usuarios adicionados";
});

// adicionando parametros pelo body

app.MapPost("/salvarproduto", (Produto produto) => { //como parametro, passamos a classe do produto que criamos, as informaçoes enviadas pelo solicitante serao salvas em produto
    return produto.Cod + '-' + produto.Name;

});


app.MapGet("/getproduct", ([FromQuery] string dateStart, [FromQuery] string dateEnd) => {
    return dateStart + "--" + dateEnd;
});

app.MapGet("/getproduct/{code}", ([FromRoute] string code) => {
    return code;
});


app.Run();


public class Produto {
    //aqui dentro vamos adicionar nossas propriedade, que sao atributos dessa classe
    public string Cod { get; set; } // esse tipo de propriedade podemos tanto obter quanto alterar
    public string Name{ get; set; }
}






