using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wsb_oop.Migrations
{
    /// <inheritdoc />
    public partial class AddDescriptionToProductEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ProductEntities",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "ProductEntities");
        }
    }
}
