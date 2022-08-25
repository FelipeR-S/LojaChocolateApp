﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            var sqlQuery = $"USE [master] if DB_ID ('loja_Chocolate') Is null CREATE DATABASE [Loja_Chocolate] ON (FILENAME = N'{diretorio}.mdf'), ( FILENAME = N'{diretorio}.ldf') FOR ATTACH";
            using (SqlConnection connection = new SqlConnection(SQLServerConn.StrConSA))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(sqlQuery, connection);
                SqlDataReader srd = cmd.ExecuteReader();
                connection.Close();
            }
        }
    }
}
