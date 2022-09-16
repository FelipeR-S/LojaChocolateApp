using LojaChocolateApp.Repository;
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

namespace LojaChocolateApp.Utils.Popups
{
    public partial class PopupConfig : Form
    {
        private string _user;
        private bool _darkMode;
        private bool _controleEstoque;
        private int _quantidadeEstoque = 0;
        public PopupConfig(string user)
        {
            _user = user;
            InitializeComponent();
            panelQuantidade.Visible = false;
            GetConfigs();
        }
        /// <summary>
        /// Faz aparece ou sumir combobox de valores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxEstoque_CheckedChanged(object sender, EventArgs e)
        {
            if (panelQuantidade.Visible == false)
                panelQuantidade.Visible = true;
            else
                panelQuantidade.Visible = false;
        }
        /// <summary>
        /// Salva configurações na database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAplicar_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBoxDarkMode.Checked == true)
                    _darkMode = true;
                if (checkBoxDarkMode.Checked == false)
                    _darkMode = false;
                if (checkBoxEstoque.Checked == true)
                {
                    _controleEstoque = true;
                    _quantidadeEstoque = Convert.ToInt32(comboBoxAvisoEstoque.Text);
                }
                if (checkBoxEstoque.Checked == false)
                {
                    _controleEstoque = false;
                    _quantidadeEstoque = 0;
                }
                using (SqlConnection connection = new SqlConnection(SQLServerConn.StrCon))
                {
                    connection.Open();
                    var sqlQuery = $"update [dbo].[Configurações] set[DarkMode] = '{_darkMode}', [Aviso Estoque] = '{_controleEstoque}', [Limite Estoque] = {_quantidadeEstoque} where[User] = '{_user}'";
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandType = CommandType.Text;
                        command.CommandText = sqlQuery;
                        int recordsAffected = command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
                MessageBox.Show("Configurações salvas!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void GetConfigs()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SQLServerConn.StrCon))
                {
                    connection.Open();
                    var sqlQuery = $"use [Loja_Chocolate] select [DarkMode], [Aviso Estoque], [Limite Estoque] from [Configurações] where [User] = '{_user}'";
                    SqlCommand cmd = new SqlCommand(sqlQuery, connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        _darkMode = reader.GetBoolean(0);
                        _controleEstoque = reader.GetBoolean(1);
                        if (_controleEstoque == true)
                            _quantidadeEstoque = Convert.ToInt32(reader.GetValue(2));
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void PopupConfig_Load(object sender, EventArgs e)
        {
            if (_darkMode == true)
                checkBoxDarkMode.Checked = true;
            if (_darkMode == false)
                checkBoxDarkMode.Checked = false;
            if (_controleEstoque == true)
            {
                var posição = -1;
                switch (_quantidadeEstoque)
                {
                    case 5:
                        posição = 0;
                        break;
                    case 10:
                        posição = 1;
                        break;
                    case 15:
                        posição = 2;
                        break;
                    default:
                        posição = -1;
                        break;
                }
                checkBoxEstoque.Checked = true;
                comboBoxAvisoEstoque.SelectedIndex = posição;
            }
        }
    }
}
