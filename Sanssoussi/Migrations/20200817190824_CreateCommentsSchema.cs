using Microsoft.EntityFrameworkCore.Migrations;

namespace Sanssoussi.Migrations
{
    public partial class CreateCommentsSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentId = table.Column<string>(),
                    UserId = table.Column<string>(),
                    Comment = table.Column<string>()
                },
                constraints: table => { table.PrimaryKey("PK_Comments", x => x.CommentId); });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
