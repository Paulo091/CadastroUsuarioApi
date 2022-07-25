using CadastroUsuarios.Domain.UsuarioRoot.Queries;
using System.Threading.Tasks;

namespace CadastroUsuarios.Domain.UsuarioRoot.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<UsuarioQueryResult> ListarTodos();
    }
}
