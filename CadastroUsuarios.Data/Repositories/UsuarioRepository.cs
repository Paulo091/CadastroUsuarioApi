using CadastroUsuarios.Data.Context;
using CadastroUsuarios.Domain.UsuarioRoot;
using CadastroUsuarios.Domain.UsuarioRoot.Commands.Inputs;
using CadastroUsuarios.Domain.UsuarioRoot.Interfaces;
using CadastroUsuarios.Domain.UsuarioRoot.Queries;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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

        public async Task<UsuarioQueryResult> ListarTodos()
        {
            var resultado = await _context.Usuarios.FindAsync();
            //TODO:Implementar mapper
            return new UsuarioQueryResult();
        }

    }
}
