﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LojaChocolateApp.Repository
{
    public class SQLServerConn
    {
        private static string _server;
        private static string _database = "Loja_Chocolate";
        private static string _user;
        private static string _password;
        public static string User { get { return _user; } }
        public SQLServerConn(string server, string login, string senha)
        {
            _server = server;
            _user = login;
            _password = senha;
        }
        public SQLServerConn()
        {             
        }
        /// <summary>
        ///  Atributo para login
        /// </summary>
        public static string StrConSA
        {
            get { return $"Data Source={_server}; Integrated Security=false; User ID={_user}; Password={_password}"; }
        }
        /// <summary>
        /// Atributo para uso do sistema
        /// </summary>
        public static string StrCon
        {
            get { return $"Data Source={_server}; Integrated Security=false; Initial Catalog={_database}; User ID={_user}; Password={_password}"; }
        }
        /// <summary>
        /// Metodo de login
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public string Conexao(string login)
        {
            if (login.ToLower() == "sa")
            {
                RecuperaBancoDeDados();
                return StrConSA;
            }
            else return StrCon;
        }
        /// <summary>
        /// Metodo que recupera banco de dados caso o mesmo não esteja disponivel no SQL Server
        /// </summary>
        private void RecuperaBancoDeDados()
        {
            // GET DIRETORIO BANCO DE DADOS
            var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
            var diretorio = path.Remove(0, 6);
            var index = diretorio.Length - 9;
            diretorio = diretorio.Remove(index);
            diretorio += @"Database\loja_Chocolate";
            var sqlDB = $"USE [master] if DB_ID ('loja_Chocolate') Is null begin CREATE DATABASE [Loja_Chocolate] ON (FILENAME = N'{diretorio}.mdf'), ( FILENAME = N'{diretorio}.ldf') FOR ATTACH end";
            //Cria DB
            using (SqlConnection connection = new SqlConnection(StrConSA))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(sqlDB, connection);
                SqlDataReader sdr = cmd.ExecuteReader();
                connection.Close();
            }
            // Criar Certificados e Login Cadastro
            var sqlCertificadoCadastro = "Use [loja_Chocolate] exec ChavesCertificados; exec CriaLoginCadastro;";
            using (SqlConnection connection = new SqlConnection(StrConSA))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(sqlCertificadoCadastro, connection);
                SqlDataReader sdr = cmd.ExecuteReader();
                connection.Close();
            }
        }
        /// <summary>
        /// Insere Imagem no banco de dados
        /// </summary>
        /// <param name="imagem"></param>
        /// <param name="tipo"></param>
        /// <param name="id"></param>
        public void InsereImagemSql(byte[] imagem, string tipo, string id)
        {
            var existe = false;
            var tabela = "";
            var coluna = "";
            switch (tipo)
            {
                case "Produto":
                    tabela = "[dbo].[Tabela_Imagens_Produtos]";
                    coluna = "[Codigo]";
                    break;
                case "Funcionario":
                    tabela = "[dbo].[Tabela_Imagens_Funcionarios]";
                    coluna = "[Matricula]";
                    break;
                default:
                    break;
            }
            using (SqlConnection connection = new SqlConnection(StrCon))
            {
                connection.Open();
                var sqlQueryVerifica = $"select {coluna} from {tabela} where {coluna} = '{id}'";
                SqlCommand cmd = new SqlCommand(sqlQueryVerifica, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var dadoTabela = reader.GetValue(0).ToString();
                    if (id == dadoTabela)
                        existe = true;
                }
                connection.Close();
                if (existe == false)
                {
                    var sqlInsereMatricula = $"insert into {tabela} ({coluna}) values (@dados)";
                    using (SqlCommand command = new SqlCommand(sqlInsereMatricula, connection))
                    {
                        connection.Open();
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@dados", id);
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
                var sqlInsereImagem = $"update {tabela} set [Imagem] = @imagem where {coluna} = '{id}'";
                using (SqlCommand command = new SqlCommand(sqlInsereImagem, connection))
                {
                    connection.Open();
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@imagem", imagem);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        public byte[] ConvertImageToByte(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }
        public Image ConvertByteArrayToImage(byte[] dados)
        {
            using (MemoryStream ms = new MemoryStream(dados))
            {
                return Image.FromStream(ms);
            }
        }
        public Image GetImagemSql(string tipo, string id)
        {
            Image imagem = null;
            var existe = false;
            var tabela = "";
            var coluna = "";
            switch (tipo)
            {
                case "Produto":
                    tabela = "[dbo].[Tabela_Imagens_Produtos]";
                    coluna = "[Codigo]";
                    break;
                case "Funcionario":
                    tabela = "[dbo].[Tabela_Imagens_Funcionarios]";
                    coluna = "[Matricula]";
                    break;
                default:
                    break;
            }
            using (SqlConnection connection = new SqlConnection(StrCon))
            {
                connection.Open();
                var sqlQueryVerifica = $"select {coluna} from {tabela} where {coluna} = '{id}'";
                SqlCommand cmd = new SqlCommand(sqlQueryVerifica, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var idTabela = reader.GetValue(0).ToString();
                    if (id == idTabela)
                        existe = true;
                }
                connection.Close();
                if (existe == true)
                {
                    connection.Open();
                    var sqlRetiraImagem = $"select [Imagem] from {tabela} where {coluna} = '{id}'";
                    SqlCommand cmdImg = new SqlCommand(sqlRetiraImagem, connection);
                    SqlDataReader readerImg = cmdImg.ExecuteReader();
                    while (readerImg.Read())
                    {
                        byte[] dadosImagem = (byte[])readerImg.GetValue(0);
                        imagem = ConvertByteArrayToImage(dadosImagem);
                    }
                    connection.Close();
                    return imagem;
                }
                else
                    return imagem;
            }
        }
        /// <summary>
        /// Acessa o Database e recupera lista de solicitações de cadastro.
        /// </summary>
        /// <returns></returns>
        public List<string> GetListaCadastro()
        {
            var listaCadastro = new List<string>();
            var listaSaida = new List<string>();
            using (SqlConnection connection = new SqlConnection(SQLServerConn.StrCon))
            {
                connection.Open();
                var SqlQueryCadastro = "Select [Nome],[Matricula],[CPF],[Cargo] from [Cadastro de Usuário]";
                SqlCommand cmd = new SqlCommand(SqlQueryCadastro, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    listaCadastro.Add($"##;{reader.GetValue(0)};{reader.GetValue(1)};{reader.GetValue(2)};{reader.GetValue(3)}");
                }
                connection.Close();
            }
            foreach (var cadastro in listaCadastro)
            {
                var linhaCadastro = cadastro.Split(';');
                var cargo = linhaCadastro[4];
                if (String.IsNullOrWhiteSpace(cargo))
                {
                    using (SqlConnection connection = new SqlConnection(SQLServerConn.StrCon))
                    {
                        connection.Open();
                        var novoCadastro = "";
                        var matricula = linhaCadastro[2];
                        var SqlQueryCadastro = $"Select [Nome] from [funcionarios] where [Matricula] = '{matricula}'";
                        SqlCommand cmd = new SqlCommand(SqlQueryCadastro, connection);
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            if (reader.GetValue(0).ToString() != string.Empty)
                                novoCadastro = cadastro.Replace("##", $"{reader.GetValue(0)}");
                        }
                        if (novoCadastro == string.Empty)
                            listaSaida.Add(cadastro);
                        else
                            listaSaida.Add(novoCadastro);
                        connection.Close();
                    }
                }
            }
            return listaSaida;
        }
    }
}
