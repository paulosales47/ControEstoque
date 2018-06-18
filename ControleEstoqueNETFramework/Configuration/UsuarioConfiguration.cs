using ControleEstoqueNETFramework.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace ControleEstoqueNETFramework.Configuration
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder
                .ToTable("TB_USUARIO");

            builder
                .Property(u => u.Id)
                .HasColumnName("ID_USUARIO");

            builder
                .Property(u => u.Nome)
                .HasColumnName("NOME");

            builder
                .Property(u => u.Senha)
                .HasColumnName("SENHA");

            builder
                .Property<DateTime>("DT_ATUALIZACAO")
                .HasDefaultValueSql("GETDATE()");

        }
    }
}
