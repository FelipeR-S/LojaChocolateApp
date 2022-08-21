﻿using LojaChocolateApp.Model;
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
    public class VendaRepository : IRepository<Venda>
    {
        /// <summary>
        /// Local padrão do <see cref="VendaRepository"/>
        /// </summary>
        private static string _localDoArquivo = "VendasRepository.CSV";
        public Venda ConverteAtributos(string linha)
        {
            // Entrada
            var linhaVenda = linha.Split(';');
            var idFuncionario = linhaVenda[0];
            var data = linhaVenda[linhaVenda.Length - 1];

            //Variáveis Locais
            var valorTotal = 0m;
            var existeUnidade = false;
            Venda vendaFalha = null;

            //Vendedor
            var funcionarioRepo = new FuncionarioRepository();
            (var vendedorExiste, var vendedor) = funcionarioRepo.GetDetalhes(idFuncionario);
            if (!vendedorExiste)
            {
                return vendaFalha;
            }
            else
            {
                var contador = 1;
                //Produtos
                var produtos = new List<Tuple<int, Produto>>();
                while (contador < linhaVenda.Length - 1)
                {
                    var vendaProduto = linhaVenda[contador].Split('|');
                    var qtdProd = vendaProduto[0];
                    var prodId = vendaProduto[1];

                    var produtoRepo = new ProdutoRepository();
                    (var existe, var produto) = produtoRepo.GetDetalhes(prodId);
                    if (!existe)
                    {
                        return vendaFalha;
                    }
                    else
                    {
                        produtos.Add(new Tuple<int, Produto>(Convert.ToInt32(qtdProd), produto));
                        foreach (var prodVenda in produtos)
                        {
                            (var qtd, var prod) = prodVenda;
                            valorTotal += qtd * prod.Valor;
                        }
                        existeUnidade = true;
                        contador++;
                    }
                }
                if (!existeUnidade)
                {
                    return vendaFalha;
                }
                else
                {
                    var venda = new Venda(vendedor, produtos, valorTotal, Convert.ToDateTime(data));
                    return venda;
                }
            }
        }
        public (bool, string) Existente(Venda venda)
        {
            throw new NotImplementedException();
        }
        public (bool, Venda) GetDetalhes(string id)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Metodo responsável por retornar detalhes dos produtos da venda solicitada
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<string> GetDetalhesVenda(string id)
        {
            var existe = false;
            var listaProdutos = new List<string>();
            using (var fileStream = new FileStream(_localDoArquivo, FileMode.Open))
            using (var reader = new StreamReader(fileStream))
            {
                while (!reader.EndOfStream)
                {
                    var linha = reader.ReadLine().ToString().Split(';');
                    var idVenda = linha[0].Remove(0, linha[0].ToString().IndexOf(':') + 1);
                    if (idVenda == id)
                    {
                        existe = true;
                        var contador = 2;
                        while (contador < linha.Length - 2)
                        {
                            var dadosProduto = linha[contador];
                            listaProdutos.Add(dadosProduto);
                            contador++;
                        }
                    }
                }
            }
            if (existe == true)
            {
                return listaProdutos;
            }
            else
            {
                var listaErro = new List<string>();
                return listaErro;
            }
        }
        public List<Venda> GetLista()
        {
            var lista = new List<Venda>();
            using (var file = new FileStream(_localDoArquivo, FileMode.Open))
            using (var leitor = new StreamReader(file))
            {
                while (!leitor.EndOfStream)
                {
                    var linha = leitor.ReadLine();
                    var dados = linha.Split(';');
                    var id = dados[0].Remove(0, dados[0].IndexOf(':') + 1);
                    var funcionario = dados[1].Split('|');
                    var funcionarioId = funcionario[0].Remove(0, funcionario[0].IndexOf(':') + 1);
                    var funcionarioNome = funcionario[1];
                    var valorTotal = Convert.ToDecimal(dados[dados.Length - 2].Remove(0, dados[dados.Length - 2].IndexOf(':') + 1));
                    var data = Convert.ToDateTime(dados[dados.Length - 1].Remove(0, dados[dados.Length - 1].IndexOf(':') + 1));
                    var venda = new Venda(id, funcionarioId, funcionarioNome, valorTotal, data);
                    lista.Add(venda);
                }
            }
            return lista;
        }
        public void IncluirUnico(Venda venda)
        {
            var numeroNF = 0;
            using (SqlConnection connection = new SqlConnection(SQLServerConn.StrCon))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "insert into [Vendas_NF] ([Vendedor Matricula], [Vendedor Nome], [Total], [Data]) VALUES(@Matricula, @Vendedor, @Total, @Data)";
                    command.Parameters.AddWithValue("@Matricula", venda.VendedorId);
                    command.Parameters.AddWithValue("@Vendedor", venda.VendedorNome);
                    command.Parameters.AddWithValue("@Total", venda.Valor);
                    command.Parameters.AddWithValue("@Data", venda.DataVenda.ToShortDateString());
                    int recordsAffected = command.ExecuteNonQuery();
                }
                var SQLnumeroNF = "SELECT MAX([Numero]) FROM [Vendas_NF]";
                SqlCommand cmd = new SqlCommand(SQLnumeroNF, connection);
                SqlDataReader srd = cmd.ExecuteReader();
                while (srd.Read())
                {
                    numeroNF = Convert.ToInt32(srd.GetValue(0));
                }
                connection.Close();
            }
            using (SqlConnection connection = new SqlConnection(SQLServerConn.StrCon))
            {
                connection.Open();
                foreach (var produto in venda.Produtos)
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        (var qtd, var prod) = produto;
                        command.Connection = connection;
                        command.CommandType = CommandType.Text;
                        command.CommandText = "insert into [Vendas_Itens] ([Numero], [Produto Codigo], [Produto Nome], [Quantidade], [Valor]) VALUES(@Numero, @Codigo, @Nome, @Quantidade, @Valor)";
                        command.Parameters.AddWithValue("@Numero", numeroNF);
                        command.Parameters.AddWithValue("@Codigo", prod.Id);
                        command.Parameters.AddWithValue("@Nome", prod.Nome);
                        command.Parameters.AddWithValue("@Quantidade", qtd);
                        command.Parameters.AddWithValue("@Valor", prod.Valor);
                        int recordsAffected = command.ExecuteNonQuery();
                    }
                }
                connection.Close();
            }
        }
        public void IncluirVarios(List<Venda> lista)
        {
            foreach (var venda in lista)
            {
                IncluirUnico(venda);
            }
        }
        public bool Remover(string id)
        {
            throw new NotImplementedException();
        }
        public (List<Venda>, List<string>, int) TrataCSV(string arquivo)
        {
            using (var file = new FileStream(arquivo, FileMode.Open))
            using (var leitor = new StreamReader(file))
            {
                var lista = new List<Venda>();
                var numeroLinha = 0;
                var naoAdicionados = new List<string>();
                var numeroDeConflitos = 0;
                while (!leitor.EndOfStream)
                {
                    numeroLinha++;
                    //dados de entrada
                    var dados = leitor.ReadLine();
                    var novaVenda = ConverteAtributos(dados);
                    if (novaVenda != null)
                    {
                        //Verifica Estoque
                        foreach (var produto in novaVenda.Produtos)
                        {
                            (var qtd, var prod) = produto;
                            if (qtd > prod.Estoque)
                            {
                                numeroDeConflitos++;
                                naoAdicionados.Add($"Linha nº {numeroLinha} com Produto de Id {prod.Id} com estoque insuficiente\n" +
                                    $"Quantidade solicitadade: {qtd} | Quantidade em estoque: {prod.Estoque}\n");
                                return (lista, naoAdicionados, numeroDeConflitos);
                            }
                        }
                        lista.Add(novaVenda);
                    }
                    else
                    {
                        numeroDeConflitos++;
                        naoAdicionados.Add($"Linha nº {numeroLinha} não está de acordo com os padrões.");
                    }
                }
                return (lista, naoAdicionados, numeroDeConflitos);
            }
        }
        public int Compare(Venda x, Venda y)
        {
            throw new NotImplementedException();
        }
    }
}
