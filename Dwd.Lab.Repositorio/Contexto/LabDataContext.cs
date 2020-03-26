using Dwd.Lab.Dominio.Entidades;
using Dwd.Lab.Dominio.ObjetoDeValor;
using Dwd.Lab.Repositorio.Map;
using Microsoft.EntityFrameworkCore;

namespace Dwd.Lab.Repositorio.Contexto
{
    public class LabDataContext : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<ItemPedido> ItemPedido { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<FormaPagamento> FormaPagamento { get; set; }        
        public DbSet<ImagemProduto> ImagemProduto { get; set; }       
        public DbSet<CategoriaProduto> CategoriaProduto { get; set; }
        public DbSet<SubCategoriaProduto> SubCategoriaProduto { get; set; }        
        public DbSet<Telefone> Telefone { get; set; }
        public DbSet<PessoaTipo> PessoaTipo { get; set; }
        public DbSet<RelacaoTipo> RelacaoTipo { get; set; }
        public DbSet<PessoaFisica> PessoaFisica { get; set; }
        public DbSet<PessoaJuridica> PessoaJuridica { get; set; }
        public DbSet<EnderecoPessoa> EnderecoPessoa { get; set; }
        public DbSet<Estado> Estado { get; set; }
        public DbSet<Cidade> Cidade { get; set; }

        public LabDataContext(DbContextOptions<LabDataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new EnderecoMap());
            modelBuilder.ApplyConfiguration(new PedidoMap());
            modelBuilder.ApplyConfiguration(new ItemPedidoMap());
            modelBuilder.ApplyConfiguration(new ProdutoMap());
            modelBuilder.ApplyConfiguration(new FormaPagamentoMap());          
            modelBuilder.ApplyConfiguration(new ImagemProdutoMap());            
            modelBuilder.ApplyConfiguration(new CategoriaProdutoMap());
            modelBuilder.ApplyConfiguration(new SubCategoriaProdutoMap());            
            modelBuilder.ApplyConfiguration(new TelefoneMap());
            modelBuilder.ApplyConfiguration(new PessoaTipoMap());
            modelBuilder.ApplyConfiguration(new RelacaoTipoMap());
            modelBuilder.ApplyConfiguration(new PessoaFisicaMap());
            modelBuilder.ApplyConfiguration(new PessoaJuridicaMap());
            modelBuilder.ApplyConfiguration(new EnderecoPessoaMap());
            modelBuilder.ApplyConfiguration(new EstadoMap());
            modelBuilder.ApplyConfiguration(new CidadeMap());
        }
    }
}
