using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjetoInterDisciplinar.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_USUARIOS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
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

            migrationBuilder.CreateTable(
                name: "TB_FUNCIONARIOS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Funcao = table.Column<int>(type: "int", nullable: false),
                    HorasDeServico = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_FUNCIONARIOS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_FUNCIONARIOS_TB_USUARIOS_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "TB_USUARIOS",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "TB_FUNCIONARIOS",
                columns: new[] { "Id", "Funcao", "HorasDeServico", "Nome", "UsuarioId" },
                values: new object[,]
                {
                    { 1, 2, 8, "Guilherme", null },
                    { 2, 6, 8, "Jessica", null },
                    { 3, 1, 8, "Leonardo", null },
                    { 4, 3, 8, "Lucas", null },
                    { 5, 4, 8, "Rogerio", null },
                    { 6, 5, 8, "Cleber Machado", null }
                });

            migrationBuilder.InsertData(
                table: "TB_USUARIOS",
                columns: new[] { "Id", "DataAcesso", "Email", "Foto", "Latitude", "Longitude", "PasswordHash", "PasswordSalt", "Perfil", "UserName" },
                values: new object[] { 1, null, "seuEmail@gmail.com", null, -23.520024100000001, -46.596497999999997, new byte[] { 118, 214, 200, 11, 163, 56, 77, 141, 86, 72, 81, 197, 12, 87, 152, 205, 160, 244, 227, 150, 175, 84, 125, 102, 102, 90, 177, 175, 150, 153, 112, 237, 66, 68, 41, 184, 49, 206, 150, 166, 187, 89, 250, 228, 109, 96, 93, 127, 141, 252, 19, 171, 250, 180, 152, 196, 220, 230, 46, 17, 154, 47, 26, 126 }, new byte[] { 235, 132, 167, 82, 78, 86, 26, 67, 35, 195, 61, 247, 172, 164, 94, 48, 67, 50, 106, 76, 66, 217, 231, 61, 134, 40, 171, 240, 88, 109, 40, 173, 212, 226, 55, 248, 226, 43, 146, 27, 57, 69, 126, 198, 179, 85, 190, 109, 239, 22, 177, 39, 84, 131, 137, 210, 149, 104, 71, 99, 56, 207, 184, 147, 140, 125, 134, 190, 214, 253, 170, 122, 170, 42, 177, 72, 150, 142, 82, 27, 180, 201, 244, 168, 215, 102, 229, 31, 160, 122, 159, 128, 84, 130, 16, 17, 248, 62, 145, 101, 172, 58, 227, 203, 188, 95, 68, 108, 14, 136, 76, 217, 207, 79, 207, 203, 166, 102, 172, 24, 185, 228, 214, 206, 56, 19, 238, 107 }, "Admin", "UsuarioAdmin" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_FUNCIONARIOS_UsuarioId",
                table: "TB_FUNCIONARIOS",
                column: "UsuarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_FUNCIONARIOS");

            migrationBuilder.DropTable(
                name: "TB_USUARIOS");
        }
    }
}
