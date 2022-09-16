using LojaChocolateApp.Repository;
using LojaChocolateApp.Utils.Panels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaChocolateApp.Utils.Popups
{
    public partial class PopupRemover : Form
    {
        AlteraFuncionario panelFuncionario;
        AlteraProdutos panelProdutos;
        private TextBoxControls _controle = new TextBoxControls();
        public PopupRemover(AlteraFuncionario panel)
        {
            InitializeComponent();
            this.panelFuncionario = panel;
        }
        public PopupRemover(AlteraProdutos panel)
        {
            InitializeComponent();
            this.panelProdutos = panel;
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
            if (panelRemoverFuncionario.Visible == true && panelRemoverProduto.Visible == false)
                textBoxFunRemove.Text = textBoxFunRemove.Text.Replace("00", $"{panelFuncionario.textBoxRemoverFuncionario.Text}");
            else
                textBoxProdRemover.Text = textBoxProdRemover.Text.Replace("00", $"{panelProdutos.textIdEstoqueProdutos.Text}");
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                var removido = false;
                var id = "";
                if (panelRemoverFuncionario.Visible == true && panelRemoverProduto.Visible == false)
                {
                    var idUser = GetMatriculaUser(SQLServerConn.User);
                    id = panelFuncionario.textBoxRemoverFuncionario.Text;
                    if (id != idUser)
                    {
                        var repositorioFuncionario = new FuncionarioRepository();
                        removido = repositorioFuncionario.Remover(id);
                        if (!removido)
                            MessageBox.Show($"Funcionário com matrícula nº {id} não encontrado!");
                        else
                            MessageBox.Show($"Funcionário com matrícula nº {id} removido com sucesso!");
                    }
                    else
                        MessageBox.Show("Não é possível remover funcionário logado!");
                }
                if (panelRemoverProduto.Visible == true && panelRemoverFuncionario.Visible == false)
                {
                    id = panelProdutos.textIdEstoqueProdutos.Text;
                    var repositorioProduto = new ProdutoRepository();
                    removido = repositorioProduto.Remover(id);
                    if (!removido)
                        MessageBox.Show($"Produto com código nº {id} não encontrado!");
                    else
                        MessageBox.Show($"Produto com código nº {id} removido com sucesso!");
                }
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
                this.Close();
            }
        }
        private string GetMatriculaUser(string user)
        {
            var matricula = "";
            using (SqlConnection connection = new SqlConnection(SQLServerConn.StrCon))
            {
                connection.Open();
                var SqlQuery = $"Select [Matricula] from [dbo].[Cadastro de Usuário] where [Nome] = '{user}'";
                SqlCommand cmd = new SqlCommand(SqlQuery, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    matricula = reader.GetString(0);
                }
                connection.Close();
            }
            return matricula;
        }
        private void CopiarSelecionar(object sender, KeyEventArgs e)
        {
            _controle.CopiarSelecionar(sender, e);
        }
    }
}
