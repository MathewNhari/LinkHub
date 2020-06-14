using Microsoft.EntityFrameworkCore.Migrations;

namespace ShareLinkFinal.Migrations
{
    public partial class isapprovedStringfy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "IsApproved",
                table: "Urls",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsApproved",
                table: "Urls",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
