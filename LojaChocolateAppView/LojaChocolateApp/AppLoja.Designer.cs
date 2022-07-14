namespace LojaChocolateApp
{
    partial class AppLoja
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppLoja));
            this.panelMenuLateral = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFuncionarios = new FontAwesome.Sharp.IconButton();
            this.panelSubMenuFuncionario = new System.Windows.Forms.Panel();
            this.btnCadastrarFuncionario = new System.Windows.Forms.Button();
            this.btnExcluirFuncionario = new System.Windows.Forms.Button();
            this.btnConsultarFuncionarios = new System.Windows.Forms.Button();
            this.btnProdutos = new FontAwesome.Sharp.IconButton();
            this.panelSubMenuProdutos = new System.Windows.Forms.Panel();
            this.btnInserirProduto = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnConsultarProdutos = new System.Windows.Forms.Button();
            this.btnVendas = new FontAwesome.Sharp.IconButton();
            this.panelSubMenuVendas = new System.Windows.Forms.Panel();
            this.btnCadastrarVendas = new System.Windows.Forms.Button();
            this.btnConsultarVendas = new System.Windows.Forms.Button();
            this.panelMenuLateral.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelSubMenuFuncionario.SuspendLayout();
            this.panelSubMenuProdutos.SuspendLayout();
            this.panelSubMenuVendas.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenuLateral
            // 
            this.panelMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.panelMenuLateral.Controls.Add(this.panelSubMenuVendas);
            this.panelMenuLateral.Controls.Add(this.btnVendas);
            this.panelMenuLateral.Controls.Add(this.panelSubMenuProdutos);
            this.panelMenuLateral.Controls.Add(this.btnProdutos);
            this.panelMenuLateral.Controls.Add(this.panelSubMenuFuncionario);
            this.panelMenuLateral.Controls.Add(this.btnFuncionarios);
            this.panelMenuLateral.Controls.Add(this.panelLogo);
            this.panelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.panelMenuLateral.Name = "panelMenuLateral";
            this.panelMenuLateral.Size = new System.Drawing.Size(250, 561);
            this.panelMenuLateral.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 125);
            this.panelLogo.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.btnFuncionarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFuncionarios.FlatAppearance.BorderSize = 0;
            this.btnFuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionarios.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionarios.ForeColor = System.Drawing.SystemColors.Window;
            this.btnFuncionarios.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnFuncionarios.IconColor = System.Drawing.Color.White;
            this.btnFuncionarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFuncionarios.IconSize = 25;
            this.btnFuncionarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFuncionarios.Location = new System.Drawing.Point(0, 125);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnFuncionarios.Size = new System.Drawing.Size(250, 45);
            this.btnFuncionarios.TabIndex = 23;
            this.btnFuncionarios.Text = "  Funcionários";
            this.btnFuncionarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFuncionarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFuncionarios.UseVisualStyleBackColor = false;
            this.btnFuncionarios.Click += new System.EventHandler(this.btnFuncionarios_Click);
            // 
            // panelSubMenuFuncionario
            // 
            this.panelSubMenuFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(167)))), ((int)(((byte)(101)))));
            this.panelSubMenuFuncionario.Controls.Add(this.btnConsultarFuncionarios);
            this.panelSubMenuFuncionario.Controls.Add(this.btnExcluirFuncionario);
            this.panelSubMenuFuncionario.Controls.Add(this.btnCadastrarFuncionario);
            this.panelSubMenuFuncionario.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuFuncionario.Location = new System.Drawing.Point(0, 170);
            this.panelSubMenuFuncionario.Name = "panelSubMenuFuncionario";
            this.panelSubMenuFuncionario.Size = new System.Drawing.Size(250, 109);
            this.panelSubMenuFuncionario.TabIndex = 28;
            // 
            // btnCadastrarFuncionario
            // 
            this.btnCadastrarFuncionario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastrarFuncionario.FlatAppearance.BorderSize = 0;
            this.btnCadastrarFuncionario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(139)))), ((int)(((byte)(60)))));
            this.btnCadastrarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarFuncionario.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarFuncionario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCadastrarFuncionario.Location = new System.Drawing.Point(0, 0);
            this.btnCadastrarFuncionario.Name = "btnCadastrarFuncionario";
            this.btnCadastrarFuncionario.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnCadastrarFuncionario.Size = new System.Drawing.Size(250, 35);
            this.btnCadastrarFuncionario.TabIndex = 19;
            this.btnCadastrarFuncionario.Text = "Cadastrar";
            this.btnCadastrarFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarFuncionario.UseVisualStyleBackColor = true;
            this.btnCadastrarFuncionario.Click += new System.EventHandler(this.btnCadastrarFuncionario_Click);
            // 
            // btnExcluirFuncionario
            // 
            this.btnExcluirFuncionario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExcluirFuncionario.FlatAppearance.BorderSize = 0;
            this.btnExcluirFuncionario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(139)))), ((int)(((byte)(60)))));
            this.btnExcluirFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirFuncionario.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirFuncionario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExcluirFuncionario.Location = new System.Drawing.Point(0, 35);
            this.btnExcluirFuncionario.Name = "btnExcluirFuncionario";
            this.btnExcluirFuncionario.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnExcluirFuncionario.Size = new System.Drawing.Size(250, 35);
            this.btnExcluirFuncionario.TabIndex = 21;
            this.btnExcluirFuncionario.Text = "Alterar Cadastro";
            this.btnExcluirFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirFuncionario.UseVisualStyleBackColor = true;
            this.btnExcluirFuncionario.Click += new System.EventHandler(this.btnExcluirFuncionario_Click);
            // 
            // btnConsultarFuncionarios
            // 
            this.btnConsultarFuncionarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultarFuncionarios.FlatAppearance.BorderSize = 0;
            this.btnConsultarFuncionarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(139)))), ((int)(((byte)(60)))));
            this.btnConsultarFuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarFuncionarios.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarFuncionarios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConsultarFuncionarios.Location = new System.Drawing.Point(0, 70);
            this.btnConsultarFuncionarios.Name = "btnConsultarFuncionarios";
            this.btnConsultarFuncionarios.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnConsultarFuncionarios.Size = new System.Drawing.Size(250, 35);
            this.btnConsultarFuncionarios.TabIndex = 25;
            this.btnConsultarFuncionarios.Text = "Consultar";
            this.btnConsultarFuncionarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarFuncionarios.UseVisualStyleBackColor = true;
            this.btnConsultarFuncionarios.Click += new System.EventHandler(this.btnConsultarFuncionarios_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProdutos.FlatAppearance.BorderSize = 0;
            this.btnProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdutos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdutos.ForeColor = System.Drawing.SystemColors.Window;
            this.btnProdutos.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.btnProdutos.IconColor = System.Drawing.Color.White;
            this.btnProdutos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProdutos.IconSize = 25;
            this.btnProdutos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProdutos.Location = new System.Drawing.Point(0, 279);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnProdutos.Size = new System.Drawing.Size(250, 45);
            this.btnProdutos.TabIndex = 29;
            this.btnProdutos.Text = "  Produtos";
            this.btnProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProdutos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProdutos.UseVisualStyleBackColor = true;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // panelSubMenuProdutos
            // 
            this.panelSubMenuProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(167)))), ((int)(((byte)(101)))));
            this.panelSubMenuProdutos.Controls.Add(this.btnConsultarProdutos);
            this.panelSubMenuProdutos.Controls.Add(this.btnEstoque);
            this.panelSubMenuProdutos.Controls.Add(this.btnInserirProduto);
            this.panelSubMenuProdutos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuProdutos.Location = new System.Drawing.Point(0, 324);
            this.panelSubMenuProdutos.Name = "panelSubMenuProdutos";
            this.panelSubMenuProdutos.Size = new System.Drawing.Size(250, 105);
            this.panelSubMenuProdutos.TabIndex = 30;
            // 
            // btnInserirProduto
            // 
            this.btnInserirProduto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInserirProduto.FlatAppearance.BorderSize = 0;
            this.btnInserirProduto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(139)))), ((int)(((byte)(60)))));
            this.btnInserirProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserirProduto.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirProduto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInserirProduto.Location = new System.Drawing.Point(0, 0);
            this.btnInserirProduto.Name = "btnInserirProduto";
            this.btnInserirProduto.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnInserirProduto.Size = new System.Drawing.Size(250, 35);
            this.btnInserirProduto.TabIndex = 18;
            this.btnInserirProduto.Text = "Inserir";
            this.btnInserirProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInserirProduto.UseVisualStyleBackColor = true;
            this.btnInserirProduto.Click += new System.EventHandler(this.btnInserirProduto_Click);
            // 
            // btnEstoque
            // 
            this.btnEstoque.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEstoque.FlatAppearance.BorderSize = 0;
            this.btnEstoque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(139)))), ((int)(((byte)(60)))));
            this.btnEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstoque.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoque.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEstoque.Location = new System.Drawing.Point(0, 35);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnEstoque.Size = new System.Drawing.Size(250, 35);
            this.btnEstoque.TabIndex = 20;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstoque.UseVisualStyleBackColor = true;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // btnConsultarProdutos
            // 
            this.btnConsultarProdutos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultarProdutos.FlatAppearance.BorderSize = 0;
            this.btnConsultarProdutos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(139)))), ((int)(((byte)(60)))));
            this.btnConsultarProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarProdutos.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarProdutos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConsultarProdutos.Location = new System.Drawing.Point(0, 70);
            this.btnConsultarProdutos.Name = "btnConsultarProdutos";
            this.btnConsultarProdutos.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnConsultarProdutos.Size = new System.Drawing.Size(250, 35);
            this.btnConsultarProdutos.TabIndex = 24;
            this.btnConsultarProdutos.Text = "Consultar";
            this.btnConsultarProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarProdutos.UseVisualStyleBackColor = true;
            this.btnConsultarProdutos.Click += new System.EventHandler(this.btnConsultarProdutos_Click);
            // 
            // btnVendas
            // 
            this.btnVendas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.btnVendas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVendas.FlatAppearance.BorderSize = 0;
            this.btnVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendas.ForeColor = System.Drawing.SystemColors.Window;
            this.btnVendas.IconChar = FontAwesome.Sharp.IconChar.BasketShopping;
            this.btnVendas.IconColor = System.Drawing.Color.White;
            this.btnVendas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVendas.IconSize = 25;
            this.btnVendas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVendas.Location = new System.Drawing.Point(0, 429);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnVendas.Size = new System.Drawing.Size(250, 45);
            this.btnVendas.TabIndex = 31;
            this.btnVendas.Text = "   Vendas";
            this.btnVendas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVendas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVendas.UseVisualStyleBackColor = false;
            this.btnVendas.Click += new System.EventHandler(this.btnVendas_Click);
            // 
            // panelSubMenuVendas
            // 
            this.panelSubMenuVendas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(167)))), ((int)(((byte)(101)))));
            this.panelSubMenuVendas.Controls.Add(this.btnConsultarVendas);
            this.panelSubMenuVendas.Controls.Add(this.btnCadastrarVendas);
            this.panelSubMenuVendas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuVendas.Location = new System.Drawing.Point(0, 474);
            this.panelSubMenuVendas.Name = "panelSubMenuVendas";
            this.panelSubMenuVendas.Size = new System.Drawing.Size(250, 70);
            this.panelSubMenuVendas.TabIndex = 32;
            // 
            // btnCadastrarVendas
            // 
            this.btnCadastrarVendas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastrarVendas.FlatAppearance.BorderSize = 0;
            this.btnCadastrarVendas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(139)))), ((int)(((byte)(60)))));
            this.btnCadastrarVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarVendas.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarVendas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCadastrarVendas.Location = new System.Drawing.Point(0, 0);
            this.btnCadastrarVendas.Name = "btnCadastrarVendas";
            this.btnCadastrarVendas.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnCadastrarVendas.Size = new System.Drawing.Size(250, 35);
            this.btnCadastrarVendas.TabIndex = 17;
            this.btnCadastrarVendas.Text = "Cadastrar";
            this.btnCadastrarVendas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarVendas.UseVisualStyleBackColor = true;
            this.btnCadastrarVendas.Click += new System.EventHandler(this.btnCadastrarVendas_Click);
            // 
            // btnConsultarVendas
            // 
            this.btnConsultarVendas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultarVendas.FlatAppearance.BorderSize = 0;
            this.btnConsultarVendas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(139)))), ((int)(((byte)(60)))));
            this.btnConsultarVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarVendas.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarVendas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConsultarVendas.Location = new System.Drawing.Point(0, 35);
            this.btnConsultarVendas.Name = "btnConsultarVendas";
            this.btnConsultarVendas.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnConsultarVendas.Size = new System.Drawing.Size(250, 35);
            this.btnConsultarVendas.TabIndex = 22;
            this.btnConsultarVendas.Text = "Consultar";
            this.btnConsultarVendas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarVendas.UseVisualStyleBackColor = true;
            this.btnConsultarVendas.Click += new System.EventHandler(this.btnConsultarVendas_Click);
            // 
            // AppLoja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 561);
            this.Controls.Add(this.panelMenuLateral);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(980, 600);
            this.Name = "AppLoja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loja de Chocolate";
            this.panelMenuLateral.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelSubMenuFuncionario.ResumeLayout(false);
            this.panelSubMenuProdutos.ResumeLayout(false);
            this.panelSubMenuVendas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuLateral;
        private System.Windows.Forms.Panel panelSubMenuVendas;
        private System.Windows.Forms.Button btnConsultarVendas;
        private System.Windows.Forms.Button btnCadastrarVendas;
        private FontAwesome.Sharp.IconButton btnVendas;
        private System.Windows.Forms.Panel panelSubMenuProdutos;
        private System.Windows.Forms.Button btnConsultarProdutos;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnInserirProduto;
        private FontAwesome.Sharp.IconButton btnProdutos;
        private System.Windows.Forms.Panel panelSubMenuFuncionario;
        private System.Windows.Forms.Button btnConsultarFuncionarios;
        private System.Windows.Forms.Button btnExcluirFuncionario;
        private System.Windows.Forms.Button btnCadastrarFuncionario;
        private FontAwesome.Sharp.IconButton btnFuncionarios;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

