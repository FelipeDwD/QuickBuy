using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dwd.Lab.Web.ViewModel
{
    public class UsuarioCadastroViewModal
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string SenhaEspelho { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Imagem { get; set; }
    }
}
