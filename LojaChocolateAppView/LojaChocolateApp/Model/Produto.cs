using LojaChocolateApp.Repository;
using System;
using System.Collections.Generic;
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
            var vendasRepo = new VendaRepository();
            var listaVendas = vendasRepo.GetLista();
            foreach (var venda in listaVendas)
            {
                var produto = vendasRepo.GetDetalhesVenda(venda.VendaId);
                foreach (var prod in produto)
                {
                    var linhaProduto = prod.Split('|');
                    var prodId = linhaProduto[1];
                    var qtd = Convert.ToInt32(linhaProduto[0].Remove(0, linhaProduto[0].IndexOf(':') + 1));
                    if (prodId == this.Id)
                    {
                        vendasId += qtd;
                    }
                }
            }
            return vendasId;
        }
    }
}
