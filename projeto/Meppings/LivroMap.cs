using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using projeto.Models;

namespace projeto.Meppings
{
    public class LivroMap : IEntityTypeConfiguration<Livro>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Livro> builder)
        {
            builder.ToTable("Livro");

            builder.Property(p => p.ID)
                .ValueGeneratedNever();

            builder.Property(p => p.Titulo)
                .HasColumnType("varchar(150)")
                .IsRequired();

            builder.Property(p => p.Preco)
                .HasColumnType("numeric(38,2)");

            builder.Property(p => p.DataEntrada)
                .HasColumnType("datetime");

            builder.HasOne(p => p.Categoria)
                 .WithMany(p => p.Livros)
                 .HasForeignKey(p => p.CategoriaID)
                 .OnDelete(DeleteBehavior.NoAction);

           
        }
    }
}
