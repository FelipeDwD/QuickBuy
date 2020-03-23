namespace Dwd.Lab.Dominio.Entidades
{
    public class EnderecoPessoa
    {
        public int Id { get; set; }
        public int EnderecoId { get; set; }
        public int PessoaId { get; set; }
        public virtual Endereco Endereco { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}
