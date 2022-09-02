using LojaChocolateApp.Repository;
using LojaChocolateApp.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaChocolateApp
{
    public partial class CadastroLogin : Form
    {
        private static TextBoxControls _controle = new TextBoxControls();
        private static string _databaseCadastro = $"Data Source = {Environment.MachineName}; Integrated Security = false; Initial Catalog = Loja_Chocolate; User ID = Cadastro; Password=cadastro";

        public CadastroLogin()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Fecha a janela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Envia dados para tabela de cadastro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                var matricula = txtMatriculaCadastro.Text;
                var nome = txtNomeCadastro.Text;
                var senha = txtSenha2Cadastro.Text;
                var cpf = txtCPFCadastro.Text;
                var CadastroString = "";
                using (SqlConnection connection = new SqlConnection(_databaseCadastro))
                {
                    connection.Open();
                    var sqlQuery = $"SELECT [Matricula], [Nome], [CPF] FROM [Cadastro de Usuário] WHERE [Matricula] = '{matricula}' or [Nome] = '{nome}' or [CPF] = '{cpf}'";
                    SqlCommand cmd = new SqlCommand(sqlQuery, connection);
                    SqlDataReader srd = cmd.ExecuteReader();
                    while (srd.Read())
                    {
                        CadastroString = $"{srd.GetValue(0)};{srd.GetValue(1)};{srd.GetValue(2)}";
                    }
                    connection.Close();
                }
                if (CadastroString == String.Empty)
                {
                    if (matricula == String.Empty || nome == String.Empty || cpf == String.Empty || senha == String.Empty)
                        MessageBox.Show($"Todos os campos devem ser preenchidos.");
                    else if (senha != txtSenha1Cadastro.Text)
                        MessageBox.Show($"A senha deve ser igual nos dois campos.");
                    else
                    {
                        using (SqlConnection connection = new SqlConnection(_databaseCadastro))
                        {
                            connection.Open();
                            SqlCommand cmd = new SqlCommand("InsereCadastro", connection);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@matricula", matricula);
                            cmd.Parameters.AddWithValue("@nome", nome);
                            cmd.Parameters.AddWithValue("@CPF", cpf);
                            cmd.Parameters.AddWithValue("@senha", senha);
                            SqlDataReader rdr = cmd.ExecuteReader();
                            connection.Close();
                        }
                        MessageBox.Show("Cadastro concluído!");
                        this.Close();
                    }
                }
                else
                    MessageBox.Show("Dados inseridos já foram cadastrados no sistema.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void OnlyNumbers(object sender, KeyPressEventArgs e)
        {
            _controle.OnlyNumbers(sender, e);
        }
        private void OnlyChars(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            TextBox t = (TextBox)sender;
            if (e.KeyChar == 3)
                t.Copy();
            if (e.KeyChar == 22)
            {
                t.Paste();
                if (!Regex.IsMatch(t.Text, @"^[A-Za-z0-9]*$"))
                {
                    MessageBox.Show("Formato incorreto.");
                    t.Text = string.Empty;
                }
            }
            if (e.KeyChar == 24)
                t.Cut();
            if (e.KeyChar == 26)
                t.Undo();
            if (e.KeyChar == 1)
                t.SelectAll();
            if (!Regex.IsMatch(c.ToString(), @"^[A-Za-z0-9]*$") && e.KeyChar != 8)
                e.Handled = true;
        }
        private void BoxCPF(object sender, KeyPressEventArgs e)
        {
            _controle.BoxCPF(sender, e);
        }
        private void CopiarSelecionar(object sender, KeyEventArgs e)
        {
            _controle.CopiarSelecionar(sender, e);
        }
        private void txtSenha2Cadastro_Leave(object sender, EventArgs e)
        {
            if (txtSenha2Cadastro.Text != txtSenha1Cadastro.Text)
                MessageBox.Show("A senha deve ser igual nos dois campos.");
        }
    }
}
