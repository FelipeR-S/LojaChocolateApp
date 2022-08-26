using LojaChocolateApp.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaChocolateApp.Utils.Popups
{
    public partial class PopupRemover : Form
    {
        AppLoja appLoja;
        public PopupRemover(AppLoja loja)
        {
            InitializeComponent();
            this.appLoja = loja;
        }
        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Recupera ID do app para exibir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PopupRemoverFuncionario_Load(object sender, EventArgs e)
        {
            textBoxIDPopup.Text = appLoja.textBoxRemoverFuncionario.Text;
            textBoxIdProduto.Text = appLoja.textIdEstoqueProdutos.Text;
        }
        private void btnExcluirFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                var removido = false;
                var id = "";
                if (panelRemoverFuncionario.Visible == true && panelRemoverProduto.Visible == false)
                {
                    id = textBoxIDPopup.Text;
                    var repositorioFuncionario = new FuncionarioRepository();
                    removido = repositorioFuncionario.Remover(id);
                }
                if (panelRemoverProduto.Visible == true && panelRemoverFuncionario.Visible == false)
                {
                    id = textBoxIdProduto.Text;
                    var repositorioProduto = new ProdutoRepository();
                    removido = repositorioProduto.Remover(id);
                }
                if (!removido)
                {
                    MessageBox.Show($"ID nº {id} não encontrado!");
                }
                else
                    MessageBox.Show($"ID nº {id} removido com sucesso!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Favor inserir algum número de ID");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                appLoja.textBoxRemoverFuncionario.Text = "";
                this.Close();
            }
        }
    }
}
