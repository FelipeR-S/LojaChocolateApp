using LojaChocolateApp.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaChocolateApp.Model
{
    public class Produto
    {
        private string _id;
        private string _nome;
        private decimal _peso;
        private decimal _valor;
        private string _tipo;
        private int _estoque;
        private int _quantidadeDeVendas { get => GetQuantidadeDeVendas(); }
        public string Id { get { return _id; } private set { } }
        public string Nome { get { return _nome; } private set { } }
        public decimal Peso { get { return _peso; } private set { } }
        public decimal Valor { get { return _valor; } private set { } }
        public string Tipo { get { return _tipo; } private set { } }
        public int Estoque { get { return _estoque; } private set { } }
        public int QuantidadeDeVendas { get => _quantidadeDeVendas; }

        public Produto(string id, string nome, decimal peso, decimal valor, string tipo, int estoque)
        {
            _id = id;
            _nome = nome;
            _peso = peso;
            _valor = valor;
            _tipo = tipo;
            _estoque = estoque;
        }
        /// <summary>
        /// Retorna o valor do <see cref="Produto.QuantidadeDeVendas"/>
        /// </summary>
        /// <returns></returns>
        private int GetQuantidadeDeVendas()
        {
            var vendasId = 0;
            using (SqlConnection connection = new SqlConnection(SQLServerConn.StrCon))
            {
                connection.Open();
                var sqlQuery = $"select [produto codigo], sum(quantidade) as qtd from Vendas_Itens where [Produto Codigo] = '{this.Id}' group by[produto codigo]";
                SqlCommand cmd = new SqlCommand(sqlQuery, connection);
                SqlDataReader srd = cmd.ExecuteReader();
                while (srd.Read())
                {
                    vendasId = Convert.ToInt32($"{srd.GetValue(1)}");
                }
                connection.Close();
            }
            return vendasId;
        }
    }
}
