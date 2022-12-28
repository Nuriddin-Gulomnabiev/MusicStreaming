using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Persistance.Migrations
{
    public partial class AddTrackDuration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("8366834f-0278-46e2-8142-011813bda329"),
                column: "Duration",
                value: 1.1m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("8366834f-0278-46e2-8142-011813bda329"),
                column: "Duration",
                value: 0m);
        }
    }
}
