using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PayrollManagementSys.Data.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PersoneId",
                table: "Salaries");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ac11170-804b-4499-b09f-5fde0f9e7b8d", "AQAAAAIAAYagAAAAELILKa5zsMiz17bHsbVlZuEg2nM1UXJeALcrv26jN8B6YqlqNK6PwA/XHWNfCpZigA==", "7256dbe7-ffe9-4ad1-bd1a-259ecf39c0e9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a8f2256a-53c1-4221-ad59-e58acad8ec57", "AQAAAAIAAYagAAAAEHMossezgfSYjZgy/xbn5tEEXDqWvIKS+BWVewwcDgi+SV8hhT6alUh/34+b/g1ndA==", "d537d684-7688-46dc-9f73-d48597f572b2" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PersoneId",
                table: "Salaries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "709b2751-1fef-42c4-bb85-1896008b2ff2", "AQAAAAIAAYagAAAAEDz7Syvr5X+TOl1eB74NnYLu3DMRRagqgWdcn75fCMx8iTLcZhz/e/WeeDROu3Y0/Q==", "78f8de58-b486-40ef-865c-c18429986db9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "91ab630c-d5fa-4ad3-a509-c2ea8f4329fb", "AQAAAAIAAYagAAAAEDawCJxSbcXG3U+aRvlZalYQkzMVAHBSHSGlxMRRqfbVHGX5c/hpIT/vdcIQPIm2JA==", "84ae4f36-d260-4d51-bffe-fa2722aa3c58" });
        }
    }
}
