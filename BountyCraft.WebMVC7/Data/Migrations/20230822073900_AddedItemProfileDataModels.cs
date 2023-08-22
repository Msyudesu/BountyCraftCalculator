using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BountyCraft.WebMVC7.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedItemProfileDataModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Realm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoldType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoldQuantity = table.Column<int>(type: "int", nullable: false),
                    Stardust = table.Column<int>(type: "int", nullable: false),
                    Recipe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstAlchemyItem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstAlchemyItemQty = table.Column<int>(type: "int", nullable: false),
                    SecondAlchemyItem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondAlchemyItemQty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Profiles",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ProfileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiles", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ProfilesItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfileId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfilesItem", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Profiles");

            migrationBuilder.DropTable(
                name: "ProfilesItem");
        }
    }
}
