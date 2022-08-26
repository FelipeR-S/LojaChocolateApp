using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaChocolateApp.Model
{
    public class Venda
    {
        private string _vendaId;
        private string _vendedorNome;
        private string _vendedorId;
        private List<Tuple<int, Produto>> _produtos;
        private decimal _valorTotal;
        private DateTime _dataVenda;

        public string VendaId { get { return _vendaId; } private set { } }
        public string VendedorNome { get { return _vendedorNome; } private set { } }
        public string VendedorId { get { return _vendedorId; } private set { } }
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
        public Venda(string id, string funcionarioId, string funcionarioNome, decimal valorTotal, DateTime data)
        {
            _vendaId = id;
            _vendedorId = funcionarioId;
            _vendedorNome = funcionarioNome;
            _valorTotal = valorTotal;
            _dataVenda = data;
        }
        public void SetVendaId()
        {
            var arquivo = "VendasRepository.CSV";
            var id = 1;
            using (var file = new FileStream(arquivo, FileMode.Open))
            using (var leitor = new StreamReader(file))
            {
                while (!leitor.EndOfStream)
                {
                    leitor.ReadLine();
                    id++;
                }
            }
            //this._vendaId = id;
        }
    }
}
