using Microsoft.EntityFrameworkCore.Migrations;

namespace ExemploEF.Migrations
{
    public partial class terceiro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cidade",
                table: "Usuarios");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cidade",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
