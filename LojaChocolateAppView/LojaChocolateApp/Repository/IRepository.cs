using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaChocolateApp.Repository
{
    public interface IRepository<T> : IComparer<T>
    {
        /// <summary>
        /// Acessa o repositório para gerar uma lista com todos objetos da classe selecionada
        /// </summary>
        /// <returns></returns>
        List<T> GetLista();
        /// <summary>
        /// Acessa o repositório para retornar um objeto com seus detalhes
        /// </summary>
        /// <param name="id">Atributo id do objeto</param>
        /// <returns><see cref="true"/> se o objeto existe, <see cref="false"/> se não e o proprio objeto</returns>
        (bool, T) GetDetalhes(string id);
        /// <summary>
        /// Incluí objeto ao repositório
        /// </summary>
        /// <param name="t">Objeto que será adicionado</param>
        void IncluirUnico(T t);
        /// <summary>
        /// Incluir vários objetos ao repositório através de lista
        /// </summary>
        /// <param name="t">Lista de objetos</param>
        void IncluirVarios(List<T> lista);
        /// <summary>
        /// Remove o objeto do repositório
        /// </summary>
        /// <param name="id">Id do objeto escolhido</param>
        /// <returns><see cref="true"/> para removido e <see cref="false"/> para não removido</returns>
        bool Remover(string id);
        /// <summary>
        /// Verifica se o objeto existe no repositório
        /// </summary>
        /// <param name="t">Objeto escolhido para a verificação</param>
        /// <returns><see cref="true"/> se existe, <see cref="false"/> se não existe e <see cref="string"/> com a mensagem do atributo encontrado</returns>
        (bool, string) Existente(T t);
        /// <summary>
        /// Trata arquivo CSV para o padrão correto e verifica se algum objeto do cadastro já existe no repositório
        /// </summary>
        /// <param name="arquivo">Arquivo CSV</param>
        /// <returns><see cref="List{T}"/> de objetos cadastrados, <see cref="List{string}"/> de objetos que não foram cadastrados e <see cref="int"/> para a quantidade que não foi cadastrada</returns>
        (List<T>, List<string>, int) TrataCSV(string arquivo);
        /// <summary>
        /// Trata linha transformando a <see cref="string"/> em objeto
        /// </summary>
        /// <param name="linha">Linha de arquivo CSV</param>
        /// <returns>Objeto transformado</returns>
        T ConverteAtributos(string linha);
    }
}
