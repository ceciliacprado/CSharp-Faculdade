// estrutura mínima para api em c#
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<Produto> produtos = new List<Produto>
{
    new Produto{ Nome = "Produto A", Valor = 90, Quantidade = 10 },
    new Produto{ Nome = "Produto A", Valor = 90, Quantidade = 10 },
    new Produto{ Nome = "Produto A", Valor = 90, Quantidade = 10 },
};

// funcionalidades
// requisição - url e verbo http - nesse caso o MapGet (get) 
app.MapGet("/", () => "API de produtos");

//get: /api/produto/listar
app.MapGet("/api/produto/listar", () =>
{
    return produtos;
});
//quando tiver {} na rota, não é mais rota fixa, apenas parâmetro 
app.MapPost("/api/produto/cadastrar/{nome}", (string nome) =>
{
    Produto produto = new Produto();
    produto.Nome = nome;
    produtos.Add(produto);
    return produtos;
});

app.Run();