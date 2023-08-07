public class Produto
{
    public string Codigo { get; set; }
    public string Descricao { get; set; }
    public double Preco { get; set; }//preco que ele ta comprando
    public double Lucro { get; set; }//porcentagem de lucro q ele quer
    public double Valor { get; set; }//preco de venda


    public Produto()
    {

    }

    public Produto(string codigo, string descricao, double preco, double lucro, double valor)
    {
        this.Codigo = codigo;
        this.Descricao = descricao;
        this.Preco = preco;
        this.Lucro = lucro;
        this.Valor = valor;

    }

}    

