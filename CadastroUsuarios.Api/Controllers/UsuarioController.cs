using CadastroUsuarios.Data.Context;
using CadastroUsuarios.Domain.UsuarioRoot;
using CadastroUsuarios.Domain.UsuarioRoot.Commands.Inputs;
using CadastroUsuarios.Domain.UsuarioRoot.Commands.Results;
using CadastroUsuarios.Domain.UsuarioRoot.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CadastroUsuarios.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<object> Get([FromServices] IUsuarioRepository repository)
        {
            return repository.ListarTodos();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public Usuario Get(int id, [FromServices] IUsuarioRepository repository)
        {
            return  repository.ObterPorId(id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public async Task<UsuarioCommandResult> Post(UsuarioAddCommand command, [FromServices] IUsuarioHandler handler)
        {
            return await handler.Handler(command);
        }

        // PUT api/<ValuesController>/5
        [HttpPut]
        public async Task<UsuarioCommandResult> Put(UsuarioUpdateCommand command, [FromServices] IUsuarioHandler handler)
        {
            return await handler.Handler(command);
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id, [FromServices] IUsuarioHandler handler)
        {
            handler.Handler(id);
        }
    }
}
