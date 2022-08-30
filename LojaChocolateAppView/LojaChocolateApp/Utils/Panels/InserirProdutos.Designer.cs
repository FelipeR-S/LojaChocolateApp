namespace LojaChocolateApp.Utils.Panels
{
    partial class InserirProdutos
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelInserirProduto = new System.Windows.Forms.Panel();
            this.textValorProduto = new System.Windows.Forms.TextBox();
            this.textTipoProduto = new System.Windows.Forms.ComboBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnInserirProdutosCSV = new System.Windows.Forms.Button();
            this.btnInfoProduto = new System.Windows.Forms.Button();
            this.textArquivoProduto = new System.Windows.Forms.TextBox();
            this.btnInserirProdutoUnico = new System.Windows.Forms.Button();
            this.textEstoqueProduto = new System.Windows.Forms.TextBox();
            this.textPesoProduto = new System.Windows.Forms.TextBox();
            this.textNomeProduto = new System.Windows.Forms.TextBox();
            this.textIdProduto = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.panelInserirProduto.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInserirProduto
            // 
            this.panelInserirProduto.BackColor = System.Drawing.Color.Transparent;
            this.panelInserirProduto.Controls.Add(this.textBox9);
            this.panelInserirProduto.Controls.Add(this.textBox8);
            this.panelInserirProduto.Controls.Add(this.textBox7);
            this.panelInserirProduto.Controls.Add(this.textBox6);
            this.panelInserirProduto.Controls.Add(this.textBox5);
            this.panelInserirProduto.Controls.Add(this.textBox4);
            this.panelInserirProduto.Controls.Add(this.textBox3);
            this.panelInserirProduto.Controls.Add(this.textBox2);
            this.panelInserirProduto.Controls.Add(this.textValorProduto);
            this.panelInserirProduto.Controls.Add(this.textTipoProduto);
            this.panelInserirProduto.Controls.Add(this.panel9);
            this.panelInserirProduto.Controls.Add(this.btnInserirProdutosCSV);
            this.panelInserirProduto.Controls.Add(this.btnInfoProduto);
            this.panelInserirProduto.Controls.Add(this.textArquivoProduto);
            this.panelInserirProduto.Controls.Add(this.btnInserirProdutoUnico);
            this.panelInserirProduto.Controls.Add(this.textEstoqueProduto);
            this.panelInserirProduto.Controls.Add(this.textPesoProduto);
            this.panelInserirProduto.Controls.Add(this.textNomeProduto);
            this.panelInserirProduto.Controls.Add(this.textIdProduto);
            this.panelInserirProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInserirProduto.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelInserirProduto.Location = new System.Drawing.Point(0, 0);
            this.panelInserirProduto.Margin = new System.Windows.Forms.Padding(0);
            this.panelInserirProduto.Name = "panelInserirProduto";
            this.panelInserirProduto.Size = new System.Drawing.Size(715, 560);
            this.panelInserirProduto.TabIndex = 27;
            // 
            // textValorProduto
            // 
            this.textValorProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(167)))), ((int)(((byte)(101)))));
            this.textValorProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textValorProduto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textValorProduto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textValorProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textValorProduto.Location = new System.Drawing.Point(187, 231);
            this.textValorProduto.MaxLength = 8;
            this.textValorProduto.Name = "textValorProduto";
            this.textValorProduto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textValorProduto.Size = new System.Drawing.Size(400, 29);
            this.textValorProduto.TabIndex = 3;
            this.textValorProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textValorProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BoxValor);
            // 
            // textTipoProduto
            // 
            this.textTipoProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.textTipoProduto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTipoProduto.FormattingEnabled = true;
            this.textTipoProduto.Items.AddRange(new object[] {
            "Chocolate",
            "Presentes"});
            this.textTipoProduto.Location = new System.Drawing.Point(187, 321);
            this.textTipoProduto.Name = "textTipoProduto";
            this.textTipoProduto.Size = new System.Drawing.Size(400, 29);
            this.textTipoProduto.TabIndex = 5;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.textBox1);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(715, 74);
            this.panel9.TabIndex = 21;
            // 
            // btnInserirProdutosCSV
            // 
            this.btnInserirProdutosCSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.btnInserirProdutosCSV.FlatAppearance.BorderSize = 0;
            this.btnInserirProdutosCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserirProdutosCSV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirProdutosCSV.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInserirProdutosCSV.Location = new System.Drawing.Point(434, 469);
            this.btnInserirProdutosCSV.Name = "btnInserirProdutosCSV";
            this.btnInserirProdutosCSV.Size = new System.Drawing.Size(93, 27);
            this.btnInserirProdutosCSV.TabIndex = 8;
            this.btnInserirProdutosCSV.Text = "Inserir";
            this.btnInserirProdutosCSV.UseVisualStyleBackColor = false;
            this.btnInserirProdutosCSV.Click += new System.EventHandler(this.btnInserirProdutosCSV_Click);
            // 
            // btnInfoProduto
            // 
            this.btnInfoProduto.BackColor = System.Drawing.Color.DarkRed;
            this.btnInfoProduto.FlatAppearance.BorderSize = 0;
            this.btnInfoProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfoProduto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfoProduto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInfoProduto.Location = new System.Drawing.Point(533, 469);
            this.btnInfoProduto.Name = "btnInfoProduto";
            this.btnInfoProduto.Size = new System.Drawing.Size(54, 27);
            this.btnInfoProduto.TabIndex = 9;
            this.btnInfoProduto.Text = "Info";
            this.btnInfoProduto.UseVisualStyleBackColor = false;
            this.btnInfoProduto.Click += new System.EventHandler(this.btnInfoProduto_Click);
            // 
            // textArquivoProduto
            // 
            this.textArquivoProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(167)))), ((int)(((byte)(101)))));
            this.textArquivoProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textArquivoProduto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textArquivoProduto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textArquivoProduto.Location = new System.Drawing.Point(187, 469);
            this.textArquivoProduto.Name = "textArquivoProduto";
            this.textArquivoProduto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textArquivoProduto.Size = new System.Drawing.Size(241, 29);
            this.textArquivoProduto.TabIndex = 7;
            this.textArquivoProduto.Click += new System.EventHandler(this.OpenFile);
            // 
            // btnInserirProdutoUnico
            // 
            this.btnInserirProdutoUnico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.btnInserirProdutoUnico.FlatAppearance.BorderSize = 0;
            this.btnInserirProdutoUnico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserirProdutoUnico.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirProdutoUnico.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInserirProdutoUnico.Location = new System.Drawing.Point(187, 372);
            this.btnInserirProdutoUnico.Name = "btnInserirProdutoUnico";
            this.btnInserirProdutoUnico.Size = new System.Drawing.Size(400, 35);
            this.btnInserirProdutoUnico.TabIndex = 6;
            this.btnInserirProdutoUnico.Text = "Inserir";
            this.btnInserirProdutoUnico.UseVisualStyleBackColor = false;
            this.btnInserirProdutoUnico.Click += new System.EventHandler(this.btnInserirProdutoUnico_Click);
            // 
            // textEstoqueProduto
            // 
            this.textEstoqueProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(167)))), ((int)(((byte)(101)))));
            this.textEstoqueProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textEstoqueProduto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEstoqueProduto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textEstoqueProduto.Location = new System.Drawing.Point(187, 276);
            this.textEstoqueProduto.MaxLength = 4;
            this.textEstoqueProduto.Name = "textEstoqueProduto";
            this.textEstoqueProduto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textEstoqueProduto.Size = new System.Drawing.Size(400, 29);
            this.textEstoqueProduto.TabIndex = 4;
            this.textEstoqueProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textEstoqueProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers);
            // 
            // textPesoProduto
            // 
            this.textPesoProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(167)))), ((int)(((byte)(101)))));
            this.textPesoProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPesoProduto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPesoProduto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textPesoProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textPesoProduto.Location = new System.Drawing.Point(187, 186);
            this.textPesoProduto.MaxLength = 4;
            this.textPesoProduto.Name = "textPesoProduto";
            this.textPesoProduto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textPesoProduto.Size = new System.Drawing.Size(400, 29);
            this.textPesoProduto.TabIndex = 2;
            this.textPesoProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textPesoProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers);
            // 
            // textNomeProduto
            // 
            this.textNomeProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(167)))), ((int)(((byte)(101)))));
            this.textNomeProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textNomeProduto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNomeProduto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textNomeProduto.Location = new System.Drawing.Point(187, 141);
            this.textNomeProduto.MaxLength = 150;
            this.textNomeProduto.Name = "textNomeProduto";
            this.textNomeProduto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textNomeProduto.Size = new System.Drawing.Size(400, 29);
            this.textNomeProduto.TabIndex = 1;
            this.textNomeProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textIdProduto
            // 
            this.textIdProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(167)))), ((int)(((byte)(101)))));
            this.textIdProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textIdProduto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIdProduto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textIdProduto.Location = new System.Drawing.Point(187, 96);
            this.textIdProduto.MaxLength = 12;
            this.textIdProduto.Name = "textIdProduto";
            this.textIdProduto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textIdProduto.Size = new System.Drawing.Size(400, 29);
            this.textIdProduto.TabIndex = 0;
            this.textIdProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textIdProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.textBox1.Location = new System.Drawing.Point(0, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(715, 32);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "Inserir Produtos";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CopiarSelecionar);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(132, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(52, 18);
            this.textBox2.TabIndex = 16;
            this.textBox2.Text = "Código";
            this.textBox2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CopiarSelecionar);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(129, 146);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(52, 18);
            this.textBox3.TabIndex = 22;
            this.textBox3.Text = "Nome";
            this.textBox3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CopiarSelecionar);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.Black;
            this.textBox4.Location = new System.Drawing.Point(129, 191);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(52, 18);
            this.textBox4.TabIndex = 23;
            this.textBox4.Text = "Peso";
            this.textBox4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CopiarSelecionar);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.White;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.Black;
            this.textBox5.Location = new System.Drawing.Point(129, 236);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(52, 18);
            this.textBox5.TabIndex = 24;
            this.textBox5.Text = "Valor";
            this.textBox5.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CopiarSelecionar);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.White;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.Black;
            this.textBox6.Location = new System.Drawing.Point(129, 281);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(52, 18);
            this.textBox6.TabIndex = 25;
            this.textBox6.Text = "Estoque";
            this.textBox6.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CopiarSelecionar);
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.White;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.Color.Black;
            this.textBox7.Location = new System.Drawing.Point(129, 327);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(52, 18);
            this.textBox7.TabIndex = 26;
            this.textBox7.Text = "Tipo";
            this.textBox7.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CopiarSelecionar);
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.White;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.textBox8.Location = new System.Drawing.Point(0, 428);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(715, 26);
            this.textBox8.TabIndex = 16;
            this.textBox8.Text = "Inserir com arquivo CSV:";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox8.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CopiarSelecionar);
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.White;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.ForeColor = System.Drawing.Color.Black;
            this.textBox9.Location = new System.Drawing.Point(83, 475);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(98, 18);
            this.textBox9.TabIndex = 27;
            this.textBox9.Text = "Inserir Arquivo";
            this.textBox9.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CopiarSelecionar);
            // 
            // InserirProdutos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelInserirProduto);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(715, 560);
            this.MinimumSize = new System.Drawing.Size(715, 560);
            this.Name = "InserirProdutos";
            this.Size = new System.Drawing.Size(715, 560);
            this.panelInserirProduto.ResumeLayout(false);
            this.panelInserirProduto.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInserirProduto;
        private System.Windows.Forms.TextBox textValorProduto;
        private System.Windows.Forms.ComboBox textTipoProduto;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnInserirProdutosCSV;
        private System.Windows.Forms.Button btnInfoProduto;
        private System.Windows.Forms.TextBox textArquivoProduto;
        private System.Windows.Forms.Button btnInserirProdutoUnico;
        private System.Windows.Forms.TextBox textEstoqueProduto;
        private System.Windows.Forms.TextBox textPesoProduto;
        private System.Windows.Forms.TextBox textNomeProduto;
        private System.Windows.Forms.TextBox textIdProduto;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}
