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
        }
    }
}
