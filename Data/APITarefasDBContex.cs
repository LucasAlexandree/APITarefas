using APITarefas.Data.Map;
using APITarefas.Models;
using Microsoft.EntityFrameworkCore;

namespace APITarefas.Data
{
    public class APITarefasDBContex : DbContext
    {
        public APITarefasDBContex(DbContextOptions<APITarefasDBContex> options)
            : base(options)
        {
        }
        public DbSet<TarefaModels> tarefas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TarefaMap());
            base.OnModelCreating(modelBuilder);
        }

    }
}
