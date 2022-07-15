using LojaChocolateApp.Model;
using LojaChocolateApp.Repository;
using LojaChocolateApp.Utils;
using LojaChocolateApp.Utils.Popups;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public AppLoja()
        {
            InitializeComponent();
            SubMenuDesign();
            TelasDesign();
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
                var verifica = new FuncionarioRepository();
                var id = Convert.ToInt32(textBoxId.Text);
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
                if (cpf.Length < 10)
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
                    (var existe, var msg) = verifica.Existente(novoFuncionario);
                    if (existe)
                    {
                        MessageBox.Show(msg);
                    }
                    else
                    {
                        var repo = new FuncionarioRepository();
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
                //ApagaTextBoX();
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

        // FIM ------------------------------------ FUNCIONARIOS ------------------------------------ FIM //
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
          panelCadastrarFuncionario.Visible = false;
          panelRemoverFuncionario.Visible = false;
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
           if (panelCadastrarFuncionario.Visible == true)
               panelCadastrarFuncionario.Visible = false;
           if (panelRemoverFuncionario.Visible == true)
               panelRemoverFuncionario.Visible = false;
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
           if (telas.Visible == false)
           {
              //panelLogoPrincipal.Visible = false;
              //ApagaTextBoX();
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
            var patternTxt = @"^[A-Za-zÀ-ú\s]*$";
            switch (caso)
            {
                case "funcionario":
                    var splitFuncionario = linha.Split(';');
                    var patternCPF = @"^\s*[0-9]{3}[.][0-9]{3}[.][0-9]{3}[-][0-9]{2}\s*$";
                    var patternContato = @"^\s*[0-9]{10,11}\s*$";
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
                    var patternEstoque = @"^\s*[0-9]{1,4}\s*$";
                    if (!Regex.IsMatch(splitProduto[0], patternID) ||
                        !Regex.IsMatch(splitProduto[1], patternTxt) ||
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
                    var patternProduto = @"^\s*[0-9]{1,3}[|][0-9]{1,3}\s*$";
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
