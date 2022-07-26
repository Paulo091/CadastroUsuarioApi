using CadastroUsuarios.Data.Context;
using CadastroUsuarios.Domain.UsuarioRoot;
using CadastroUsuarios.Domain.UsuarioRoot.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroUsuarios.Data.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly UsuariosDbContext _context;

        public UsuarioRepository(UsuariosDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Usuario> ListarTodos()
        {
            return _context.Set<Usuario>().ToList();
        }

        public Usuario ObterPorId(int id)
        {
            return _context.Set<Usuario>().Where(x => x.Id == id).FirstOrDefault();
        }

        public async Task<int> AddAsync(Usuario usuario)
        {
            try
            {
                await _context.Usuarios.AddAsync(usuario);
                return await _context.SaveChangesAsync();                 
            }
            catch(Exception e)
            {
                throw new Exception($"Não foi possível inserir os dados: {e}");
            }
        }

        public void Remove(int id)
        {
            try
            {
                var user = _context.Set<Usuario>().Where(x => x.Id == id).FirstOrDefault();

                if (user == null)
                    return;

                var result = _context.Usuarios.Remove(user);

                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception($"Não foi possível deletar os dados: {e}");
            }
        }

        public async Task<int> Update(Usuario usuario)
        {
            try
            {
                _context.Set<Usuario>().Update(usuario);                
                return await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception($"Não foi possível alterar os dados: {e}");
            }
        }
    }
}
