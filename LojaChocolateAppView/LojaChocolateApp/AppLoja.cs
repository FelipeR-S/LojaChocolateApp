using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaChocolateApp
{
    public partial class AppLoja : Form
    {
        public AppLoja()
        {
            InitializeComponent();
            SubMenuDesign();
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
        /// <summary>
        /// Deixa texto e layout de exibição de <see cref="Panel"/> que exibe detalhes não vísivel ao iniciar a aplicação ou ao acessar outro submenu
        /// </summary>
        private void EscondeTextoDetalhes()
        {
           //flowLayoutPanelFuncionario.Controls.Clear();
           //TituloExibeFuncionario.Visible = false;
           //flowLayoutLayoutExibeProdutos.Controls.Clear();
           //tituloExibeProdutos.Visible = false;
           //panelQuantidadeProduto.Visible = false;
           //panelNovoValorProduto.Visible = false;
        }
        /// <summary>
        /// Deixa telas dos submenus não vísiveis ao iniciar a aplicação
        /// </summary>
        private void TelasDesign()
        {
          //panelCadastrarFuncionario.Visible = false;
          //panelRemoverFuncionario.Visible = false;
          //panelConsultarFuncionario.Visible = false;
          //panelInserirProduto.Visible = false;
          //panelEstoqueProduto.Visible = false;
          //panelExibirProdutos.Visible = false;
          //panelCadastrarVendas.Visible = false;
          //panelConsultaVendas.Visible = false;
          //dataGridViewVendas.Visible = false;
        }
        /// <summary>
        /// Esconde uma tela enquanto outra estiver ativa
        /// </summary>
        private void EsconderTelas()
        {
           //if (panelCadastrarFuncionario.Visible == true)
           //    panelCadastrarFuncionario.Visible = false;
           //if (panelRemoverFuncionario.Visible == true)
           //    panelRemoverFuncionario.Visible = false;
           //if (panelConsultarFuncionario.Visible == true)
           //    panelConsultarFuncionario.Visible = false;
           //if (panelInserirProduto.Visible == true)
           //    panelInserirProduto.Visible = false;
           //if (panelEstoqueProduto.Visible == true)
           //    panelEstoqueProduto.Visible = false;
           //if (panelExibirProdutos.Visible == true)
           //    panelExibirProdutos.Visible = false;
           //if (panelCadastrarVendas.Visible == true)
           //    panelCadastrarVendas.Visible = false;
           //if (panelConsultaVendas.Visible == true)
           //{
           //    panelConsultaVendas.Visible = false;
           //    dataGridViewVendas.Visible = false;
           //    dataGridViewVendas.Rows.Clear();
           //}
        }
        /// <summary>
        /// Mostra uma tela ao ser invocada ou a esconde caso já esteja vísivel
        /// </summary>
        /// <param name="telas">Objeto do tipo <see cref="Panel"/> que refere a uma tela invocada por botão de submenu</param>
        public void MostrarTelas(Panel telas)
        {
           //if (telas.Visible == false)
           //{
           //    panelLogoPrincipal.Visible = false;
           //    ApagaTextBoX();
           //    EscondeTextoDetalhes();
           //    EsconderTelas();
           //    telas.Visible = true;
           //}
           //else
           //    telas.Visible = false;
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
            EsconderTelas();
            //MostrarTelas(panelCadastrarFuncionario);
            EsconderSubMenu();
        }
        /// <summary>
        /// Botão de submenu REMOVER do MENU FUNCIONARIO que invoca painel de REMOVER
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExcluirFuncionario_Click(object sender, EventArgs e)
        {
            EsconderTelas();
            //MostrarTelas(panelRemoverFuncionario);
            EsconderSubMenu();
        }
        /// <summary>
        /// Botão de submenu CONSULTAR do MENU FUNCIONARIO que invoca painel de CONSULTAR
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConsultarFuncionarios_Click(object sender, EventArgs e)
        {
            EsconderTelas();
            //MostrarTelas(panelConsultarFuncionario);
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
            EsconderTelas();
            //MostrarTelas(panelInserirProduto);
            EsconderSubMenu();
        }
        /// <summary>
        /// Botão do submenu ESTOQUE do MENU PRODUTOS que invoca painel de ESTOQUE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEstoque_Click(object sender, EventArgs e)
        {
            EsconderTelas();
            //MostrarTelas(panelEstoqueProduto);
            EsconderSubMenu();
        }
        /// <summary>
        /// Botão do submenu CONSULTA do MENU PRODUTOS que invoca painel de CONSULTA
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConsultarProdutos_Click(object sender, EventArgs e)
        {
            EsconderTelas();
            //MostrarTelas(panelExibirProdutos);
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
            //CarregaComboBox();
            EsconderTelas();
            //MostrarTelas(panelCadastrarVendas);
            EsconderSubMenu();
           //_addProdVenda = 0;
           //textProdVendas.ReadOnly = true;
           //textProdVendas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        }
        /// <summary>
        /// Botão do submenu CONSULTAR do MENU VENDAS que invoca painel Lista de Vendas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConsultarVendas_Click(object sender, EventArgs e)
        {
            EsconderTelas();
            //MostrarTelas(panelConsultaVendas);
            EsconderSubMenu();
        }
        // FIM ------------------------------------ SUBMENU VENDAS ------------------------------------ FIM //
    }
}
