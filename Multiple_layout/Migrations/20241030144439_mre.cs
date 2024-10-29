using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Multiple_layout.Migrations
{
    /// <inheritdoc />
    public partial class mre : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_Items",
                columns: table => new
                {
                    I_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    I_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    C_id = table.Column<int>(type: "int", nullable: false),
                    P_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Items", x => x.I_id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_Items");
        }
    }
}
