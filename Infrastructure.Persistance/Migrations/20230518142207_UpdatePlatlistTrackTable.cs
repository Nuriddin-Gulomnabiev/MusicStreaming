using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Persistance.Migrations
{
    public partial class UpdatePlatlistTrackTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlaylistTracks_PlaylistTracks_NextPlaylistTrackId",
                table: "PlaylistTracks");

            migrationBuilder.DropIndex(
                name: "IX_PlaylistTracks_NextPlaylistTrackId",
                table: "PlaylistTracks");

            migrationBuilder.DropColumn(
                name: "NextPlaylistTrackId",
                table: "PlaylistTracks");

            migrationBuilder.AddColumn<double>(
                name: "Position",
                table: "PlaylistTracks",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "PlaylistTracks",
                keyColumn: "Id",
                keyValue: new Guid("162609a2-ce5d-4cb7-b808-bf1acf903852"),
                column: "Position",
                value: 50.0);

            migrationBuilder.UpdateData(
                table: "PlaylistTracks",
                keyColumn: "Id",
                keyValue: new Guid("2b33dd70-f22c-4186-8100-d7a2e503b454"),
                column: "Position",
                value: 100.0);

            migrationBuilder.UpdateData(
                table: "PlaylistTracks",
                keyColumn: "Id",
                keyValue: new Guid("2e8395fe-912d-499c-8a7b-5c04e47f3231"),
                column: "Position",
                value: 150.0);

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("1afe4a9e-7121-4b34-89a6-8db6e0b6ddad"),
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("492f70ab-f1de-4de4-93b3-8602df66b05a"),
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("533b7e3d-9cfd-4731-8dda-a1d5a86ff80a"),
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("6d342342-ea26-40f4-aa92-420f3a943603"),
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("77b75ed9-e6d2-4d47-84c9-58af10e455c1"),
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("7fdfa190-66d6-43be-b2af-dbbd45052828"),
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("8366834f-0278-46e2-8142-011813bda329"),
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("84d5050b-a7b7-4c23-a2d1-93281183264a"),
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("8e22b0a3-063e-40ae-976e-5b06f762c8ce"),
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("baace2ca-c2c0-4cee-b129-53079d696059"),
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("f0c1326b-0646-46f4-966f-c10caa9c931b"),
                column: "IsActive",
                value: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Position",
                table: "PlaylistTracks");

            migrationBuilder.AddColumn<Guid>(
                name: "NextPlaylistTrackId",
                table: "PlaylistTracks",
                type: "uuid",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "PlaylistTracks",
                keyColumn: "Id",
                keyValue: new Guid("162609a2-ce5d-4cb7-b808-bf1acf903852"),
                column: "NextPlaylistTrackId",
                value: new Guid("2b33dd70-f22c-4186-8100-d7a2e503b454"));

            migrationBuilder.UpdateData(
                table: "PlaylistTracks",
                keyColumn: "Id",
                keyValue: new Guid("2b33dd70-f22c-4186-8100-d7a2e503b454"),
                column: "NextPlaylistTrackId",
                value: new Guid("2e8395fe-912d-499c-8a7b-5c04e47f3231"));

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("1afe4a9e-7121-4b34-89a6-8db6e0b6ddad"),
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("492f70ab-f1de-4de4-93b3-8602df66b05a"),
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("533b7e3d-9cfd-4731-8dda-a1d5a86ff80a"),
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("6d342342-ea26-40f4-aa92-420f3a943603"),
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("77b75ed9-e6d2-4d47-84c9-58af10e455c1"),
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("7fdfa190-66d6-43be-b2af-dbbd45052828"),
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("8366834f-0278-46e2-8142-011813bda329"),
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("84d5050b-a7b7-4c23-a2d1-93281183264a"),
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("8e22b0a3-063e-40ae-976e-5b06f762c8ce"),
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("baace2ca-c2c0-4cee-b129-53079d696059"),
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("f0c1326b-0646-46f4-966f-c10caa9c931b"),
                column: "IsActive",
                value: false);

            migrationBuilder.CreateIndex(
                name: "IX_PlaylistTracks_NextPlaylistTrackId",
                table: "PlaylistTracks",
                column: "NextPlaylistTrackId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlaylistTracks_PlaylistTracks_NextPlaylistTrackId",
                table: "PlaylistTracks",
                column: "NextPlaylistTrackId",
                principalTable: "PlaylistTracks",
                principalColumn: "Id");
        }
    }
}
