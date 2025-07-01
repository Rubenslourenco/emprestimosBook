using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmprestimosBook.Migrations
{
    /// <inheritdoc />
    public partial class AdicionandoTabelaUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
