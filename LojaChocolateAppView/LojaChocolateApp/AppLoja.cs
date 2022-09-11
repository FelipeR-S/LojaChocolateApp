using LojaChocolateApp.Properties;
using LojaChocolateApp.Repository;
using LojaChocolateApp.Utils;
using LojaChocolateApp.Utils.Panels;
using LojaChocolateApp.Utils.Popups;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace LojaChocolateApp
{
    public partial class AppLoja : Form
    {
        private static TextBoxControls _controle = new TextBoxControls();
        private bool _darkMode;
        private bool _controleEstoque;
        private int _quantidadeEstoque;
        private bool _sair;
        private string _usuario;
        private string _database;
        private string _cargo;

        public AppLoja()
        {
            _sair = false;
            InitializeComponent();
            SubMenuDesign();
            GetConfigs();
        }
        public AppLoja(string usuario, string database, string cargo)
        {
            _sair = false;
            _usuario = usuario;
            _database = database;
            _cargo = cargo;
            InitializeComponent();
            SubMenuDesign();
        }
        private void AppLoja_ClientSizeChanged(object sender, EventArgs e)
        {
            try
            {
                panelLoadPanels.Update();
                if (WindowState == FormWindowState.Maximized)
                {
                    _controle.AumentaTxT(this);
                    var maxWidth = panelLogin.Width;
                    var centerWidth = panelLogin.Width / 2;
                    labelServer.Location = new Point(maxWidth - 202, 0);
                    txtServidor.Location = new Point(maxWidth - 140, 0);
                    labelCargo.Location = new Point(centerWidth - 45, 0);
                    txtCargo.Location = new Point(centerWidth, 0);
                    panelLoadPanels.Padding = new Padding(200, 100, 200, 0);
                }
                else
                {
                    _controle.DiminuiTxT(this);
                    labelServer.Location = new Point(497, 0);
                    txtServidor.Location = new Point(559, 0);
                    labelCargo.Location = new Point(305, 0);
                    txtCargo.Location = new Point(350, 0);
                    panelLoadPanels.Padding = new Padding(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Abre form de configurações
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            try
            {
                PopupConfig config = new PopupConfig(_usuario);
                config.ShowDialog();
                GetConfigs();
                DarkMode();
                if (_controleEstoque == true)
                {
                    ControleEstoque controle = new ControleEstoque(_controleEstoque, _quantidadeEstoque);
                    controle.GetControleEstoque();
                }
                panelLoadPanels.Controls.Clear();
                panelLoadPanels.Controls.Add(panelLogoPrincipal);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Ativa ou desativa o modo Dark
        /// </summary>
        /// <param name="control"></param>
        private void DarkMode()
        {
            try
            {
                if (_darkMode == true)
                {
                    panelLoadPanels.BackColor = Color.FromArgb(30, 30, 30);
                    pictureBoxLogo.Image = Resources.LojaDeChocolateLogoBranco;
                }
                if (_darkMode == false)
                {
                    panelLoadPanels.BackColor = Color.White;
                    pictureBoxLogo.Image = Resources.LojaDeChocolateLogoCor;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Recebe da Databese as configurações
        /// </summary>
        private void GetConfigs()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SQLServerConn.StrCon))
                {
                    connection.Open();
                    var sqlQuery = $"use [Loja_Chocolate] select [DarkMode], [Aviso Estoque], [Limite Estoque] from [Configurações] where [User] = '{_usuario}'";
                    SqlCommand cmd = new SqlCommand(sqlQuery, connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        _darkMode = reader.GetBoolean(0);
                        _controleEstoque = reader.GetBoolean(1);
                        if (_controleEstoque == true)
                            _quantidadeEstoque = Convert.ToInt32(reader.GetValue(2));
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //LOGIN
        private void AppLoja_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_sair == false)
                Application.Exit();
        }
        private void AppLoja_Load(object sender, EventArgs e)
        {
            try
            {
                txtServidor.Text = _database;
                if (_usuario.ToLower() == "sa")
                {
                    txtUser.Text = "Administrador";
                    txtCargo.Text = "";
                    labelCargo.Text = "";
                    btnProdutos.Visible = false;
                    btnVendas.Visible = false;
                    btnExcluirFuncionario.Visible = false;
                    btnConsultarFuncionarios.Visible = false;
                    panelSubMenuFuncionario.Height = 70;
                    btnConfigurar.Visible = false;
                }
                else
                {
                    txtUser.Text = _usuario;
                    txtCargo.Text = _cargo;
                    if (_cargo != "Gerente")
                    {
                        btnFuncionarios.Visible = false;
                    }
                    GetConfigs();
                    DarkMode();
                    ControleEstoque controle = new ControleEstoque(_controleEstoque, _quantidadeEstoque);
                    controle.GetControleEstoque();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            _sair = true;
            LoginLoja logon = new LoginLoja();
            logon.Show();
            this.Close();
        }
        // INICIO ------------------------------ VISIBILIDADE DE ELEMENTOS ------------------------------ INICIO //
        /// <summary>
        /// Esconde um submenu quando outro estiver vísivel
        /// </summary>
        private void EsconderSubMenu()
        {
            if (panelSubMenuFuncionario.Visible == true)
                panelSubMenuFuncionario.Visible = false;
            if (panelSubMenuProdutos.Visible == true)
                panelSubMenuProdutos.Visible = false;
            if (panelSubMenuVendas.Visible == true)
                panelSubMenuVendas.Visible = false;
        }
        /// <summary>
        /// Mostra um submenu ao ser invocado ou esconde caso já esteja vísivel
        /// </summary>
        /// <param name="subMenu">Objeto do tipo <see cref="Panel"/> que refere a um submenu invocado por botão de menu</param>
        private void MostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                EsconderSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        /// <summary>
        /// Deixa submenu não vísivel ao iniciar a aplicação
        /// </summary>
        private void SubMenuDesign()
        {
            panelSubMenuFuncionario.Visible = false;
            panelSubMenuProdutos.Visible = false;
            panelSubMenuVendas.Visible = false;
        }
        private void LogoMenu_Click(object sender, EventArgs e)
        {
            panelLoadPanels.Controls.Clear();
            panelLoadPanels.Controls.Add(panelLogoPrincipal);
            EsconderSubMenu();
        }
        // FIM ------------------------------ VISIBILIDADE DE ELEMENTOS ------------------------------ FIM //
        // INICIO ------------------------------------ SUBMENU FUNCIONARIO ------------------------------------ INICIO //
        /// <summary>
        /// Botão menu Funcionarios que invoca submenu de funcionarios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSubMenuFuncionario);
        }
        /// <summary>
        /// Botão de submenu CADASTRAR do MENU FUNCIONARIO que invoca painel de CADASTRAR
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            var panel = new CadastrarFuncionario(_darkMode);
            panel.Dock = DockStyle.Fill;
            panelLoadPanels.Controls.Clear();
            panelLoadPanels.Controls.Add(panel);
            EsconderSubMenu();
            if (WindowState == FormWindowState.Maximized)
                _controle.AumentaTxT(this);
        }
        /// <summary>
        /// Botão de submenu REMOVER do MENU FUNCIONARIO que invoca painel de REMOVER
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExcluirFuncionario_Click(object sender, EventArgs e)
        {
            var panel = new AlteraFuncionario(_darkMode);
            panel.Dock = DockStyle.Fill;
            panelLoadPanels.Controls.Clear();
            panelLoadPanels.Controls.Add(panel);
            EsconderSubMenu();
            if (WindowState == FormWindowState.Maximized)
                _controle.AumentaTxT(this);
        }
        /// <summary>
        /// Botão de submenu CONSULTAR do MENU FUNCIONARIO que invoca painel de CONSULTAR
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConsultarFuncionarios_Click(object sender, EventArgs e)
        {
            var panel = new ConsultaFuncionarios(_darkMode);
            panel.Dock = DockStyle.Fill;
            panelLoadPanels.Controls.Clear();
            panelLoadPanels.Controls.Add(panel);
            EsconderSubMenu();
            if (WindowState == FormWindowState.Maximized)
                _controle.AumentaTxT(this);
        }
        /// <summary>
        /// Acessa Sistema de autorização de cadastro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnControleDeAcesso_Click(object sender, EventArgs e)
        {
            var panel = new ControleDeAcesso(_darkMode);
            panel.Dock = DockStyle.Fill;
            panelLoadPanels.Controls.Clear();
            panelLoadPanels.Controls.Add(panel);
            EsconderSubMenu();
            if (WindowState == FormWindowState.Maximized)
                _controle.AumentaTxT(this);
        }
        // FIM ------------------------------------ SUBMENU FUNCIONARIO ------------------------------------ FIM //
        // INICIO ------------------------------------ SUBMENU PRODUTOS ------------------------------------ INICIO //
        /// <summary>
        /// Botão de menu produtos que invoca submenu de produtos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProdutos_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSubMenuProdutos);
        }
        /// <summary>
        /// Botão do submenu INSERIR do MENU PRODUTOS que invoca painel de INSERIR
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInserirProduto_Click(object sender, EventArgs e)
        {
            var panel = new InserirProdutos(_darkMode);
            panel.Dock = DockStyle.Fill;
            panelLoadPanels.Controls.Clear();
            panelLoadPanels.Controls.Add(panel);
            EsconderSubMenu();
            if (WindowState == FormWindowState.Maximized)
                _controle.AumentaTxT(this);
        }
        /// <summary>
        /// Botão do submenu ESTOQUE do MENU PRODUTOS que invoca painel de ESTOQUE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEstoque_Click(object sender, EventArgs e)
        {
            var panel = new AlteraProdutos(_darkMode, _controleEstoque, _quantidadeEstoque);
            panel.Dock = DockStyle.Fill;
            panelLoadPanels.Controls.Clear();
            panelLoadPanels.Controls.Add(panel);
            EsconderSubMenu();
            if (WindowState == FormWindowState.Maximized)
                _controle.AumentaTxT(this);
        }
        /// <summary>
        /// Botão do submenu CONSULTA do MENU PRODUTOS que invoca painel de CONSULTA
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConsultarProdutos_Click(object sender, EventArgs e)
        {
            var panel = new ConsultaProdutos(_darkMode);
            panel.Dock = DockStyle.Fill;
            panelLoadPanels.Controls.Clear();
            panelLoadPanels.Controls.Add(panel);
            EsconderSubMenu();
            if (WindowState == FormWindowState.Maximized)
                _controle.AumentaTxT(this);
        }
        // FIM ------------------------------------ SUBMENU PRODUTOS ------------------------------------ FIM //
        // INICIO ------------------------------------ SUBMENU VENDAS ------------------------------------ INICIO //
        /// <summary>
        /// Botão menu Vendas que invoca submenu de vendas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVendas_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSubMenuVendas);
        }
        /// <summary>
        /// Botão do submenu INSERIR do MENU VENDAS que invoca painel de INSERIR
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCadastrarVendas_Click(object sender, EventArgs e)
        {
            var panel = new CadastrarVenda(_darkMode, _controleEstoque, _quantidadeEstoque);
            panel.Dock = DockStyle.Fill;
            panelLoadPanels.Controls.Clear();
            panelLoadPanels.Controls.Add(panel);
            EsconderSubMenu();
            if (WindowState == FormWindowState.Maximized)
                _controle.AumentaTxT(this);
        }
        /// <summary>
        /// Botão do submenu CONSULTAR do MENU VENDAS que invoca painel Lista de Vendas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConsultarVendas_Click(object sender, EventArgs e)
        {
            var panel = new ConsultaVendas(_darkMode);
            panel.Dock = DockStyle.Fill;
            panelLoadPanels.Controls.Clear();
            panelLoadPanels.Controls.Add(panel);
            panel.dataGridViewVendas.Rows.Clear();
            EsconderSubMenu();
            if (WindowState == FormWindowState.Maximized)
                _controle.AumentaTxT(this);
        }
        // FIM ------------------------------------ SUBMENU VENDAS ------------------------------------ FIM //
    }
}
