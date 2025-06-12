using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PostcardsWeb.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddEnglishTitleAndDescriptions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.AddColumn<string>(
                name: "BackColorEn",
                table: "Cards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BackTextEn",
                table: "Cards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BackTextOrg",
                table: "Cards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FrontColorEn",
                table: "Cards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FrontTextEn",
                table: "Cards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FrontTextOrg",
                table: "Cards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NameEn",
                table: "Cards",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BackColorEn",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "BackTextEn",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "BackTextOrg",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "FrontColorEn",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "FrontTextEn",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "FrontTextOrg",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "NameEn",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "RegTime",
                table: "Cards");
        }
    }
}
