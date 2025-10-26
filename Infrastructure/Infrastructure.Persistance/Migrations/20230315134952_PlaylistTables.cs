using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Persistance.Migrations
{
    public partial class PlaylistTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpiresAt",
                table: "Sessions",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AddColumn<string>(
                name: "CoverUrl",
                table: "Albums",
                type: "text",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Playlists",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Code = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedByArtistId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsPublic = table.Column<bool>(type: "boolean", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CoverUrl = table.Column<string>(type: "text", nullable: true),
                    LastUpdatedAt = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Playlists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Playlists_Artists_CreatedByArtistId",
                        column: x => x.CreatedByArtistId,
                        principalTable: "Artists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlaylistTracks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PlaylistId = table.Column<Guid>(type: "uuid", nullable: false),
                    TrackId = table.Column<Guid>(type: "uuid", maxLength: 50, nullable: false),
                    NextPlaylistTrackId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaylistTracks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlaylistTracks_Playlists_PlaylistId",
                        column: x => x.PlaylistId,
                        principalTable: "Playlists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlaylistTracks_PlaylistTracks_NextPlaylistTrackId",
                        column: x => x.NextPlaylistTrackId,
                        principalTable: "PlaylistTracks",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PlaylistTracks_Tracks_TrackId",
                        column: x => x.TrackId,
                        principalTable: "Tracks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Playlists",
                columns: new[] { "Id", "CoverUrl", "CreatedByArtistId", "IsActive", "IsPublic", "LastUpdatedAt", "Title" },
                values: new object[] { new Guid("b0e7bcbd-945d-453e-a9cc-e54d397a9fe9"), null, new Guid("c878736d-da07-4401-ab27-2743d4e035c5"), true, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Лучшее XXXtentacion" });

            migrationBuilder.InsertData(
                table: "PlaylistTracks",
                columns: new[] { "Id", "NextPlaylistTrackId", "PlaylistId", "TrackId" },
                values: new object[] { new Guid("2e8395fe-912d-499c-8a7b-5c04e47f3231"), null, new Guid("b0e7bcbd-945d-453e-a9cc-e54d397a9fe9"), new Guid("1afe4a9e-7121-4b34-89a6-8db6e0b6ddad") });

            migrationBuilder.InsertData(
                table: "PlaylistTracks",
                columns: new[] { "Id", "NextPlaylistTrackId", "PlaylistId", "TrackId" },
                values: new object[] { new Guid("2b33dd70-f22c-4186-8100-d7a2e503b454"), new Guid("2e8395fe-912d-499c-8a7b-5c04e47f3231"), new Guid("b0e7bcbd-945d-453e-a9cc-e54d397a9fe9"), new Guid("533b7e3d-9cfd-4731-8dda-a1d5a86ff80a") });

            migrationBuilder.InsertData(
                table: "PlaylistTracks",
                columns: new[] { "Id", "NextPlaylistTrackId", "PlaylistId", "TrackId" },
                values: new object[] { new Guid("162609a2-ce5d-4cb7-b808-bf1acf903852"), new Guid("2b33dd70-f22c-4186-8100-d7a2e503b454"), new Guid("b0e7bcbd-945d-453e-a9cc-e54d397a9fe9"), new Guid("8366834f-0278-46e2-8142-011813bda329") });

            migrationBuilder.CreateIndex(
                name: "IX_Playlists_CreatedByArtistId",
                table: "Playlists",
                column: "CreatedByArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_PlaylistTracks_NextPlaylistTrackId",
                table: "PlaylistTracks",
                column: "NextPlaylistTrackId");

            migrationBuilder.CreateIndex(
                name: "IX_PlaylistTracks_PlaylistId",
                table: "PlaylistTracks",
                column: "PlaylistId");

            migrationBuilder.CreateIndex(
                name: "IX_PlaylistTracks_TrackId",
                table: "PlaylistTracks",
                column: "TrackId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlaylistTracks");

            migrationBuilder.DropTable(
                name: "Playlists");

            migrationBuilder.DropColumn(
                name: "CoverUrl",
                table: "Albums");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpiresAt",
                table: "Sessions",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");
        }
    }
}
