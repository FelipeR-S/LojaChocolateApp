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
    public partial class CadastrarFuncionario : UserControl
    {
        private TextBoxControls _controle = new TextBoxControls();
        public CadastrarFuncionario(bool darkMode)
        {
            InitializeComponent();
            DarkMode activeDarkMode = new DarkMode(darkMode);
            activeDarkMode.GetDarkMode(this);
        }
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
                        _controle.ApagaBox(this);
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
                        correto = _controle.CSVIsMatch(linha, "funcionario");
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
                _controle.ApagaBox(this);
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
        private void OnlyNumbers(object sender, KeyPressEventArgs e)
        {
            _controle.OnlyNumbers(sender, e);
        }
        private void OnlyChars(object sender, KeyPressEventArgs e)
        {
            _controle.OnlyChars(sender, e);
        }
        private void BoxCPF(object sender, KeyPressEventArgs e)
        {
            _controle.BoxCPF(sender, e);
        }
        private void BoxContato(object sender, KeyPressEventArgs e)
        {
            _controle.BoxContato(sender, e);
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
        private void textBoxArquivo_KeyUp(object sender, KeyEventArgs e)
        {
            _controle.CopiarSelecionar(sender, e);
            if (e.KeyData == Keys.Enter)
                _controle.OpenFile(sender, e);
        }
    }
}
