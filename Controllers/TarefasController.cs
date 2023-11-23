using APITarefas.Models;
using APITarefas.Repositorios.Interface;
using Microsoft.AspNetCore.Mvc;

namespace APITarefas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefasController : ControllerBase
    {
        private readonly ITarefaRepositorio _tarefaRepositorio;
        public TarefasController(ITarefaRepositorio tarefaRepositorio)
        {
            _tarefaRepositorio = tarefaRepositorio;
        }
        [HttpGet]
        public async Task<ActionResult<List<TarefaModels>>> BuscarTodasTarefas()
        {
            List<TarefaModels> tarefas = await _tarefaRepositorio.BuscarTodasTarefas();
            return Ok(tarefas);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<TarefaModels>> BuscarPorId(int id)
        {
            TarefaModels tarefa = await _tarefaRepositorio.BuscarPorId(id);
            return Ok(tarefa);
        }
        [HttpPost]
        public async Task<ActionResult<TarefaModels>> Cadastrar ([FromBody] TarefaModels tarefaModel)
        {
            TarefaModels  tarefa = await _tarefaRepositorio.Adicionar(tarefaModel);
            return Ok(tarefa);

        }
        [HttpPut("{id}")]
        public async Task<ActionResult<TarefaModels>> Atualizar ([FromBody] TarefaModels tarefaModel , int id)
        {
            tarefaModel.Id = id;
            TarefaModels tarefa = await _tarefaRepositorio.Atualizar(tarefaModel,id);
            return Ok(tarefa);

        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<TarefaModels>> Deletar (int id)
        {
            
            bool deletado  = await _tarefaRepositorio.Deletar(id);
            return Ok(deletado);

        }

    }
}
