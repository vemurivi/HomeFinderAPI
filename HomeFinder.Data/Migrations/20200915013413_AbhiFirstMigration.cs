using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeFinder.Data.Migrations
{
    public partial class AbhiFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Buyers",
                columns: table => new
                {
                    BuyerId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 50, nullable: true),
                    LastName = table.Column<string>(maxLength: 50, nullable: true),
                    Email = table.Column<string>(maxLength: 50, nullable: true),
                    PhoneNumber = table.Column<string>(maxLength: 50, nullable: true),
                    TimeStamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buyers", x => x.BuyerId);
                });

            migrationBuilder.CreateTable(
                name: "Sellers",
                columns: table => new
                {
                    SellerId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 50, nullable: true),
                    LastName = table.Column<string>(maxLength: 50, nullable: true),
                    Email = table.Column<string>(maxLength: 50, nullable: true),
                    PhoneNumber = table.Column<string>(maxLength: 15, nullable: true),
                    FaxNumber = table.Column<string>(maxLength: 15, nullable: true),
                    TimeStamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sellers", x => x.SellerId);
                });

            migrationBuilder.CreateTable(
                name: "Houses",
                columns: table => new
                {
                    HouseId = table.Column<int>(type: "int", nullable: false),
                    SellerId = table.Column<long>(nullable: false),
                    Address1 = table.Column<string>(maxLength: 100, nullable: true),
                    Address2 = table.Column<string>(maxLength: 100, nullable: true),
                    City = table.Column<string>(maxLength: 20, nullable: true),
                    ZipCode = table.Column<string>(maxLength: 10, nullable: true),
                    Province = table.Column<string>(maxLength: 10, nullable: true),
                    Country = table.Column<string>(maxLength: 30, nullable: true),
                    HouseType = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: true),
                    Area = table.Column<int>(nullable: false),
                    Amenities = table.Column<string>(maxLength: 200, nullable: true),
                    Parking = table.Column<string>(maxLength: 100, nullable: true),
                    Garage = table.Column<string>(maxLength: 100, nullable: true),
                    BedRooms = table.Column<int>(nullable: false),
                    BathRooms = table.Column<int>(nullable: false),
                    BackYard = table.Column<string>(maxLength: 100, nullable: true),
                    FrontYard = table.Column<string>(maxLength: 100, nullable: true),
                    Storage = table.Column<string>(maxLength: 100, nullable: true),
                    Laundry = table.Column<string>(maxLength: 100, nullable: true),
                    NeighborLocations = table.Column<string>(maxLength: 100, nullable: true),
                    Furniture = table.Column<string>(maxLength: 100, nullable: true),
                    Appliances = table.Column<string>(maxLength: 100, nullable: true),
                    Price = table.Column<string>(nullable: true),
                    TimeStamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Houses", x => x.HouseId);
                    table.ForeignKey(
                        name: "FK_Houses_Sellers_SellerId",
                        column: x => x.SellerId,
                        principalTable: "Sellers",
                        principalColumn: "SellerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HouseId = table.Column<int>(nullable: false),
                    BuyerId = table.Column<long>(nullable: false),
                    IsItAReply = table.Column<bool>(maxLength: 200, nullable: false),
                    TimeStamp = table.Column<DateTime>(nullable: false),
                    UserComment = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => new { x.CommentId, x.HouseId, x.BuyerId });
                    table.ForeignKey(
                        name: "FK_Comments_Buyers_BuyerId",
                        column: x => x.BuyerId,
                        principalTable: "Buyers",
                        principalColumn: "BuyerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Houses_HouseId",
                        column: x => x.HouseId,
                        principalTable: "Houses",
                        principalColumn: "HouseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HouseProspects",
                columns: table => new
                {
                    HouseProspectId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HouseId = table.Column<int>(nullable: false),
                    BuyerId = table.Column<long>(nullable: false),
                    TimeStamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseProspects", x => new { x.HouseProspectId, x.HouseId, x.BuyerId });
                    table.ForeignKey(
                        name: "FK_HouseProspects_Buyers_BuyerId",
                        column: x => x.BuyerId,
                        principalTable: "Buyers",
                        principalColumn: "BuyerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HouseProspects_Houses_HouseId",
                        column: x => x.HouseId,
                        principalTable: "Houses",
                        principalColumn: "HouseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_BuyerId",
                table: "Comments",
                column: "BuyerId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_HouseId",
                table: "Comments",
                column: "HouseId");

            migrationBuilder.CreateIndex(
                name: "IX_HouseProspects_BuyerId",
                table: "HouseProspects",
                column: "BuyerId");

            migrationBuilder.CreateIndex(
                name: "IX_HouseProspects_HouseId",
                table: "HouseProspects",
                column: "HouseId");

            migrationBuilder.CreateIndex(
                name: "IX_Houses_SellerId",
                table: "Houses",
                column: "SellerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "HouseProspects");

            migrationBuilder.DropTable(
                name: "Buyers");

            migrationBuilder.DropTable(
                name: "Houses");

            migrationBuilder.DropTable(
                name: "Sellers");
        }
    }
}
