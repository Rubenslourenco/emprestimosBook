using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmprestimosBook.Migrations
{
    /// <inheritdoc />
    public partial class AdicionandoTabelaUsuarios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_EmprestimosModel",
                table: "EmprestimosModel");

            migrationBuilder.RenameTable(
                name: "EmprestimosModel",
                newName: "Emprestimos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Emprestimos",
                table: "Emprestimos",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sobrenome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SenhaHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    SenhaSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Emprestimos",
                table: "Emprestimos");

            migrationBuilder.RenameTable(
                name: "Emprestimos",
                newName: "EmprestimosModel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmprestimosModel",
                table: "EmprestimosModel",
                column: "Id");
        }
    }
}
