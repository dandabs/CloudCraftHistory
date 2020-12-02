using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CloudCraftHistory.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Member",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(nullable: true),
                    PreferredName = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: false),
                    Languages = table.Column<string>(nullable: true),
                    WasStaff = table.Column<bool>(nullable: false),
                    JoinDate = table.Column<DateTime>(nullable: false),
                    Discord = table.Column<string>(nullable: true),
                    Skype = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Instagram = table.Column<string>(nullable: true),
                    Snapchat = table.Column<string>(nullable: true),
                    Reddit = table.Column<string>(nullable: true),
                    Twitter = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    fourteen = table.Column<bool>(nullable: false),
                    fifteen = table.Column<bool>(nullable: false),
                    sixteen = table.Column<bool>(nullable: false),
                    seventeen = table.Column<bool>(nullable: false),
                    eighteen = table.Column<bool>(nullable: false),
                    nineteen = table.Column<bool>(nullable: false),
                    twenty = table.Column<bool>(nullable: false),
                    twentyone = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Member", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Member");
        }
    }
}
