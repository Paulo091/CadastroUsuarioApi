using CadastroUsuarios.Domain.UsuarioRoot.Commands.Inputs;
using CadastroUsuarios.Domain.UsuarioRoot.Commands.Results;
using System.Threading.Tasks;

namespace CadastroUsuarios.Domain.UsuarioRoot.Interfaces
{
    public interface IUsuarioHandler
    {
        Task<UsuarioCommandResult> Handler(UsuarioAddCommand command);

        Task<UsuarioCommandResult> Handler(UsuarioUpdateCommand command);

        Task<UsuarioCommandResult> Handler(UsuarioDeleteCommand command);

    }
}
