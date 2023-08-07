namespace AtProduto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_codigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_lucro = new System.Windows.Forms.TextBox();
            this.tb_preco = new System.Windows.Forms.TextBox();
            this.tb_valor = new System.Windows.Forms.TextBox();
            this.excluir = new System.Windows.Forms.Button();
            this.novotxt = new System.Windows.Forms.Button();
            this.cadastrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(107, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Produto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(82, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código:";
            // 
            // tb_codigo
            // 
            this.tb_codigo.Location = new System.Drawing.Point(150, 107);
            this.tb_codigo.Name = "tb_codigo";
            this.tb_codigo.Size = new System.Drawing.Size(100, 23);
            this.tb_codigo.TabIndex = 2;
            this.tb_codigo.TextChanged += new System.EventHandler(this.codigo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(364, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descrição:";
            // 
            // tb_descricao
            // 
            this.tb_descricao.Location = new System.Drawing.Point(450, 106);
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.Size = new System.Drawing.Size(100, 23);
            this.tb_descricao.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Preço de aquisição:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(22, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Valor do produto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(375, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Lucro %:";
            // 
            // tb_lucro
            // 
            this.tb_lucro.Location = new System.Drawing.Point(450, 144);
            this.tb_lucro.Name = "tb_lucro";
            this.tb_lucro.Size = new System.Drawing.Size(100, 23);
            this.tb_lucro.TabIndex = 8;
            // 
            // tb_preco
            // 
            this.tb_preco.Location = new System.Drawing.Point(160, 157);
            this.tb_preco.Name = "tb_preco";
            this.tb_preco.Size = new System.Drawing.Size(100, 23);
            this.tb_preco.TabIndex = 9;
            // 
            // tb_valor
            // 
            this.tb_valor.Location = new System.Drawing.Point(160, 209);
            this.tb_valor.Name = "tb_valor";
            this.tb_valor.Size = new System.Drawing.Size(100, 23);
            this.tb_valor.TabIndex = 10;
            // 
            // excluir
            // 
            this.excluir.Location = new System.Drawing.Point(516, 227);
            this.excluir.Name = "excluir";
            this.excluir.Size = new System.Drawing.Size(75, 23);
            this.excluir.TabIndex = 11;
            this.excluir.Text = "excluir";
            this.excluir.UseVisualStyleBackColor = true;
            // 
            // novotxt
            // 
            this.novotxt.Location = new System.Drawing.Point(319, 227);
            this.novotxt.Name = "novotxt";
            this.novotxt.Size = new System.Drawing.Size(75, 23);
            this.novotxt.TabIndex = 12;
            this.novotxt.Text = "novo";
            this.novotxt.UseVisualStyleBackColor = true;
            this.novotxt.Click += new System.EventHandler(this.novotxt_Click);
            // 
            // cadastrar
            // 
            this.cadastrar.Location = new System.Drawing.Point(415, 227);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(75, 23);
            this.cadastrar.TabIndex = 13;
            this.cadastrar.Text = "cadastrar";
            this.cadastrar.UseVisualStyleBackColor = true;
            this.cadastrar.Click += new System.EventHandler(this.cadastrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(107, 283);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(452, 155);
            this.dataGridView1.TabIndex = 14;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(22, 261);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(38, 15);
            this.label.TabIndex = 15;
            this.label.Text = "label7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 450);
            this.Controls.Add(this.label);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cadastrar);
            this.Controls.Add(this.novotxt);
            this.Controls.Add(this.excluir);
            this.Controls.Add(this.tb_valor);
            this.Controls.Add(this.tb_preco);
            this.Controls.Add(this.tb_lucro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_descricao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_codigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tb_codigo;
        private Label label3;
        private TextBox tb_descricao;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tb_lucro;
        private TextBox tb_preco;
        private TextBox tb_valor;
        private Button excluir;
        private Button novotxt;
        private Button cadastrar;
        private DataGridView dataGridView1;
        private Label label;
    }
}