using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using projeto.Models;

namespace projeto.Meppings
{
    public class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("Categoria");

            builder.Property(p => p.Nome)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.HasData(
                new Categoria(1, "Software")
                );
        }
    }
}
