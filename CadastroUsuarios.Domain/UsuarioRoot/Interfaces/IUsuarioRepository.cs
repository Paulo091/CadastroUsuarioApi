using System.Collections.Generic;
using System.Threading.Tasks;

namespace CadastroUsuarios.Domain.UsuarioRoot.Interfaces
{
    public interface IUsuarioRepository
    {
        IEnumerable<Usuario> ListarTodos();

        Usuario ObterPorId(int id);

        Task<int> AddAsync(Usuario usuario);

        void Remove(int id);

        Task<int> Update(Usuario usuario);
    }
}
