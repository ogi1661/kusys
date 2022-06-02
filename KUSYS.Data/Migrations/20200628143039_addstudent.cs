using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestProje.Data.Migrations
{
    public partial class addstudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Surname = table.Column<string>(nullable: true),
                    Number = table.Column<int>(nullable: false),
                    Tc = table.Column<string>(nullable: true),
                    BrithDay = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
