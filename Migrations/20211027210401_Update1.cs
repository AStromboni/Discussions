using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Discussions.Migrations
{
    public partial class Update1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Communautes",
                keyColumn: "CommunauteId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2021, 10, 27, 21, 4, 1, 291, DateTimeKind.Utc).AddTicks(8566));

            migrationBuilder.UpdateData(
                table: "Communautes",
                keyColumn: "CommunauteId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2021, 10, 27, 21, 4, 1, 291, DateTimeKind.Utc).AddTicks(8839));

            migrationBuilder.UpdateData(
                table: "Communautes",
                keyColumn: "CommunauteId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2021, 10, 27, 21, 4, 1, 291, DateTimeKind.Utc).AddTicks(8841));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Communautes",
                keyColumn: "CommunauteId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2021, 10, 27, 17, 29, 37, 643, DateTimeKind.Utc).AddTicks(7683));

            migrationBuilder.UpdateData(
                table: "Communautes",
                keyColumn: "CommunauteId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2021, 10, 27, 17, 29, 37, 643, DateTimeKind.Utc).AddTicks(7951));

            migrationBuilder.UpdateData(
                table: "Communautes",
                keyColumn: "CommunauteId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2021, 10, 27, 17, 29, 37, 643, DateTimeKind.Utc).AddTicks(7953));
        }
    }
}
