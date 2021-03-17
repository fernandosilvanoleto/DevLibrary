using Microsoft.EntityFrameworkCore.Migrations;

namespace DevLibrary.Infrastructure.Persistence.Migrations
{
    public partial class CreateCorrectionEntitiesRegistroATAAlunosMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RegistroATA_Alunos_AlunoId",
                table: "RegistroATA");

            migrationBuilder.DropIndex(
                name: "IX_RegistroATA_AlunoId",
                table: "RegistroATA");

            migrationBuilder.DropColumn(
                name: "AlunoId",
                table: "RegistroATA");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AlunoId",
                table: "RegistroATA",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RegistroATA_AlunoId",
                table: "RegistroATA",
                column: "AlunoId");

            migrationBuilder.AddForeignKey(
                name: "FK_RegistroATA_Alunos_AlunoId",
                table: "RegistroATA",
                column: "AlunoId",
                principalTable: "Alunos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
