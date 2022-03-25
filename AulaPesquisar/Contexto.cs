using Microsoft.EntityFrameworkCore;

namespace AulaPesquisar
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> opt) : base(opt) { }
        public DbSet<Pessoa> PESSOAS { get; set; }
    }
}
