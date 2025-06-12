using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PostcardsWeb.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddTablesAndSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Borders",
                columns: table => new
                {
                    BorderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Borders", x => x.BorderId);
                });

            migrationBuilder.CreateTable(
                name: "Colorations",
                columns: table => new
                {
                    ColorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colorations", x => x.ColorId);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NamePt = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    IsoRegion = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    IsoLang = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    CountryDesc = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    MatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.MatId);
                });

            migrationBuilder.CreateTable(
                name: "Orientations",
                columns: table => new
                {
                    OrientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orientations", x => x.OrientId);
                });

            migrationBuilder.CreateTable(
                name: "Shapes",
                columns: table => new
                {
                    ShapeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shapes", x => x.ShapeId);
                });

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    SizeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.SizeId);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    TagId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.TagId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    BrandId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CompanyGroup = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    WebPage = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    BrandCountryId = table.Column<int>(type: "int", nullable: false),
                    BrandImage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.BrandId);
                    table.ForeignKey(
                        name: "FK_Brands_Countries_BrandCountryId",
                        column: x => x.BrandCountryId,
                        principalTable: "Countries",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    CardId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NameOrig = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsVisible = table.Column<bool>(type: "bit", nullable: true),
                    IsFav = table.Column<bool>(type: "bit", nullable: true),
                    IsScan = table.Column<bool>(type: "bit", nullable: true),
                    PrintYear = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    PhotoYear = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    IsMultiview = table.Column<bool>(type: "bit", nullable: true),
                    TotalPhotos = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    IsSeries = table.Column<bool>(type: "bit", nullable: true),
                    IsPuzzle = table.Column<bool>(type: "bit", nullable: true),
                    IsIdentical = table.Column<bool>(type: "bit", nullable: true),
                    Barcode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    HasFrame = table.Column<bool>(type: "bit", nullable: true),
                    Dimensions = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    FrontText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FrontColor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BackText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BackColor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WebPage = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ShwFrtImg = table.Column<bool>(type: "bit", nullable: true),
                    FrontImg = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ShwBckImg = table.Column<bool>(type: "bit", nullable: true),
                    BackImg = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CardDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardTags = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OriginCountryId = table.Column<int>(type: "int", nullable: true),
                    PrintedCountryId = table.Column<int>(type: "int", nullable: true),
                    CardBrandId = table.Column<int>(type: "int", nullable: true),
                    CardColorId = table.Column<int>(type: "int", nullable: true),
                    CardSizeId = table.Column<int>(type: "int", nullable: true),
                    CardShapeId = table.Column<int>(type: "int", nullable: true),
                    CardMatId = table.Column<int>(type: "int", nullable: true),
                    CardBorderId = table.Column<int>(type: "int", nullable: true),
                    FrontOrientId = table.Column<int>(type: "int", nullable: true),
                    BackOrientId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.CardId);
                    table.ForeignKey(
                        name: "FK_Cards_Borders_CardBorderId",
                        column: x => x.CardBorderId,
                        principalTable: "Borders",
                        principalColumn: "BorderId");
                    table.ForeignKey(
                        name: "FK_Cards_Brands_CardBrandId",
                        column: x => x.CardBrandId,
                        principalTable: "Brands",
                        principalColumn: "BrandId");
                    table.ForeignKey(
                        name: "FK_Cards_Colorations_CardColorId",
                        column: x => x.CardColorId,
                        principalTable: "Colorations",
                        principalColumn: "ColorId");
                    table.ForeignKey(
                        name: "FK_Cards_Countries_OriginCountryId",
                        column: x => x.OriginCountryId,
                        principalTable: "Countries",
                        principalColumn: "CountryId");
                    table.ForeignKey(
                        name: "FK_Cards_Countries_PrintedCountryId",
                        column: x => x.PrintedCountryId,
                        principalTable: "Countries",
                        principalColumn: "CountryId");
                    table.ForeignKey(
                        name: "FK_Cards_Materials_CardMatId",
                        column: x => x.CardMatId,
                        principalTable: "Materials",
                        principalColumn: "MatId");
                    table.ForeignKey(
                        name: "FK_Cards_Orientations_BackOrientId",
                        column: x => x.BackOrientId,
                        principalTable: "Orientations",
                        principalColumn: "OrientId");
                    table.ForeignKey(
                        name: "FK_Cards_Orientations_FrontOrientId",
                        column: x => x.FrontOrientId,
                        principalTable: "Orientations",
                        principalColumn: "OrientId");
                    table.ForeignKey(
                        name: "FK_Cards_Shapes_CardShapeId",
                        column: x => x.CardShapeId,
                        principalTable: "Shapes",
                        principalColumn: "ShapeId");
                    table.ForeignKey(
                        name: "FK_Cards_Sizes_CardSizeId",
                        column: x => x.CardSizeId,
                        principalTable: "Sizes",
                        principalColumn: "SizeId");
                });

            migrationBuilder.CreateTable(
                name: "Series",
                columns: table => new
                {
                    SerieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SerieNumber = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    NameOrig = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    IsScan = table.Column<bool>(type: "bit", nullable: true),
                    SerieDate = table.Column<DateOnly>(type: "date", nullable: true),
                    PrintYear = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    PhotoYear = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    IsMultiview = table.Column<bool>(type: "bit", nullable: true),
                    TotalPhotos = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    IsIdentical = table.Column<bool>(type: "bit", nullable: true),
                    Barcode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    HasFrame = table.Column<bool>(type: "bit", nullable: true),
                    FrontText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FrontColor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BackText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BackColor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WebPage = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ShwFrtImg = table.Column<bool>(type: "bit", nullable: true),
                    FrontImg = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ShwBckImg = table.Column<bool>(type: "bit", nullable: true),
                    BackImg = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SerieDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SerieTags = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SerieCardId = table.Column<int>(type: "int", nullable: true),
                    OriginCountryId = table.Column<int>(type: "int", nullable: true),
                    SerieColorId = table.Column<int>(type: "int", nullable: true),
                    FrontOrientId = table.Column<int>(type: "int", nullable: true),
                    BackOrientId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Series", x => x.SerieId);
                    table.ForeignKey(
                        name: "FK_Series_Cards_SerieCardId",
                        column: x => x.SerieCardId,
                        principalTable: "Cards",
                        principalColumn: "CardId");
                    table.ForeignKey(
                        name: "FK_Series_Colorations_SerieColorId",
                        column: x => x.SerieColorId,
                        principalTable: "Colorations",
                        principalColumn: "ColorId");
                    table.ForeignKey(
                        name: "FK_Series_Countries_OriginCountryId",
                        column: x => x.OriginCountryId,
                        principalTable: "Countries",
                        principalColumn: "CountryId");
                    table.ForeignKey(
                        name: "FK_Series_Orientations_BackOrientId",
                        column: x => x.BackOrientId,
                        principalTable: "Orientations",
                        principalColumn: "OrientId");
                    table.ForeignKey(
                        name: "FK_Series_Orientations_FrontOrientId",
                        column: x => x.FrontOrientId,
                        principalTable: "Orientations",
                        principalColumn: "OrientId");
                });

            migrationBuilder.InsertData(
                table: "Borders",
                columns: new[] { "BorderId", "Name" },
                values: new object[,]
                {
                    { 1, "Smooth" },
                    { 2, "Cut out" }
                });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MatId", "Name" },
                values: new object[,]
                {
                    { 1, "Coconut" },
                    { 2, "Cork" },
                    { 3, "Metal/Copper" },
                    { 4, "Paper/Cardboard" },
                    { 5, "Tile/Ceramics" },
                    { 6, "Wood" }
                });

            migrationBuilder.InsertData(
                table: "Orientations",
                columns: new[] { "OrientId", "Name" },
                values: new object[,]
                {
                    { 1, "Horizontal" },
                    { 2, "Vertical" },
                    { 3, "Horizontal/Vertical" },
                    { 4, "None" }
                });

            migrationBuilder.InsertData(
                table: "Shapes",
                columns: new[] { "ShapeId", "Name" },
                values: new object[,]
                {
                    { 1, "Rectangular" },
                    { 2, "Round" },
                    { 3, "Squared" },
                    { 4, "Flower" },
                    { 5, "Triangular" }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "SizeId", "Name" },
                values: new object[,]
                {
                    { 1, "Regular" },
                    { 2, "Big" },
                    { 3, "Small" },
                    { 4, "Round" },
                    { 5, "Square" },
                    { 6, "N/A" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Brands_BrandCountryId",
                table: "Brands",
                column: "BrandCountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_BackOrientId",
                table: "Cards",
                column: "BackOrientId");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_CardBorderId",
                table: "Cards",
                column: "CardBorderId");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_CardBrandId",
                table: "Cards",
                column: "CardBrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_CardColorId",
                table: "Cards",
                column: "CardColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_CardMatId",
                table: "Cards",
                column: "CardMatId");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_CardShapeId",
                table: "Cards",
                column: "CardShapeId");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_CardSizeId",
                table: "Cards",
                column: "CardSizeId");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_FrontOrientId",
                table: "Cards",
                column: "FrontOrientId");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_OriginCountryId",
                table: "Cards",
                column: "OriginCountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_PrintedCountryId",
                table: "Cards",
                column: "PrintedCountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Series_BackOrientId",
                table: "Series",
                column: "BackOrientId");

            migrationBuilder.CreateIndex(
                name: "IX_Series_FrontOrientId",
                table: "Series",
                column: "FrontOrientId");

            migrationBuilder.CreateIndex(
                name: "IX_Series_OriginCountryId",
                table: "Series",
                column: "OriginCountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Series_SerieCardId",
                table: "Series",
                column: "SerieCardId");

            migrationBuilder.CreateIndex(
                name: "IX_Series_SerieColorId",
                table: "Series",
                column: "SerieColorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Series");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "Borders");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Colorations");

            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.DropTable(
                name: "Orientations");

            migrationBuilder.DropTable(
                name: "Shapes");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
