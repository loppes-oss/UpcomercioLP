using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ComercioLP.Migrations
{
    public partial class OtherEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "vendedor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DtNasc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BaseSalario = table.Column<double>(type: "float", nullable: false),
                    DepartamentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vendedor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_vendedor_Departament_DepartamentId",
                        column: x => x.DepartamentId,
                        principalTable: "Departament",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VendasRecord",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Quantidade = table.Column<double>(type: "float", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    vendedorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendasRecord", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VendasRecord_vendedor_vendedorId",
                        column: x => x.vendedorId,
                        principalTable: "vendedor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VendasRecord_vendedorId",
                table: "VendasRecord",
                column: "vendedorId");

            migrationBuilder.CreateIndex(
                name: "IX_vendedor_DepartamentId",
                table: "vendedor",
                column: "DepartamentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VendasRecord");

            migrationBuilder.DropTable(
                name: "vendedor");
        }
    }
}
