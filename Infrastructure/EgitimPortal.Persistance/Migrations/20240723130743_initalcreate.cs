using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EgitimPortal.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class initalcreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ParentId = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Priority = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    title = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    price = table.Column<decimal>(type: "numeric", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

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

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Name", "ParentId", "Priority" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 23, 13, 7, 43, 71, DateTimeKind.Utc).AddTicks(8808), false, "Yazılım", 0, 1 },
                    { 2, new DateTime(2024, 7, 23, 13, 7, 43, 71, DateTimeKind.Utc).AddTicks(8811), false, "Dil", 0, 2 },
                    { 3, new DateTime(2024, 7, 23, 13, 7, 43, 71, DateTimeKind.Utc).AddTicks(8813), false, "C# Dersleri", 1, 1 },
                    { 4, new DateTime(2024, 7, 23, 13, 7, 43, 71, DateTimeKind.Utc).AddTicks(8815), false, "İngilizce", 1, 2 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "description", "price", "title" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 23, 13, 7, 43, 74, DateTimeKind.Utc).AddTicks(4019), false, "The Football Is Good For Training And Recreational Purposes", 593.85m, "Fantastic Steel Hat" },
                    { 2, new DateTime(2024, 7, 23, 13, 7, 43, 74, DateTimeKind.Utc).AddTicks(4052), false, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 855.03m, "Fantastic Granite Bacon" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryProduct_productsId",
                table: "CategoryProduct",
                column: "productsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryProduct");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
