using Dwd.Lab.Dominio.Entidades;
using Dwd.Lab.Dominio.ObjetoDeValor;
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


    }
}
