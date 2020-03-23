using System;

namespace Dwd.Lab.Dominio.Entidades
{
    public class PessoaFisica
    {
        public int Id { get; set; }
        public int PessoaId { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Cpf { get; set; }
        public string Sexo { get; set; }
        public DateTime DataNascimento { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}
