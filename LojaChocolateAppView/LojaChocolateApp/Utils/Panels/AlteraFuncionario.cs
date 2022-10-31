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
    public partial class AlteraFuncionario : UserControl
    {
        private TextBoxControls _controle = new TextBoxControls();
        public AlteraFuncionario(bool darkMode)
        {
            InitializeComponent();
            DarkMode activeDarkMode = new DarkMode(darkMode);
            activeDarkMode.GetDarkMode(this);
        }
        /// <summary>
        /// Invoca Popup para aceitar remoção do <see cref="Funcionario"/> do <see cref="FuncionarioRepository"/> caso ele exista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoverFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                Form background = new Form();
                var id = textBoxRemoverFuncionario.Text;
                var funcionarioRepo = new FuncionarioRepository();
                (var existe, var funcionario) = funcionarioRepo.GetDetalhes(id);

                if (existe)
                {
                    /// Verifica se existe cadastro pendente
                    var sqlServer = new SQLServerConn();
                    var lista = sqlServer.GetListaCadastro();
                    var cadastroPendente = false;

                    foreach (var cadastro in lista)
                    {
                        var dados = cadastro.Split(';');
                        var idCadastro = dados[2];
                        if (idCadastro == id)
                        {
                            cadastroPendente = true;
                            break;
                        }
                    }

                    if (cadastroPendente)
                        MessageBox.Show("Usuário não pode ser excluído pois seu cadastro de login está pendente!");
                    else
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
                }
                else
                {
                    MessageBox.Show($"Funcionário com Matrícula nº {id} não encontrado.");
                }
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
        /// Altera salário de <see cref="Funcionario"/> no <see cref="FuncionarioRepository"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAlterarSalarioFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                var id = textIdSlarioFuncionario.Text;
                var salario = Convert.ToDecimal(textSalarioFuncionario.Text);
                var repoFuncionario = new FuncionarioRepository();
                (var existe, var salarioAntigo) = repoFuncionario.AlteraSalarioRepository(id, salario);
                if (existe)
                {
                    MessageBox.Show($"O funcionário com id: {id} teve seu salário alterado de {salarioAntigo.ToString("F2")} para {salario}.");
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
            finally
            {
                _controle.ApagaBox(this);
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
        private void CopiarSelecionar(object sender, KeyEventArgs e)
        {
            _controle.CopiarSelecionar(sender, e);
        }
    }
}
