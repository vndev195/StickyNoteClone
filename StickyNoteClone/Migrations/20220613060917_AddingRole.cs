using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StickyNoteClone.Migrations
{
    public partial class AddingRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b0d32bb-057a-4c8b-b5bc-73289d192695");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d168445-f19c-4a51-882a-a17146f28f64");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "576f6397-8b7d-40ae-8ce4-cba9f275c6ee", "ee2cdaad-c05f-4259-965f-66eadb7e2c62", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c414e358-b5aa-4762-a003-e9044e948903", "09afcad7-79b8-48bb-8c3a-43a620f1f8a8", "Basic", "BASIC" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "576f6397-8b7d-40ae-8ce4-cba9f275c6ee");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c414e358-b5aa-4762-a003-e9044e948903");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6b0d32bb-057a-4c8b-b5bc-73289d192695", "e35bb601-8302-4c2c-94cf-e3f24b678cfd", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9d168445-f19c-4a51-882a-a17146f28f64", "e0913758-54fb-4ca9-a036-195ffde45885", "Visitor", "VISITOR" });
        }
    }
}
