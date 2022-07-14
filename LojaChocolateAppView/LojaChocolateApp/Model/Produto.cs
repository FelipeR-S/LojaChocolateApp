using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaChocolateApp.Model
{
    public class Produto
    {
        private int _id;
        private string _nome;
        private decimal _peso;
        private decimal _valor;
        private string _tipo;
        private int _estoque;
        private int _quantidadeDeVendas { get; }
        public int Id { get { return _id; } private set { } }
        public string Nome { get { return _nome; } private set { } }
        public decimal Peso { get { return _peso; } private set { } }
        public decimal Valor { get { return _valor; } private set { } }
        public string Tipo { get { return _tipo; } private set { } }
        public int Estoque { get { return _estoque; } private set { } }
        public int QuantidadeDeVendas { get => _quantidadeDeVendas; }

        public Produto(int id, string nome, decimal peso, decimal valor, string tipo, int estoque)
        {
            _id = id;
            _nome = nome;
            _peso = peso;
            _valor = valor;
            _tipo = tipo;
            _estoque = estoque;
        }
        /// <summary>
        /// Atualiza a quantidade do <see cref="Produto.Estoque"/>
        /// </summary>
        /// <param name="quantidade"></param>
        public void AlteraEstoque(int quantidade)
        {
            _estoque += quantidade;
        }
        /// <summary>
        /// Atualiza o valor do <see cref="Produto.Valor"/>
        /// </summary>
        /// <param name="novoValor"></param>
        public void AlteraValor(decimal novoValor)
        {
            _valor = novoValor;
        }
    }
}
