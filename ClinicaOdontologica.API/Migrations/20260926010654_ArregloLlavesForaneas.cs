using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicaOdontologica.API.Migrations
{
    /// <inheritdoc />
    public partial class ArregloLlavesForaneas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_detallescita_tratamientos_TratamientoidTratamiento",
                table: "detallescita");

            migrationBuilder.DropIndex(
                name: "IX_detallescita_TratamientoidTratamiento",
                table: "detallescita");

            migrationBuilder.DropColumn(
                name: "TratamientoidTratamiento",
                table: "detallescita");

            migrationBuilder.AlterColumn<DateTime>(
                name: "fecha_cita",
                table: "citas",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.CreateIndex(
                name: "IX_detallescita_id_tratamiento",
                table: "detallescita",
                column: "id_tratamiento");

            migrationBuilder.AddForeignKey(
                name: "FK_detallescita_tratamientos_id_tratamiento",
                table: "detallescita",
                column: "id_tratamiento",
                principalTable: "tratamientos",
                principalColumn: "id_tratamiento",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_detallescita_tratamientos_id_tratamiento",
                table: "detallescita");

            migrationBuilder.DropIndex(
                name: "IX_detallescita_id_tratamiento",
                table: "detallescita");

            migrationBuilder.AddColumn<int>(
                name: "TratamientoidTratamiento",
                table: "detallescita",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "fecha_cita",
                table: "citas",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.CreateIndex(
                name: "IX_detallescita_TratamientoidTratamiento",
                table: "detallescita",
                column: "TratamientoidTratamiento");

            migrationBuilder.AddForeignKey(
                name: "FK_detallescita_tratamientos_TratamientoidTratamiento",
                table: "detallescita",
                column: "TratamientoidTratamiento",
                principalTable: "tratamientos",
                principalColumn: "id_tratamiento",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
