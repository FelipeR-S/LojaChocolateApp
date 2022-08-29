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
        public AlteraFuncionario()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Invoca Popup para aceitar remoção do <see cref="Funcionario"/> do <see cref="FuncionarioRepository"/> caso ele exista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoverFuncionario_Click(object sender, EventArgs e)
        {
            Form background = new Form();
            var id = textBoxRemoverFuncionario.Text;
            try
            {
                var funcionarioRepo = new FuncionarioRepository();
                (var existe, var funcionario) = funcionarioRepo.GetDetalhes(id);
                if (existe)
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

    }
}
