using LojaChocolateApp.Model;
using LojaChocolateApp.Repository;
using LojaChocolateApp.Utils.Popups;
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
    public partial class AlteraProdutos : UserControl
    {
        private TextBoxControls _controle = new TextBoxControls();
        public AlteraProdutos()
        {
            InitializeComponent();
            panelQuantidadeProduto.Visible = false;
            panelNovoValorProduto.Visible = false;
        }
        /// <summary>
        /// Altera Estoque removendo, aumentando, diminuindo a quantidade ou alterando o valor do <see cref="Produto"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAlterarEstoque_Click(object sender, EventArgs e)
        {
            try
            {
                // Variaveis para alteração
                var produtoRepo = new ProdutoRepository();
                Produto produto = null;
                var alternativa = comboBoxOpcaoProdutos.Text;
                var id = textIdEstoqueProdutos.Text;

                var quantidade = "";
                var valorAnterior = 0m;
                var novoValor = 0m;
                var concluido = false;
                var existe = false;
                var msg = "";

                switch (alternativa)
                {
                    case "Remover":
                        (var existeProd, var prod) = produtoRepo.GetDetalhes(id);
                        if (existeProd)
                        {
                            Form background = new Form();
                            using (PopupRemover popupRemover = new PopupRemover(this))
                            {
                                var backGroundDesign = new BackGroundPopup();

                                backGroundDesign.BackGroundPopupDesign(background);

                                popupRemover.Owner = background;
                                popupRemover.panelRemoverFuncionario.Visible = false;
                                popupRemover.panelRemoverProduto.Visible = true;
                                popupRemover.ShowDialog();
                                background.Dispose();
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Produto com Código nº {id} não encontrado.");
                        }
                        break;
                    case "Inserir":
                        quantidade = textEstoqueQtdProdutos.Text;
                        (concluido, produto) = produtoRepo.AlteraEstoqueRepository(id, Convert.ToInt32(quantidade));
                        if (concluido && produto != null)
                        {
                            MessageBox.Show($"Alteração Concluída!\n" +
                                $"O produto:{produto.Nome}\n teve sua quantidade alterada\n" +
                                $"de: {produto.Estoque} para {produto.Estoque + Convert.ToInt32(quantidade)}");
                        }
                        else
                        {
                            msg = "Produto não encontrado!";
                            MessageBox.Show(msg);
                        }
                        break;
                    case "Retirar":
                        quantidade = textEstoqueQtdProdutos.Text;
                        var qtdRetirar = Convert.ToInt32($"-{quantidade}");
                        (concluido, produto) = produtoRepo.AlteraEstoqueRepository(id, qtdRetirar);
                        if (concluido && produto != null)
                        {
                            MessageBox.Show($"Alteração Concluída!\n" +
                                $"O produto:{produto.Nome}\n teve sua quantidade alterada\n" +
                                $"de: {produto.Estoque} para {produto.Estoque + qtdRetirar}");
                        }
                        else
                        {
                            msg += "Não foi possível retirar a quantidade informada!\nVerifique se o ID está correto ou se há produtos suficientes no estoque!";
                            MessageBox.Show(msg);
                        }
                        break;
                    case "Alterar Valor":
                        novoValor = Convert.ToDecimal(textNovoValorProduto.Text);
                        (concluido, valorAnterior) = produtoRepo.AlteraValorProduto(id, novoValor);
                        if (concluido)
                        {
                            (existe, produto) = produtoRepo.GetDetalhes(id);
                            MessageBox.Show($"Alteração Concluída!\n" +
                                $"O produto {produto.Nome}\n teve ser valor alterada\n" +
                                $"de: {valorAnterior.ToString("F2")} para {produto.Valor.ToString("F2")}");
                        }
                        else
                        {
                            msg = "Produto não encontrado!";
                            MessageBox.Show(msg);
                        }
                        break;
                    default:
                        break;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Favor inserir algum número de ID e Quantidade caso necessário!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                _controle.ApagaBox(this);
            }
        }
        /// <summary>
        /// Padrão de Exibição de elementos do submenu ESTOQUE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxOpcaoProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            var alternativas = comboBoxOpcaoProdutos.Text;
            switch (alternativas)
            {
                case "Inserir":
                    panelQuantidadeProduto.Visible = true;
                    panelNovoValorProduto.Visible = false;
                    break;
                case "Retirar":
                    panelQuantidadeProduto.Visible = true;
                    panelNovoValorProduto.Visible = false;
                    break;
                case "Alterar Valor":
                    panelNovoValorProduto.Visible = true;
                    panelQuantidadeProduto.Visible = false;
                    break;
                default:
                    panelQuantidadeProduto.Visible = false;
                    panelNovoValorProduto.Visible = false;
                    break;
            }
        }
        private void OnlyNumbers(object sender, KeyPressEventArgs e)
        {
            _controle.OnlyNumbers(sender, e);
        }
        private void BoxValor(object sender, KeyPressEventArgs e)
        {
            _controle.BoxValor(sender, e);
        }
    }
}
