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
                name: "TB_FUNCIONARIOS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Funcao = table.Column<int>(type: "int", nullable: false),
                    HorasDeServico = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_FUNCIONARIOS", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TB_FUNCIONARIOS",
                columns: new[] { "Id", "Funcao", "HorasDeServico", "Nome" },
                values: new object[,]
                {
                    { 1, 2, 8, "Guilherme" },
                    { 2, 6, 8, "Jessica" },
                    { 3, 1, 8, "Leonardo" },
                    { 4, 3, 8, "Lucas" },
                    { 5, 4, 8, "Rogerio" },
                    { 6, 5, 8, "Cleber Machado" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_FUNCIONARIOS");
        }
    }
}
