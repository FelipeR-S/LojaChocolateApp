using LojaChocolateApp.Model;
using System;
using System.Collections.Generic;
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
            (var vendedorExiste, var vendedor) = funcionarioRepo.GetDetalhes(Convert.ToInt32(idFuncionario));
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
                    (var existe, var produto) = produtoRepo.GetDetalhes(Convert.ToInt32(prodId));
                    if (!existe)
                    {
                        return vendaFalha;
                    }
                    else
                    {
                        produtos.Add(new Tuple<int, Produto>(Convert.ToInt32(qtdProd), produto));
                        foreach(var prodVenda in produtos)
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
        public (bool, Venda) GetDetalhes(int id)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Metodo responsável por retornar detalhes dos produtos da venda solicitada
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<string> GetDetalhesVenda(int id)
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
                    if (Convert.ToInt32(idVenda) == id)
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
                    var id = Convert.ToInt32(dados[0].Remove(0, dados[0].IndexOf(':') + 1));
                    var funcionario = dados[1].Split('|');
                    var funcionarioId = Convert.ToInt32(funcionario[0].Remove(0, funcionario[0].IndexOf(':') + 1));
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
            venda.SetVendaId();
            using (var file = new FileStream(_localDoArquivo, FileMode.Append))
            using (var escritor = new StreamWriter(file))
            {
                var linhaProduto = "";
                foreach (var produto in venda.Produtos)
                {
                    (var qtd, var prod) = produto;
                    linhaProduto += $"Quantidade:{qtd}|Id:{prod.Id}|{prod.Nome}|Valor R$:{prod.Valor};";
                }
                escritor.WriteLine($"Venda:{venda.VendaId};Vendedor:{venda.VendedorId}|{venda.VendedorNome};{linhaProduto}Valor Total R$:{venda.Valor};Data:{venda.DataVenda}");
            }
        }
        public void IncluirVarios(List<Venda> lista)
        {
            foreach (var venda in lista)
            {
                venda.SetVendaId();
                using (var file = new FileStream(_localDoArquivo, FileMode.Append))
                using (var escritor = new StreamWriter(file))
                {
                    var repoProduto = new ProdutoRepository();
                    var linhaProduto = "";
                    foreach (var produto in venda.Produtos)
                    {
                        (var qtd, var prod) = produto;
                        linhaProduto += $"Quantidade:{qtd}|Id:{prod.Id}|{prod.Nome}|Valor R$:{prod.Valor};";
                        var diminuiEstoque = $"-{qtd}";
                        repoProduto.AlteraEstoqueRepository(prod.Id, Convert.ToInt32(diminuiEstoque));
                    }
                    escritor.WriteLine($"Venda:{venda.VendaId};Vendedor:{venda.VendedorId}|{venda.VendedorNome};{linhaProduto}Valor Total R$:{venda.Valor};Data:{venda.DataVenda}");
                }
            }
        }
        public bool Remover(int id)
        {
            throw new NotImplementedException();
        }
        public (List<Venda>, List<string>, int) TrataCSV(string arquivo)
        {
            using (var file = new FileStream(arquivo, FileMode.Open))
            using (var leitor = new StreamReader(file))
            {
                var lista = new List<Venda>();
                var naoAdicionados = new List<string>();
                var numeroDeConflitos = 0;
                while (!leitor.EndOfStream)
                {
                    //dados de entrada
                    var dados = leitor.ReadLine();
                    var novaVenda = ConverteAtributos(dados);
                    //Verifica Estoque
                    foreach (var venda in novaVenda.Produtos)
                    {
                        (var qtd, var prod) = venda;
                        if (qtd > prod.Estoque)
                        {
                            numeroDeConflitos++;
                            naoAdicionados.Add($"Produto de Id {prod.Id} com estoque insuficiente\n" +
                                $"Quantidade solicitadade: {qtd} | Quantidade em estoque: {prod.Estoque}\n");
                            return (lista, naoAdicionados, numeroDeConflitos);
                        }
                    }
                    lista.Add(novaVenda);
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
