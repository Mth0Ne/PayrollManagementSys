using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PayrollManagementSys.Data.Migrations
{
    /// <inheritdoc />
    public partial class migbilmem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "StartedDate" },
                values: new object[] { "dd93fbbc-d82e-4cf8-8437-f14ada9745fe", "AQAAAAIAAYagAAAAEGMdLASh5Ys4MoMH9EyoznLcmybPgw1ppkpRiVwS6Uttj3zXuWqCopdVBVzw/XSbCw==", "aeea519e-113c-4ad0-8137-2774b3db410f", new DateTime(2023, 12, 24, 16, 39, 21, 105, DateTimeKind.Local).AddTicks(8273) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "StartedDate" },
                values: new object[] { "77f1d526-3ecf-48c6-9bc3-3550d53398c3", "AQAAAAIAAYagAAAAEGn/xCHX5b4vJx91h6GRkf9Jhp3ybXooLyo43Sf5hWVScJAv+Gc1S3LHbOgp5Dijnw==", "348dd89b-9032-44ce-8a02-400a8a27a28d", new DateTime(2023, 12, 24, 16, 39, 21, 198, DateTimeKind.Local).AddTicks(4493) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "StartedDate" },
                values: new object[] { "8ac11170-804b-4499-b09f-5fde0f9e7b8d", "AQAAAAIAAYagAAAAELILKa5zsMiz17bHsbVlZuEg2nM1UXJeALcrv26jN8B6YqlqNK6PwA/XHWNfCpZigA==", "7256dbe7-ffe9-4ad1-bd1a-259ecf39c0e9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "StartedDate" },
                values: new object[] { "a8f2256a-53c1-4221-ad59-e58acad8ec57", "AQAAAAIAAYagAAAAEHMossezgfSYjZgy/xbn5tEEXDqWvIKS+BWVewwcDgi+SV8hhT6alUh/34+b/g1ndA==", "d537d684-7688-46dc-9f73-d48597f572b2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
