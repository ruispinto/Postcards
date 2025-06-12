using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PostcardsWeb.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddMissingFieldsToCard : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Borders_CardBorderId",
                table: "Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Brands_CardBrandId",
                table: "Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Colorations_CardColorId",
                table: "Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Countries_OriginCountryId",
                table: "Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Countries_PrintedCountryId",
                table: "Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Materials_CardMatId",
                table: "Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Orientations_BackOrientId",
                table: "Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Orientations_FrontOrientId",
                table: "Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Shapes_CardShapeId",
                table: "Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Sizes_CardSizeId",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "NameEn",
                table: "Cards");

            migrationBuilder.RenameColumn(
                name: "NameEn",
                table: "Series",
                newName: "NamePt");

            migrationBuilder.AlterColumn<string>(
                name: "SerieDate",
                table: "Series",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Materials",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "WebPage",
                table: "Cards",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TotalPhotos",
                table: "Cards",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(4)",
                oldMaxLength: 4,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "ShwFrtImg",
                table: "Cards",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "ShwBckImg",
                table: "Cards",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PrintedCountryId",
                table: "Cards",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrintYear",
                table: "Cards",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(4)",
                oldMaxLength: 4,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PhotoYear",
                table: "Cards",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(4)",
                oldMaxLength: 4,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OriginCountryId",
                table: "Cards",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsVisible",
                table: "Cards",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsSeries",
                table: "Cards",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsScan",
                table: "Cards",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsPuzzle",
                table: "Cards",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsMultiview",
                table: "Cards",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsIdentical",
                table: "Cards",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsFav",
                table: "Cards",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Cards",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "HasFrame",
                table: "Cards",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FrontText",
                table: "Cards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FrontOrientId",
                table: "Cards",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FrontImg",
                table: "Cards",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FrontColor",
                table: "Cards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Dimensions",
                table: "Cards",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CardSizeId",
                table: "Cards",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CardShapeId",
                table: "Cards",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CardMatId",
                table: "Cards",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CardDesc",
                table: "Cards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CardColorId",
                table: "Cards",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CardBrandId",
                table: "Cards",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CardBorderId",
                table: "Cards",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Barcode",
                table: "Cards",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BackText",
                table: "Cards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BackOrientId",
                table: "Cards",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BackImg",
                table: "Cards",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BackColor",
                table: "Cards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NamePt",
                table: "Cards",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "NeedReplace",
                table: "Cards",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Number",
                table: "Cards",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PuzzleFrtImg",
                table: "Cards",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "CardIdents",
                columns: table => new
                {
                    IdentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescFrtIdent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescBckIdent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardOrigId = table.Column<int>(type: "int", nullable: true),
                    CardIdentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardIdents", x => x.IdentId);
                    table.ForeignKey(
                        name: "FK_CardIdents_Cards_CardIdentId",
                        column: x => x.CardIdentId,
                        principalTable: "Cards",
                        principalColumn: "CardId");
                    table.ForeignKey(
                        name: "FK_CardIdents_Cards_CardOrigId",
                        column: x => x.CardOrigId,
                        principalTable: "Cards",
                        principalColumn: "CardId");
                });

            migrationBuilder.UpdateData(
                table: "Borders",
                keyColumn: "BorderId",
                keyValue: 2,
                column: "Name",
                value: "Recortado");

            migrationBuilder.UpdateData(
                table: "Shapes",
                keyColumn: "ShapeId",
                keyValue: 2,
                column: "Name",
                value: "Rounded");

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 6,
                column: "Name",
                value: "N/D");

            migrationBuilder.CreateIndex(
                name: "IX_CardIdents_CardIdentId",
                table: "CardIdents",
                column: "CardIdentId");

            migrationBuilder.CreateIndex(
                name: "IX_CardIdents_CardOrigId",
                table: "CardIdents",
                column: "CardOrigId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Borders_CardBorderId",
                table: "Cards",
                column: "CardBorderId",
                principalTable: "Borders",
                principalColumn: "BorderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Brands_CardBrandId",
                table: "Cards",
                column: "CardBrandId",
                principalTable: "Brands",
                principalColumn: "BrandId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Colorations_CardColorId",
                table: "Cards",
                column: "CardColorId",
                principalTable: "Colorations",
                principalColumn: "ColorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Countries_OriginCountryId",
                table: "Cards",
                column: "OriginCountryId",
                principalTable: "Countries",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Countries_PrintedCountryId",
                table: "Cards",
                column: "PrintedCountryId",
                principalTable: "Countries",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Materials_CardMatId",
                table: "Cards",
                column: "CardMatId",
                principalTable: "Materials",
                principalColumn: "MatId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Orientations_BackOrientId",
                table: "Cards",
                column: "BackOrientId",
                principalTable: "Orientations",
                principalColumn: "OrientId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Orientations_FrontOrientId",
                table: "Cards",
                column: "FrontOrientId",
                principalTable: "Orientations",
                principalColumn: "OrientId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Shapes_CardShapeId",
                table: "Cards",
                column: "CardShapeId",
                principalTable: "Shapes",
                principalColumn: "ShapeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Sizes_CardSizeId",
                table: "Cards",
                column: "CardSizeId",
                principalTable: "Sizes",
                principalColumn: "SizeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Borders_CardBorderId",
                table: "Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Brands_CardBrandId",
                table: "Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Colorations_CardColorId",
                table: "Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Countries_OriginCountryId",
                table: "Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Countries_PrintedCountryId",
                table: "Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Materials_CardMatId",
                table: "Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Orientations_BackOrientId",
                table: "Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Orientations_FrontOrientId",
                table: "Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Shapes_CardShapeId",
                table: "Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Sizes_CardSizeId",
                table: "Cards");

            migrationBuilder.DropTable(
                name: "CardIdents");

            migrationBuilder.DropColumn(
                name: "NamePt",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "NeedReplace",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "Number",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "PuzzleFrtImg",
                table: "Cards");

            migrationBuilder.RenameColumn(
                name: "NamePt",
                table: "Series",
                newName: "NameEn");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "SerieDate",
                table: "Series",
                type: "date",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Materials",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "WebPage",
                table: "Cards",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "TotalPhotos",
                table: "Cards",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(4)",
                oldMaxLength: 4);

            migrationBuilder.AlterColumn<bool>(
                name: "ShwFrtImg",
                table: "Cards",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "ShwBckImg",
                table: "Cards",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "PrintedCountryId",
                table: "Cards",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "PrintYear",
                table: "Cards",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(4)",
                oldMaxLength: 4);

            migrationBuilder.AlterColumn<string>(
                name: "PhotoYear",
                table: "Cards",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(4)",
                oldMaxLength: 4);

            migrationBuilder.AlterColumn<int>(
                name: "OriginCountryId",
                table: "Cards",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "IsVisible",
                table: "Cards",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "IsSeries",
                table: "Cards",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "IsScan",
                table: "Cards",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "IsPuzzle",
                table: "Cards",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "IsMultiview",
                table: "Cards",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "IsIdentical",
                table: "Cards",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "IsFav",
                table: "Cards",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Cards",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "HasFrame",
                table: "Cards",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "FrontText",
                table: "Cards",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "FrontOrientId",
                table: "Cards",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "FrontImg",
                table: "Cards",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FrontColor",
                table: "Cards",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Dimensions",
                table: "Cards",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<int>(
                name: "CardSizeId",
                table: "Cards",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CardShapeId",
                table: "Cards",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CardMatId",
                table: "Cards",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "CardDesc",
                table: "Cards",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "CardColorId",
                table: "Cards",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CardBrandId",
                table: "Cards",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CardBorderId",
                table: "Cards",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Barcode",
                table: "Cards",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "BackText",
                table: "Cards",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "BackOrientId",
                table: "Cards",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "BackImg",
                table: "Cards",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "BackColor",
                table: "Cards",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "NameEn",
                table: "Cards",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Borders",
                keyColumn: "BorderId",
                keyValue: 2,
                column: "Name",
                value: "Cut out");

            migrationBuilder.UpdateData(
                table: "Shapes",
                keyColumn: "ShapeId",
                keyValue: 2,
                column: "Name",
                value: "Round");

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 6,
                column: "Name",
                value: "N/A");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Borders_CardBorderId",
                table: "Cards",
                column: "CardBorderId",
                principalTable: "Borders",
                principalColumn: "BorderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Brands_CardBrandId",
                table: "Cards",
                column: "CardBrandId",
                principalTable: "Brands",
                principalColumn: "BrandId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Colorations_CardColorId",
                table: "Cards",
                column: "CardColorId",
                principalTable: "Colorations",
                principalColumn: "ColorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Countries_OriginCountryId",
                table: "Cards",
                column: "OriginCountryId",
                principalTable: "Countries",
                principalColumn: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Countries_PrintedCountryId",
                table: "Cards",
                column: "PrintedCountryId",
                principalTable: "Countries",
                principalColumn: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Materials_CardMatId",
                table: "Cards",
                column: "CardMatId",
                principalTable: "Materials",
                principalColumn: "MatId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Orientations_BackOrientId",
                table: "Cards",
                column: "BackOrientId",
                principalTable: "Orientations",
                principalColumn: "OrientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Orientations_FrontOrientId",
                table: "Cards",
                column: "FrontOrientId",
                principalTable: "Orientations",
                principalColumn: "OrientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Shapes_CardShapeId",
                table: "Cards",
                column: "CardShapeId",
                principalTable: "Shapes",
                principalColumn: "ShapeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Sizes_CardSizeId",
                table: "Cards",
                column: "CardSizeId",
                principalTable: "Sizes",
                principalColumn: "SizeId");
        }
    }
}
