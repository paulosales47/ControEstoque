using ControleEstoqueNETFramework.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace ControleEstoqueNETFramework.Configuration
{
    public class CategoriaProdutoConfiguration : IEntityTypeConfiguration<CategoriaProduto>
    {
        public void Configure(EntityTypeBuilder<CategoriaProduto> builder)
        {
            builder
                .ToTable("TB_CATEGORIA_PRODUTO");

            builder
                .Property(cp => cp.Id)
                .HasColumnName("ID_CATEGORIA_PRODUTO");

            builder
                .Property(cp => cp.Nome)
                .HasColumnName("NOME");

            builder
                .Property(cp => cp.Descricao)
                .HasColumnName("DESCRICAO");

            builder
                .Property<DateTime>("DT_ATUALIZACAO")
                .HasDefaultValueSql("GETDATE()");
        }
    }
}
