using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace projeto.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Livro",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    CategoriaID = table.Column<int>(nullable: false),
                    Titulo = table.Column<string>(type: "varchar(150)", nullable: false),
                    Autor = table.Column<string>(nullable: true),
                    Quantidade = table.Column<string>(nullable: true),
                    Preco = table.Column<decimal>(type: "numeric(38,2)", nullable: false),
                    DataEntrada = table.Column<DateTime>(type: "datetime", nullable: false),
                    CategoriaID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livro", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Livro_Categoria_CategoriaID",
                        column: x => x.CategoriaID,
                        principalTable: "Categoria",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Livro_Categoria_CategoriaID1",
                        column: x => x.CategoriaID1,
                        principalTable: "Categoria",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "ID", "Nome" },
                values: new object[] { 1, "Software" });

            migrationBuilder.CreateIndex(
                name: "IX_Livro_CategoriaID",
                table: "Livro",
                column: "CategoriaID");

            migrationBuilder.CreateIndex(
                name: "IX_Livro_CategoriaID1",
                table: "Livro",
                column: "CategoriaID1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Livro");

            migrationBuilder.DropTable(
                name: "Categoria");
        }
    }
}
