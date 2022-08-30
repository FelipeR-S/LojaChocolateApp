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
    public partial class CadastrarVenda : UserControl
    {
        private int _addProdVenda;
        private TextBoxControls _controle = new TextBoxControls();
        public CadastrarVenda()
        {
            InitializeComponent();
            CarregaComboBoxProduto();
            textProdVendas.ReadOnly = true;
            textProdVendas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            _addProdVenda = 0;
        }
        /// <summary>
        /// Adiciona <see cref="Produto"/> ao texBox de venda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdicionarProdVenda_Click(object sender, EventArgs e)
        {
            try
            {
                textProdVendas.Visible = true;
                if (_addProdVenda < 10)
                {
                    var quantidade = textQtdVendasProd.Text;
                    var produto = cboProduto1.Text;
                    if (quantidade == "" || produto == "")
                    {
                        MessageBox.Show("Quantidade e produto devem ser declarados!");
                    }
                    else if (textProdVendas.Text.Contains(produto))
                    {
                        MessageBox.Show("Produto já foi inserido!");
                    }
                    else
                    {
                        textProdVendas.Text += $"{quantidade} | {produto}\r\n";
                        _addProdVenda++;
                    }
                }
                else
                    MessageBox.Show("Número máximo de produtos inserido!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                textQtdVendasProd.Text = "";
                textIdRemoverVenda.Text = "";
                cboProduto1.Text = "";
            }
        }
        /// <summary>
        /// Remove Produto inserido no box de venda
        /// </summary>
        /// <param name="id">Id do produto</param>
        private void RemoveVenda(string id)
        {
            try
            {
                if (_addProdVenda > 0)
                {
                    var idProd = id;
                    var linhas = textProdVendas.Text.Replace("\r\n", "\n").Replace("\n", "\n").Replace("\r", "\n").Split('\n');
                    var listaLinha = new List<string>();
                    var contador = -1;

                    for (int i = 0; i < linhas.Length - 1; i++)
                    {
                        var textoId = linhas[i].Split('|');
                        if (id == textoId[1].Replace(" ", ""))
                        {
                            contador = i;
                        }
                        else
                            listaLinha.Add(linhas[i]);
                    }
                    if (contador >= 0)
                    {
                        _addProdVenda--;
                        textProdVendas.Controls.Clear();
                        textProdVendas.Text = "";
                        foreach (var linha in listaLinha)
                        {
                            textProdVendas.Text += $"{linha}\r\n";
                        }
                        MessageBox.Show("Produto Removido!");
                    }
                    else
                        MessageBox.Show("Produto não inserido!");
                }
                else
                    MessageBox.Show("Nenhum produto para remover!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                textQtdVendasProd.Text = "";
                textIdRemoverVenda.Text = "";
                cboProduto1.Text = "";
            }
        }
        /// <summary>
        /// Remove <see cref="Produto"/> do texBox de Venda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoverVenda_Click(object sender, EventArgs e)
        {
            RemoveVenda(textIdRemoverVenda.Text);
        }
        /// <summary>
        /// Carrega elementos do combobox do submenu cadastrar vendas de forma dinamica
        /// </summary>
        private void CarregaComboBoxProduto()
        {
            //ComboBox Funcionario
            var repoFuncionario = new FuncionarioRepository();
            var listaFuncionarioRepo = repoFuncionario.GetLista();
            var funcionarioVazio = new Vendedor("", "", "", "", 0m, "", "0");
            var listaFuncionarios = new List<Funcionario>();
            listaFuncionarios.Add(funcionarioVazio);
            foreach (var f in listaFuncionarioRepo)
            {
                var novoFuncionario = new Vendedor(f.Id, $"{f.Id} | {f.Nome}", f.Cpf, f.Contato, f.Salario, f.Cargo, f.DataCadastro);
                listaFuncionarios.Add(novoFuncionario);
            }
            listaFuncionarios.Sort(new FuncionarioRepository(""));
            textIdVendasCadastro.DataSource = listaFuncionarios;
            textIdVendasCadastro.ValueMember = "Id";
            textIdVendasCadastro.DisplayMember = "Nome";
            //ComboBox Produto
            var repoProduto = new ProdutoRepository();
            var listaProdutoRepo = repoProduto.GetLista();
            var listaProdutos = new List<Produto>();
            var produtoVazio = new Produto("", "", 0m, 0m, "", 0);
            listaProdutos.Add(produtoVazio);
            foreach (var p in listaProdutoRepo)
            {
                var novoProduto = new Produto(p.Id, $"{p.Id} | {p.Nome} | R$ {p.Valor}", p.Peso, p.Valor, p.Tipo, p.Estoque);
                listaProdutos.Add(novoProduto);
            }
            listaProdutos.Sort(new ProdutoRepository(""));
            cboProduto1.DataSource = listaProdutos;
            cboProduto1.ValueMember = "Id";
            cboProduto1.DisplayMember = "Nome";
        }
        /// <summary>
        /// Recebe dados de textBox para cadastrar venda com dados informados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCadastrarVendaUnica_Click(object sender, EventArgs e)
        {
            try
            {
                //Entrada de dados
                var vendas = textProdVendas.Text.Replace("\r\n", "\n").Replace("\n", "\n").Replace("\r", "\n").Split('\n');
                var entradaFuncionarioId = textIdVendasCadastro.Text.Replace(" ", "").Split('|');
                var funcionarioId = entradaFuncionarioId[0];
                var conflito = false;
                var valorTotal = 0m;
                var data = DateTime.Now;
                if (funcionarioId != "")
                {
                    //Repositorios
                    var repoFuncionario = new FuncionarioRepository();
                    var repoProduto = new ProdutoRepository();
                    var repoVendas = new VendaRepository();

                    //Listas
                    var listaProdVendas = new List<Tuple<int, Produto>>();

                    //Get Funcionario
                    (var existeFuncionario, var funcionario) = repoFuncionario.GetDetalhes(funcionarioId);
                    if (textProdVendas.Text != "")
                    {
                        for (int i = 0; i < vendas.Length - 1; i++)
                        {
                            var linha = vendas[i].Split('|');
                            var qtdProdutos = Convert.ToInt32(linha[0]);
                            if (qtdProdutos <= 0)
                            {
                                conflito = true;
                                MessageBox.Show("Quantidade de produtos deve ser maior que 0.");
                                RemoveVenda(linha[1].Replace(" ", ""));
                                break;
                            }
                            else
                            {
                                (var exProd, var produto) = repoProduto.GetDetalhes(linha[1].Replace(" ", ""));
                                if (qtdProdutos > produto.Estoque || !exProd)
                                {
                                    MessageBox.Show($"Impossível cadastrar a compra o produto abaixo possuí estoque insuficiente!\n" +
                                        $"{produto.Nome} | ID: {produto.Id} | Estoque: {produto.Estoque}\n" +
                                        $"Quantidade tentada: {qtdProdutos}");
                                    conflito = true;
                                    RemoveVenda(produto.Id);
                                    break;
                                }
                                else
                                {
                                    listaProdVendas.Add(new Tuple<int, Produto>(qtdProdutos, produto));
                                }
                            }
                        }
                        if (!conflito)
                        {
                            foreach (var item in listaProdVendas)
                            {
                                (var qtd, var prod) = item;
                                valorTotal += qtd * prod.Valor;
                            }
                            var venda = new Venda(funcionario, listaProdVendas, valorTotal, data);
                            repoVendas.IncluirUnico(venda);
                            _addProdVenda = 0;
                            MessageBox.Show("Cadastro concluído!");
                            _controle.ApagaBox(this);
                        }
                    }
                    else
                        MessageBox.Show("Favor informar os produtos e quantidades de forma correta!");
                }
                else
                    MessageBox.Show("Favor inserir funcionário!");
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
        private void btnInfoVendaCSV_Click(object sender, EventArgs e)
        {
            Form background = new Form();
            try
            {
                using (PopupInfoCSV popupCSV = new PopupInfoCSV())
                {
                    var backGroundDesign = new BackGroundPopup();

                    backGroundDesign.BackGroundPopupDesign(background);
                    popupCSV.txtFuncionarioCSV.Visible = false;
                    popupCSV.txtProdutoCSV.Visible = false;
                    popupCSV.textInfoVendasCSV.Visible = true;
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
        /// <summary>
        /// Recebe arquivo CSV e adiciona informações para cadastro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCadastrarVendasCSV_Click(object sender, EventArgs e)
        {
            try
            {
                var produtoRepo = new ProdutoRepository();
                var tratamentoArquivo = new VendaRepository();
                var arquivo = textArquivoVendasCadastro.Text;
                var correto = true;
                var linhaErrada = 0;
                using (var filestream = new FileStream(arquivo, FileMode.Open))
                using (var leitor = new StreamReader(filestream))
                {
                    var contadorLinhas = 0;
                    while (!leitor.EndOfStream)
                    {
                        var linha = leitor.ReadLine();
                        correto = _controle.CSVIsMatch(linha, "vendas");
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
                    if (qtdconflitos != 0)
                    {
                        var erros = "";
                        foreach (var msg in conflitos)
                        {
                            erros += $"{msg}\n";
                        }
                        MessageBox.Show(erros);
                    }
                    else
                    {
                        // Inclui venda
                        var repoProduto = new ProdutoRepository();
                        var listaErros = new List<string>();
                        var contadorLinha = 0;
                        var existeErro = false;
                        foreach (var venda in inseridos)
                        {
                            var conflitosVenda = 0;
                            contadorLinha++;
                            var erro = "";
                            foreach (var prodVendas in venda.Produtos)
                            {
                                (var qtd, var prod) = prodVendas;
                                (var existe, var produtoEstoque) = repoProduto.GetDetalhes(prod.Id);
                                if (qtd > produtoEstoque.Estoque)
                                {
                                    conflitosVenda++;
                                    erro += $"Produto: {prod.Nome} | {prod.Id}\nPossui estoque insuficiente.\n" +
                                        $"Quantidade solicitada: {qtd}\nQuantidade em Estoque:{produtoEstoque.Estoque}\n\n";
                                    existeErro = true;
                                }
                            }
                            if (conflitosVenda > 0)
                            {
                                erro += $"Venda linha nº{contadorLinha} não foi cadastrada.";
                                listaErros.Add(erro);
                            }
                            else
                                tratamentoArquivo.IncluirUnico(venda);
                        }
                        if (existeErro)
                        {
                            var erros = "";
                            foreach (var msg in listaErros)
                            {
                                erros += $"{msg}\n\n";
                            }
                            MessageBox.Show(erros);
                        }
                        else
                            MessageBox.Show("Vendas inseridas com sucesso!");
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
        private void OnlyNumbers(object sender, KeyPressEventArgs e)
        {
            _controle.OnlyNumbers(sender, e);
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
