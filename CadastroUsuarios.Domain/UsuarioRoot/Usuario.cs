using System;
using System.ComponentModel.DataAnnotations;

namespace CadastroUsuarios.Domain.UsuarioRoot
{
    public class Usuario
    {
        public int Id { get; private set; }
        [Required]
        public string Nome { get; private set; }
        [Required]
        public string Sobrenome { get; private set; }
        [Required]
        public string Email { get; private set; }
        [Required]
        public DateTime DataNascimento { get; private set; }
        [Required]
        public int Escolaridade { get; private set; }
        
        protected Usuario() { }

        public Usuario(string Nome,string Sobrenome, string Email, int Escolaridade, DateTime DataNascimento)
        {
            this.Nome = Nome;
            this.Sobrenome = Sobrenome;
            this.Email = Email;
            this.Escolaridade = Escolaridade;
            this.DataNascimento = DataNascimento;
        }

        public Usuario(int Id, string Nome, string Sobrenome, string Email, int Escolaridade, DateTime DataNascimento)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Sobrenome = Sobrenome;
            this.Email = Email;
            this.Escolaridade = Escolaridade;
            this.DataNascimento = DataNascimento;
        }
    }
}
