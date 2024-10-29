using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Multiple_layout.Migrations
{
    /// <inheritdoc />
    public partial class mb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "tbl_category",
                columns: table => new
                {
                    C_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    C_name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_category", x => x.C_id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_category");

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
    }
}
