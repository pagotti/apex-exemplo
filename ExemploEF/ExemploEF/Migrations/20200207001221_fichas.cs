using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExemploEF.Migrations
{
    public partial class fichas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fichas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: false),
                    Curso = table.Column<string>(nullable: false),
                    Data = table.Column<DateTime>(nullable: false),
                    Instrutor = table.Column<string>(nullable: false),
                    SalaEquipamentoNota = table.Column<int>(nullable: false),
                    PontualidadeNota = table.Column<int>(nullable: false),
                    ConteudoNota = table.Column<int>(nullable: false),
                    InstrutorNota = table.Column<int>(nullable: false),
                    Dificuldade = table.Column<string>(nullable: true),
                    Sugestao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fichas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fichas");
        }
    }
}
