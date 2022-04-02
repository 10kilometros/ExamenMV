using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Examen.Caso3.Infrastructure.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Activo = table.Column<bool>(nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nombres = table.Column<string>(type: "varchar(250)", nullable: false),
                    Apellidos = table.Column<string>(type: "varchar(250)", nullable: false),
                    Correo = table.Column<string>(type: "varchar(320)", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Direccion = table.Column<string>(type: "varchar(800)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");
        }
    }
}
