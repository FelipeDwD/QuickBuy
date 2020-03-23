using System;
using System.Collections.Generic;

namespace Dwd.Lab.Dominio.Entidades
{
    public class Pessoa
    {
        public int Id { get; set; }
        public int EnderecoId { get; set; }
        public int RelacaoTipoId { get; set; }
        public int PessoaTipoId { get; set; }
        public string RazaoSocialNome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Telefone> Telefones { get; set; }
        public virtual Endereco Endereco { get; set; }
        public virtual PessoaTipo PessoaTipo { get; set; }
        public virtual RelacaoTipo RelacaoTipo { get; set; }

    }
}
