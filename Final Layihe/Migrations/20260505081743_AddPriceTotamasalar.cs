using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_Layihe.Migrations
{
    /// <inheritdoc />
    public partial class AddPriceTotamasalar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Price",
                table: "tamasalar",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "tamasalar");
        }
    }
}
