// estrutura mínima para api em c#
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// funcionalidades
// requisição - url e verbo http - nesse caso o MapGet (get) 
app.MapGet("/", () => "Projeto API com C#");

app.MapGet("/segunda", () => "segunda funcionalidade");


app.Run();
