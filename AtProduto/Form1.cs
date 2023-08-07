namespace AtProduto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cadastrar_Click(object sender, EventArgs e)
        {
            List<Produto> produtos = new List<Produto>();

            Produto produto1 = new Produto();

            produto1.Codigo = tb_codigo.Text;
            produto1.Descricao = tb_descricao.Text;
            produto1.Preco = tb_preco.Text;
            produto1.Lucro = tb_lucro.Text;
            produto1.Valor = tb_valor.Text;

            produtos.Add(produto1);

            foreach(Produto produto in produtos)
            {
                label.Text = $"Lista de produtos:   {produto.Codigo}  {produto.Valor}";
            }
        }

        private void novotxt_Click(object sender, EventArgs e)
        {
            
            tb_codigo.Clear();
            tb_preco.Clear();
            tb_valor.Clear();
            tb_descricao.Clear();
            tb_lucro.Clear();
        }

        private void codigo_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}