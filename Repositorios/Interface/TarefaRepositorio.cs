using APITarefas.Models;
using System.Threading.Tasks;

namespace APITarefas.Repositorios.Interface
{
    public interface ITarefaRepositorio
    {
        Task<List<TarefaModels>> BuscarTodasTarefas();

        Task<TarefaModels> BuscarPorId(int id);
        Task<TarefaModels> Adicionar(TarefaModels tarefa);
        Task<TarefaModels> Atualizar(TarefaModels tarefa, int id);
        Task<bool> Deletar(int id);
    }
}
