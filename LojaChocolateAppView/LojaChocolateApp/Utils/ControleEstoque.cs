using LojaChocolateApp.Model;
using LojaChocolateApp.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaChocolateApp.Utils
{
    public class ControleEstoque : Form
    {
        private bool _controleEstoque;
        private int _quantidadeEstoque;
        public ControleEstoque(bool controleEstoque, int quantidadeEstoque)
        {
            _controleEstoque = controleEstoque;
            _quantidadeEstoque = quantidadeEstoque;
        }
        /// <summary>
        /// Exibe mensagem de produtos com pouco estoque
        /// </summary>
        public void GetControleEstoque()
        {
            if (_controleEstoque == true)
            {
                var mensagem = "";
                var listaProdutos = new List<Produto>();
                using (SqlConnection connection = new SqlConnection(SQLServerConn.StrCon))
                {
                    connection.Open();
                    var sqlQuery = $"select [Codigo], [Nome], [Peso], [Valor], [Estoque], [Tipo] from [Produtos] where Estoque <= {_quantidadeEstoque}";
                    SqlCommand cmd = new SqlCommand(sqlQuery, connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var id = reader.GetValue(0).ToString();
                        var nome = reader.GetValue(1).ToString();
                        var peso = Convert.ToDecimal(reader.GetValue(2));
                        var valor = Convert.ToDecimal(reader.GetValue(3));
                        var estoque = Convert.ToInt32(reader.GetValue(4));
                        var tipo = reader.GetValue(5).ToString();
                        var produto = new Produto(id, nome, peso, valor, tipo, estoque);
                        listaProdutos.Add(produto);
                    }
                    connection.Close();
                }
                foreach (var produto in listaProdutos)
                {
                    mensagem += $"Produto: {produto.Nome} | {produto.Id} está com estoque baixo.\n" +
                        $"Estoque atual: {produto.Estoque}\n\n";
                }
                if (mensagem != "")
                    MessageBox.Show(mensagem);
            }
        }

    }
}
