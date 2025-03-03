using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VeterinariaAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCitasTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DoctorId",
                table: "HistorialMedico",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "Citas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_HistorialMedico_DoctorId",
                table: "HistorialMedico",
                column: "DoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_HistorialMedico_Usuarios_DoctorId",
                table: "HistorialMedico",
                column: "DoctorId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HistorialMedico_Usuarios_DoctorId",
                table: "HistorialMedico");

            migrationBuilder.DropIndex(
                name: "IX_HistorialMedico_DoctorId",
                table: "HistorialMedico");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "HistorialMedico");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Citas");
        }
    }
}
