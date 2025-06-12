using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PostcardsWeb.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddBrandAbrToBrandTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Brands_Countries_BrandCountryId",
                table: "Brands");

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                table: "Tags",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "WebPage",
                table: "Brands",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "CompanyGroup",
                table: "Brands",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "BrandImage",
                table: "Brands",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "BrandCountryId",
                table: "Brands",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "BrandAbr",
                table: "Brands",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.InsertData(
                table: "Colorations",
                columns: new[] { "ColorId", "Name" },
                values: new object[,]
                {
                    { 1, "Colored" },
                    { 2, "Black & White" },
                    { 3, "Sepia" },
                    { 4, "Other" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Brands_Countries_BrandCountryId",
                table: "Brands",
                column: "BrandCountryId",
                principalTable: "Countries",
                principalColumn: "CountryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Brands_Countries_BrandCountryId",
                table: "Brands");

            migrationBuilder.DeleteData(
                table: "Colorations",
                keyColumn: "ColorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colorations",
                keyColumn: "ColorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Colorations",
                keyColumn: "ColorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Colorations",
                keyColumn: "ColorId",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "BrandAbr",
                table: "Brands");

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                table: "Tags",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "WebPage",
                table: "Brands",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CompanyGroup",
                table: "Brands",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BrandImage",
                table: "Brands",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BrandCountryId",
                table: "Brands",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Brands_Countries_BrandCountryId",
                table: "Brands",
                column: "BrandCountryId",
                principalTable: "Countries",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
