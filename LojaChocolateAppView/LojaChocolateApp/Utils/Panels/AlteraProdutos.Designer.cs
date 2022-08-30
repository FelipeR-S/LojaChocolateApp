namespace LojaChocolateApp.Utils.Panels
{
    partial class AlteraProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlteraProdutos));
            this.panelEstoqueProduto = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.BtnAlterarEstoque = new System.Windows.Forms.Button();
            this.panelNovoValorProduto = new System.Windows.Forms.Panel();
            this.textNovoValorProduto = new System.Windows.Forms.TextBox();
            this.panelQuantidadeProduto = new System.Windows.Forms.Panel();
            this.textEstoqueQtdProdutos = new System.Windows.Forms.TextBox();
            this.comboBoxOpcaoProdutos = new System.Windows.Forms.ComboBox();
            this.textIdEstoqueProdutos = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.panelEstoqueProduto.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panelNovoValorProduto.SuspendLayout();
            this.panelQuantidadeProduto.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEstoqueProduto
            // 
            this.panelEstoqueProduto.BackColor = System.Drawing.Color.Transparent;
            this.panelEstoqueProduto.Controls.Add(this.panel12);
            this.panelEstoqueProduto.Controls.Add(this.panel10);
            this.panelEstoqueProduto.Controls.Add(this.panel11);
            this.panelEstoqueProduto.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelEstoqueProduto.Location = new System.Drawing.Point(1, 0);
            this.panelEstoqueProduto.Margin = new System.Windows.Forms.Padding(0);
            this.panelEstoqueProduto.Name = "panelEstoqueProduto";
            this.panelEstoqueProduto.Size = new System.Drawing.Size(714, 561);
            this.panelEstoqueProduto.TabIndex = 29;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.textBox3);
            this.panel12.Controls.Add(this.BtnAlterarEstoque);
            this.panel12.Controls.Add(this.panelNovoValorProduto);
            this.panel12.Controls.Add(this.panelQuantidadeProduto);
            this.panel12.Controls.Add(this.comboBoxOpcaoProdutos);
            this.panel12.Controls.Add(this.textIdEstoqueProdutos);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 308);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(714, 150);
            this.panel12.TabIndex = 23;
            // 
            // BtnAlterarEstoque
            // 
            this.BtnAlterarEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.BtnAlterarEstoque.FlatAppearance.BorderSize = 0;
            this.BtnAlterarEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAlterarEstoque.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAlterarEstoque.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAlterarEstoque.Location = new System.Drawing.Point(445, 33);
            this.BtnAlterarEstoque.Name = "BtnAlterarEstoque";
            this.BtnAlterarEstoque.Size = new System.Drawing.Size(173, 78);
            this.BtnAlterarEstoque.TabIndex = 4;
            this.BtnAlterarEstoque.Text = "Alterar Estoque";
            this.BtnAlterarEstoque.UseVisualStyleBackColor = false;
            this.BtnAlterarEstoque.Click += new System.EventHandler(this.BtnAlterarEstoque_Click);
            // 
            // panelNovoValorProduto
            // 
            this.panelNovoValorProduto.Controls.Add(this.textBox5);
            this.panelNovoValorProduto.Controls.Add(this.textNovoValorProduto);
            this.panelNovoValorProduto.Location = new System.Drawing.Point(269, 65);
            this.panelNovoValorProduto.Name = "panelNovoValorProduto";
            this.panelNovoValorProduto.Size = new System.Drawing.Size(165, 53);
            this.panelNovoValorProduto.TabIndex = 38;
            // 
            // textNovoValorProduto
            // 
            this.textNovoValorProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(167)))), ((int)(((byte)(101)))));
            this.textNovoValorProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textNovoValorProduto.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNovoValorProduto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textNovoValorProduto.Location = new System.Drawing.Point(56, 12);
            this.textNovoValorProduto.MaxLength = 8;
            this.textNovoValorProduto.Name = "textNovoValorProduto";
            this.textNovoValorProduto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textNovoValorProduto.Size = new System.Drawing.Size(100, 33);
            this.textNovoValorProduto.TabIndex = 3;
            this.textNovoValorProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textNovoValorProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BoxValor);
            // 
            // panelQuantidadeProduto
            // 
            this.panelQuantidadeProduto.Controls.Add(this.textBox4);
            this.panelQuantidadeProduto.Controls.Add(this.textEstoqueQtdProdutos);
            this.panelQuantidadeProduto.Location = new System.Drawing.Point(67, 65);
            this.panelQuantidadeProduto.Name = "panelQuantidadeProduto";
            this.panelQuantidadeProduto.Size = new System.Drawing.Size(182, 53);
            this.panelQuantidadeProduto.TabIndex = 36;
            // 
            // textEstoqueQtdProdutos
            // 
            this.textEstoqueQtdProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(167)))), ((int)(((byte)(101)))));
            this.textEstoqueQtdProdutos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textEstoqueQtdProdutos.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEstoqueQtdProdutos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textEstoqueQtdProdutos.Location = new System.Drawing.Point(119, 12);
            this.textEstoqueQtdProdutos.MaxLength = 4;
            this.textEstoqueQtdProdutos.Name = "textEstoqueQtdProdutos";
            this.textEstoqueQtdProdutos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textEstoqueQtdProdutos.Size = new System.Drawing.Size(50, 33);
            this.textEstoqueQtdProdutos.TabIndex = 2;
            this.textEstoqueQtdProdutos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textEstoqueQtdProdutos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers);
            // 
            // comboBoxOpcaoProdutos
            // 
            this.comboBoxOpcaoProdutos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOpcaoProdutos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOpcaoProdutos.FormattingEnabled = true;
            this.comboBoxOpcaoProdutos.Items.AddRange(new object[] {
            "Remover",
            "Inserir",
            "Retirar",
            "Alterar Valor"});
            this.comboBoxOpcaoProdutos.Location = new System.Drawing.Point(274, 35);
            this.comboBoxOpcaoProdutos.Name = "comboBoxOpcaoProdutos";
            this.comboBoxOpcaoProdutos.Size = new System.Drawing.Size(151, 29);
            this.comboBoxOpcaoProdutos.TabIndex = 1;
            this.comboBoxOpcaoProdutos.SelectedIndexChanged += new System.EventHandler(this.comboBoxOpcaoProdutos_SelectedIndexChanged);
            // 
            // textIdEstoqueProdutos
            // 
            this.textIdEstoqueProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(167)))), ((int)(((byte)(101)))));
            this.textIdEstoqueProdutos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textIdEstoqueProdutos.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIdEstoqueProdutos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textIdEstoqueProdutos.Location = new System.Drawing.Point(131, 37);
            this.textIdEstoqueProdutos.MaxLength = 12;
            this.textIdEstoqueProdutos.Name = "textIdEstoqueProdutos";
            this.textIdEstoqueProdutos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textIdEstoqueProdutos.Size = new System.Drawing.Size(106, 25);
            this.textIdEstoqueProdutos.TabIndex = 0;
            this.textIdEstoqueProdutos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textIdEstoqueProdutos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.textBox1);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 134);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(40, 40, 40, 20);
            this.panel10.Size = new System.Drawing.Size(714, 174);
            this.panel10.TabIndex = 22;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.textBox2);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(714, 134);
            this.panel11.TabIndex = 16;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(40, 40);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(634, 114);
            this.textBox1.TabIndex = 19;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CopiarSelecionar);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.textBox2.Location = new System.Drawing.Point(-1, 57);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(715, 38);
            this.textBox2.TabIndex = 20;
            this.textBox2.Text = "Estoque de Produtos";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CopiarSelecionar);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(70, 41);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(59, 18);
            this.textBox3.TabIndex = 21;
            this.textBox3.Text = "Código:";
            this.textBox3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CopiarSelecionar);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.Black;
            this.textBox4.Location = new System.Drawing.Point(3, 19);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(86, 18);
            this.textBox4.TabIndex = 39;
            this.textBox4.Text = "Quantidade:";
            this.textBox4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CopiarSelecionar);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.White;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.Black;
            this.textBox5.Location = new System.Drawing.Point(3, 19);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(53, 18);
            this.textBox5.TabIndex = 40;
            this.textBox5.Text = "Valor:";
            this.textBox5.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CopiarSelecionar);
            // 
            // AlteraProdutos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelEstoqueProduto);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(715, 560);
            this.MinimumSize = new System.Drawing.Size(715, 560);
            this.Name = "AlteraProdutos";
            this.Size = new System.Drawing.Size(715, 560);
            this.panelEstoqueProduto.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panelNovoValorProduto.ResumeLayout(false);
            this.panelNovoValorProduto.PerformLayout();
            this.panelQuantidadeProduto.ResumeLayout(false);
            this.panelQuantidadeProduto.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEstoqueProduto;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button BtnAlterarEstoque;
        private System.Windows.Forms.Panel panelNovoValorProduto;
        public System.Windows.Forms.TextBox textNovoValorProduto;
        private System.Windows.Forms.Panel panelQuantidadeProduto;
        public System.Windows.Forms.TextBox textEstoqueQtdProdutos;
        private System.Windows.Forms.ComboBox comboBoxOpcaoProdutos;
        public System.Windows.Forms.TextBox textIdEstoqueProdutos;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
    }
}
