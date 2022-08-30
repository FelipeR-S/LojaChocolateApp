using LojaChocolateApp.Model;
using LojaChocolateApp.Repository;
using LojaChocolateApp.Utils.Popups;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaChocolateApp.Utils.Panels
{
    public partial class InserirProdutos : UserControl
    {
        private TextBoxControls _controle = new TextBoxControls();
        public InserirProdutos()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Insere um unico <see cref="Produto"/> através dos dados informados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInserirProdutoUnico_Click(object sender, EventArgs e)
        {
            try
            {
                var verifica = new ProdutoRepository();
                var id = textIdProduto.Text;
                var nome = textNomeProduto.Text;
                var peso = Convert.ToDecimal(textPesoProduto.Text);
                var valor = Convert.ToDecimal(textValorProduto.Text);
                var tipo = textTipoProduto.Text;
                switch (tipo)
                {
                    case "Chocolate":
                        break;
                    case "Presentes":
                        break;
                    default:
                        tipo = "Chocolate";
                        break;
                }
                var estoque = Convert.ToInt32(textEstoqueProduto.Text);
                var produto = new Produto(id, nome, peso, valor, tipo, estoque);
                (var existe, var msg) = verifica.Existente(produto);

                if (existe)
                {
                    MessageBox.Show(msg);
                }
                else
                {
                    verifica.IncluirUnico(produto);
                    MessageBox.Show("Cadastro Concluído");
                    _controle.ApagaBox(this);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Todos os campos devem ser preenchidos");
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Todos os campos devem ser preenchidos");

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
        /// Insere uma lista de produtos a partir de arquivo CSV
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInserirProdutosCSV_Click(object sender, EventArgs e)
        {
            try
            {
                var tratamentoArquivo = new ProdutoRepository();
                var arquivo = textArquivoProduto.Text;
                var correto = true;
                var linhaErrada = 0;
                using (var fileStream = new FileStream(arquivo, FileMode.Open))
                using (var sr = new StreamReader(fileStream))
                {
                    var contadorLinhas = 0;
                    while (!sr.EndOfStream)
                    {
                        var linha = sr.ReadLine();
                        correto = _controle.CSVIsMatch(linha, "produto");
                        if (!correto)
                        {
                            linhaErrada = contadorLinhas + 1;
                            break;
                        }
                        contadorLinhas++;
                    }
                }
                if (correto)
                {
                    (var inseridos, var conflitos, var qtdconflitos) = tratamentoArquivo.TrataCSV(arquivo);
                    tratamentoArquivo.IncluirVarios(inseridos);
                    var erros = $"{qtdconflitos} linhas não foram adicionadas:\n";
                    if (qtdconflitos != 0)
                    {
                        var contadorLinhas = 0;
                        while (contadorLinhas < qtdconflitos)
                        {
                            erros += $"{conflitos[contadorLinhas]}\n";
                            contadorLinhas++;
                        }
                        MessageBox.Show($"Cadastro Concluído\n\n{erros}");
                    }
                    else
                    {
                        MessageBox.Show("Produtos inseridos com sucesso!");
                    }
                }
                else
                    MessageBox.Show($"Linha nº {linhaErrada} em formato incorreto no arquivo!");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Favor selecionar um arquivo CSV");
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
        /// Exibe popup de informações dobre arquivo CSV
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInfoProduto_Click(object sender, EventArgs e)
        {
            Form background = new Form();

            try
            {
                using (PopupInfoCSV popupCSV = new PopupInfoCSV())
                {
                    var backGroundDesign = new BackGroundPopup();

                    backGroundDesign.BackGroundPopupDesign(background);
                    popupCSV.txtFuncionarioCSV.Visible = false;
                    popupCSV.txtProdutoCSV.Visible = true;
                    popupCSV.textInfoVendasCSV.Visible = false;
                    popupCSV.txtFuncionarioCSV.ReadOnly = true;
                    popupCSV.txtProdutoCSV.ReadOnly = true;
                    popupCSV.textInfoVendasCSV.ReadOnly = true;
                    popupCSV.Owner = background;
                    popupCSV.ShowDialog();
                    background.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                background.Dispose();
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
        private void OpenFile(object sender, EventArgs e)
        {
            _controle.OpenFile(sender, e);
        }
        private void CopiarSelecionar(object sender, KeyEventArgs e)
        {
            _controle.CopiarSelecionar(sender, e);
        }
    }
}
