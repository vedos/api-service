using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace api_service.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { 1, null, new byte[] { 153, 187, 11, 237, 58, 225, 90, 216, 77, 59, 57, 92, 109, 35, 170, 58, 15, 98, 101, 123, 217, 244, 234, 117, 83, 182, 107, 211, 168, 163, 92, 201, 81, 189, 155, 210, 125, 170, 241, 149, 21, 85, 218, 232, 29, 30, 6, 223, 173, 108, 30, 178, 31, 44, 24, 142, 69, 35, 10, 184, 34, 188, 83, 126 }, new byte[] { 85, 223, 255, 38, 139, 7, 98, 111, 51, 89, 36, 129, 104, 164, 91, 228, 220, 42, 227, 163, 58, 180, 68, 189, 70, 23, 176, 27, 188, 199, 48, 137, 150, 136, 32, 140, 205, 239, 227, 16, 1, 170, 186, 37, 239, 92, 116, 217, 228, 25, 38, 70, 207, 2, 224, 42, 121, 149, 187, 91, 30, 201, 80, 77, 35, 162, 52, 65, 132, 95, 119, 169, 225, 13, 76, 129, 109, 192, 26, 69, 98, 75, 225, 245, 29, 57, 14, 1, 81, 1, 217, 152, 16, 122, 50, 6, 106, 171, 208, 28, 81, 147, 204, 78, 52, 222, 246, 252, 156, 37, 5, 223, 78, 240, 212, 197, 149, 138, 241, 247, 71, 141, 253, 49, 187, 22, 17, 210 }, "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
