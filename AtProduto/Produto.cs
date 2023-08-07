public class Produto
{
    public string Codigo { get; set; }
    public string Descricao { get; set; }
    public string Preco { get; set; }
    public string Lucro { get; set; }
    public string Valor { get; set; }

    
    public Produto()
    {

    }

    public Produto(string codigo, string descricao, string preco, string lucro, string valor )
    {
        this.Codigo = codigo;
        this.Descricao = descricao;
        this.Preco = preco;
        this.Lucro = lucro;
        this.Valor = valor;

    }
}

