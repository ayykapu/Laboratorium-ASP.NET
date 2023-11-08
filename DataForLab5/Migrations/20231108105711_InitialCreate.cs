using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataForLab5.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "contacts",
                columns: table => new
                {
                    ContactId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Phone = table.Column<string>(type: "TEXT", nullable: true),
                    Birth = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contacts", x => x.ContactId);
                });

            migrationBuilder.InsertData(
                table: "contacts",
                columns: new[] { "ContactId", "Birth", "Email", "name", "Phone" },
                values: new object[,]
                {
                    { 1, new DateTime(2002, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "adam@wsei.pl", "Adam", "123123123" },
                    { 2, new DateTime(2002, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "maciek@wsei.pl", "Maciek", "345345345" },
                    { 3, new DateTime(2002, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "bartosz@wsei.pl", "Bartosz", "345234123" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "contacts");
        }
    }
}
