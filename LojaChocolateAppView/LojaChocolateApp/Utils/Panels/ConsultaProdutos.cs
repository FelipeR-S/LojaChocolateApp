using LojaChocolateApp.Model;
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
    public partial class ConsultaProdutos : UserControl
    {
        private TextBoxControls _controle = new TextBoxControls();
        public ConsultaProdutos(bool darkMode)
        {
            InitializeComponent();
            flowLayoutLayoutExibeProdutos.Controls.Clear();
            tituloExibeProdutos.Visible = false;
            DarkMode activeDarkMode = new DarkMode(darkMode);
            activeDarkMode.GetDarkMode(this);
        }
        /// <summary>
        /// Exibe detalhes de um <see cref="Produto"/> a partir do seu id
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscaIdProduto_Click(object sender, EventArgs e)
        {
            try
            {
                flowLayoutLayoutExibeProdutos.Controls.Clear();
                tituloExibeProdutos.Visible = false;
                var id = textIdBuscaProdutos.Text;
                var repoFuncionario = new ProdutoRepository();

                (var existe, var produto) = repoFuncionario.GetDetalhes(id);

                if (existe)
                {
                    PopulaExibeDetalheProduto(produto);
                    comboBoxOrdemProdutos.Text = "";
                    textIdBuscaProdutos.Text = "";
                }
                else
                    MessageBox.Show($"Funcionário com ID nº {id} não encontrado!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Produto não encontrado!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Popula elemento que aparecerá ao clicar no botão de buscar detalhes de <see cref="Produto"/>
        /// </summary>
        /// <param name="produto"></param>
        private void PopulaExibeDetalheProduto(Produto produto)
        {
            var layoutProdutos = new LayoutProdutos();
            layoutProdutos.Nome = produto.Nome;
            layoutProdutos.Id = produto.Id.ToString();
            layoutProdutos.Peso = $"{produto.Peso}g";
            layoutProdutos.Estoque = produto.Estoque.ToString();
            layoutProdutos.Valor = $"R$ {produto.Valor.ToString().Replace('.', ',')}";
            layoutProdutos.Tipo = produto.Tipo;
            layoutProdutos.Vendas = produto.QuantidadeDeVendas.ToString();
            if (flowLayoutLayoutExibeProdutos.Controls.Count < 0)
            {
                flowLayoutLayoutExibeProdutos.Controls.Clear();
            }
            flowLayoutLayoutExibeProdutos.Controls.Add(layoutProdutos);
        }
        /// <summary>
        /// Exibe lista de <see cref="Produto"/> inseridos no <see cref="ProdutoRepository"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExibeTodosProdutos_Click(object sender, EventArgs e)
        {
            try
            {
                flowLayoutLayoutExibeProdutos.Controls.Clear();
                var ordem = comboBoxOrdemProdutos.Text;
                var repo = new ProdutoRepository();
                var lista = repo.GetLista();
                var quantidade = 0;
                foreach (var produto in lista)
                {
                    quantidade += produto.Estoque;
                }

                tituloExibeProdutos.Text = $"Total de {lista.Count} tipos de produtos e {quantidade} produtos no estoque";
                tituloExibeProdutos.Visible = true;
                lista.Sort(new ProdutoRepository(ordem));
                PopulaTodosProdutos(lista);
                comboBoxOrdemProdutos.Text = "";
                textIdBuscaProdutos.Text = "";
            }
            catch (FormatException)
            {
                MessageBox.Show("Não há nenhum produto cadastrado!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Popula os elementos que aparecerão ao clicar no botão todos de busca de <see cref="Produto"/>
        /// </summary>
        /// <param name="lista"></param>
        private void PopulaTodosProdutos(List<Produto> lista)
        {
            LayoutProdutos[] layoutLista = new LayoutProdutos[lista.Count];
            for (int i = 0; i < lista.Count; i++)
            {
                PopulaExibeDetalheProduto(lista[i]);
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
