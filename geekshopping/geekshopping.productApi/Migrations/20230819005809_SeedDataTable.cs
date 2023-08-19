using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace geekshopping.productApi.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "id", "category_name", "description", "name", "price", "image_url" },
                values: new object[] { 20L, "test category", "desc test", "name test", 33.219999999999999, "imurl.com.test" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "id",
                keyValue: 20L);
        }
    }
}
