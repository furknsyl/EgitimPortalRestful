using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EgitimPortal.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class db : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 30, 8, 56, 21, 216, DateTimeKind.Utc).AddTicks(9245));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 30, 8, 56, 21, 216, DateTimeKind.Utc).AddTicks(9248));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 30, 8, 56, 21, 216, DateTimeKind.Utc).AddTicks(9250));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 30, 8, 56, 21, 216, DateTimeKind.Utc).AddTicks(9252));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "description", "price", "title" },
                values: new object[] { new DateTime(2024, 7, 30, 8, 56, 21, 220, DateTimeKind.Utc).AddTicks(1032), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 172.59m, "Sleek Frozen Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "description", "price", "title" },
                values: new object[] { new DateTime(2024, 7, 30, 8, 56, 21, 220, DateTimeKind.Utc).AddTicks(1066), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 121.21m, "Sleek Soft Shirt" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "CreatedDate", "description", "price", "title" },
                values: new object[] { new DateTime(2024, 7, 30, 8, 15, 40, 185, DateTimeKind.Utc).AddTicks(9347), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 260.22m, "Intelligent Rubber Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "description", "price", "title" },
                values: new object[] { new DateTime(2024, 7, 30, 8, 15, 40, 185, DateTimeKind.Utc).AddTicks(9389), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 981.38m, "Ergonomic Metal Table" });
        }
    }
}
