using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaChocolateApp.Model
{
    public class Venda
    {
        private int _vendaId;
        private string _vendedorNome;
        private int _vendedorId;
        private List<Tuple<int, Produto>> _produtos;
        private decimal _valorTotal;
        private DateTime _dataVenda;

        public int VendaId { get { return _vendaId; } private set { } }
        public string VendedorNome { get { return _vendedorNome; } private set { } }
        public int VendedorId { get { return _vendedorId; } private set { } }
        public List<Tuple<int, Produto>> Produtos { get { return _produtos; } private set { } }
        public decimal Valor { get { return _valorTotal; } private set { } }
        public DateTime DataVenda { get { return _dataVenda; } private set { } }
        public Venda(Funcionario funcionario, List<Tuple<int, Produto>> produtos, decimal valorTotal, DateTime data)
        {
            _vendedorNome = funcionario.Nome;
            _vendedorId = funcionario.Id;
            _produtos = produtos;
            _valorTotal = valorTotal;
            _dataVenda = data;
        }
        public Venda(int id, int funcionarioId, string funcionarioNome, decimal valorTotal, DateTime data)
        {
            _vendaId = id;
            _vendedorId = funcionarioId;
            _vendedorNome = funcionarioNome;
            _valorTotal = valorTotal;
            _dataVenda = data;
        }
    }
}
