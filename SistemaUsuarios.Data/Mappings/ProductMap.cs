using Delivery.Item.SqlData.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Delivery.Item.SqlData.Mappings
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("PRODUCT");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .HasColumnName("PRODUCTID")
                .IsRequired();

            builder.Property(p => p.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(p => p.Stock)
                .HasColumnName("STOCK")
                .IsRequired();

            builder.Property(p => p.Price)
                .IsRequired();
        }
    }
}
