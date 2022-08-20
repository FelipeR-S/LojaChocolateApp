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
    public class ProdutoRepository : IRepository<Produto>
    {
        /// <summary>
        /// Atributo para ordenar o metodo <see cref="Compare"/>
        /// </summary>
        private string _ordem { get; }
        public ProdutoRepository()
        {
        }
        /// <summary>
        /// Construtor usado no metodo Sort() para ordenar lista
        /// </summary>
        /// <param name="ordem"></param>
        public ProdutoRepository(string ordem)
        {
            _ordem = ordem;
        }
        /// <summary>
        /// Local padrão do <see cref="ProdutoRepository"/>
        /// </summary>
        private static string _localdoArquivo = "ProdutoRepository.CSV";
        /// <summary>
        /// Local temporário para excluir itens presentes no repositório
        /// </summary>
        private static string _arquivoTemporario = "temp.CSV";
        public Produto ConverteAtributos(string linha)
        {
            var dados = linha.Split(';');
            var id = dados[0];
            var nome = dados[1];
            var peso = Convert.ToDecimal(dados[2]);
            var valor = Math.Round(Convert.ToDecimal(dados[3]), 2);
            var tipo = dados[4];
            var estoque = Convert.ToInt32(dados[5]);
            var produto = new Produto(id, nome, peso, valor, tipo, estoque);
            return produto;
        }
        public (bool, string) Existente(Produto produto)
        {
            var existe = false;
            var stringSQLCodigo = "";
            using (SqlConnection connection = new SqlConnection(SQLServerConn.StrCon))
            {
                connection.Open();
                var sqlQuery = $"SELECT [Codigo] FROM [dbo].[Produtos] WHERE [Codigo] = '{produto.Id}'";
                SqlCommand cmd = new SqlCommand(sqlQuery, connection);
                SqlDataReader srd = cmd.ExecuteReader();
                while (srd.Read())
                {
                    stringSQLCodigo = srd.GetValue(0).ToString();
                }
                connection.Close();
            }
            if (stringSQLCodigo == "")
            {
                return (existe, "");
            }
            else
            {
                if (stringSQLCodigo == produto.Id.ToString())
                {
                    existe = true;
                    return (existe, "Código de produto já existe no cadastro!");
                }
                else
                    return (existe, "Código de produto já existe no cadastro!");
            }
        }
        public (bool, Produto) GetDetalhes(string id)
        {
            var existe = false;
            Produto produto = null;
            var produtoString = "";

            using (SqlConnection connection = new SqlConnection(SQLServerConn.StrCon))
            {
                connection.Open();
                var sqlQuery = $"SELECT [Codigo], [Nome], [Peso], [Valor], [Tipo], [Estoque] FROM [dbo].[Produtos] WHERE [Codigo] = '{id}'";
                SqlCommand cmd = new SqlCommand(sqlQuery, connection);
                SqlDataReader srd = cmd.ExecuteReader();
                while (srd.Read())
                {
                    produtoString = $"{srd.GetValue(0)};{srd.GetValue(1)};{srd.GetValue(2)};{srd.GetValue(3)};{srd.GetValue(4)};{srd.GetValue(5)}";
                }
                connection.Close();
            }
            if (produtoString == "")
            {
                return (existe, produto);
            }
            else
            {
                existe = true;
                produto = ConverteAtributos(produtoString);
                return (existe, produto);
            }
        }
        public List<Produto> GetLista()
        {
            var lista = new List<Produto>();
            using (var file = new FileStream(_localdoArquivo, FileMode.Open))
            using (var leitor = new StreamReader(file))
            {
                while (!leitor.EndOfStream)
                {
                    var linha = leitor.ReadLine();
                    var produto = ConverteAtributos(linha);
                    lista.Add(produto);
                }
            }
            return lista;
        }
        public void IncluirUnico(Produto produto)
        {
            using (SqlConnection connection = new SqlConnection(SQLServerConn.StrCon))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "INSERT INTO[dbo].[Produtos] ([Codigo], [Nome], [Peso], [Valor], [Estoque], [Tipo]) VALUES(@Codigo, @Nome, @Peso, @Valor, @Estoque, @Tipo)";
                    command.Parameters.AddWithValue("@Codigo", produto.Id);
                    command.Parameters.AddWithValue("@Nome", produto.Nome);
                    command.Parameters.AddWithValue("@Peso", produto.Peso.ToString().Replace(',', '.'));
                    command.Parameters.AddWithValue("@Valor", produto.Valor.ToString().Replace(',', '.'));
                    command.Parameters.AddWithValue("@Estoque", produto.Estoque);
                    command.Parameters.AddWithValue("@Tipo", produto.Tipo);
                    connection.Open();
                    int recordsAffected = command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        public void IncluirVarios(List<Produto> lista)
        {
            using (SqlConnection connection = new SqlConnection(SQLServerConn.StrCon))
            {
                connection.Open();
                foreach (var produto in lista)
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandType = CommandType.Text;
                        command.CommandText = "INSERT INTO[dbo].[Produtos] ([Codigo], [Nome], [Peso], [Valor], [Estoque], [Tipo]) VALUES(@Codigo, @Nome, @Peso, @Valor, @Estoque, @Tipo)";
                        command.Parameters.AddWithValue("@Codigo", produto.Id);
                        command.Parameters.AddWithValue("@Nome", produto.Nome);
                        command.Parameters.AddWithValue("@Peso", produto.Peso.ToString().Replace(',', '.'));
                        command.Parameters.AddWithValue("@Valor", produto.Valor.ToString().Replace(',', '.'));
                        command.Parameters.AddWithValue("@Estoque", produto.Estoque);
                        command.Parameters.AddWithValue("@Tipo", produto.Tipo);
                        int recordsAffected = command.ExecuteNonQuery();
                    }
                }
                connection.Close();
            }
        }
        public bool Remover(string id)
        {
            var existe = false;
            var stringSQLMatricula = "";
            using (SqlConnection connection = new SqlConnection(SQLServerConn.StrCon))
            {
                connection.Open();
                var sqlQuery = $"SELECT [Codigo] FROM [dbo].[Produtos] WHERE [Codigo] = '{id}'";
                SqlCommand cmd = new SqlCommand(sqlQuery, connection);
                SqlDataReader srd = cmd.ExecuteReader();
                while (srd.Read())
                {
                    stringSQLMatricula = srd.GetValue(0).ToString();
                }
                connection.Close();
                if (stringSQLMatricula == "")
                {
                    return existe;
                }
                else
                {
                    existe = true;
                    using (SqlCommand command = new SqlCommand())
                    {
                        connection.Open();
                        command.Connection = connection;
                        command.CommandType = CommandType.Text;
                        command.CommandText = $"DELETE FROM [dbo].[Produtos] WHERE [Codigo] = '{id}'";
                        int recordsAffected = command.ExecuteNonQuery();
                        connection.Close();
                    }
                    return existe;
                }
            }
        }
        public (List<Produto>, List<string>, int) TrataCSV(string arquivo)
        {
            var lista = new List<Produto>();
            var naoAdd = new List<string>();
            var contadorLinhas = 0;
            var numeroConflitos = 0;
            using (var file = new FileStream(arquivo, FileMode.Open))
            using (var leitor = new StreamReader(file))
            {
                while (!leitor.EndOfStream)
                {
                    var dados = leitor.ReadLine();
                    var produto = ConverteAtributos(dados);
                    (var existe, var msg) = Existente(produto);
                    if (existe)
                    {
                        numeroConflitos++;
                        contadorLinhas++;
                        naoAdd.Add($"Linha {contadorLinhas}; {msg}");
                    }
                    else
                    {
                        lista.Add(produto);
                        contadorLinhas++;
                    }
                }
                return (lista, naoAdd, numeroConflitos);
            }
        }
        /// <summary>
        /// Ordena a lista por nome, id ou valor
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int Compare(Produto x, Produto y)
        {
            switch (_ordem.ToLower())
            {
                case "id":
                    return x.Id.CompareTo(y.Id);
                case "nome":
                    return x.Nome.CompareTo(y.Nome);
                case "valor":
                    return x.Valor.CompareTo(y.Valor);
                default:
                    return x.Id.CompareTo(y.Id);
            }
        }
        /// <summary>
        /// Verifica de o <see cref="Produto"/> existe no cadastro e altera a sua quantidade em estoque
        /// </summary>
        /// <param name="id"></param>
        /// <param name="quantidade"></param>
        /// <returns><see cref="true"/> para estoque alterado, <see cref="false"/> quando não há no cadastro e o <see cref="Produto"/> alterado</returns>
        public (bool, Produto) AlteraEstoqueRepository(string id, int quantidade)
        {
            var existe = false;
            Produto produtoAnterior = null;
            var SQLCodigo = "";
            var SQLEstoque = 0;
            var SQLLinha = "";
            using (SqlConnection connection = new SqlConnection(SQLServerConn.StrCon))
            {
                connection.Open();
                var sqlQuery = $"SELECT [Codigo], [Nome], [Peso], [Valor], [Tipo], [Estoque]  FROM [dbo].[Produtos] WHERE [Codigo] = '{id}'";
                SqlCommand cmd = new SqlCommand(sqlQuery, connection);
                SqlDataReader srd = cmd.ExecuteReader();
                while (srd.Read())
                {
                    SQLCodigo = srd.GetValue(0).ToString();
                    SQLEstoque = Convert.ToInt32(srd.GetValue(5));
                    SQLLinha = $"{srd.GetValue(0)};{srd.GetValue(1)};{srd.GetValue(2)};{srd.GetValue(3)};{srd.GetValue(4)};{srd.GetValue(5)}";
                }
                connection.Close();
                if (SQLCodigo == "" || SQLEstoque + quantidade <= 0)
                {
                    return (existe, produtoAnterior);
                }
                else
                {
                    existe = true;
                    var novoEstoque = SQLEstoque + quantidade;
                    produtoAnterior = ConverteAtributos(SQLLinha);
                    using (SqlCommand command = new SqlCommand())
                    {
                        connection.Open();
                        command.Connection = connection;
                        command.CommandType = CommandType.Text;
                        command.CommandText = $"UPDATE [dbo].[Produtos] SET [Estoque] = {novoEstoque} WHERE [Codigo] = '{id}'";
                        int recordsAffected = command.ExecuteNonQuery();
                        connection.Close();
                    }
                    return (existe, produtoAnterior);
                }
            }
        }
        /// <summary>
        /// Verifica se <see cref="Produto"/> existe no cadastro e altera seu valor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="novoValor"></param>
        /// <returns>Retorna <see cref="bool"/> para a conclusão do serviço e <see cref="decimal"/> para o valor anterior a mudança</returns>
        public (bool, decimal) AlteraValorProduto(string id, decimal novoValor)
        {
            var existe = false;
            var valorAnterior = 0m;
            var SQLCodigo = "";
            using (SqlConnection connection = new SqlConnection(SQLServerConn.StrCon))
            {
                connection.Open();
                var sqlQuery = $"SELECT [Codigo], [Valor] FROM [dbo].[Produtos] WHERE [Codigo] = '{id}'";
                SqlCommand cmd = new SqlCommand(sqlQuery, connection);
                SqlDataReader srd = cmd.ExecuteReader();
                while (srd.Read())
                {
                    SQLCodigo = srd.GetValue(0).ToString();
                    valorAnterior = Convert.ToDecimal(srd.GetValue(1));
                }
                connection.Close();
                if (SQLCodigo == "")
                {
                    return (existe, valorAnterior);
                }
                else
                {
                    existe = true;
                    using (SqlCommand command = new SqlCommand())
                    {
                        connection.Open();
                        command.Connection = connection;
                        command.CommandType = CommandType.Text;
                        command.CommandText = $"UPDATE [dbo].[Produtos] SET [Valor] = {novoValor.ToString().Replace(',','.')} WHERE [Codigo] = '{id}'";
                        int recordsAffected = command.ExecuteNonQuery();
                        connection.Close();
                    }
                    return (existe, valorAnterior);
                }
            }
        }
    }
}
