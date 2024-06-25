 using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContasEmpresaApp.Infra.DATA.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CONTA",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DESCRICAO = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    VALOR = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DATAVENCIMENTO = table.Column<DateTime>(type: "DateTime", nullable: false),
                    DATAHORAPAGAMENTO = table.Column<DateTime>(type: "DateTime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONTA", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CONTA");
        }
    }
}
