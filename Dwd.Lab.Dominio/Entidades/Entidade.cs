using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Dwd.Lab.Dominio.Entidades
{
    public abstract class Entidade
    {
        [NotMapped]
        public List<string> _mensagensValidacao { get; set; }

        private List<string> MensagemValidacao
        {
            get { return _mensagensValidacao ?? (_mensagensValidacao = new List<string>());  }
        }

        protected abstract void Validate();

        protected void LimparMensagensValidacao()
        {
            MensagemValidacao.Clear();
        }

        protected void AdicionarCritica(string mensagem)
        {
            MensagemValidacao.Add($"Critíca: {mensagem}");
        }

        public bool EhValido
        {
            get { return !MensagemValidacao.Any();  }
        }
    }
}
