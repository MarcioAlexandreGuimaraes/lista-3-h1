using ListaH1.Domain;
using Microsoft.EntityFrameworkCore;

namespace ListaH1.Data
{
    public class EscolaContext : DbContext
    {
        public EscolaContext(DbContextOptions<EscolaContext> options) : base(options) { }

        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }
    }
}
