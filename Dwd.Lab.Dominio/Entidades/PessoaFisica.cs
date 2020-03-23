namespace Dwd.Lab.Dominio.Entidades
{
    public class PessoaFisica
    {
        public int Id { get; set; }
        public int PessoaId { get; set; }
        public string Cpf { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}
