using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaChocolateApp.Model
{
    public class Gerente : Funcionario
    {
        public Gerente(string id, string nome, string cpf, string contato, decimal salario, string cargo, string dataCadastro) : base(id, nome, cpf, contato, salario, cargo, dataCadastro)
        {
        }
    }
}
