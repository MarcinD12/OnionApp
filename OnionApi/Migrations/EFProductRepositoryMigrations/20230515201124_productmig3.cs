using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnionApi.Migrations.EFProductRepositoryMigrations
{
    /// <inheritdoc />
    public partial class productmig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Part_Products_ProductId",
                table: "Part");

            migrationBuilder.DropIndex(
                name: "IX_Part_ProductId",
                table: "Part");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Part");

            migrationBuilder.RenameColumn(
                name: "ProductPrice",
                table: "Products",
                newName: "Price");

            migrationBuilder.CreateTable(
                name: "PartProduct",
                columns: table => new
                {
                    PartsPartId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductsProductId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartProduct", x => new { x.PartsPartId, x.ProductsProductId });
                    table.ForeignKey(
                        name: "FK_PartProduct_Part_PartsPartId",
                        column: x => x.PartsPartId,
                        principalTable: "Part",
                        principalColumn: "PartId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartProduct_Products_ProductsProductId",
                        column: x => x.ProductsProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PartProduct_ProductsProductId",
                table: "PartProduct",
                column: "ProductsProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PartProduct");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Products",
                newName: "ProductPrice");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Part",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Part_ProductId",
                table: "Part",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Part_Products_ProductId",
                table: "Part",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId");
        }
    }
}
