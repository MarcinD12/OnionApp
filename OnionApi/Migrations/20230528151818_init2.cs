using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnionApi.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PartStock");

            migrationBuilder.AddColumn<int>(
                name: "PartId",
                table: "Stocks",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_PartId",
                table: "Stocks",
                column: "PartId");

            migrationBuilder.AddForeignKey(
                name: "FK_Stocks_Parts_PartId",
                table: "Stocks",
                column: "PartId",
                principalTable: "Parts",
                principalColumn: "PartId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stocks_Parts_PartId",
                table: "Stocks");

            migrationBuilder.DropIndex(
                name: "IX_Stocks_PartId",
                table: "Stocks");

            migrationBuilder.DropColumn(
                name: "PartId",
                table: "Stocks");

            migrationBuilder.CreateTable(
                name: "PartStock",
                columns: table => new
                {
                    PartsPartId = table.Column<int>(type: "INTEGER", nullable: false),
                    StocksStockId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartStock", x => new { x.PartsPartId, x.StocksStockId });
                    table.ForeignKey(
                        name: "FK_PartStock_Parts_PartsPartId",
                        column: x => x.PartsPartId,
                        principalTable: "Parts",
                        principalColumn: "PartId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartStock_Stocks_StocksStockId",
                        column: x => x.StocksStockId,
                        principalTable: "Stocks",
                        principalColumn: "StockId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PartStock_StocksStockId",
                table: "PartStock",
                column: "StocksStockId");
        }
    }
}
