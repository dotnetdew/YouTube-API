using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YouTubeApi.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Update2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CraetedDate", "Name" },
                values: new object[] { new DateTime(2024, 6, 30, 10, 16, 7, 134, DateTimeKind.Utc).AddTicks(7978), "Toys, Electronics & Baby" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CraetedDate", "Name" },
                values: new object[] { new DateTime(2024, 6, 30, 10, 16, 7, 134, DateTimeKind.Utc).AddTicks(7998), "Garden & Outdoors" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CraetedDate", "Name" },
                values: new object[] { new DateTime(2024, 6, 30, 10, 16, 7, 134, DateTimeKind.Utc).AddTicks(8007), "Beauty" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CraetedDate",
                value: new DateTime(2024, 6, 30, 15, 16, 7, 135, DateTimeKind.Local).AddTicks(2695));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CraetedDate",
                value: new DateTime(2024, 6, 30, 15, 16, 7, 135, DateTimeKind.Local).AddTicks(2697));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CraetedDate",
                value: new DateTime(2024, 6, 30, 15, 16, 7, 135, DateTimeKind.Local).AddTicks(2700));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CraetedDate",
                value: new DateTime(2024, 6, 30, 15, 16, 7, 135, DateTimeKind.Local).AddTicks(2702));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CraetedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 6, 30, 15, 16, 7, 138, DateTimeKind.Local).AddTicks(1345), "Alias perferendis dicta aliquid deleniti.", "Gülüyorum." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CraetedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 6, 30, 15, 16, 7, 138, DateTimeKind.Local).AddTicks(1395), "Ipsam sevindi suscipit sevindi gazete.", "Cezbelendi hesap." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CraetedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 6, 30, 15, 16, 7, 138, DateTimeKind.Local).AddTicks(1434), "Exercitationem hesap inventore incidunt doğru.", "Ekşili." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CraetedDate", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 6, 30, 15, 16, 7, 141, DateTimeKind.Local).AddTicks(8818), 2.140361208584010m, 321.86m, "Tasty Fresh Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CraetedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 6, 30, 15, 16, 7, 141, DateTimeKind.Local).AddTicks(8859), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 9.698697109497860m, 520.13m, "Intelligent Rubber Pants" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CraetedDate", "Name" },
                values: new object[] { new DateTime(2024, 6, 26, 8, 35, 44, 492, DateTimeKind.Utc).AddTicks(6343), "Jewelery" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CraetedDate", "Name" },
                values: new object[] { new DateTime(2024, 6, 26, 8, 35, 44, 492, DateTimeKind.Utc).AddTicks(6361), "Automotive" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CraetedDate", "Name" },
                values: new object[] { new DateTime(2024, 6, 26, 8, 35, 44, 492, DateTimeKind.Utc).AddTicks(6433), "Jewelery, Baby & Clothing" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CraetedDate",
                value: new DateTime(2024, 6, 26, 13, 35, 44, 492, DateTimeKind.Local).AddTicks(9589));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CraetedDate",
                value: new DateTime(2024, 6, 26, 13, 35, 44, 492, DateTimeKind.Local).AddTicks(9593));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CraetedDate",
                value: new DateTime(2024, 6, 26, 13, 35, 44, 492, DateTimeKind.Local).AddTicks(9596));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CraetedDate",
                value: new DateTime(2024, 6, 26, 13, 35, 44, 492, DateTimeKind.Local).AddTicks(9599));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CraetedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 6, 26, 13, 35, 44, 495, DateTimeKind.Local).AddTicks(6826), "Için türemiş tempora öyle kapının.", "Yazın." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CraetedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 6, 26, 13, 35, 44, 495, DateTimeKind.Local).AddTicks(6882), "Sarmal değerli alias dignissimos exercitationem.", "Qui totam." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CraetedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 6, 26, 13, 35, 44, 495, DateTimeKind.Local).AddTicks(6928), "Minima karşıdakine aliquid inventore et.", "Eve." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CraetedDate", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 6, 26, 13, 35, 44, 499, DateTimeKind.Local).AddTicks(5557), 5.82223553586390m, 206.27m, "Small Metal Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CraetedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 6, 26, 13, 35, 44, 499, DateTimeKind.Local).AddTicks(5600), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 6.737917100530440m, 906.74m, "Gorgeous Soft Gloves" });
        }
    }
}
