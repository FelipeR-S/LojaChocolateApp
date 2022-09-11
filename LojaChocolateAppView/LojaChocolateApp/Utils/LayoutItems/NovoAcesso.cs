using LojaChocolateApp.Repository;
using LojaChocolateApp.Utils.Panels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaChocolateApp.Utils.LayoutItems
{
    public partial class NovoAcesso : UserControl
    {
        static private TextBoxControls _controle = new TextBoxControls();
        #region Propriedades
        private string _nome;
        private string _matricula;
        private string _cpf;
        private string _user;

        [Category("Custom Props")]
        public string Nome { get { return _nome; } set { _nome = value; txtNome.Text = value; } }
        [Category("Custom Props")]
        public string Matricula { get { return _matricula; } set { _matricula = value; txtMatricula.Text = value; } }
        [Category("Custom Props")]
        public string Cpf { get { return _cpf; } set { _cpf = value; txtCpf.Text = value; } }
        [Category("Custom Props")]
        public string User { get { return _user; } set { _user = value; txtUser.Text = value; } }
        #endregion
        public NovoAcesso()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Exclui user da tabela de solicitação e nega cadastro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNegar_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(SQLServerConn.StrCon))
            {
                connection.Open();
                var matricula = txtMatricula.Text;
                var SQLQuery = $"DELETE FROM [dbo].[Cadastro de Usuário] WHERE [Matricula] = '{matricula}'";
                SqlCommand cmd = new SqlCommand(SQLQuery, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                connection.Close();
            }
            MessageBox.Show("Cadastro Removido!");
            Controls.Clear();
            this.Height = 0;
        }
        /// <summary>
        /// Cria login de acesso através da tabela de cadastros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPermitir_Click(object sender, EventArgs e)
        {
            var cargo = comboBoxCargo.Text;
            var matricula = txtMatricula.Text;
            if (cargo != String.Empty)
            {
                using (SqlConnection connection = new SqlConnection(SQLServerConn.StrCon))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("NovoAcesso", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@matricula", matricula);
                    cmd.Parameters.AddWithValue("@Cargo", cargo);
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        int recordsAffected = cmd.ExecuteNonQuery();
                    }
                    connection.Close();
                }
                MessageBox.Show("Cadastro Concluído!");
                Controls.Clear();
                this.Height = 0;
            }
            else
                MessageBox.Show("Favor selecionar um cargo.");
        }
        private void CopiarSelecionar(object sender, KeyEventArgs e)
        {
            _controle.CopiarSelecionar(sender, e);
        }
    }
}
