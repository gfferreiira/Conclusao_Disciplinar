using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoInterDisciplinar.Migrations
{
    /// <inheritdoc />
    public partial class FuncionarioCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Username",
                table: "TB_USUARIOS",
                newName: "UserName");

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 113, 139, 80, 147, 200, 251, 124, 104, 28, 193, 135, 252, 171, 176, 73, 132, 222, 114, 36, 26, 109, 245, 83, 71, 204, 172, 35, 91, 6, 223, 96, 196, 217, 165, 95, 113, 153, 45, 220, 58, 220, 172, 246, 10, 130, 59, 141, 194, 117, 63, 202, 244, 150, 182, 4, 145, 19, 221, 20, 220, 15, 147, 206, 130 }, new byte[] { 37, 219, 75, 211, 218, 190, 252, 26, 106, 187, 105, 46, 238, 179, 99, 126, 7, 93, 13, 79, 44, 156, 197, 77, 96, 114, 212, 145, 93, 48, 136, 112, 200, 90, 199, 28, 205, 244, 203, 138, 5, 189, 152, 105, 181, 179, 95, 215, 144, 210, 188, 150, 45, 149, 16, 58, 32, 102, 224, 168, 77, 175, 20, 183, 74, 110, 76, 18, 9, 238, 127, 91, 238, 18, 18, 230, 21, 32, 168, 247, 244, 154, 101, 223, 216, 12, 111, 26, 215, 99, 188, 88, 132, 201, 237, 95, 112, 118, 1, 152, 82, 236, 171, 161, 41, 221, 52, 195, 201, 136, 89, 144, 8, 183, 26, 30, 144, 180, 77, 143, 187, 104, 149, 175, 252, 205, 25, 119 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "TB_USUARIOS",
                newName: "Username");

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 157, 253, 44, 73, 140, 141, 161, 146, 183, 6, 103, 34, 218, 24, 219, 166, 92, 142, 50, 136, 5, 11, 205, 207, 112, 88, 227, 172, 105, 41, 191, 47, 43, 194, 30, 71, 235, 113, 21, 209, 170, 223, 114, 62, 191, 117, 219, 52, 142, 51, 238, 93, 34, 148, 97, 121, 130, 187, 178, 245, 44, 130, 210, 146 }, new byte[] { 93, 88, 242, 196, 137, 145, 236, 51, 96, 164, 253, 117, 116, 22, 241, 136, 151, 38, 79, 215, 227, 125, 164, 167, 56, 182, 157, 18, 21, 215, 223, 147, 51, 25, 136, 219, 169, 180, 88, 44, 132, 101, 38, 176, 99, 255, 164, 251, 35, 86, 92, 111, 133, 85, 186, 84, 251, 107, 235, 253, 206, 70, 240, 152, 21, 137, 98, 35, 185, 209, 135, 205, 189, 179, 1, 111, 144, 31, 250, 237, 65, 21, 183, 103, 243, 146, 133, 93, 90, 21, 232, 44, 4, 91, 118, 124, 170, 234, 49, 182, 6, 42, 172, 214, 182, 146, 182, 41, 143, 118, 113, 251, 137, 92, 19, 9, 94, 218, 14, 161, 247, 232, 65, 210, 108, 220, 79, 19 } });
        }
    }
}
