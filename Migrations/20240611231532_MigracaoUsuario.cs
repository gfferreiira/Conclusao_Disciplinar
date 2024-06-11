using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoInterDisciplinar.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "TB_FUNCIONARIOS",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TB_USUARIOS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Foto = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Latitude = table.Column<double>(type: "float", nullable: true),
                    Longitude = table.Column<double>(type: "float", nullable: true),
                    DataAcesso = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Perfil = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Email = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_USUARIOS", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "TB_FUNCIONARIOS",
                keyColumn: "Id",
                keyValue: 1,
                column: "UsuarioId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TB_FUNCIONARIOS",
                keyColumn: "Id",
                keyValue: 2,
                column: "UsuarioId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TB_FUNCIONARIOS",
                keyColumn: "Id",
                keyValue: 3,
                column: "UsuarioId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TB_FUNCIONARIOS",
                keyColumn: "Id",
                keyValue: 4,
                column: "UsuarioId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TB_FUNCIONARIOS",
                keyColumn: "Id",
                keyValue: 5,
                column: "UsuarioId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TB_FUNCIONARIOS",
                keyColumn: "Id",
                keyValue: 6,
                column: "UsuarioId",
                value: null);

            migrationBuilder.InsertData(
                table: "TB_USUARIOS",
                columns: new[] { "Id", "DataAcesso", "Email", "Foto", "Latitude", "Longitude", "PasswordHash", "PasswordSalt", "Perfil", "Username" },
                values: new object[] { 1, null, "seuEmail@gmail.com", null, -23.520024100000001, -46.596497999999997, new byte[] { 157, 253, 44, 73, 140, 141, 161, 146, 183, 6, 103, 34, 218, 24, 219, 166, 92, 142, 50, 136, 5, 11, 205, 207, 112, 88, 227, 172, 105, 41, 191, 47, 43, 194, 30, 71, 235, 113, 21, 209, 170, 223, 114, 62, 191, 117, 219, 52, 142, 51, 238, 93, 34, 148, 97, 121, 130, 187, 178, 245, 44, 130, 210, 146 }, new byte[] { 93, 88, 242, 196, 137, 145, 236, 51, 96, 164, 253, 117, 116, 22, 241, 136, 151, 38, 79, 215, 227, 125, 164, 167, 56, 182, 157, 18, 21, 215, 223, 147, 51, 25, 136, 219, 169, 180, 88, 44, 132, 101, 38, 176, 99, 255, 164, 251, 35, 86, 92, 111, 133, 85, 186, 84, 251, 107, 235, 253, 206, 70, 240, 152, 21, 137, 98, 35, 185, 209, 135, 205, 189, 179, 1, 111, 144, 31, 250, 237, 65, 21, 183, 103, 243, 146, 133, 93, 90, 21, 232, 44, 4, 91, 118, 124, 170, 234, 49, 182, 6, 42, 172, 214, 182, 146, 182, 41, 143, 118, 113, 251, 137, 92, 19, 9, 94, 218, 14, 161, 247, 232, 65, 210, 108, 220, 79, 19 }, "Admin", "UsuarioAdmin" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_FUNCIONARIOS_UsuarioId",
                table: "TB_FUNCIONARIOS",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_FUNCIONARIOS_TB_USUARIOS_UsuarioId",
                table: "TB_FUNCIONARIOS",
                column: "UsuarioId",
                principalTable: "TB_USUARIOS",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_FUNCIONARIOS_TB_USUARIOS_UsuarioId",
                table: "TB_FUNCIONARIOS");

            migrationBuilder.DropTable(
                name: "TB_USUARIOS");

            migrationBuilder.DropIndex(
                name: "IX_TB_FUNCIONARIOS_UsuarioId",
                table: "TB_FUNCIONARIOS");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "TB_FUNCIONARIOS");
        }
    }
}
