using LojaChocolateApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaChocolateApp.Model
{
    public abstract class Funcionario
    {
        private int _id;
        private string _nome;
        private string _cpf;
        private string _contato;
        private decimal _salario;
        private string _cargo;
        private int _quantidadeDeVendas { get => GetQuantidadeDeVendas(); }
        private string _dataCadastro;
        public int Id { get { return _id; } private set { } }
        public string Nome { get { return _nome; } private set { } }
        public string Cpf { get { return _cpf; } private set { } }
        public string Contato { get { return _contato; } private set { } }
        public decimal Salario { get { return _salario; } private set { } }
        public string Cargo { get { return _cargo; } private set { } }
        public int QuantidadeDeVendas { get => _quantidadeDeVendas; }
        public string DataCadastro { get { return _dataCadastro; } private set { } }

        public Funcionario(int id, string nome, string cpf, string contato, decimal salario, string cargo, string dataCadastro)
        {
            _id = id;
            _nome = nome;
            _cpf = cpf;
            _contato = contato;
            _salario = salario;
            _cargo = cargo;
            _dataCadastro = dataCadastro;
        }
        /// <summary>
        /// Atualiza o valor de <see cref="Funcionario.Salario"/>
        /// </summary>
        /// <param name="novoSalario"></param>
        public void AlteraSalario(decimal novoSalario)
        {
            _salario = novoSalario;
        }
        /// <summary>
        /// Retorna o valor de <see cref="Funcionario.QuantidadeDeVendas"/>
        /// </summary>
        /// <returns></returns>
        private int GetQuantidadeDeVendas()
        {
            var vendasId = 0;
            var vendasRepo = new VendaRepository();
            var listaVendas = vendasRepo.GetLista();
            foreach (var venda in listaVendas)
            {
                if (venda.VendedorId == this.Id)
                {
                    vendasId++;
                }
            }
            return vendasId;
        }
    }
}
