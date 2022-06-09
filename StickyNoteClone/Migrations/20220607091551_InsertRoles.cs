using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StickyNoteClone.Migrations
{
    public partial class InsertRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1b84e23f-8789-49cf-a7eb-09fe477cbbc0", "479b1f98-8bd8-44fa-978e-6c3d19f4d34e", "Basic", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7b86820c-40b4-4e7f-b709-8345c351b637", "26978683-31a1-4d15-bf88-78e2a2a35f28", "Administrator", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1b84e23f-8789-49cf-a7eb-09fe477cbbc0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b86820c-40b4-4e7f-b709-8345c351b637");
        }
    }
}
