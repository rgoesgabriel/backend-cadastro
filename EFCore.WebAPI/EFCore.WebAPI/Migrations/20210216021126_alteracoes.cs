using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore.WebAPI.Migrations
{
    public partial class alteracoes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PessoaId",
                table: "Dependentes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Dependentes_PessoaId",
                table: "Dependentes",
                column: "PessoaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dependentes_Pessoas_PessoaId",
                table: "Dependentes",
                column: "PessoaId",
                principalTable: "Pessoas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dependentes_Pessoas_PessoaId",
                table: "Dependentes");

            migrationBuilder.DropIndex(
                name: "IX_Dependentes_PessoaId",
                table: "Dependentes");

            migrationBuilder.DropColumn(
                name: "PessoaId",
                table: "Dependentes");
        }
    }
}
