using Microsoft.EntityFrameworkCore.Migrations;

namespace PoetCRM.Migrations
{
    public partial class UpdateDoctoresEspecialidad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Doctores_IdEspecialidad",
                table: "Doctores",
                column: "IdEspecialidad");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctores_Especialidades_IdEspecialidad",
                table: "Doctores",
                column: "IdEspecialidad",
                principalTable: "Especialidades",
                principalColumn: "IdEspecialidad",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctores_Especialidades_IdEspecialidad",
                table: "Doctores");

            migrationBuilder.DropIndex(
                name: "IX_Doctores_IdEspecialidad",
                table: "Doctores");
        }
    }
}
