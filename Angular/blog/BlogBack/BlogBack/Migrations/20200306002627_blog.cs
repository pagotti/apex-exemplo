using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogBack.Migrations
{
    public partial class blog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Autores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Postagems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(nullable: false),
                    Data = table.Column<DateTime>(nullable: false),
                    Texto = table.Column<string>(nullable: false),
                    Likes = table.Column<int>(nullable: false),
                    Dislikes = table.Column<int>(nullable: false),
                    Foto = table.Column<string>(nullable: true),
                    AutorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Postagems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Postagems_Autores_AutorId",
                        column: x => x.AutorId,
                        principalTable: "Autores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoriaPostagem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoriaId = table.Column<int>(nullable: false),
                    PostagemId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaPostagem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoriaPostagem_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoriaPostagem_Postagems_PostagemId",
                        column: x => x.PostagemId,
                        principalTable: "Postagems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comentarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Texto = table.Column<string>(nullable: false),
                    Data = table.Column<DateTime>(nullable: false),
                    Comentarista = table.Column<string>(nullable: false),
                    PostagemId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comentarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comentarios_Postagems_PostagemId",
                        column: x => x.PostagemId,
                        principalTable: "Postagems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoriaPostagem_CategoriaId",
                table: "CategoriaPostagem",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriaPostagem_PostagemId",
                table: "CategoriaPostagem",
                column: "PostagemId");

            migrationBuilder.CreateIndex(
                name: "IX_Comentarios_PostagemId",
                table: "Comentarios",
                column: "PostagemId");

            migrationBuilder.CreateIndex(
                name: "IX_Postagems_AutorId",
                table: "Postagems",
                column: "AutorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoriaPostagem");

            migrationBuilder.DropTable(
                name: "Comentarios");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Postagems");

            migrationBuilder.DropTable(
                name: "Autores");
        }
    }
}
