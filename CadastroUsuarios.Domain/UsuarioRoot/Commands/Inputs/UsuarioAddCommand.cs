using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroUsuarios.Domain.UsuarioRoot.Commands.Inputs
{
    public class UsuarioAddCommand
    {
        [Required(ErrorMessage ="O nome é obrigatório!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O sobrenome é obrigatório!")]
        public string Sobrenome { get; set; }
        [Required(ErrorMessage = "O email é obrigatório!")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "E-mail em formato inválido.")]
        public string Email { get; set; }
        [Required]
        [Range(0, 3, ErrorMessage = "Escolaridade inválida!")]
        public int Escolaridade { get; set; }

        public DateTime DataNascimento { get; set; }
    }
}
