using LojaChocolateApp.Repository;
using LojaChocolateApp.Utils;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaChocolateApp
{
    public partial class LoginLoja : Form
    {
        private TextBoxControls _controle = new TextBoxControls();
        private static CadastroLogin _cadastro = new CadastroLogin();
        public LoginLoja()
        {
            InitializeComponent();
            CarregaComboBoxDatabase();
        }
        /// <summary>
        /// Carrega instancias do SQL Server
        /// </summary>
        private void CarregaComboBoxDatabase()
        {
            try
            {
                var listaDatabase = new List<string>();
                var database = "";
                listaDatabase.Add(database);

                string ServerName = Environment.MachineName;
                RegistryView registryView = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;
                using (RegistryKey hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registryView))
                {
                    RegistryKey instanceKey = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", false);
                    if (instanceKey != null)
                    {
                        foreach (var instanceName in instanceKey.GetValueNames())
                        {
                            database = ServerName + "\\" + instanceName;
                            listaDatabase.Add(database);
                        }
                    }
                }
                comboBoxDatabase.DataSource = listaDatabase;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// Realiza tentativa de login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                _cadastro.Close();
                var conectado = false;
                var databaseTxt = comboBoxDatabase.SelectedItem.ToString();
                var login = textBoxUser.Text;
                var senha = textBoxSenha.Text;
                var cargo = "";

                if (login == "" || senha == "" || databaseTxt == "")
                {
                    MessageBox.Show("Favor Preencher todas as informações!");
                }
                else
                {
                    var database = databaseTxt.Remove(databaseTxt.IndexOf('\\'));
                    var LoginServer = new SQLServerConn(database, login, senha);
                    using (SqlConnection connection = new SqlConnection(LoginServer.Conexao(login)))
                    {
                        connection.Open();
                        var SqlQuery = $"use [Loja_Chocolate] select [cargo] from [Cadastro de Usuário] where [Nome] = '{login}'";
                        SqlCommand cmd = new SqlCommand(SqlQuery, connection);
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            cargo = reader.GetString(0);
                        }
                        conectado = true;
                        connection.Close();
                    }
                    if (conectado == true)
                    {
                        this.Visible = false;
                        this.ShowInTaskbar = false;
                        AppLoja appLoja = new AppLoja(login, database, cargo);
                        appLoja.ShowDialog();
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("Falha de logon do usuário"))
                    MessageBox.Show("Usuário ou senha incorretos.\n Favor verificar!");
                else
                    MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Exibe painel de novo cadastro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkCadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                CadastroLogin cadastro = new CadastroLogin();
                _cadastro = cadastro;
                _cadastro.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoginLoja_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void OnlyNumbersAndChars(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnLogin_Click(sender, e);
            else
                _controle.OnlyNumbersAndChars(sender, e);
        }
        private void textBoxSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnLogin_Click(sender, e);
        }
    }
}
