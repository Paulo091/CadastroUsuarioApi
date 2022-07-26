using CadastroUsuarios.Domain.UsuarioRoot.Commands.Inputs;
using CadastroUsuarios.Domain.UsuarioRoot.Commands.Results;
using CadastroUsuarios.Domain.UsuarioRoot.Interfaces;
using System;
using System.Threading.Tasks;

namespace CadastroUsuarios.Domain.UsuarioRoot.Commands.Handlers
{
    public class UsuarioHandler : IUsuarioHandler
    {
        private readonly IUsuarioRepository _repository;

        public UsuarioHandler(IUsuarioRepository repository)
        {
            _repository = repository;
        }

        public async Task<UsuarioCommandResult> Handler(UsuarioAddCommand command)
        {
            var user = new Usuario(command.Nome, command.Sobrenome, command.Email, command.Escolaridade, command.DataNascimento);
         
            await _repository.AddAsync(user);

            return new UsuarioCommandResult()
            {
                DataNascimento = DateTime.Now,
                Nome = command.Nome,
                Sobrenome = command.Sobrenome,
                Email = command.Email,
                Escolaridade = command.Escolaridade
            };
        }

        public async Task<UsuarioCommandResult> Handler(UsuarioUpdateCommand command)
        {
            var user = new Usuario(command.Id, command.Nome, command.Sobrenome, command.Email, command.Escolaridade, command.DataNascimento);

            await _repository.Update(user);

            return new UsuarioCommandResult()
            {
                Id = command.Id,
                DataNascimento = DateTime.Now,
                Nome = command.Nome,
                Sobrenome = command.Sobrenome,
                Email = command.Email,
                Escolaridade = command.Escolaridade
            };
        }

        public void Handler(int Id)
        {
            var resposta = _repository.ObterPorId(Id);

            _repository.Remove(Id);
        }
    }
}
