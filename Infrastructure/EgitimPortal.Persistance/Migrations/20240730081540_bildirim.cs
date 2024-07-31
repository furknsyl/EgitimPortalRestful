using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EgitimPortal.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class bildirim : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Message = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 30, 8, 15, 40, 181, DateTimeKind.Utc).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 30, 8, 15, 40, 181, DateTimeKind.Utc).AddTicks(8382));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 30, 8, 15, 40, 181, DateTimeKind.Utc).AddTicks(8384));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 30, 8, 15, 40, 181, DateTimeKind.Utc).AddTicks(8385));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "price", "title" },
                values: new object[] { new DateTime(2024, 7, 30, 8, 15, 40, 185, DateTimeKind.Utc).AddTicks(9347), 260.22m, "Intelligent Rubber Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "description", "price", "title" },
                values: new object[] { new DateTime(2024, 7, 30, 8, 15, 40, 185, DateTimeKind.Utc).AddTicks(9389), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 981.38m, "Ergonomic Metal Table" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 25, 11, 48, 47, 989, DateTimeKind.Utc).AddTicks(6971));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 25, 11, 48, 47, 989, DateTimeKind.Utc).AddTicks(6973));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 25, 11, 48, 47, 989, DateTimeKind.Utc).AddTicks(6975));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 25, 11, 48, 47, 989, DateTimeKind.Utc).AddTicks(6976));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "price", "title" },
                values: new object[] { new DateTime(2024, 7, 25, 11, 48, 47, 994, DateTimeKind.Utc).AddTicks(3350), 229.19m, "Gorgeous Metal Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "description", "price", "title" },
                values: new object[] { new DateTime(2024, 7, 25, 11, 48, 47, 994, DateTimeKind.Utc).AddTicks(3393), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 604.62m, "Unbranded Frozen Salad" });
        }
    }
}
