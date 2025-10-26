using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Persistance.Migrations
{
    public partial class AddNewTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Artists",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Artists",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Sessions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ArtistId = table.Column<Guid>(type: "uuid", nullable: false),
                    DeviceId = table.Column<string>(type: "text", nullable: false),
                    RefreshToken = table.Column<string>(type: "text", nullable: true),
                    ExpiresAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sessions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sessions_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("03810320-12e9-435f-9d8b-473572074360"),
                columns: new[] { "Email", "Password" },
                values: new object[] { "liluzivert@gmail.com", "1111" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("a62f20f1-a42d-41cb-8c17-890cc61b4b14"),
                columns: new[] { "Email", "Password" },
                values: new object[] { "playboi@gmail.com", "1111" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("c878736d-da07-4401-ab27-2743d4e035c5"),
                columns: new[] { "Email", "Password" },
                values: new object[] { "xxxtentacion@gmail.com", "1111" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("d3179697-703d-4ee8-998d-7674119309a5"),
                columns: new[] { "Email", "Password" },
                values: new object[] { "bourne@gmail.com", "1111" });

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_ArtistId",
                table: "Sessions",
                column: "ArtistId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sessions");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Artists");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Artists");
        }
    }
}
