using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Persistance.Migrations
{
    public partial class AddInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FirstName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    MiddleName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    Login = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    Password = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    AccessToken = table.Column<string>(type: "text", nullable: true),
                    RefreshToken = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Code = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ReleaseDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Code = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Code = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    AlbumId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Genres_Albums_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Albums",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Tracks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(70)", maxLength: 70, nullable: false),
                    Code = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AlbumId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Number = table.Column<int>(type: "integer", nullable: false, defaultValue: 1),
                    Duration = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tracks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tracks_Albums_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Albums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArtistAlbums",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ArtistId = table.Column<Guid>(type: "uuid", nullable: false),
                    AlbumId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtistAlbums", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArtistAlbums_Albums_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Albums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtistAlbums_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AlbumGenres",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    AlbumId = table.Column<Guid>(type: "uuid", nullable: false),
                    GenreId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlbumGenres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AlbumGenres_Albums_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Albums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlbumGenres_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArtistTracks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ArtistId = table.Column<Guid>(type: "uuid", nullable: false),
                    TrackId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtistTracks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArtistTracks_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtistTracks_Tracks_TrackId",
                        column: x => x.TrackId,
                        principalTable: "Tracks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AccessToken", "FirstName", "LastName", "Login", "MiddleName", "Password", "RefreshToken" },
                values: new object[] { new Guid("3e54f0cd-21d9-406d-bf67-e3bce0ce1199"), null, "Админ", "Админов", "admin", "Админович", "admin", null });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "IsActive", "Name", "ReleaseDate" },
                values: new object[,]
                {
                    { new Guid("62e05eec-dfed-462d-abfe-7489534fad8b"), false, "RED & WHITE", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c7b12644-83a9-4ccd-8418-808b11d9755e"), false, "Whole Lotta Red", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f7c43f96-79e4-4244-b21b-8ac476e54495"), false, "Life Of Pi'erre 5", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fe024194-aad4-462a-8fbd-8dd7b4a2cd90"), false, "17", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "IsActive", "Name" },
                values: new object[,]
                {
                    { new Guid("03810320-12e9-435f-9d8b-473572074360"), false, "Lil Uzi Vert" },
                    { new Guid("a62f20f1-a42d-41cb-8c17-890cc61b4b14"), false, "Playboi Carti" },
                    { new Guid("c878736d-da07-4401-ab27-2743d4e035c5"), false, "XXXtentacion" },
                    { new Guid("d3179697-703d-4ee8-998d-7674119309a5"), false, "Pi'erre Bourne" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "AlbumId", "IsActive", "Name" },
                values: new object[,]
                {
                    { new Guid("2f044c88-a983-4cf5-bcc1-a5d7764507ed"), null, false, "Клауд-рэп" },
                    { new Guid("8745e56f-b335-43fe-bd10-bad6bead0892"), null, false, "Хип-Хоп" },
                    { new Guid("ae14797c-31cd-432a-b2de-b3db95a82ab4"), null, false, "Трэп" },
                    { new Guid("baa56e06-9672-4118-aee3-4098cec4581e"), null, false, "Эмо" },
                    { new Guid("e2a8929f-2190-4329-bae1-83b170a3677f"), null, false, "Альтернативный рок" }
                });

            migrationBuilder.InsertData(
                table: "AlbumGenres",
                columns: new[] { "Id", "AlbumId", "GenreId" },
                values: new object[,]
                {
                    { new Guid("262342b2-861e-4802-a54c-c84522188cd7"), new Guid("62e05eec-dfed-462d-abfe-7489534fad8b"), new Guid("ae14797c-31cd-432a-b2de-b3db95a82ab4") },
                    { new Guid("395d511c-4387-46e8-9868-f8be6ea5c517"), new Guid("62e05eec-dfed-462d-abfe-7489534fad8b"), new Guid("8745e56f-b335-43fe-bd10-bad6bead0892") },
                    { new Guid("444757cc-64ec-46b3-a97b-6c31e25d7d18"), new Guid("62e05eec-dfed-462d-abfe-7489534fad8b"), new Guid("2f044c88-a983-4cf5-bcc1-a5d7764507ed") },
                    { new Guid("46e8fe85-9e9d-4ab1-b711-2a100f9402c6"), new Guid("fe024194-aad4-462a-8fbd-8dd7b4a2cd90"), new Guid("8745e56f-b335-43fe-bd10-bad6bead0892") },
                    { new Guid("49318a5d-3a15-4ca5-8a26-71c5e0928bee"), new Guid("fe024194-aad4-462a-8fbd-8dd7b4a2cd90"), new Guid("baa56e06-9672-4118-aee3-4098cec4581e") },
                    { new Guid("631bc28a-fc2c-406e-9bd6-3dcd90ef2bf4"), new Guid("fe024194-aad4-462a-8fbd-8dd7b4a2cd90"), new Guid("e2a8929f-2190-4329-bae1-83b170a3677f") },
                    { new Guid("9788b398-eb7d-4f0a-a778-a595edf8764e"), new Guid("c7b12644-83a9-4ccd-8418-808b11d9755e"), new Guid("ae14797c-31cd-432a-b2de-b3db95a82ab4") },
                    { new Guid("c2d56b4f-1968-42e0-b95c-ceb4cd976ffd"), new Guid("c7b12644-83a9-4ccd-8418-808b11d9755e"), new Guid("8745e56f-b335-43fe-bd10-bad6bead0892") },
                    { new Guid("f1279fe9-84d4-417e-8b5b-627e0b4e6029"), new Guid("f7c43f96-79e4-4244-b21b-8ac476e54495"), new Guid("8745e56f-b335-43fe-bd10-bad6bead0892") }
                });

            migrationBuilder.InsertData(
                table: "ArtistAlbums",
                columns: new[] { "Id", "AlbumId", "ArtistId" },
                values: new object[,]
                {
                    { new Guid("30965a2d-b2eb-448b-bedb-56e56215f76f"), new Guid("fe024194-aad4-462a-8fbd-8dd7b4a2cd90"), new Guid("c878736d-da07-4401-ab27-2743d4e035c5") },
                    { new Guid("86e9eb76-1f31-40b1-a655-6b7d6860a7bd"), new Guid("c7b12644-83a9-4ccd-8418-808b11d9755e"), new Guid("a62f20f1-a42d-41cb-8c17-890cc61b4b14") },
                    { new Guid("87cb0a2e-63f3-491c-b164-eac43dd743f4"), new Guid("62e05eec-dfed-462d-abfe-7489534fad8b"), new Guid("03810320-12e9-435f-9d8b-473572074360") },
                    { new Guid("994a42cd-1c68-4fdb-b2b1-f0e9f4ee44a5"), new Guid("f7c43f96-79e4-4244-b21b-8ac476e54495"), new Guid("d3179697-703d-4ee8-998d-7674119309a5") }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "AlbumId", "Duration", "IsActive", "Name" },
                values: new object[,]
                {
                    { new Guid("1afe4a9e-7121-4b34-89a6-8db6e0b6ddad"), new Guid("fe024194-aad4-462a-8fbd-8dd7b4a2cd90"), 0m, false, "Depression & Obsession" },
                    { new Guid("492f70ab-f1de-4de4-93b3-8602df66b05a"), new Guid("fe024194-aad4-462a-8fbd-8dd7b4a2cd90"), 0m, false, "Revenge" },
                    { new Guid("533b7e3d-9cfd-4731-8dda-a1d5a86ff80a"), new Guid("fe024194-aad4-462a-8fbd-8dd7b4a2cd90"), 0m, false, "Jocelyn Flores" },
                    { new Guid("6d342342-ea26-40f4-aa92-420f3a943603"), new Guid("fe024194-aad4-462a-8fbd-8dd7b4a2cd90"), 0m, false, "Fuck Love feat. Trippie Redd" },
                    { new Guid("77b75ed9-e6d2-4d47-84c9-58af10e455c1"), new Guid("fe024194-aad4-462a-8fbd-8dd7b4a2cd90"), 0m, false, "Orlando" },
                    { new Guid("7fdfa190-66d6-43be-b2af-dbbd45052828"), new Guid("fe024194-aad4-462a-8fbd-8dd7b4a2cd90"), 0m, false, "Ayala (Outro)" },
                    { new Guid("8366834f-0278-46e2-8142-011813bda329"), new Guid("fe024194-aad4-462a-8fbd-8dd7b4a2cd90"), 1.1m, false, "The Explanation" },
                    { new Guid("84d5050b-a7b7-4c23-a2d1-93281183264a"), new Guid("fe024194-aad4-462a-8fbd-8dd7b4a2cd90"), 0m, false, "Dead Inside (Interlude)" },
                    { new Guid("8e22b0a3-063e-40ae-976e-5b06f762c8ce"), new Guid("fe024194-aad4-462a-8fbd-8dd7b4a2cd90"), 0m, false, "Carry On" },
                    { new Guid("baace2ca-c2c0-4cee-b129-53079d696059"), new Guid("fe024194-aad4-462a-8fbd-8dd7b4a2cd90"), 0m, false, "Save Me" },
                    { new Guid("f0c1326b-0646-46f4-966f-c10caa9c931b"), new Guid("fe024194-aad4-462a-8fbd-8dd7b4a2cd90"), 0m, false, "Everybody Dies In Their Nightmares" }
                });

            migrationBuilder.InsertData(
                table: "ArtistTracks",
                columns: new[] { "Id", "ArtistId", "TrackId" },
                values: new object[,]
                {
                    { new Guid("034fe159-32db-4875-9131-6426134d2743"), new Guid("c878736d-da07-4401-ab27-2743d4e035c5"), new Guid("8366834f-0278-46e2-8142-011813bda329") },
                    { new Guid("062c2665-7591-4c78-82da-da9fe95f2277"), new Guid("c878736d-da07-4401-ab27-2743d4e035c5"), new Guid("533b7e3d-9cfd-4731-8dda-a1d5a86ff80a") },
                    { new Guid("1227371f-f8cb-409c-ae62-9a864ce52d62"), new Guid("c878736d-da07-4401-ab27-2743d4e035c5"), new Guid("1afe4a9e-7121-4b34-89a6-8db6e0b6ddad") },
                    { new Guid("1d7ace2e-de9c-492a-b535-723fb24975cb"), new Guid("c878736d-da07-4401-ab27-2743d4e035c5"), new Guid("f0c1326b-0646-46f4-966f-c10caa9c931b") },
                    { new Guid("38d003fd-762e-410b-b93c-3b4ef2ec39ca"), new Guid("c878736d-da07-4401-ab27-2743d4e035c5"), new Guid("492f70ab-f1de-4de4-93b3-8602df66b05a") },
                    { new Guid("960c53c2-d34a-4692-9f2b-6d6fd1015868"), new Guid("c878736d-da07-4401-ab27-2743d4e035c5"), new Guid("baace2ca-c2c0-4cee-b129-53079d696059") },
                    { new Guid("983414b0-1371-4327-bd66-684afc8e3d05"), new Guid("c878736d-da07-4401-ab27-2743d4e035c5"), new Guid("84d5050b-a7b7-4c23-a2d1-93281183264a") },
                    { new Guid("d033186f-8ab5-435e-9874-5238e141b148"), new Guid("c878736d-da07-4401-ab27-2743d4e035c5"), new Guid("6d342342-ea26-40f4-aa92-420f3a943603") },
                    { new Guid("dc4036b5-d7ef-4788-8b33-e21b42374005"), new Guid("c878736d-da07-4401-ab27-2743d4e035c5"), new Guid("8e22b0a3-063e-40ae-976e-5b06f762c8ce") },
                    { new Guid("dc96bf29-f981-4cfe-9777-a459d0ab69db"), new Guid("c878736d-da07-4401-ab27-2743d4e035c5"), new Guid("77b75ed9-e6d2-4d47-84c9-58af10e455c1") },
                    { new Guid("de175c65-a3a6-4204-a1b2-318abe039cee"), new Guid("c878736d-da07-4401-ab27-2743d4e035c5"), new Guid("7fdfa190-66d6-43be-b2af-dbbd45052828") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AlbumGenres_AlbumId",
                table: "AlbumGenres",
                column: "AlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_AlbumGenres_GenreId",
                table: "AlbumGenres",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtistAlbums_AlbumId",
                table: "ArtistAlbums",
                column: "AlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtistAlbums_ArtistId",
                table: "ArtistAlbums",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtistTracks_ArtistId",
                table: "ArtistTracks",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtistTracks_TrackId",
                table: "ArtistTracks",
                column: "TrackId");

            migrationBuilder.CreateIndex(
                name: "IX_Genres_AlbumId",
                table: "Genres",
                column: "AlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_Tracks_AlbumId",
                table: "Tracks",
                column: "AlbumId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "AlbumGenres");

            migrationBuilder.DropTable(
                name: "ArtistAlbums");

            migrationBuilder.DropTable(
                name: "ArtistTracks");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Artists");

            migrationBuilder.DropTable(
                name: "Tracks");

            migrationBuilder.DropTable(
                name: "Albums");
        }
    }
}
