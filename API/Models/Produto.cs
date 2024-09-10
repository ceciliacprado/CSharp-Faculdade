namespace API.Models;

using System;
public class Produto
{
    //se tiver mais de um construtor com nomes iguais os parâmetros devem ser diferentes 
    public Produto()
    { //identificador unico global 
        Id = Guid.NewGuid().ToString();
        CriadoEm = DateTime.Now;

    }

    public string Id { get; set; }
    public string Nome { get; set; }
    public double Valor { get; set; }
    public int Quantidade { get; set; }
    public DateTime CriadoEm { get; set; }

}
