using System;
using System.Collections.Generic;

namespace Dwd.Lab.Dominio.Entidades
{
    public class Pessoa
    {
        public int Id { get; set; }
        public int EnderecoId { get; set; }
        public string RazaoSocialNome { get; set; }
        public DateTime DataNascimento { get; set; }
        public virtual ICollection<Telefone> Telefones { get; set; }
        public virtual Endereco Endereco { get; set; }

    }
}
