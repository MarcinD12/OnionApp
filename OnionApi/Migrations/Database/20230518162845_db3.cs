using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnionApi.Migrations.Database
{
    /// <inheritdoc />
    public partial class db3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Parts_Orders_OrderId",
                table: "Parts");

            migrationBuilder.DropIndex(
                name: "IX_Parts_OrderId",
                table: "Parts");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Parts");

            migrationBuilder.CreateTable(
                name: "OrderPart",
                columns: table => new
                {
                    OrdersOrderId = table.Column<int>(type: "INTEGER", nullable: false),
                    PartsPartId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderPart", x => new { x.OrdersOrderId, x.PartsPartId });
                    table.ForeignKey(
                        name: "FK_OrderPart_Orders_OrdersOrderId",
                        column: x => x.OrdersOrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderPart_Parts_PartsPartId",
                        column: x => x.PartsPartId,
                        principalTable: "Parts",
                        principalColumn: "PartId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderPart_PartsPartId",
                table: "OrderPart",
                column: "PartsPartId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderPart");

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Parts",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Parts_OrderId",
                table: "Parts",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Parts_Orders_OrderId",
                table: "Parts",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId");
        }
    }
}
