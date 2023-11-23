using System.ComponentModel;

namespace APITarefas.Enums
{
    public enum Statustarefa
    {
        [Description("A Fazer")]
        Afazer = 1,
        [Description("Em Andamento")]
        EmAndamento = 2,
        [Description("concluido")]
        Concluido = 3,
    }
}
