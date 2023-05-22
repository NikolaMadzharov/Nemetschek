using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nemetschek.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Added_New_Column_In_Film : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Films",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Films");
        }
    }
}
