using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace coreapiswagger.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Developerss",
                columns: table => new
                {
                    DevelopersId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeveloperName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FoundationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeveloperValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Developerss", x => x.DevelopersId);
                });

            migrationBuilder.CreateTable(
                name: "Gamess",
                columns: table => new
                {
                    GamesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gamess", x => x.GamesId);
                });

            migrationBuilder.CreateTable(
                name: "Platformss",
                columns: table => new
                {
                    PlatformsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlatformName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Platformss", x => x.PlatformsId);
                });

            migrationBuilder.CreateTable(
                name: "Publisherss",
                columns: table => new
                {
                    PublishersId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PublisherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FoundationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PublisherValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publisherss", x => x.PublishersId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Developerss");

            migrationBuilder.DropTable(
                name: "Gamess");

            migrationBuilder.DropTable(
                name: "Platformss");

            migrationBuilder.DropTable(
                name: "Publisherss");
        }
    }
}
