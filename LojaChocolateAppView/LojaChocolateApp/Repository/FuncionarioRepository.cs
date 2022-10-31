using LojaChocolateApp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaChocolateApp.Repository
{
    public class FuncionarioRepository : IRepository<Funcionario>
    {
        /// <summary>
        /// Atributo para ordenar o metodo <see cref="Compare"/>
        /// </summary>
        private string _ordem { get; }
        public FuncionarioRepository()
        {
        }
        /// <summary>
        /// Construtor usado no metodo Sort() para ordenar lista
        /// </summary>
        /// <param name="ordem">Atributo que será ordenado</param>
        public FuncionarioRepository(string ordem)
        {
            _ordem = ordem;
        }
        public Funcionario ConverteAtributos(string linha)
        {
            var dados = linha.Split(';');
            var id = dados[0];
            var nome = dados[1];
            var cpf = dados[2];
            var contato = dados[3];
            var salario = Math.Round(Convert.ToDecimal(dados[4]), 2);
            var cargo = dados[5];
            // Converte Data Cadastro
            var date = Convert.ToDateTime(dados[6]);
            var dataCadastro = date.ToShortDateString();
            // Converte Data Cadastroa
            switch (cargo.ToLower())
            {
                case "vendedor":
                    return new Vendedor(id, nome, cpf, contato, salario, cargo, dataCadastro);
                case "gerente":
                    return new Gerente(id, nome, cpf, contato, salario, cargo, dataCadastro);
                default:
                    return new Vendedor(id, nome, cpf, contato, salario, cargo, dataCadastro);
            }
        }
        public (bool, string) Existente(Funcionario funcionario)
        {
            var existe = false;
            var stringSQLMatricula = "";
            var stringSQLCPF = "";
            using (SqlConnection connection = new SqlConnection(SQLServerConn.StrCon))
            {
                connection.Open();
                var sqlQuery = $"SELECT [Matricula], [CPF] FROM [dbo].[Funcionarios] WHERE [Matricula] = '{funcionario.Id}' or [CPF] = '{funcionario.Cpf}'";
                SqlCommand cmd = new SqlCommand(sqlQuery, connection);
                SqlDataReader srd = cmd.ExecuteReader();
                while (srd.Read())
                {
                    stringSQLMatricula = srd.GetValue(0).ToString();
                    stringSQLCPF = srd.GetValue(1).ToString();
                }
                connection.Close();
            }
            if (stringSQLMatricula == "" && stringSQLCPF == "")
            {
                return (existe, "");
            }
            else
            {
                if (stringSQLMatricula == funcionario.Id.ToString() && stringSQLCPF == funcionario.Cpf)
                {
                    existe = true;
                    return (existe, "ID e CPF já existem no cadastro!");
                }
                if (stringSQLMatricula == funcionario.Id.ToString())
                {
                    existe = true;
                    return (existe, "ID já existe no cadastro!");
                }
                else
                {
                    existe = true;
                    return (existe, "CPF já existe no cadastro!");
                }
            }
        }
        public (bool, Funcionario) GetDetalhes(string id)
        {
            Funcionario funcionario = null;
            var existe = false;
            var funcionarioString = "";

            using (SqlConnection connection = new SqlConnection(SQLServerConn.StrCon))
            {
                connection.Open();
                var sqlQuery = $"SELECT [Matricula], [Nome], [CPF], [Contato], [Salario], [Cargo], [Cadastro] FROM [dbo].[Funcionarios] WHERE [Matricula] = '{id}'";
                SqlCommand cmd = new SqlCommand(sqlQuery, connection);
                SqlDataReader srd = cmd.ExecuteReader();
                while (srd.Read())
                {
                    funcionarioString = $"{srd.GetValue(0)};{srd.GetValue(1)};{srd.GetValue(2)};{srd.GetValue(3)};{srd.GetValue(4)};{srd.GetValue(5)};{srd.GetValue(6)}";
                }
                connection.Close();
            }
            if (funcionarioString == "")
            {
                return (existe, funcionario);
            }
            else
            {
                existe = true;
                funcionario = ConverteAtributos(funcionarioString);
                return (existe, funcionario);
            }
        }
        public List<Funcionario> GetLista()
        {
            var lista = new List<Funcionario>();
            var funcionarioString = "";
            using (SqlConnection connection = new SqlConnection(SQLServerConn.StrCon))
            {
                connection.Open();
                var sqlQuery = $"SELECT [Matricula], [Nome], [CPF], [Contato], [Salario], [Cargo], [Cadastro] FROM [dbo].[Funcionarios]";
                SqlCommand cmd = new SqlCommand(sqlQuery, connection);
                SqlDataReader srd = cmd.ExecuteReader();
                while (srd.Read())
                {
                    funcionarioString = $"{srd.GetValue(0)};{srd.GetValue(1)};{srd.GetValue(2)};{srd.GetValue(3)};{srd.GetValue(4)};{srd.GetValue(5)};{srd.GetValue(6)}";
                    var funcionario = ConverteAtributos(funcionarioString);
                    lista.Add(funcionario);
                }
                connection.Close();
            }
            return lista;
        }
        public void IncluirUnico(Funcionario funcionario)
        {
            using (SqlConnection connection = new SqlConnection(SQLServerConn.StrCon))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "INSERT INTO[dbo].[Funcionarios] ([Matricula], [Nome], [CPF], [Contato], [Salario], [Cargo], [Cadastro]) VALUES(@Matricula, @Nome, @CPF, @Contato, @Salario, @Cargo, @Cadastro)";
                    command.Parameters.AddWithValue("@Matricula", funcionario.Id.ToString());
                    command.Parameters.AddWithValue("@Nome", funcionario.Nome);
                    command.Parameters.AddWithValue("@CPF", funcionario.Cpf);
                    command.Parameters.AddWithValue("@Contato", funcionario.Contato);
                    command.Parameters.AddWithValue("@Salario", funcionario.Salario.ToString().Replace(',', '.'));
                    command.Parameters.AddWithValue("@Cargo", funcionario.Cargo);
                    command.Parameters.AddWithValue("@Cadastro", funcionario.DataCadastro);

                    connection.Open();
                    int recordsAffected = command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        public void IncluirVarios(List<Funcionario> lista)
        {
            foreach (var funcionario in lista)
            {
                IncluirUnico(funcionario);
            }
        }
        public bool Remover(string id)
        {
            var existe = false;
            var stringSQLMatricula = "";
            using (SqlConnection connection = new SqlConnection(SQLServerConn.StrCon))
            {
                connection.Open();
                var sqlQuery = $"SELECT [Matricula] FROM [dbo].[Funcionarios] WHERE [Matricula] = '{id}'";
                SqlCommand cmd = new SqlCommand(sqlQuery, connection);
                SqlDataReader srd = cmd.ExecuteReader();
                while (srd.Read())
                {
                    stringSQLMatricula = srd.GetValue(0).ToString();
                }
                connection.Close();
            }

            if (stringSQLMatricula == "")
            {
                return existe;
            }
            else
            {
                existe = true;
                //Remove funcionário
                using (SqlConnection connection = new SqlConnection(SQLServerConn.StrCon))
                {
                    connection.Open();
                    SqlCommand cmdProcedure = new SqlCommand("sp_RemoveFuncionario", connection);
                    cmdProcedure.CommandType = CommandType.StoredProcedure;
                    cmdProcedure.Parameters.AddWithValue("@matricula", id);
                    SqlDataReader rdr = cmdProcedure.ExecuteReader();
                    while (rdr.Read())
                    {
                        int recordsAffected = cmdProcedure.ExecuteNonQuery();
                    }
                    connection.Close();
                }
                return existe;
            }
        }
        public (List<Funcionario>, List<string>, int) TrataCSV(string arquivo)
        {
            var lista = new List<Funcionario>();
            var naoAdd = new List<string>();
            var contadorLinhas = 0;
            var numeroConflitos = 0;
            using (var file = new FileStream(arquivo, FileMode.Open))
            using (var leitor = new StreamReader(file))
            {
                while (!leitor.EndOfStream)
                {
                    var dados = leitor.ReadLine();
                    var funcionario = ConverteAtributos(dados);
                    // Varifica se já exite
                    (var existe, var msg) = Existente(funcionario);
                    if (existe)
                    {
                        numeroConflitos++;
                        contadorLinhas++;
                        naoAdd.Add($"Linha {contadorLinhas}; {msg}");
                    }
                    else
                    {
                        lista.Add(funcionario);
                        contadorLinhas++;
                    }
                }
            }
            return (lista, naoAdd, numeroConflitos);
        }
        /// <summary>
        /// Ordena a lista por nome, id ou cargo
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public int Compare(Funcionario x, Funcionario y)
        {
            switch (_ordem.ToLower())
            {
                case "id":
                    return x.Id.CompareTo(y.Id);
                case "nome":
                    return x.Nome.CompareTo(y.Nome);
                case "cargo":
                    return x.Cargo.CompareTo(y.Cargo);
                default:
                    return x.Id.CompareTo(y.Id);
            }
        }
        /// <summary>
        /// Altera o salário do <see cref="Funcionario"/> com id informado
        /// </summary>
        /// <param name="id"></param>
        /// <param name="novoSalario"></param>
        /// <returns>Retorna <see cref="bool"/> para se a operação foi realizada e o sálario antigo</returns>
        public (bool, decimal) AlteraSalarioRepository(string id, decimal novoSalario)
        {
            var existe = false;
            var salarioAntigo = 0m;
            var stringSQLMatricula = "";
            using (SqlConnection connection = new SqlConnection(SQLServerConn.StrCon))
            {
                connection.Open();
                var sqlQuery = $"SELECT [Matricula], [Salario] FROM [dbo].[Funcionarios] WHERE [Matricula] = '{id}'";
                SqlCommand cmd = new SqlCommand(sqlQuery, connection);
                SqlDataReader srd = cmd.ExecuteReader();
                while (srd.Read())
                {
                    stringSQLMatricula = srd.GetValue(0).ToString();
                    salarioAntigo += Convert.ToDecimal(srd.GetValue(1));
                }
                connection.Close();
                if (stringSQLMatricula == "")
                {
                    salarioAntigo = 0m;
                    return (existe, salarioAntigo);
                }
                else
                {
                    existe = true;
                    using (SqlCommand command = new SqlCommand())
                    {
                        connection.Open();
                        command.Connection = connection;
                        command.CommandType = CommandType.Text;
                        command.CommandText = $"UPDATE [dbo].[Funcionarios] SET [Salario] = '{novoSalario.ToString().Replace(',', '.')}' WHERE [Matricula] = '{id}'";
                        int recordsAffected = command.ExecuteNonQuery();
                        connection.Close();
                    }
                    return (existe, salarioAntigo);
                }
            }
        }
    }
}
