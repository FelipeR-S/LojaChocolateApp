using LojaChocolateApp.Model;
using LojaChocolateApp.Properties;
using LojaChocolateApp.Repository;
using LojaChocolateApp.Utils;
using LojaChocolateApp.Utils.LayoutItems;
using LojaChocolateApp.Utils.Panels;
using LojaChocolateApp.Utils.Popups;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaChocolateApp
{
    public partial class AppLoja : Form
    {
        /// <summary>
        /// Atributo para controles de TextBox
        /// </summary>
        private TextBoxControls _controle = new TextBoxControls();
        public AppLoja()
        {
            InitializeComponent();
            SubMenuDesign();
        }
        //LOGIN
        private void AppLoja_Load(object sender, EventArgs e)
        {
            try
            {
                this.Hide();

                LoginLoja logon = new LoginLoja();

                if (logon.ShowDialog() != DialogResult.OK)
                {
                    Application.Exit();
                }
                else
                {
                    if (logon.Usuario.ToLower() == "sa")
                    {
                        txtUser.Text = "Administrador";
                        txtCargo.Text = "";
                        labelCargo.Text = "";
                    }
                    else
                    {
                        txtUser.Text = logon.Usuario;
                        //btnControleDeAcesso.Visible = false;
                        //panelSubMenuFuncionario.Height = 105;
                    }
                    txtServidor.Text = logon.Database;
                    this.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            panelLoadPanels.Visible = true;
            var panel = new CadastrarFuncionario();
            panelLoadPanels.Controls.Clear();
            panelLoadPanels.Controls.Add(panel);
            EsconderSubMenu();
        }
        /// <summary>
        /// Botão de submenu REMOVER do MENU FUNCIONARIO que invoca painel de REMOVER
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExcluirFuncionario_Click(object sender, EventArgs e)
        {
            panelLoadPanels.Visible = true;
            var panel = new AlteraFuncionario();
            panelLoadPanels.Controls.Clear();
            panelLoadPanels.Controls.Add(panel);
            EsconderSubMenu();
        }
        /// <summary>
        /// Botão de submenu CONSULTAR do MENU FUNCIONARIO que invoca painel de CONSULTAR
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConsultarFuncionarios_Click(object sender, EventArgs e)
        {
            panelLoadPanels.Visible = true;
            var panel = new ConsultaFuncionarios();
            panelLoadPanels.Controls.Clear();
            panelLoadPanels.Controls.Add(panel);
            EsconderSubMenu();
        }
        /// <summary>
        /// Acessa Sistema de autorização de cadastro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnControleDeAcesso_Click(object sender, EventArgs e)
        {
            panelLoadPanels.Visible = true;
            var panel = new ControleDeAcesso();
            panelLoadPanels.Controls.Clear();
            panelLoadPanels.Controls.Add(panel);
            EsconderSubMenu();
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
            panelLoadPanels.Visible = true;
            var panel = new InserirProdutos();
            panelLoadPanels.Controls.Clear();
            panelLoadPanels.Controls.Add(panel);
            EsconderSubMenu();
        }
        /// <summary>
        /// Botão do submenu ESTOQUE do MENU PRODUTOS que invoca painel de ESTOQUE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEstoque_Click(object sender, EventArgs e)
        {
            panelLoadPanels.Visible = true;
            var panel = new AlteraProdutos();
            panelLoadPanels.Controls.Clear();
            panelLoadPanels.Controls.Add(panel);
            EsconderSubMenu();
        }
        /// <summary>
        /// Botão do submenu CONSULTA do MENU PRODUTOS que invoca painel de CONSULTA
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConsultarProdutos_Click(object sender, EventArgs e)
        {
            panelLoadPanels.Visible = true;
            var panel = new ConsultaProdutos();
            panelLoadPanels.Controls.Clear();
            panelLoadPanels.Controls.Add(panel);
            EsconderSubMenu();
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
            panelLoadPanels.Visible = true;
            var panel = new CadastrarVenda();
            panelLoadPanels.Controls.Clear();
            panelLoadPanels.Controls.Add(panel);
            EsconderSubMenu();
        }
        /// <summary>
        /// Botão do submenu CONSULTAR do MENU VENDAS que invoca painel Lista de Vendas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConsultarVendas_Click(object sender, EventArgs e)
        {
            panelLoadPanels.Visible = true;
            var panel = new ConsultaVendas();
            panelLoadPanels.Controls.Clear();
            panelLoadPanels.Controls.Add(panel);
            panel.dataGridViewVendas.Rows.Clear();
            EsconderSubMenu();
        }

 
        // FIM ------------------------------------ SUBMENU VENDAS ------------------------------------ FIM //
    }
}
