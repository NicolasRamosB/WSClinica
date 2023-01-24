using Microsoft.EntityFrameworkCore.Migrations;

namespace WSClinica.Migrations
{
    public partial class tres : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medico_Especialidad_EspecialidadId1",
                table: "Medico");

            migrationBuilder.DropIndex(
                name: "IX_Medico_EspecialidadId1",
                table: "Medico");

            migrationBuilder.DropColumn(
                name: "EspecialidadId1",
                table: "Medico");

            migrationBuilder.AlterColumn<int>(
                name: "EspecialidadId",
                table: "Medico",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Medico_EspecialidadId",
                table: "Medico",
                column: "EspecialidadId");

            migrationBuilder.AddForeignKey(
                name: "FK_Medico_Especialidad_EspecialidadId",
                table: "Medico",
                column: "EspecialidadId",
                principalTable: "Especialidad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medico_Especialidad_EspecialidadId",
                table: "Medico");

            migrationBuilder.DropIndex(
                name: "IX_Medico_EspecialidadId",
                table: "Medico");

            migrationBuilder.AlterColumn<string>(
                name: "EspecialidadId",
                table: "Medico",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "EspecialidadId1",
                table: "Medico",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Medico_EspecialidadId1",
                table: "Medico",
                column: "EspecialidadId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Medico_Especialidad_EspecialidadId1",
                table: "Medico",
                column: "EspecialidadId1",
                principalTable: "Especialidad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
