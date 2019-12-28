
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

        public Entidade()
        {
            Validate();
        }

        /// <summary>
        ///  Implementar método "GerarExcecao()"
        /// </summary>
        protected abstract void Validate();        
               

        public bool EhValido
        {
            get { return !MensagemValidacao.Any();  }
        }
    }
}
