using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ControleEstoqueNETFramework.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_CATEGORIA_PRODUTO",
                columns: table => new
                {
                    ID_CATEGORIA_PRODUTO = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NOME = table.Column<string>(nullable: true),
                    DESCRICAO = table.Column<string>(nullable: true),
                    DT_ATUALIZACAO = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_CATEGORIA_PRODUTO", x => x.ID_CATEGORIA_PRODUTO);
                });

            migrationBuilder.CreateTable(
                name: "TB_USUARIO",
                columns: table => new
                {
                    ID_USUARIO = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NOME = table.Column<string>(nullable: true),
                    SENHA = table.Column<string>(nullable: true),
                    DT_ATUALIZACAO = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_USUARIO", x => x.ID_USUARIO);
                });

            migrationBuilder.CreateTable(
                name: "TB_PRODUTO",
                columns: table => new
                {
                    ID_PRODUTO = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NOME = table.Column<string>(nullable: true),
                    PRECO = table.Column<float>(nullable: false),
                    ID_CATEGORIA_PRODUTO = table.Column<int>(nullable: false),
                    Descricao = table.Column<string>(nullable: true),
                    QUANTIDADE = table.Column<int>(nullable: false),
                    DT_ATUALIZACAO = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PRODUTO", x => x.ID_PRODUTO);
                    table.ForeignKey(
                        name: "FK_TB_PRODUTO_TB_CATEGORIA_PRODUTO_ID_CATEGORIA_PRODUTO",
                        column: x => x.ID_CATEGORIA_PRODUTO,
                        principalTable: "TB_CATEGORIA_PRODUTO",
                        principalColumn: "ID_CATEGORIA_PRODUTO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_PRODUTO_ID_CATEGORIA_PRODUTO",
                table: "TB_PRODUTO",
                column: "ID_CATEGORIA_PRODUTO");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_PRODUTO");

            migrationBuilder.DropTable(
                name: "TB_USUARIO");

            migrationBuilder.DropTable(
                name: "TB_CATEGORIA_PRODUTO");
        }
    }
}
