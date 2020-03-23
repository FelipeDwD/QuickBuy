namespace Dwd.Lab.Dominio.Entidades
{
    public class PessoaJuridica
    {
        public int Id { get; set; }
        public int PessoaId { get; set; }
        public string Cnpj { get; set; }
        public string NomeRepresentante { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}
