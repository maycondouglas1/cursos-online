using System.Data.Entity;
using VireiDev.Models;

namespace VireiDev.Context
{
    public class Contexto : DbContext
    {
        public DbSet<CursoModels> Cursos { get; set; }
        public DbSet<TurmaModels> Turmas { get; set; }
    }
}