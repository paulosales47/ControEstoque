﻿// <auto-generated />
using System;
using ControleEstoqueNETFramework.DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ControleEstoqueNETFramework.Migrations
{
    [DbContext(typeof(EstoqueContext))]
    partial class EstoqueContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ControleEstoqueNETFramework.Models.CategoriaProduto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID_CATEGORIA_PRODUTO")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DT_ATUALIZACAO")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Descricao")
                        .HasColumnName("DESCRICAO");

                    b.Property<string>("Nome")
                        .HasColumnName("NOME");

                    b.HasKey("Id");

                    b.ToTable("TB_CATEGORIA_PRODUTO");
                });

            modelBuilder.Entity("ControleEstoqueNETFramework.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID_PRODUTO")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DT_ATUALIZACAO")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Descricao");

                    b.Property<int>("ID_CATEGORIA_PRODUTO");

                    b.Property<string>("Nome")
                        .HasColumnName("NOME");

                    b.Property<float>("Preco")
                        .HasColumnName("PRECO");

                    b.Property<int>("Quantidade")
                        .HasColumnName("QUANTIDADE");

                    b.HasKey("Id");

                    b.HasIndex("ID_CATEGORIA_PRODUTO");

                    b.ToTable("TB_PRODUTO");
                });

            modelBuilder.Entity("ControleEstoqueNETFramework.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID_USUARIO")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DT_ATUALIZACAO")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Nome")
                        .HasColumnName("NOME");

                    b.Property<string>("Senha")
                        .HasColumnName("SENHA");

                    b.HasKey("Id");

                    b.ToTable("TB_USUARIO");
                });

            modelBuilder.Entity("ControleEstoqueNETFramework.Models.Produto", b =>
                {
                    b.HasOne("ControleEstoqueNETFramework.Models.CategoriaProduto", "Categoria")
                        .WithMany("Produtos")
                        .HasForeignKey("ID_CATEGORIA_PRODUTO")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
