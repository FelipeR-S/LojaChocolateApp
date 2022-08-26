using LojaChocolateApp.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaChocolateApp.Model
{
    public abstract class Funcionario
    {
        private string _id;
        private string _nome;
        private string _cpf;
        private string _contato;
        private decimal _salario;
        private string _cargo;
        private int _quantidadeDeVendas { get => GetQuantidadeDeVendas(); }
        private string _dataCadastro;
        public string Id { get { return _id; } private set { } }
        public string Nome { get { return _nome; } private set { } }
        public string Cpf { get { return _cpf; } private set { } }
        public string Contato { get { return _contato; } private set { } }
        public decimal Salario { get { return _salario; } private set { } }
        public string Cargo { get { return _cargo; } private set { } }
        public int QuantidadeDeVendas { get { return _quantidadeDeVendas; } private set { }  }
        public string DataCadastro { get { return _dataCadastro; } private set { } }

        public Funcionario(string id, string nome, string cpf, string contato, decimal salario, string cargo, string dataCadastro)
        {
            _id = id;
            _nome = nome;
            _cpf = cpf;
            _contato = contato;
            _salario = salario;
            _cargo = cargo;
            _dataCadastro = dataCadastro;
        }
        /// <summary>
        /// Atualiza o valor de <see cref="Funcionario.Salario"/>
        /// </summary>
        /// <param name="novoSalario"></param>
        public void AlteraSalario(decimal novoSalario)
        {
            _salario = novoSalario;
        }
        /// <summary>
        /// Retorna o valor de <see cref="Funcionario.QuantidadeDeVendas"/>
        /// </summary>
        /// <returns></returns>
        private int GetQuantidadeDeVendas()
        {
            var vendasId = 0;
            using (SqlConnection connection = new SqlConnection(SQLServerConn.StrCon))
            {
                connection.Open();
                var sqlQuery = $"select Count(*) from Funcionarios inner join Vendas_NF on Funcionarios.Matricula = Vendas_NF.[Vendedor Matricula] where matricula = '{this.Id}'";
                SqlCommand cmd = new SqlCommand(sqlQuery, connection);
                SqlDataReader srd = cmd.ExecuteReader();
                while (srd.Read())
                {
                    vendasId = Convert.ToInt32($"{srd.GetValue(0)}");
                }
                connection.Close();
            }
            return vendasId;
        }
    }
}
