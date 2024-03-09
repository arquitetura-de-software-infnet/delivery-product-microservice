using Delivery.Item.SqlData.Entities;
using Delivery.Item.SqlData.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Delivery.Item.SqlData.Contexts
{
    /// <summary>
    /// Classe para acessar o banco de dados do SqlServer
    /// através do EntityFramework (classe de conexão com o BD)
    /// </summary>
    public class SqlServerContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=PAULONOTE;Initial Catalog=DBDELIVERY_PRODUCT;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductMap());
        }

        public DbSet<Product> Product { get; set; }

    }
}
