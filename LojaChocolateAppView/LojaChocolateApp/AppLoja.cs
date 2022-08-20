using LojaChocolateApp.Model;
using LojaChocolateApp.Properties;
using LojaChocolateApp.Repository;
using LojaChocolateApp.Utils;
using LojaChocolateApp.Utils.LayoutItems;
using LojaChocolateApp.Utils.Popups;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaChocolateApp
{
    public partial class AppLoja : Form
    {
        private int _addProdVenda;
        public AppLoja()
        {
            InitializeComponent();
            SubMenuDesign();
            TelasDesign();
            EscondeTextoDetalhes();
        }
        // INICIO ------------------------------------ FUNCIONARIOS ------------------------------------ INICIO //
        /// <summary>
        /// Envia dados dos textbox para cadastro de <see cref="Funcionario"/> no <see cref="FuncionarioRepository"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnviarCadastroFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                var repo = new FuncionarioRepository();
                var id = textBoxId.Text;
                var nome = textBoxNome.Text;
                var cpf = textBoxCpf.Text;
                var contato = textBoxContato.Text;
                var salario = Convert.ToDecimal(textBoxSalario.Text);
                var cargo = "";
                if (comboBoxCargo.Text == "")
                {
                    cargo = "Vendedor";
                }
                else
                {
                    cargo = comboBoxCargo.Text;
                }
                var dataCadastro = DateTime.Now.ToShortDateString();
                Funcionario novoFuncionario = null;
                if (cpf.Length < 14)
                {
                    MessageBox.Show("CPF digitado incorretamente!");
                }
                else
                {
                    switch (cargo.ToLower())
                    {
                        case "vendedor":
                            novoFuncionario = new Vendedor(id, nome, cpf, contato, salario, cargo, dataCadastro);
                            break;
                        case "gerente":
                            novoFuncionario = new Gerente(id, nome, cpf, contato, salario, cargo, dataCadastro);
                            break;
                        default:
                            novoFuncionario = new Vendedor(id, nome, cpf, contato, salario, cargo, dataCadastro);
                            break;
                    }
                    // Verifica se Funcionário já está Cadastrado
                    (var existe, var msg) = repo.Existente(novoFuncionario);
                    if (existe)
                    {
                        MessageBox.Show(msg);
                    }
                    else
                    {
                        repo.IncluirUnico(novoFuncionario);
                        MessageBox.Show("Cadastro Concluído");
                        ApagaTextBoX();
                    }
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Todos os campos devem ser preenchidos corretamente!");
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Todos os campos devem ser preenchidos corretamente!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Envia arquivo CSV com <see cref="Funcionario"/> para serem inseridos no <see cref="FuncionarioRepository"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCadastrarListaFuncionarios_Click(object sender, EventArgs e)
        {
            try
            {
                var tratamentoDeArquivo = new FuncionarioRepository();
                var arquivo = textBoxArquivo.Text;
                var correto = true;
                var linhaErrada = 0;
                using (var fileStream = new FileStream(arquivo, FileMode.Open))
                using (var sr = new StreamReader(fileStream))
                {
                    var contadorLinhas = 0;
                    while (!sr.EndOfStream)
                    {
                        var linha = sr.ReadLine();
                        correto = CSVIsMatch(linha, "funcionario");
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
                    (var lista, var naoAdicionados, var numeroDeConflitos) = tratamentoDeArquivo.TrataCSV(arquivo);
                    tratamentoDeArquivo.IncluirVarios(lista);
                    var erros = $"{numeroDeConflitos} linhas não foram adicionadas:\n";
                    if (numeroDeConflitos != 0)
                    {
                        var contadorLinhas = 0;
                        while (contadorLinhas < numeroDeConflitos)
                        {
                            erros += $"{naoAdicionados[contadorLinhas]}\n";
                            contadorLinhas++;
                        }
                        MessageBox.Show($"Cadastro Concluído\n\n{erros}");
                    }
                    else
                    {
                        MessageBox.Show("Cadastro Concluído");
                    }
                }
                else
                    MessageBox.Show($"Linha nº {linhaErrada} em formato incorreto no arquivo!");
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Todos os dados devem ser informados.\nFavor verificar forma correta no botão info!");
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
                ApagaTextBoX();
            }
        }
        /// <summary>
        /// Exibe Popup com informações de formatação de CSV
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void infoFuncionario_Click(object sender, EventArgs e)
        {
            Form background = new Form();

            try
            {
                using (PopupInfoCSV popupCSV = new PopupInfoCSV())
                {
                    var backGroundDesign = new BackGroundPopup();

                    backGroundDesign.BackGroundPopupDesign(background);
                    popupCSV.txtFuncionarioCSV.Visible = true;
                    popupCSV.txtProdutoCSV.Visible = false;
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
        /// <summary>
        /// Invoca Popup para aceitar remoção do <see cref="Funcionario"/> do <see cref="FuncionarioRepository"/> caso ele exista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoverFuncionario_Click(object sender, EventArgs e)
        {
            Form background = new Form();
            try
            {
                using (PopupRemover popupRemover = new PopupRemover(this))
                {
                    var backGroundDesign = new BackGroundPopup();

                    backGroundDesign.BackGroundPopupDesign(background);

                    popupRemover.Owner = background;
                    popupRemover.panelRemoverProduto.Visible = false;
                    popupRemover.panelRemoverFuncionario.Visible = true;
                    popupRemover.ShowDialog();
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
        /// Altera salário de <see cref="Funcionario"/> no <see cref="FuncionarioRepository"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAlterarSalarioFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                var id = Convert.ToInt32(textIdSlarioFuncionario.Text);
                var salario = Convert.ToDecimal(textSalarioFuncionario.Text);
                var repoFuncionario = new FuncionarioRepository();
                (var existe, var salarioAntigo) = repoFuncionario.AlteraSalarioRepository(id, salario);
                if (existe)
                {
                    MessageBox.Show($"O funcionário com id: {id} teve seu salário alterado de {salarioAntigo} para {salario}.");
                    ApagaTextBoX();
                }
                else
                {
                    MessageBox.Show($"Funcionário não encontrado!");
                }
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
        /// Recupera detalhes do <see cref="Funcionario"/> no <see cref="FuncionarioRepository"/> quando ele existe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnExibeDetalhesFuncionario_Click(object sender, EventArgs e)
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
        public void PopulaExibeDetalhe(Funcionario funcionario)
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
        // FIM ------------------------------------ FUNCIONARIOS ------------------------------------ FIM //
        // INICIO ------------------------------------ PRODUTO ------------------------------------ INICIO //
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
                    ApagaTextBoX();
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
                        correto = CSVIsMatch(linha, "produto");
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
                ApagaTextBoX();
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
                                $"de: {valorAnterior} para {produto.Valor}");
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
                ApagaTextBoX();
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
            try
            {

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
                layoutLista[i] = new LayoutProdutos();
                layoutLista[i].Nome = lista[i].Nome;
                layoutLista[i].Id = lista[i].Id.ToString();
                layoutLista[i].Peso = $"{lista[i].Peso}g";
                layoutLista[i].Estoque = lista[i].Estoque.ToString();
                layoutLista[i].Valor = $"R$ {lista[i].Valor}";
                layoutLista[i].Tipo = lista[i].Tipo;
                layoutLista[i].Vendas = lista[i].QuantidadeDeVendas.ToString();

                if (flowLayoutLayoutExibeProdutos.Controls.Count < 0)
                {
                    flowLayoutLayoutExibeProdutos.Controls.Clear();
                }
                flowLayoutLayoutExibeProdutos.Controls.Add(layoutLista[i]);
            }
        }
        // FIM ------------------------------------ PRODUTO ------------------------------------ FIM //
        // INICIO ---------------------------------- VENDAS ---------------------------------- INICIO //
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
        /// Remove <see cref="Produto"/> do texBox de Venda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoverVenda_Click(object sender, EventArgs e)
        {
            try
            {
                if (_addProdVenda > 0)
                {
                    var id = Convert.ToInt32(textIdRemoverVenda.Text);
                    var linhas = textProdVendas.Text.Replace("\r\n", "\n").Replace("\n", "\n").Replace("\r", "\n").Split('\n');
                    var listaLinha = new List<string>();
                    var contador = -1;

                    for (int i = 0; i < linhas.Length - 1; i++)
                    {
                        var textoId = linhas[i].Split('|');
                        if (id == Convert.ToInt32(textoId[1]))
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
                var entradaFuncionarioId = textIdVendasCadastro.Text.Split('|');
                var funcionarioId = entradaFuncionarioId[0];
                var conflito = false;
                var valorTotal = 0m;
                var data = DateTime.Now;

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
                    if (existeFuncionario)
                    {
                        // Verifica estoque
                        for (int i = 0; i < vendas.Length - 1; i++)
                        {
                            var linha = vendas[i].Split('|');
                            var qtdProdutos = Convert.ToInt32(linha[0]);
                            (var exProd, var produto) = repoProduto.GetDetalhes(linha[1]);
                            if (qtdProdutos > produto.Estoque || !exProd)
                            {
                                MessageBox.Show($"Impossível cadastrar a compra o produto abaixo possuí estoque insuficiente!\n" +
                                    $"{produto.Nome} | ID: {produto.Id} | Estoque: {produto.Estoque}\n" +
                                    $"Quantidade tentada: {qtdProdutos}");
                                conflito = true;
                                break;
                            }
                            else
                            {
                                listaProdVendas.Add(new Tuple<int, Produto>(qtdProdutos, produto));
                            }
                        }
                        if (!conflito)
                        {
                            foreach (var item in listaProdVendas)
                            {
                                (var qtd, var prod) = item;
                                valorTotal += qtd * prod.Valor;
                                var diminuiEstoque = $"-{qtd}";
                                // Altera estoque de produtos
                                repoProduto.AlteraEstoqueRepository(prod.Id, Convert.ToInt32(diminuiEstoque));
                            }
                            var venda = new Venda(funcionario, listaProdVendas, valorTotal, data);
                            repoVendas.IncluirUnico(venda);
                            _addProdVenda = 0;
                            MessageBox.Show("Cadastro concluído!");
                            ApagaTextBoX();
                        }
                    }
                    else
                        MessageBox.Show("Funcionário não encontrado na base de dados!");
                }
                else
                    MessageBox.Show("Favor informar os produtos e quantidades!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Favor inserir funcionário!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                        correto = CSVIsMatch(linha, "vendas");
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
                        tratamentoArquivo.IncluirVarios(inseridos);
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
                ApagaTextBoX();
            }
        }
        /// <summary>
        /// Insere dados na lista de vendas em um DataGrid
        /// </summary>
        private void PopulaListaVendas()
        {
            var repoVendas = new VendaRepository();
            var listaVendas = repoVendas.GetLista();
            DesignDataGrid();
            foreach (var venda in listaVendas)
            {
                var qtdTotal = 0;
                var produtos = repoVendas.GetDetalhesVenda(venda.VendaId);
                foreach (var produto in produtos)
                {
                    var dados = produto.Split('|');
                    var qtd = Convert.ToInt32(dados[0].Remove(0, dados[0].IndexOf(':') + 1));
                    qtdTotal += qtd;
                }
                var id = $"{venda.VendaId}";
                var descricao = $"Venda por {venda.VendedorNome}, id: {venda.VendedorId}, quantidade de produtos: {qtdTotal}";
                var valor = $"{venda.Valor}";
                var data = venda.DataVenda.ToShortDateString();
                dataGridVendasBindingSource.Add(new DataGridVendas() { Id = id, Descricao = descricao, Valor = valor, Data = data, BtnText = "+" });
            }
            dataGridViewVendas.Visible = true;
        }
        /// <summary>
        /// Exibe ou apaga detalhes do DataGrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewVendas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    var index = -1;
                    //Remove detalhes
                    if (dataGridViewVendas.Rows[e.RowIndex].Cells[4].Value.ToString() == "-" && dataGridViewVendas.Columns[e.ColumnIndex].HeaderText == "+")
                    {
                        index = dataGridViewVendas.Rows[e.RowIndex].Index;
                        var contador = index;
                        while (contador + 1 < dataGridViewVendas.Rows.Count)
                        {
                            if (dataGridViewVendas.Rows[index + 1].Index == dataGridViewVendas.Rows.Count)
                            {
                                break;
                            }
                            else
                            {
                                if (dataGridViewVendas.Rows[index + 1].Cells[0].Value.ToString() == "")
                                {
                                    dataGridViewVendas.Rows.RemoveAt(index + 1);
                                }
                                else
                                    break;
                            }
                        }
                        dataGridViewVendas.Rows[index].Cells[4].Value = "+";
                        goto SkipToEnd;
                    }
                    //Exibe detalhes
                    if (dataGridViewVendas.Rows[e.RowIndex].Cells[4].Value.ToString() == "+" && dataGridViewVendas.Columns[e.ColumnIndex].HeaderText == "+")
                    {
                        var id = dataGridViewVendas.Rows[e.RowIndex].Cells[0].Value.ToString();
                        index = dataGridViewVendas.Rows[e.RowIndex].Index + 1;
                        var descricao = dataGridViewVendas.Rows[e.RowIndex].Cells[1].Value.ToString();
                        dataGridViewVendas.Rows[e.RowIndex].Selected = true;

                        // Replace na venda clicada "-"
                        dataGridViewVendas.Rows[index - 1].Cells[4].Value = "-";
                        PopulaDetalhesBtn(id, index, descricao);
                        goto SkipToEnd;
                    }
                    else
                    {
                        goto SkipToEnd;
                    }
                }
            SkipToEnd:;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Carrega a lista para exibição do datagrid em tela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCarregaListaVendas_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewVendas.Rows.Clear();
                PopulaListaVendas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Define parametros de colunas e outras informações de design para o DataGridVendas
        /// </summary>
        private void DesignDataGrid()
        {
            dataGridViewVendas.ColumnHeadersDefaultCellStyle.Font = new Font("Lato", 10, FontStyle.Bold);
            dataGridViewVendas.ColumnHeadersHeight = 30;
            dataGridViewVendas.Columns[0].Width = 30;
            dataGridViewVendas.Columns[0].CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewVendas.Columns[1].Width = 410;
            dataGridViewVendas.Columns[2].Width = 70;
            dataGridViewVendas.Columns[2].CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewVendas.Columns[3].Width = 100;
            dataGridViewVendas.Columns[3].CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewVendas.Columns[4].Width = 30;
            dataGridViewVendas.Columns[4].CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        /// <summary>
        /// Popula as linhas de detalhes de cada venda
        /// </summary>
        /// <param name="idVenda"></param>
        /// <param name="index"></param>
        /// <param name="descricao"></param>
        private void PopulaDetalhesBtn(string idVenda, int index, string descricao)
        {
            var repovendas = new VendaRepository();
            var produtos = repovendas.GetDetalhesVenda(idVenda);
            // Detalhes adicionados
            foreach (var produto in produtos)
            {
                var dados = produto.Split('|');
                var descricaoProd = $"{dados[0]} | {dados[1]} | {dados[2]}";
                var valorProd = $"{dados[3].Remove(0, dados[3].IndexOf(':') + 1)}";
                dataGridVendasBindingSource
                    .Insert(index, new DataGridVendas() { Id = "", Descricao = descricaoProd, Valor = valorProd, Data = "", BtnText = "" });
                dataGridViewVendas.Rows[index].DefaultCellStyle.BackColor = Color.FromArgb(235, 167, 101);
            }
        }
        // FIM ---------------------------------- VENDAS ---------------------------------- FIM //
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
            flowLayoutPanelFuncionario.Controls.Clear();
            TituloExibeFuncionario.Visible = false;
            panelQuantidadeProduto.Visible = false;
            panelNovoValorProduto.Visible = false;
            flowLayoutLayoutExibeProdutos.Controls.Clear();
            tituloExibeProdutos.Visible = false;
        }
        /// <summary>
        /// Deixa telas dos submenus não vísiveis ao iniciar a aplicação
        /// </summary>
        private void TelasDesign()
        {
            panelCadastrarFuncionario.Visible = false;
            panelRemoverFuncionario.Visible = false;
            panelConsultarFuncionario.Visible = false;
            panelInserirProduto.Visible = false;
            panelEstoqueProduto.Visible = false;
            panelExibirProdutos.Visible = false;
            panelCadastrarVendas.Visible = false;
            panelConsultaVendas.Visible = false;
            dataGridViewVendas.Visible = false;
        }
        /// <summary>
        /// Esconde uma tela enquanto outra estiver ativa
        /// </summary>
        private void EsconderTelas()
        {
            if (panelCadastrarFuncionario.Visible == true)
                panelCadastrarFuncionario.Visible = false;
            if (panelRemoverFuncionario.Visible == true)
                panelRemoverFuncionario.Visible = false;
            if (panelConsultarFuncionario.Visible == true)
                panelConsultarFuncionario.Visible = false;
            if (panelInserirProduto.Visible == true)
                panelInserirProduto.Visible = false;
            if (panelEstoqueProduto.Visible == true)
                panelEstoqueProduto.Visible = false;
            if (panelExibirProdutos.Visible == true)
                panelExibirProdutos.Visible = false;
            if (panelCadastrarVendas.Visible == true)
                panelCadastrarVendas.Visible = false;
            if (panelConsultaVendas.Visible == true)
            {
                panelConsultaVendas.Visible = false;
                dataGridViewVendas.Visible = false;
                dataGridViewVendas.Rows.Clear();
            }
        }
        /// <summary>
        /// Mostra uma tela ao ser invocada ou a esconde caso já esteja vísivel
        /// </summary>
        /// <param name="telas">Objeto do tipo <see cref="Panel"/> que refere a uma tela invocada por botão de submenu</param>
        public void MostrarTelas(Panel telas)
        {
            if (telas.Visible == false)
            {
                panelLogoPrincipal.Visible = false;
                ApagaTextBoX();
                EscondeTextoDetalhes();
                EsconderTelas();
                telas.Visible = true;
            }
            else
                telas.Visible = false;
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
            MostrarTelas(panelCadastrarFuncionario);
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
            MostrarTelas(panelRemoverFuncionario);
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
            MostrarTelas(panelConsultarFuncionario);
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
            MostrarTelas(panelInserirProduto);
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
            MostrarTelas(panelEstoqueProduto);
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
            MostrarTelas(panelExibirProdutos);
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
            CarregaComboBoxProduto();
            EsconderTelas();
            MostrarTelas(panelCadastrarVendas);
            EsconderSubMenu();
            _addProdVenda = 0;
            textProdVendas.ReadOnly = true;
            textProdVendas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        }
        /// <summary>
        /// Botão do submenu CONSULTAR do MENU VENDAS que invoca painel Lista de Vendas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConsultarVendas_Click(object sender, EventArgs e)
        {
            EsconderTelas();
            MostrarTelas(panelConsultaVendas);
            EsconderSubMenu();
        }
        // FIM ------------------------------------ SUBMENU VENDAS ------------------------------------ FIM //
        // INICIO ------------------------------------ TEXTBOX ------------------------------------ INICIO //
        /// <summary>
        /// Apaga conteudo de todas as textbox inseridas quando invocado
        /// </summary>
        private void ApagaTextBoX()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };
            func(Controls);
            ApagaComboBox();
        }
        private void ApagaComboBox()
        {
            textTipoProduto.Text = "";
            comboBoxCargo.Text = "";
            comboBoxOrdenar.Text = "";
            textTipoProduto.Text = "";
            comboBoxOpcaoProdutos.Text = "";
            comboBoxOrdemProdutos.Text = "";
            cboProduto1.Text = "";
        }
        /// <summary>
        /// Permite apenas numeros na textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnlyNumbers(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!Char.IsDigit(c) && c != 8)
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// Permite apenas letras e "-" no textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnlyChars(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (Char.IsDigit(c) && c != 8 && c != 45)
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// Alterar formato de caracteres do CPF para inserção correta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BoxCPF(object sender, KeyPressEventArgs e)
        {
            var posicao = textBoxCpf.SelectionStart;
            char c = e.KeyChar;
            if (!Char.IsDigit(c) && c != 8)
            {
                e.Handled = true;
            }
            else if (c == 8) posicao--;
            else if (posicao == 3 && c != 8 || posicao == 7 && c != 8)
            {
                textBoxCpf.Text = textBoxCpf.Text.Insert(posicao, ".");
                textBoxCpf.SelectionStart = posicao + 1;

            }
            else if (posicao == 11 && c != 8)
            {
                textBoxCpf.Text = textBoxCpf.Text.Insert(posicao, "-");
                textBoxCpf.SelectionStart = posicao + 1;
            }
        }
        /// <summary>
        /// Formata o box para o celular contato padrao
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BoxContato(object sender, KeyPressEventArgs e)
        {
            var posicao = textBoxContato.SelectionStart;
            char c = e.KeyChar;
            if (!Char.IsDigit(c) && c != 8)
            {
                e.Handled = true;
            }
            else if (c == 8) posicao--;
            else if (posicao == 0 && c != 8)
            {
                textBoxContato.Text = textBoxContato.Text.Insert(posicao, "(");
                textBoxContato.SelectionStart = posicao + 1;
            }
            else if (posicao == 3 && c != 8)
            {
                textBoxContato.Text = textBoxContato.Text.Insert(posicao, ")");
                textBoxContato.SelectionStart = posicao + 1;
            }
            else if (posicao == 9 && c != 8)
            {
                textBoxContato.Text = textBoxContato.Text.Insert(posicao, "-");
                textBoxContato.SelectionStart = posicao + 1;
            }
        }
        /// <summary>
        /// Formata o box para o valor em dinheiro padrão
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BoxValor(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar.Equals((char)Keys.Back))
            {
                TextBox t = (TextBox)sender;
                if (t.Text.Length < 9 || e.KeyChar.Equals((char)Keys.Back))
                {
                    string w = Regex.Replace(t.Text, "[^0-9]", string.Empty);
                    if (w == string.Empty) w = "00";

                    if (e.KeyChar.Equals((char)Keys.Back))
                        w = w.Substring(0, w.Length - 1);
                    else
                        w += e.KeyChar;
                    t.Text = string.Format("{0:#,##0.00}", double.Parse(w) / 100);
                    t.Select(t.Text.Length, 0);
                }
                else e.Handled = true;
            }
            e.Handled = true;
        }
        /// <summary>
        /// Dialogo para selecionar arquivo para cadastro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenFile(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            tb.Text = file.FileName;
            tb.Text = file.FileName;
        }
        /// <summary>
        /// Recebe arquivo CSV e verifica se está no padrão correto
        /// </summary>
        /// <param name="linha"></param>
        /// <param name="caso"></param>
        /// <returns>Retorna bool para correto ou incorreto</returns>
        private bool CSVIsMatch(string linha, string caso)
        {
            var patternID = @"^\s*[0-9]{1,3}\s*$";
            var patternData = @"^\s*[0-9]{1,2}[/][0-9]{1,2}[/][0-9]{4}\s*$";
            var patternValor = @"^\s*[0-9]{1,5}[,][0-9]{2}\s*$";
            var patternTxt = @"^[A-Za-zÀ-ú\s]{1,150}$";
            switch (caso)
            {
                case "funcionario":
                    var splitFuncionario = linha.Split(';');
                    var patternCPF = @"^[\s]?[0-9]{3}[\.]?[0-9]{3}[\.]?[0-9]{3}[\-]?[0-9]{2}[\s]?$";
                    var patternContato = @"^[\s]?[\(]?[0-9]{2}[\)]?[0-9]{4,5}[\-]?[0-9]{4}[\s]?$";
                    if (!Regex.IsMatch(splitFuncionario[0], patternID) ||
                        !Regex.IsMatch(splitFuncionario[1], patternTxt) ||
                        !Regex.IsMatch(splitFuncionario[2], patternCPF) ||
                        !Regex.IsMatch(splitFuncionario[3], patternContato) ||
                        !Regex.IsMatch(splitFuncionario[4], patternValor) ||
                        !Regex.IsMatch(splitFuncionario[5], patternTxt) ||
                        !Regex.IsMatch(splitFuncionario[6], patternData))
                    {
                        return false;
                    }
                    else
                        return true;
                case "produto":
                    var splitProduto = linha.Split(';');
                    var patternCodProd = @"^[\s]?[0-9]{12}[\s]?$";
                    var patternEstoque = @"^[\s]?[0-9]{1,4}[\s]?$";
                    var patternTxtProd = @"^.{1,150}$";

                    if (!Regex.IsMatch(splitProduto[0], patternCodProd) ||
                        !Regex.IsMatch(splitProduto[1], patternTxtProd) ||
                        !Regex.IsMatch(splitProduto[2], patternID) ||
                        !Regex.IsMatch(splitProduto[3], patternValor) ||
                        !Regex.IsMatch(splitProduto[4], patternTxt) ||
                        !Regex.IsMatch(splitProduto[5], patternEstoque))
                    {
                        return false;
                    }
                    return true;
                case "vendas":
                    var splitVenda = linha.Split(';');
                    var patternProduto = @"^[\s]?[0-9]{12}[|][0-9]{12}[\s]?$";
                    var contador = 1;
                    var listaIdProduto = new List<int>();
                    var correto = false;
                    if (!Regex.IsMatch(splitVenda[0], patternID))
                    {
                        return correto;
                    }
                    else
                    {
                        while (contador < splitVenda.Length - 1)
                        {
                            var vendaProduto = splitVenda[contador].Split('|');
                            if (!Regex.IsMatch(splitVenda[contador], patternProduto))
                            {
                                correto = false;
                                break;
                            }
                            var idProduto = Convert.ToInt32(vendaProduto[1]);
                            if (listaIdProduto.Contains(idProduto))
                            {
                                correto = false;
                                break;
                            }
                            else
                            {
                                correto = true;
                                listaIdProduto.Add(idProduto);
                                contador++;
                            }
                        }
                        if (correto)
                        {
                            if (!Regex.IsMatch(splitVenda[splitVenda.Length - 1], patternData))
                            {
                                correto = false;
                                return correto;
                            }
                            else
                                return correto;
                        }
                        return correto;
                    }
                default:
                    return false;
            }
        }
        // INICIO ------------------------------------ FIM ------------------------------------ INICIO //
    }
}
