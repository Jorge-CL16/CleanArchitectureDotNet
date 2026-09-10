using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Infraestructure.Persistence.Settings
{
    internal class ProductSettings : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(prop => prop.Name)
                .HasMaxLength(200)
                .IsRequired();

            builder.HasIndex(prop => prop.Name).IsUnique();

            builder.Property(x => x.Description)
                .HasMaxLength(2000);


            builder.ComplexProperty(prop => prop.Price, action =>
            {
                action.Property(e => e.Amount).HasColumnName("Precio").HasPrecision(18, 2);
                action.Property(e => e.Currency).HasColumnName("Moneda");
            });

            builder.ComplexProperty(prop => prop.InventoryQuantity, action =>
            {
                action.Property(e => e.Value).HasColumnName("Inventario");
            });
        }
    }
}
