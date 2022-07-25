using CadastroUsuarios.Domain.UsuarioRoot.Commands.Inputs;
using CadastroUsuarios.Domain.UsuarioRoot.Commands.Results;
using CadastroUsuarios.Domain.UsuarioRoot.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroUsuarios.Domain.UsuarioRoot.Commands.Handlers
{
    public class UsuarioHandler : IUsuarioHandler
    {
        public Task<UsuarioCommandResult> Handler(UsuarioAddCommand command)
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioCommandResult> Handler(UsuarioUpdateCommand command)
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioCommandResult> Handler(UsuarioDeleteCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
