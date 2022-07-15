using LojaChocolateApp.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaChocolateApp.Repository
{
    public class FuncionarioRepository : IRepository<Funcionario>
    {
        /// <summary>
        /// Atributo para ordenar o metodo <see cref="Compare"/>
        /// </summary>
        private string _ordem { get; }
        public FuncionarioRepository()
        {
        }
        /// <summary>
        /// Construtor usado no metodo Sort() para ordenar lista
        /// </summary>
        /// <param name="ordem">Atributo que será ordenado</param>
        public FuncionarioRepository(string ordem)
        {
            _ordem = ordem;
        }
        /// <summary>
        /// Local padrão para o <see cref="FuncionarioRepository"/>
        /// </summary>
        private static string _localDoArquivo = "FuncionarioRepository.CSV";
        /// <summary>
        /// Local temporário para alterar ou remover objeto do <see cref="FuncionarioRepository"/>
        /// </summary>
        private static string _ArquivoTemporario = "temp.CSV";
        public Funcionario ConverteAtributos(string linha)
        {
            var dados = linha.Split(';');
            var id = Convert.ToInt32(dados[0]);
            var nome = dados[1];
            var cpf = dados[2];
            var contato = dados[3];
            var salario = Convert.ToDecimal(dados[4]);
            var cargo = dados[5];
            var dataCadastro = dados[6];
            switch (cargo.ToLower())
            {
                case "vendedor":
                    return new Vendedor(id, nome, cpf, contato, salario, cargo, dataCadastro);
                case "gerente":
                    return new Gerente(id, nome, cpf, contato, salario, cargo, dataCadastro);
                default:
                    return new Vendedor(id, nome, cpf, contato, salario, cargo, dataCadastro);
            }
        }
        public (bool, string) Existente(Funcionario funcionario)
        {
            var existe = false;
            using (var file = new FileStream(_localDoArquivo, FileMode.Open))
            using (var leitor = new StreamReader(file))
            {
                while (!leitor.EndOfStream)
                {
                    var cadastrado = leitor.ReadLine().Split(';');
                    if (cadastrado[0] == funcionario.Id.ToString() && cadastrado[2] == funcionario.Cpf)
                    {
                        existe = true;
                        return (existe, "ID e CPF já existem no cadastro!");
                    }
                    if (cadastrado[0] == funcionario.Id.ToString())
                    {
                        existe = true;
                        return (existe, "ID já existe no cadastro!");
                    }
                    if (cadastrado[2] == funcionario.Cpf)
                    {
                        existe = true;
                        return (existe, "CPF já existe no cadastro!");
                    }
                }
            }
            return (existe, "");
        }
        public (bool, Funcionario) GetDetalhes(int id)
        {
            var existe = false;
            Funcionario funcionario = null;
            using (var file = new FileStream(_localDoArquivo, FileMode.Open))
            using (var leitor = new StreamReader(file))
            {
                while (!leitor.EndOfStream)
                {
                    var linha = leitor.ReadLine();
                    var cadastrado = ConverteAtributos(linha);
                    if (cadastrado.Id == id)
                    {
                        existe = true;
                        funcionario = cadastrado;
                    }
                }
            }
            return (existe, funcionario);
        }
        public List<Funcionario> GetLista()
        {
            var lista = new List<Funcionario>();
            using (var file = new FileStream(_localDoArquivo, FileMode.Open))
            using (var leitor = new StreamReader(file))
            {
                while (!leitor.EndOfStream)
                {
                    var linha = leitor.ReadLine();
                    var funcionario = ConverteAtributos(linha);
                    lista.Add(funcionario);
                }
            }
            return lista;
        }
        public void IncluirUnico(Funcionario funcionario)
        {
            using (var file = new FileStream(_localDoArquivo, FileMode.Append))
            using (var escritor = new StreamWriter(file))
            {
                escritor.WriteLine($"{funcionario.Id};{funcionario.Nome};{funcionario.Cpf};{funcionario.Contato};{funcionario.Salario};{funcionario.Cargo};{funcionario.DataCadastro}");
            }
        }
        public void IncluirVarios(List<Funcionario> lista)
        {
            using (var file = new FileStream(_localDoArquivo, FileMode.Append))
            using (var escritor = new StreamWriter(file))
            {
                foreach (var funcionario in lista)
                {
                    escritor.WriteLine($"{funcionario.Id};{funcionario.Nome};{funcionario.Cpf};{funcionario.Contato};{funcionario.Salario};{funcionario.Cargo};{funcionario.DataCadastro}");
                }
            }
        }
        public bool Remover(int id)
        {
            var novoRepo = new List<Funcionario>();
            var existe = false;
            using (var file = new FileStream(_localDoArquivo, FileMode.Open))
            using (var leitor = new StreamReader(file))
            {
                while (!leitor.EndOfStream)
                {
                    var dados = leitor.ReadLine();
                    var funcionario = ConverteAtributos(dados);
                    if (funcionario.Id == id)
                    {
                        existe = true;
                    }
                    else
                        novoRepo.Add(funcionario);
                }
            }
            if (existe)
            {
                using (var novoFile = new FileStream(_ArquivoTemporario, FileMode.Create))
                using (var escritor = new StreamWriter(novoFile))
                {
                    foreach (var funcionario in novoRepo)
                    {
                        escritor.WriteLine($"{funcionario.Id};{funcionario.Nome};{funcionario.Cpf};{funcionario.Contato};{funcionario.Salario};{funcionario.Cargo};{funcionario.DataCadastro}");

                    }
                }
                File.Delete(_localDoArquivo);
                File.Move(_ArquivoTemporario, _localDoArquivo);
                return existe;
            }
            else
                return existe;
        }
        public (List<Funcionario>, List<string>, int) TrataCSV(string arquivo)
        {
            var lista = new List<Funcionario>();
            var naoAdd = new List<string>();
            var contadorLinhas = 0;
            var numeroConflitos = 0;
            using (var file = new FileStream(arquivo, FileMode.Open))
            using (var leitor = new StreamReader(file))
            {
                while (!leitor.EndOfStream)
                {
                    var dados = leitor.ReadLine();
                    var funcionario = ConverteAtributos(dados);
                    // Varifica se já exite
                    (var existe, var msg) = Existente(funcionario);
                    if (existe)
                    {
                        numeroConflitos++;
                        contadorLinhas++;
                        naoAdd.Add($"Linha {contadorLinhas}; {msg}");
                    }
                    else
                    {
                        lista.Add(funcionario);
                        contadorLinhas++;
                    }
                }
            }
            return (lista, naoAdd, numeroConflitos);
        }
        /// <summary>
        /// Ordena a lista por nome, id ou cargo
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public int Compare(Funcionario x, Funcionario y)
        {
            switch (_ordem.ToLower())
            {
                case "id":
                    return x.Id.CompareTo(y.Id);
                case "nome":
                    return x.Nome.CompareTo(y.Nome);
                case "cargo":
                    return x.Cargo.CompareTo(y.Cargo);
                default:
                    return x.Id.CompareTo(y.Id);
            }
        }
        /// <summary>
        /// Altera o salário do <see cref="Funcionario"/> com id informado
        /// </summary>
        /// <param name="id"></param>
        /// <param name="novoSalario"></param>
        /// <returns>Retorna <see cref="bool"/> para se a operação foi realizada e o sálario antigo</returns>
        public (bool, decimal) AlteraSalarioRepository(int id, decimal novoSalario)
        {
            var novoRepository = new List<Funcionario>();
            var salarioAntigo = 0m;
            var existe = false;
            using (var file = new FileStream(_localDoArquivo, FileMode.Open))
            using (var leitor = new StreamReader(file))
            {
                while (!leitor.EndOfStream)
                {
                    var dados = leitor.ReadLine();
                    var funcionario = ConverteAtributos(dados);

                    if (funcionario.Id == id)
                    {
                        salarioAntigo += funcionario.Salario;
                        funcionario.AlteraSalario(novoSalario);
                        existe = true;
                        novoRepository.Add(funcionario);
                    }
                    else
                    {
                        novoRepository.Add(funcionario);
                    }
                }
            }
            if (existe)
            {
                using (var novoFileStream = new FileStream(_ArquivoTemporario, FileMode.Create))
                using (var escritor = new StreamWriter(novoFileStream))
                {
                    foreach (var funcionario in novoRepository)
                    {
                        escritor.WriteLine($"{funcionario.Id};{funcionario.Nome};{funcionario.Cpf};{funcionario.Contato};{funcionario.Salario};{funcionario.Cargo};{funcionario.DataCadastro}");
                    }
                }
                File.Delete(_localDoArquivo);
                File.Move(_ArquivoTemporario, _localDoArquivo);
                return (true, salarioAntigo);
            }
            else
                return (false, salarioAntigo);
        }
    }
}
