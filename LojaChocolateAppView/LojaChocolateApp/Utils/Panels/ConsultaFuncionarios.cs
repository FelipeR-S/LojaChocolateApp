using LojaChocolateApp.Model;
using LojaChocolateApp.Properties;
using LojaChocolateApp.Repository;
using LojaChocolateApp.Utils.LayoutItems;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaChocolateApp.Utils.Panels
{
    public partial class ConsultaFuncionarios : UserControl
    {
        private TextBoxControls _controle = new TextBoxControls();
        public ConsultaFuncionarios()
        {
            InitializeComponent();
            flowLayoutPanelFuncionario.Controls.Clear();
            TituloExibeFuncionario.Visible = false;
        }
        /// <summary>
        /// Recupera detalhes do <see cref="Funcionario"/> no <see cref="FuncionarioRepository"/> quando ele existe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExibeDetalhesFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                flowLayoutPanelFuncionario.Controls.Clear();
                TituloExibeFuncionario.Visible = false;
                var id = textBoxIDDetalhesFuncionario.Text;
                var repoFuncionario = new FuncionarioRepository();

                (var existe, var funcionario) = repoFuncionario.GetDetalhes(id);

                if (existe)
                {
                    PopulaExibeDetalhe(funcionario);
                    textBoxIDDetalhesFuncionario.Text = "";
                    comboBoxOrdenar.Text = "";
                }
                else
                    MessageBox.Show($"Funcionário com ID nº {id} não encontrado!");
            }
            catch (FormatException)
            {
                MessageBox.Show($"Funcionário não encontrado!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Carrega layout de detalhes de <see cref="Funcionario"/>
        /// </summary>
        /// <param name="funcionario"></param>
        private void PopulaExibeDetalhe(Funcionario funcionario)
        {
            LayoutFuncionarios detalhes = new LayoutFuncionarios();
            detalhes.Nome = funcionario.Nome;
            detalhes.Id = funcionario.Id.ToString();
            detalhes.Cargo = funcionario.Cargo;
            detalhes.Cpf = funcionario.Cpf;
            detalhes.Contato = funcionario.Contato;
            detalhes.Salario = $"R$ {funcionario.Salario}";
            detalhes.DataCadastro = funcionario.DataCadastro;
            detalhes.Vendas = funcionario.QuantidadeDeVendas.ToString();
            detalhes.Imagem = Resources.userWhite;
            detalhes.BackGroundColor = Color.FromArgb(238, 118, 0);
            detalhes.btnMenosDetalhes.Visible = false;
            detalhes.btnMaisDetalhes.Visible = false;

            if (flowLayoutPanelFuncionario.Controls.Count < 0)
            {
                flowLayoutPanelFuncionario.Controls.Clear();
            }
            flowLayoutPanelFuncionario.Controls.Add(detalhes);
        }
        /// <summary>
        /// Recupera e exibe lista de todos os <see cref="Funcionario"/> no <see cref="FuncionarioRepository"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExibeTodosFuncionarios_Click(object sender, EventArgs e)
        {
            try
            {
                flowLayoutPanelFuncionario.Controls.Clear();
                var ordem = comboBoxOrdenar.Text;
                var repo = new FuncionarioRepository();
                var lista = repo.GetLista();
                TituloExibeFuncionario.Text = $"Total de {lista.Count} Funcionários Cadastrados";
                TituloExibeFuncionario.Visible = true;
                lista.Sort(new FuncionarioRepository(ordem));
                PopularExibeTodosFuncionarios(lista);
                comboBoxOrdenar.Text = "";
                textBoxIDDetalhesFuncionario.Text = "";
            }
            catch (FormatException)
            {
                MessageBox.Show("Não há nenhum funcionário cadastrado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Carrega layout que exibe lista de funcionários
        /// </summary>
        /// <param name="lista"></param>
        private void PopularExibeTodosFuncionarios(List<Funcionario> lista)
        {
            LayoutFuncionarios[] layoutLista = new LayoutFuncionarios[lista.Count];
            for (int i = 0; i < lista.Count; i++)
            {
                layoutLista[i] = new LayoutFuncionarios();
                layoutLista[i].Nome = lista[i].Nome;
                layoutLista[i].Id = lista[i].Id.ToString();
                layoutLista[i].Cargo = lista[i].Cargo;
                layoutLista[i].Cpf = lista[i].Cpf;
                layoutLista[i].Contato = lista[i].Contato;
                layoutLista[i].Salario = $"R$ {lista[i].Salario}";
                layoutLista[i].DataCadastro = lista[i].DataCadastro.ToString();
                layoutLista[i].Vendas = lista[i].QuantidadeDeVendas.ToString();
                layoutLista[i].BackGroundColor = Color.Gray;
                layoutLista[i].panelExibeDetalhes.Visible = false;
                layoutLista[i].Height = 80;
                layoutLista[i].btnMenosDetalhes.Visible = false;

                if (flowLayoutPanelFuncionario.Controls.Count < 0)
                {
                    flowLayoutPanelFuncionario.Controls.Clear();
                }
                flowLayoutPanelFuncionario.Controls.Add(layoutLista[i]);
            }
        }
        private void OnlyNumbers(object sender, KeyPressEventArgs e)
        {
            _controle.OnlyNumbers(sender, e);
        }
        private void CopiarSelecionar(object sender, KeyEventArgs e)
        {
            _controle.CopiarSelecionar(sender, e);
        }

    }
}
