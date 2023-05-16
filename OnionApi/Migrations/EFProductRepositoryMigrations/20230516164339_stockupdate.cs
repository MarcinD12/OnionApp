using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnionApi.Migrations.EFProductRepositoryMigrations
{
    /// <inheritdoc />
    public partial class stockupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductStock",
                table: "Products",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PartStock",
                table: "Part",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductStock",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "PartStock",
                table: "Part");
        }
    }
}
