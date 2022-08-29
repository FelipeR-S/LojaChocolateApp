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
            this.label16 = new System.Windows.Forms.Label();
            this.btnInserirProdutosCSV = new System.Windows.Forms.Button();
            this.btnInfoProduto = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textArquivoProduto = new System.Windows.Forms.TextBox();
            this.btnInserirProdutoUnico = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.textEstoqueProduto = new System.Windows.Forms.TextBox();
            this.textPesoProduto = new System.Windows.Forms.TextBox();
            this.textNomeProduto = new System.Windows.Forms.TextBox();
            this.textIdProduto = new System.Windows.Forms.TextBox();
            this.panelInserirProduto.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInserirProduto
            // 
            this.panelInserirProduto.BackColor = System.Drawing.Color.Transparent;
            this.panelInserirProduto.Controls.Add(this.textValorProduto);
            this.panelInserirProduto.Controls.Add(this.textTipoProduto);
            this.panelInserirProduto.Controls.Add(this.panel9);
            this.panelInserirProduto.Controls.Add(this.btnInserirProdutosCSV);
            this.panelInserirProduto.Controls.Add(this.btnInfoProduto);
            this.panelInserirProduto.Controls.Add(this.label17);
            this.panelInserirProduto.Controls.Add(this.label19);
            this.panelInserirProduto.Controls.Add(this.textArquivoProduto);
            this.panelInserirProduto.Controls.Add(this.btnInserirProdutoUnico);
            this.panelInserirProduto.Controls.Add(this.label20);
            this.panelInserirProduto.Controls.Add(this.label21);
            this.panelInserirProduto.Controls.Add(this.label22);
            this.panelInserirProduto.Controls.Add(this.label23);
            this.panelInserirProduto.Controls.Add(this.label24);
            this.panelInserirProduto.Controls.Add(this.label25);
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
            this.panel9.Controls.Add(this.label16);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(715, 74);
            this.panel9.TabIndex = 21;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.label16.Location = new System.Drawing.Point(293, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(200, 32);
            this.label16.TabIndex = 14;
            this.label16.Text = "Inserir Produtos";
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
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Location = new System.Drawing.Point(80, 474);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 17);
            this.label17.TabIndex = 16;
            this.label17.Text = "Inserir Arquivo";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.label19.Location = new System.Drawing.Point(263, 428);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(232, 25);
            this.label19.TabIndex = 15;
            this.label19.Text = "Inserir com arquivo CSV:";
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
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label20.Location = new System.Drawing.Point(124, 280);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(57, 17);
            this.label20.TabIndex = 11;
            this.label20.Text = "Estoque";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label21.Location = new System.Drawing.Point(124, 325);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(36, 17);
            this.label21.TabIndex = 10;
            this.label21.Text = "Tipo";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label22.Location = new System.Drawing.Point(124, 237);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(40, 17);
            this.label22.TabIndex = 9;
            this.label22.Text = "Valor";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label23.Location = new System.Drawing.Point(124, 192);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(37, 17);
            this.label23.TabIndex = 8;
            this.label23.Text = "Peso";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label24.Location = new System.Drawing.Point(124, 145);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(45, 17);
            this.label24.TabIndex = 7;
            this.label24.Text = "Nome";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label25.Location = new System.Drawing.Point(124, 101);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(52, 17);
            this.label25.TabIndex = 6;
            this.label25.Text = "Código";
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
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnInserirProdutosCSV;
        private System.Windows.Forms.Button btnInfoProduto;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textArquivoProduto;
        private System.Windows.Forms.Button btnInserirProdutoUnico;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textEstoqueProduto;
        private System.Windows.Forms.TextBox textPesoProduto;
        private System.Windows.Forms.TextBox textNomeProduto;
        private System.Windows.Forms.TextBox textIdProduto;
    }
}
