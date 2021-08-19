using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace api_service.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Users",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 89, 238, 82, 191, 183, 235, 198, 188, 127, 225, 118, 208, 18, 95, 251, 4, 228, 106, 79, 168, 236, 162, 87, 159, 177, 123, 71, 172, 128, 250, 128, 189, 86, 46, 210, 202, 157, 58, 30, 227, 154, 156, 121, 171, 160, 220, 62, 111, 75, 102, 114, 50, 19, 53, 6, 254, 2, 250, 238, 110, 121, 29, 119, 228 }, new byte[] { 232, 158, 23, 68, 243, 208, 35, 163, 251, 109, 56, 215, 189, 209, 206, 113, 202, 156, 138, 228, 41, 247, 71, 200, 63, 164, 77, 119, 177, 49, 185, 98, 242, 134, 59, 236, 154, 159, 138, 210, 37, 237, 99, 160, 214, 94, 56, 225, 63, 78, 68, 25, 142, 11, 73, 92, 181, 101, 0, 58, 189, 214, 148, 255, 54, 1, 49, 191, 62, 54, 104, 16, 197, 177, 121, 233, 227, 76, 81, 35, 1, 220, 131, 196, 189, 17, 251, 190, 227, 57, 58, 193, 147, 34, 157, 223, 210, 192, 64, 99, 227, 85, 0, 177, 19, 97, 240, 253, 57, 10, 140, 199, 114, 4, 97, 67, 133, 59, 239, 214, 126, 17, 173, 209, 44, 5, 186, 126 } });

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Username",
                table: "Users",
                column: "Username",
                unique: true,
                filter: "[Username] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_Email",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_Username",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 153, 187, 11, 237, 58, 225, 90, 216, 77, 59, 57, 92, 109, 35, 170, 58, 15, 98, 101, 123, 217, 244, 234, 117, 83, 182, 107, 211, 168, 163, 92, 201, 81, 189, 155, 210, 125, 170, 241, 149, 21, 85, 218, 232, 29, 30, 6, 223, 173, 108, 30, 178, 31, 44, 24, 142, 69, 35, 10, 184, 34, 188, 83, 126 }, new byte[] { 85, 223, 255, 38, 139, 7, 98, 111, 51, 89, 36, 129, 104, 164, 91, 228, 220, 42, 227, 163, 58, 180, 68, 189, 70, 23, 176, 27, 188, 199, 48, 137, 150, 136, 32, 140, 205, 239, 227, 16, 1, 170, 186, 37, 239, 92, 116, 217, 228, 25, 38, 70, 207, 2, 224, 42, 121, 149, 187, 91, 30, 201, 80, 77, 35, 162, 52, 65, 132, 95, 119, 169, 225, 13, 76, 129, 109, 192, 26, 69, 98, 75, 225, 245, 29, 57, 14, 1, 81, 1, 217, 152, 16, 122, 50, 6, 106, 171, 208, 28, 81, 147, 204, 78, 52, 222, 246, 252, 156, 37, 5, 223, 78, 240, 212, 197, 149, 138, 241, 247, 71, 141, 253, 49, 187, 22, 17, 210 } });
        }
    }
}
