using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FazendaWeb.Migrations
{
    public partial class NovasClasses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PastoId",
                table: "Rebanho",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Pasto",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: true),
                    Area = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pasto", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rebanho_PastoId",
                table: "Rebanho",
                column: "PastoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rebanho_Pasto_PastoId",
                table: "Rebanho",
                column: "PastoId",
                principalTable: "Pasto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rebanho_Pasto_PastoId",
                table: "Rebanho");

            migrationBuilder.DropTable(
                name: "Pasto");

            migrationBuilder.DropIndex(
                name: "IX_Rebanho_PastoId",
                table: "Rebanho");

            migrationBuilder.DropColumn(
                name: "PastoId",
                table: "Rebanho");
        }
    }
}
