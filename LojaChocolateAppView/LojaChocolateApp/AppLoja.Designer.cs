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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppLoja));
            this.panelMenuLateral = new System.Windows.Forms.Panel();
            this.panelSubMenuVendas = new System.Windows.Forms.Panel();
            this.btnConsultarVendas = new System.Windows.Forms.Button();
            this.btnCadastrarVendas = new System.Windows.Forms.Button();
            this.btnVendas = new FontAwesome.Sharp.IconButton();
            this.panelSubMenuProdutos = new System.Windows.Forms.Panel();
            this.btnConsultarProdutos = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnInserirProduto = new System.Windows.Forms.Button();
            this.btnProdutos = new FontAwesome.Sharp.IconButton();
            this.panelSubMenuFuncionario = new System.Windows.Forms.Panel();
            this.btnConsultarFuncionarios = new System.Windows.Forms.Button();
            this.btnExcluirFuncionario = new System.Windows.Forms.Button();
            this.btnCadastrarFuncionario = new System.Windows.Forms.Button();
            this.btnFuncionarios = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.LogoMenu = new System.Windows.Forms.PictureBox();
            this.panelLoadPanels = new System.Windows.Forms.Panel();
            this.panelLogoPrincipal = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridVendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelMenuLateral.SuspendLayout();
            this.panelSubMenuVendas.SuspendLayout();
            this.panelSubMenuProdutos.SuspendLayout();
            this.panelSubMenuFuncionario.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoMenu)).BeginInit();
            this.panelLoadPanels.SuspendLayout();
            this.panelLogoPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVendasBindingSource)).BeginInit();
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
            this.panelMenuLateral.Controls.Add(this.panel1);
            this.panelMenuLateral.Controls.Add(this.panelLogo);
            this.panelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.panelMenuLateral.Name = "panelMenuLateral";
            this.panelMenuLateral.Size = new System.Drawing.Size(248, 561);
            this.panelMenuLateral.TabIndex = 1;
            // 
            // panelSubMenuVendas
            // 
            this.panelSubMenuVendas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(167)))), ((int)(((byte)(101)))));
            this.panelSubMenuVendas.Controls.Add(this.btnConsultarVendas);
            this.panelSubMenuVendas.Controls.Add(this.btnCadastrarVendas);
            this.panelSubMenuVendas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuVendas.Location = new System.Drawing.Point(0, 472);
            this.panelSubMenuVendas.Name = "panelSubMenuVendas";
            this.panelSubMenuVendas.Size = new System.Drawing.Size(248, 70);
            this.panelSubMenuVendas.TabIndex = 15;
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
            this.btnConsultarVendas.Size = new System.Drawing.Size(248, 35);
            this.btnConsultarVendas.TabIndex = 48;
            this.btnConsultarVendas.Text = "Consultar";
            this.btnConsultarVendas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarVendas.UseVisualStyleBackColor = true;
            this.btnConsultarVendas.Click += new System.EventHandler(this.btnConsultarVendas_Click);
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
            this.btnCadastrarVendas.Size = new System.Drawing.Size(248, 35);
            this.btnCadastrarVendas.TabIndex = 47;
            this.btnCadastrarVendas.Text = "Cadastrar";
            this.btnCadastrarVendas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarVendas.UseVisualStyleBackColor = true;
            this.btnCadastrarVendas.Click += new System.EventHandler(this.btnCadastrarVendas_Click);
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
            this.btnVendas.Location = new System.Drawing.Point(0, 427);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnVendas.Size = new System.Drawing.Size(248, 45);
            this.btnVendas.TabIndex = 0;
            this.btnVendas.Text = "   Vendas";
            this.btnVendas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVendas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVendas.UseVisualStyleBackColor = false;
            this.btnVendas.Click += new System.EventHandler(this.btnVendas_Click);
            // 
            // panelSubMenuProdutos
            // 
            this.panelSubMenuProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(167)))), ((int)(((byte)(101)))));
            this.panelSubMenuProdutos.Controls.Add(this.btnConsultarProdutos);
            this.panelSubMenuProdutos.Controls.Add(this.btnEstoque);
            this.panelSubMenuProdutos.Controls.Add(this.btnInserirProduto);
            this.panelSubMenuProdutos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuProdutos.Location = new System.Drawing.Point(0, 322);
            this.panelSubMenuProdutos.Name = "panelSubMenuProdutos";
            this.panelSubMenuProdutos.Size = new System.Drawing.Size(248, 105);
            this.panelSubMenuProdutos.TabIndex = 13;
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
            this.btnConsultarProdutos.Size = new System.Drawing.Size(248, 35);
            this.btnConsultarProdutos.TabIndex = 3;
            this.btnConsultarProdutos.Text = "Consultar";
            this.btnConsultarProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarProdutos.UseVisualStyleBackColor = true;
            this.btnConsultarProdutos.Click += new System.EventHandler(this.btnConsultarProdutos_Click);
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
            this.btnEstoque.Size = new System.Drawing.Size(248, 35);
            this.btnEstoque.TabIndex = 2;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstoque.UseVisualStyleBackColor = true;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
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
            this.btnInserirProduto.Size = new System.Drawing.Size(248, 35);
            this.btnInserirProduto.TabIndex = 1;
            this.btnInserirProduto.Text = "Inserir";
            this.btnInserirProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInserirProduto.UseVisualStyleBackColor = true;
            this.btnInserirProduto.Click += new System.EventHandler(this.btnInserirProduto_Click);
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
            this.btnProdutos.Location = new System.Drawing.Point(0, 277);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnProdutos.Size = new System.Drawing.Size(248, 45);
            this.btnProdutos.TabIndex = 0;
            this.btnProdutos.Text = "  Produtos";
            this.btnProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProdutos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProdutos.UseVisualStyleBackColor = true;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // panelSubMenuFuncionario
            // 
            this.panelSubMenuFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(167)))), ((int)(((byte)(101)))));
            this.panelSubMenuFuncionario.Controls.Add(this.btnConsultarFuncionarios);
            this.panelSubMenuFuncionario.Controls.Add(this.btnExcluirFuncionario);
            this.panelSubMenuFuncionario.Controls.Add(this.btnCadastrarFuncionario);
            this.panelSubMenuFuncionario.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuFuncionario.Location = new System.Drawing.Point(0, 168);
            this.panelSubMenuFuncionario.Name = "panelSubMenuFuncionario";
            this.panelSubMenuFuncionario.Size = new System.Drawing.Size(248, 109);
            this.panelSubMenuFuncionario.TabIndex = 11;
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
            this.btnConsultarFuncionarios.Size = new System.Drawing.Size(248, 35);
            this.btnConsultarFuncionarios.TabIndex = 3;
            this.btnConsultarFuncionarios.Text = "Consultar";
            this.btnConsultarFuncionarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarFuncionarios.UseVisualStyleBackColor = true;
            this.btnConsultarFuncionarios.Click += new System.EventHandler(this.btnConsultarFuncionarios_Click);
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
            this.btnExcluirFuncionario.Size = new System.Drawing.Size(248, 35);
            this.btnExcluirFuncionario.TabIndex = 2;
            this.btnExcluirFuncionario.Text = "Alterar Cadastro";
            this.btnExcluirFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirFuncionario.UseVisualStyleBackColor = true;
            this.btnExcluirFuncionario.Click += new System.EventHandler(this.btnExcluirFuncionario_Click);
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
            this.btnCadastrarFuncionario.Size = new System.Drawing.Size(248, 35);
            this.btnCadastrarFuncionario.TabIndex = 1;
            this.btnCadastrarFuncionario.Text = "Cadastrar";
            this.btnCadastrarFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarFuncionario.UseVisualStyleBackColor = true;
            this.btnCadastrarFuncionario.Click += new System.EventHandler(this.btnCadastrarFuncionario_Click);
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
            this.btnFuncionarios.Location = new System.Drawing.Point(0, 123);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnFuncionarios.Size = new System.Drawing.Size(248, 45);
            this.btnFuncionarios.TabIndex = 0;
            this.btnFuncionarios.Text = "  Funcionários";
            this.btnFuncionarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFuncionarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFuncionarios.UseVisualStyleBackColor = false;
            this.btnFuncionarios.Click += new System.EventHandler(this.btnFuncionarios_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(247, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 561);
            this.panel1.TabIndex = 1;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.panelLogo.Controls.Add(this.LogoMenu);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Padding = new System.Windows.Forms.Padding(20);
            this.panelLogo.Size = new System.Drawing.Size(248, 123);
            this.panelLogo.TabIndex = 0;
            // 
            // LogoMenu
            // 
            this.LogoMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogoMenu.Image = global::LojaChocolateApp.Properties.Resources.LojaDeChocolateLogoBranco;
            this.LogoMenu.Location = new System.Drawing.Point(20, 20);
            this.LogoMenu.Name = "LogoMenu";
            this.LogoMenu.Size = new System.Drawing.Size(208, 83);
            this.LogoMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoMenu.TabIndex = 1;
            this.LogoMenu.TabStop = false;
            this.LogoMenu.Click += new System.EventHandler(this.LogoMenu_Click);
            // 
            // panelLoadPanels
            // 
            this.panelLoadPanels.Controls.Add(this.panelLogoPrincipal);
            this.panelLoadPanels.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelLoadPanels.Location = new System.Drawing.Point(247, 0);
            this.panelLoadPanels.Name = "panelLoadPanels";
            this.panelLoadPanels.Size = new System.Drawing.Size(717, 561);
            this.panelLoadPanels.TabIndex = 34;
            // 
            // panelLogoPrincipal
            // 
            this.panelLogoPrincipal.BackColor = System.Drawing.Color.White;
            this.panelLogoPrincipal.Controls.Add(this.pictureBox2);
            this.panelLogoPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogoPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelLogoPrincipal.Name = "panelLogoPrincipal";
            this.panelLogoPrincipal.Size = new System.Drawing.Size(717, 561);
            this.panelLogoPrincipal.TabIndex = 35;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LojaChocolateApp.Properties.Resources.LojaDeChocolateLogoCor;
            this.pictureBox2.Location = new System.Drawing.Point(108, 150);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(500, 250);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // dataGridVendasBindingSource
            // 
            this.dataGridVendasBindingSource.DataSource = typeof(LojaChocolateApp.Utils.DataGridVendas);
            // 
            // AppLoja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(964, 561);
            this.Controls.Add(this.panelMenuLateral);
            this.Controls.Add(this.panelLoadPanels);
            this.Font = new System.Drawing.Font("Lato", 9.749999F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximumSize = new System.Drawing.Size(980, 600);
            this.MinimumSize = new System.Drawing.Size(980, 600);
            this.Name = "AppLoja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loja de Chocolate";
            this.Load += new System.EventHandler(this.AppLoja_Load);
            this.panelMenuLateral.ResumeLayout(false);
            this.panelSubMenuVendas.ResumeLayout(false);
            this.panelSubMenuProdutos.ResumeLayout(false);
            this.panelSubMenuFuncionario.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoMenu)).EndInit();
            this.panelLoadPanels.ResumeLayout(false);
            this.panelLogoPrincipal.ResumeLayout(false);
            this.panelLogoPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVendasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuLateral;
        private System.Windows.Forms.Panel panelSubMenuVendas;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox LogoMenu;
        private System.Windows.Forms.Button btnConsultarVendas;
        private System.Windows.Forms.Button btnCadastrarVendas;
        private System.Windows.Forms.BindingSource dataGridVendasBindingSource;
        private System.Windows.Forms.Panel panelLoadPanels;
        private System.Windows.Forms.Panel panelLogoPrincipal;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

