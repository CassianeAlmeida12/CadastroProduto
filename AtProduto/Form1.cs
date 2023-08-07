namespace AtProduto
{
    public partial class Form1 : Form
    {
        List<Produto> produtos = new List<Produto>(); // atributo da classe
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cadastrar_Click(object sender, EventArgs e)
        {
            

            Produto produto1 = new Produto();

            produto1.Codigo = tb_codigo.Text;
            produto1.Descricao = tb_descricao.Text;
            produto1.Preco = Convert.ToDouble(tb_preco.Text);
            produto1.Lucro = Convert.ToDouble(tb_lucro.Text);
            produto1.Valor = produto1.Preco + (produto1.Preco * produto1.Lucro / 100);

            tb_valor.Text = Convert.ToString(produto1.Valor);

            

            produtos.Add(produto1);

            dataGridView.DataSource = null; //vai limpar o que ja tinha
            dataGridView.Refresh();
            dataGridView.DataSource = produtos;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}