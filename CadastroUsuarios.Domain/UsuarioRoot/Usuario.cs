using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroUsuarios.Domain.UsuarioRoot
{
    public class Usuario
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public string Email { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public int Escolaridade { get; private set; }
        protected Usuario() { }
    }
}
