using LojaChocolateApp.Repository;
using Microsoft.Win32;
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

namespace LojaChocolateApp
{
    public partial class LoginLoja : Form
    {
        private string _usuario;
        private string _password;
        private string _database;
        public string Usuario { get { return _usuario; } }
        public string Password { get { return _password; } }
        public string Database { get { return _database; } }
        public LoginLoja()
        {
            InitializeComponent();
            CarregaComboBoxDatabase();
        }
        /// <summary>
        /// Carrega instancias do SQL Server
        /// </summary>
        public void CarregaComboBoxDatabase()
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
        private void OnlyNumbersAndChars(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!Char.IsLetterOrDigit(c) && c != 8)
            {
                e.Handled = true;
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
                var databaseTxt = comboBoxDatabase.SelectedItem.ToString();
                var login = textBoxUser.Text;
                var senha = textBoxSenha.Text;

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
                        this.DialogResult = DialogResult.OK;
                        DadosLogin(database, login, senha);
                        connection.Close();
                    }
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Usuário ou senha incorretos.\n Favor verificar!");
            }
        }
        /// <summary>
        /// Recupera e atribui os dados de login
        /// </summary>
        /// <param name="database"></param>
        /// <param name="usuario"></param>
        /// <param name="senha"></param>
        private void DadosLogin(string database, string usuario, string senha)
        {
            _usuario = usuario;
            _password = senha;
            _database = database;
        }
    }
}
