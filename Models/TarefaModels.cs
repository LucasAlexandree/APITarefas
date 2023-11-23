using APITarefas.Enums;

namespace APITarefas.Models
{
    public class TarefaModels
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public  Statustarefa Status { get; set; }

    }
}
