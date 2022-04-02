using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Examen.Caso3.Infrastructure.Data.Migrations
{
    public partial class UpdateCorreoUnique : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Cliente",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaNacimiento",
                table: "Cliente",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_Correo",
                table: "Cliente",
                column: "Correo",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Cliente_Correo",
                table: "Cliente");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Cliente",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaNacimiento",
                table: "Cliente",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);
        }
    }
}
