using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EgitimPortal.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class update1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryProduct");

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "integer", nullable: false),
                    CategoryId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => new { x.ProductId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_ProductCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductCategories_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 24, 12, 40, 36, 865, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 24, 12, 40, 36, 865, DateTimeKind.Utc).AddTicks(4718));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 24, 12, 40, 36, 865, DateTimeKind.Utc).AddTicks(4720));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 24, 12, 40, 36, 865, DateTimeKind.Utc).AddTicks(4722));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "description", "price", "title" },
                values: new object[] { new DateTime(2024, 7, 24, 12, 40, 36, 870, DateTimeKind.Utc).AddTicks(704), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 199.82m, "Sleek Soft Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "description", "price", "title" },
                values: new object[] { new DateTime(2024, 7, 24, 12, 40, 36, 870, DateTimeKind.Utc).AddTicks(745), "The Football Is Good For Training And Recreational Purposes", 811.23m, "Generic Granite Tuna" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_CategoryId",
                table: "ProductCategories",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.CreateTable(
                name: "CategoryProduct",
                columns: table => new
                {
                    categoriesId = table.Column<int>(type: "integer", nullable: false),
                    productsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryProduct", x => new { x.categoriesId, x.productsId });
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Categories_categoriesId",
                        column: x => x.categoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Products_productsId",
                        column: x => x.productsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 23, 13, 7, 43, 71, DateTimeKind.Utc).AddTicks(8808));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 23, 13, 7, 43, 71, DateTimeKind.Utc).AddTicks(8811));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 23, 13, 7, 43, 71, DateTimeKind.Utc).AddTicks(8813));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 23, 13, 7, 43, 71, DateTimeKind.Utc).AddTicks(8815));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "description", "price", "title" },
                values: new object[] { new DateTime(2024, 7, 23, 13, 7, 43, 74, DateTimeKind.Utc).AddTicks(4019), "The Football Is Good For Training And Recreational Purposes", 593.85m, "Fantastic Steel Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "description", "price", "title" },
                values: new object[] { new DateTime(2024, 7, 23, 13, 7, 43, 74, DateTimeKind.Utc).AddTicks(4052), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 855.03m, "Fantastic Granite Bacon" });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryProduct_productsId",
                table: "CategoryProduct",
                column: "productsId");
        }
    }
}
