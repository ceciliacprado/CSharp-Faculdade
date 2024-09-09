namespace API.Models;

public class Produto
{
    private double valor;

    //getters(pega a informação) e setters (coloca a informação dentro do atributo do valor)

    public void setValor(double valor)
    {
        this.valor = valor * 3;
    }

    public void getValor()
    {
        return this.valor;
    }

}