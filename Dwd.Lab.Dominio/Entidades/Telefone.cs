namespace Dwd.Lab.Dominio.Entidades
{
    public class Telefone
    {
        public int Id { get; set; }
        public int PessoaId { get; set; }

        public string Numero { get; set; }

        public virtual Pessoa Pessoa { get; set; }
    }
}
