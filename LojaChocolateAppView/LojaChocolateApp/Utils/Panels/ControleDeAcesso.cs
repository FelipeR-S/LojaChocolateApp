using LojaChocolateApp.Repository;
using LojaChocolateApp.Utils.LayoutItems;
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

namespace LojaChocolateApp.Utils.Panels
{
    public partial class ControleDeAcesso : UserControl
    {
        public ControleDeAcesso(bool darkMode)
        {
            InitializeComponent();
            DarkMode activeDarkMode = new DarkMode(darkMode);
            activeDarkMode.GetDarkMode(this);
        }
        /// <summary>
        /// Carrega Controles com informações dos cadastros solicitados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ControleDeAcesso_Load(object sender, EventArgs e)
        {
            try
            {
                var sqlServer = new SQLServerConn();
                var lista = sqlServer.GetListaCadastro();
                flowLayoutPanelCadastros.Controls.Clear();
                if (lista.Count == 0)
                {
                    textTitulo.Text = "Não há Nenhuma Solicitação de Cadastro!";
                }
                PopulaAcessoFuncionario(lista);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Populas os controles de cadastro
        /// </summary>
        /// <param name="lista"></param>
        private void PopulaAcessoFuncionario(List<string> lista)
        {
            NovoAcesso[] layoutLista = new NovoAcesso[lista.Count];
            for (int i = 0; i < lista.Count; i++)
            {
                var dados = lista[i].Split(';');
                layoutLista[i] = new NovoAcesso();
                if (dados[0] == "##")
                    layoutLista[i].Nome = "Funcionário não existe!";
                else layoutLista[i].Nome = dados[0];
                layoutLista[i].User = dados[1];
                layoutLista[i].Matricula = dados[2];
                layoutLista[i].Cpf = dados[3];

                if (flowLayoutPanelCadastros.Controls.Count < 0)
                {
                    flowLayoutPanelCadastros.Controls.Clear();
                }
                flowLayoutPanelCadastros.Controls.Add(layoutLista[i]);
            }
        }
    }
}
