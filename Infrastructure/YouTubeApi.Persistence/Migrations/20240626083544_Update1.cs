using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YouTubeApi.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Update1 : Migration
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
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
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
                columns: new[] { "CraetedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 6, 26, 13, 35, 44, 499, DateTimeKind.Local).AddTicks(5557), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 5.82223553586390m, 206.27m, "Small Metal Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CraetedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 6, 26, 13, 35, 44, 499, DateTimeKind.Local).AddTicks(5600), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 6.737917100530440m, 906.74m, "Gorgeous Soft Gloves" });

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
                    CategoriesId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryProduct", x => new { x.CategoriesId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CraetedDate", "Name" },
                values: new object[] { new DateTime(2024, 6, 17, 10, 38, 5, 132, DateTimeKind.Utc).AddTicks(3652), "Tools, Books & Clothing" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CraetedDate", "Name" },
                values: new object[] { new DateTime(2024, 6, 17, 10, 38, 5, 132, DateTimeKind.Utc).AddTicks(3679), "Music & Health" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CraetedDate", "Name" },
                values: new object[] { new DateTime(2024, 6, 17, 10, 38, 5, 132, DateTimeKind.Utc).AddTicks(3696), "Electronics & Garden" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CraetedDate",
                value: new DateTime(2024, 6, 17, 15, 38, 5, 132, DateTimeKind.Local).AddTicks(6887));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CraetedDate",
                value: new DateTime(2024, 6, 17, 15, 38, 5, 132, DateTimeKind.Local).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CraetedDate",
                value: new DateTime(2024, 6, 17, 15, 38, 5, 132, DateTimeKind.Local).AddTicks(6894));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CraetedDate",
                value: new DateTime(2024, 6, 17, 15, 38, 5, 132, DateTimeKind.Local).AddTicks(6896));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CraetedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 6, 17, 15, 38, 5, 135, DateTimeKind.Local).AddTicks(211), "Consequatur değirmeni dolayı gül dignissimos.", "Mutlu." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CraetedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 6, 17, 15, 38, 5, 135, DateTimeKind.Local).AddTicks(302), "Beğendim dergi çarpan voluptatem eius.", "Enim için." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CraetedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 6, 17, 15, 38, 5, 135, DateTimeKind.Local).AddTicks(336), "Incidunt aut filmini layıkıyla aut.", "Laudantium." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CraetedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 6, 17, 15, 38, 5, 137, DateTimeKind.Local).AddTicks(2430), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 9.868114912860710m, 230.61m, "Handcrafted Granite Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CraetedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 6, 17, 15, 38, 5, 137, DateTimeKind.Local).AddTicks(2466), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 6.970545558632840m, 280.60m, "Awesome Steel Bacon" });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryProduct_ProductsId",
                table: "CategoryProduct",
                column: "ProductsId");
        }
    }
}
