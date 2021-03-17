using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DevLibrary.Infrastructure.Persistence.Migrations
{
    public partial class CreateCorrectionEntitiesMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Locacao_Livro_LivroId",
                table: "Locacao");

            migrationBuilder.DropForeignKey(
                name: "FK_Locacao_RegistroATA_RegistroATAId1",
                table: "Locacao");

            migrationBuilder.DropIndex(
                name: "IX_Locacao_LivroId",
                table: "Locacao");

            migrationBuilder.DropIndex(
                name: "IX_Locacao_RegistroATAId1",
                table: "Locacao");

            migrationBuilder.DropColumn(
                name: "LivroId",
                table: "Locacao");

            migrationBuilder.DropColumn(
                name: "RegistroATAId1",
                table: "Locacao");

            migrationBuilder.AlterColumn<int>(
                name: "QuantidadeSuspensaoRegistro",
                table: "RegistroATA",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataSuspensao",
                table: "RegistroATA",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "QuantidadeSuspensaoRegistro",
                table: "RegistroATA",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataSuspensao",
                table: "RegistroATA",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LivroId",
                table: "Locacao",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RegistroATAId1",
                table: "Locacao",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Locacao_LivroId",
                table: "Locacao",
                column: "LivroId");

            migrationBuilder.CreateIndex(
                name: "IX_Locacao_RegistroATAId1",
                table: "Locacao",
                column: "RegistroATAId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Locacao_Livro_LivroId",
                table: "Locacao",
                column: "LivroId",
                principalTable: "Livro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Locacao_RegistroATA_RegistroATAId1",
                table: "Locacao",
                column: "RegistroATAId1",
                principalTable: "RegistroATA",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
