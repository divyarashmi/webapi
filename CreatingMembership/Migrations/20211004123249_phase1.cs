using Microsoft.EntityFrameworkCore.Migrations;

namespace CreatingMembership.Migrations
{
    public partial class phase1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "memberships",
                columns: table => new
                {
                    username = table.Column<string>(type: "character varying(27)", maxLength: 27, nullable: false),
                    Password = table.Column<string>(type: "character varying(27)", maxLength: 27, nullable: false),
                    age = table.Column<int>(type: "integer", maxLength: 1, nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_memberships", x => x.username);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "memberships");
        }
    }
}
