using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContactManager.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Organization = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactId);
                    table.ForeignKey(
                        name: "FK_Contacts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, "Family" },
                    { 2, "Friend" },
                    { 3, "Partner" },
                    { 4, "Coworker" },
                    { 5, "Other" }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "CategoryId", "DateAdded", "Email", "Firstname", "Lastname", "Organization", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 5, 5, 21, 34, 16, 306, DateTimeKind.Local).AddTicks(8294), "caty.dogger@yahoo.com", "Caty", "Dogger", "Organization 200", "000-123-4567" },
                    { 2, 2, new DateTime(2022, 5, 5, 21, 34, 16, 306, DateTimeKind.Local).AddTicks(8323), "fishy.tanks@gmail.com", "Fishy", "Tanks", "Org A", "000-222-4567" },
                    { 3, 3, new DateTime(2022, 5, 5, 21, 34, 16, 306, DateTimeKind.Local).AddTicks(8326), "hamlet.burgers@hotmail.com", "Hamlet", "Burgers", "Org B", "000-444-4567" },
                    { 4, 4, new DateTime(2022, 5, 5, 21, 34, 16, 306, DateTimeKind.Local).AddTicks(8328), "kermittacus.froggius@rocketmail.com", "Kermittacus", "Froggius", "Muppets Inc.", "000-555-4567" },
                    { 5, 5, new DateTime(2022, 5, 5, 21, 34, 16, 306, DateTimeKind.Local).AddTicks(8330), "chocobo.latte@aol.com", "Chocobo", "Latte", "Org C", "000-888-4567" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_CategoryId",
                table: "Contacts",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
