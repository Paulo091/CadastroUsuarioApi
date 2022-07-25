using CadastroUsuarios.Domain.UsuarioRoot;
using Microsoft.EntityFrameworkCore;

namespace CadastroUsuarios.Data.Context
{
    public class UsuariosDbContext : DbContext
    {
        public virtual DbSet<Usuario> Usuarios {get;set;}

        public UsuariosDbContext(DbContextOptions<UsuariosDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=PAULO\SQLEXPRESS;Database=CadastroUsuariosDB;Trusted_Connection=True;");
        }
    }
}
