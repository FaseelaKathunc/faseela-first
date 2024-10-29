using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Multiple_layout.Migrations
{
    /// <inheritdoc />
    public partial class mkj : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_Register",
                table: "tbl_Register");

            migrationBuilder.RenameTable(
                name: "tbl_Register",
                newName: "Register");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Register",
                table: "Register",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Register",
                table: "Register");

            migrationBuilder.RenameTable(
                name: "Register",
                newName: "tbl_Register");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_Register",
                table: "tbl_Register",
                column: "Id");
        }
    }
}
