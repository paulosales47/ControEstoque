using ControleEstoqueNETFramework.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace ControleEstoqueNETFramework.Configuration
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder
                .ToTable("TB_PRODUTO");

            builder
                .Property(p => p.Id)
                .HasColumnName("ID_PRODUTO");

            builder
                .Property(p => p.Nome)
                .HasColumnName("NOME");

            builder
                .Property(p => p.Preco)
                .HasColumnName("PRECO");

            builder
                .Property(p => p.Quantidade)
                .HasColumnName("QUANTIDADE");

            builder
                .Property<int>("ID_CATEGORIA_PRODUTO");

            builder
                .HasOne(p => p.Categoria)
                .WithMany(c => c.Produtos)
                .HasForeignKey("ID_CATEGORIA_PRODUTO");

            builder
                .Property<DateTime>("DT_ATUALIZACAO")
                .HasDefaultValueSql("GETDATE()");

        }
    }
}
