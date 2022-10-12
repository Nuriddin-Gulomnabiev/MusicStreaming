using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using System;

#nullable disable

namespace Infrastructure.Persistance.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "Track",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(70)", maxLength: 70, nullable: false),
                    Code = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AlbumId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Track", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Track_Albums_AlbumId",
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
                        name: "FK_ArtistTracks_Track_TrackId",
                        column: x => x.TrackId,
                        principalTable: "Track",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                    { new Guid("1aa4b453-910f-472e-a2f4-aa0b37c43da0"), new Guid("f7c43f96-79e4-4244-b21b-8ac476e54495"), new Guid("8745e56f-b335-43fe-bd10-bad6bead0892") },
                    { new Guid("73055509-0b5e-4c11-b737-d4199ebb317c"), new Guid("fe024194-aad4-462a-8fbd-8dd7b4a2cd90"), new Guid("baa56e06-9672-4118-aee3-4098cec4581e") },
                    { new Guid("84f702b7-c750-4143-a09d-a84d6f4b528b"), new Guid("62e05eec-dfed-462d-abfe-7489534fad8b"), new Guid("2f044c88-a983-4cf5-bcc1-a5d7764507ed") },
                    { new Guid("8d86c4a7-9cbc-48bd-a119-6416775d4347"), new Guid("fe024194-aad4-462a-8fbd-8dd7b4a2cd90"), new Guid("e2a8929f-2190-4329-bae1-83b170a3677f") },
                    { new Guid("9f433270-b261-4db5-b292-695794f1fb2c"), new Guid("fe024194-aad4-462a-8fbd-8dd7b4a2cd90"), new Guid("8745e56f-b335-43fe-bd10-bad6bead0892") },
                    { new Guid("c1be9843-74b6-455a-9c98-d17edcb6adf0"), new Guid("c7b12644-83a9-4ccd-8418-808b11d9755e"), new Guid("8745e56f-b335-43fe-bd10-bad6bead0892") },
                    { new Guid("e559f1a6-f2cb-4e98-95a4-7445413322d9"), new Guid("c7b12644-83a9-4ccd-8418-808b11d9755e"), new Guid("ae14797c-31cd-432a-b2de-b3db95a82ab4") },
                    { new Guid("f37179f8-81e6-46a7-9553-eeebc3079f93"), new Guid("62e05eec-dfed-462d-abfe-7489534fad8b"), new Guid("ae14797c-31cd-432a-b2de-b3db95a82ab4") },
                    { new Guid("f92b6d27-6701-44fd-a95d-22440faf8c9b"), new Guid("62e05eec-dfed-462d-abfe-7489534fad8b"), new Guid("8745e56f-b335-43fe-bd10-bad6bead0892") }
                });

            migrationBuilder.InsertData(
                table: "ArtistAlbums",
                columns: new[] { "Id", "AlbumId", "ArtistId" },
                values: new object[,]
                {
                    { new Guid("197eb987-b01a-46c6-af84-9887f53eb28f"), new Guid("fe024194-aad4-462a-8fbd-8dd7b4a2cd90"), new Guid("c878736d-da07-4401-ab27-2743d4e035c5") },
                    { new Guid("2bc3a501-1cee-45d8-810b-becb146292b3"), new Guid("62e05eec-dfed-462d-abfe-7489534fad8b"), new Guid("03810320-12e9-435f-9d8b-473572074360") },
                    { new Guid("680e53f6-7a90-440c-ba67-37a63196306b"), new Guid("c7b12644-83a9-4ccd-8418-808b11d9755e"), new Guid("a62f20f1-a42d-41cb-8c17-890cc61b4b14") },
                    { new Guid("a93fc435-17a1-4322-aea6-497b2cca341c"), new Guid("f7c43f96-79e4-4244-b21b-8ac476e54495"), new Guid("d3179697-703d-4ee8-998d-7674119309a5") }
                });

            migrationBuilder.InsertData(
                table: "Track",
                columns: new[] { "Id", "AlbumId", "IsActive", "Name" },
                values: new object[,]
                {
                    { new Guid("1afe4a9e-7121-4b34-89a6-8db6e0b6ddad"), new Guid("fe024194-aad4-462a-8fbd-8dd7b4a2cd90"), false, "Depression & Obsession" },
                    { new Guid("492f70ab-f1de-4de4-93b3-8602df66b05a"), new Guid("fe024194-aad4-462a-8fbd-8dd7b4a2cd90"), false, "Revenge" },
                    { new Guid("533b7e3d-9cfd-4731-8dda-a1d5a86ff80a"), new Guid("fe024194-aad4-462a-8fbd-8dd7b4a2cd90"), false, "Jocelyn Flores" },
                    { new Guid("6d342342-ea26-40f4-aa92-420f3a943603"), new Guid("fe024194-aad4-462a-8fbd-8dd7b4a2cd90"), false, "Fuck Love feat. Trippie Redd" },
                    { new Guid("77b75ed9-e6d2-4d47-84c9-58af10e455c1"), new Guid("fe024194-aad4-462a-8fbd-8dd7b4a2cd90"), false, "Orlando" },
                    { new Guid("7fdfa190-66d6-43be-b2af-dbbd45052828"), new Guid("fe024194-aad4-462a-8fbd-8dd7b4a2cd90"), false, "Ayala (Outro)" },
                    { new Guid("8366834f-0278-46e2-8142-011813bda329"), new Guid("fe024194-aad4-462a-8fbd-8dd7b4a2cd90"), false, "The Explanation" },
                    { new Guid("84d5050b-a7b7-4c23-a2d1-93281183264a"), new Guid("fe024194-aad4-462a-8fbd-8dd7b4a2cd90"), false, "Dead Inside (Interlude)" },
                    { new Guid("8e22b0a3-063e-40ae-976e-5b06f762c8ce"), new Guid("fe024194-aad4-462a-8fbd-8dd7b4a2cd90"), false, "Carry On" },
                    { new Guid("baace2ca-c2c0-4cee-b129-53079d696059"), new Guid("fe024194-aad4-462a-8fbd-8dd7b4a2cd90"), false, "Save Me" },
                    { new Guid("f0c1326b-0646-46f4-966f-c10caa9c931b"), new Guid("fe024194-aad4-462a-8fbd-8dd7b4a2cd90"), false, "Everybody Dies In Their Nightmares" }
                });

            migrationBuilder.InsertData(
                table: "ArtistTracks",
                columns: new[] { "Id", "ArtistId", "TrackId" },
                values: new object[,]
                {
                    { new Guid("0280e933-4523-4073-9d47-26f7a6b05a14"), new Guid("c878736d-da07-4401-ab27-2743d4e035c5"), new Guid("84d5050b-a7b7-4c23-a2d1-93281183264a") },
                    { new Guid("0b19db21-ec04-4590-9884-eecad9e52f8d"), new Guid("c878736d-da07-4401-ab27-2743d4e035c5"), new Guid("8e22b0a3-063e-40ae-976e-5b06f762c8ce") },
                    { new Guid("10dc748b-47a1-412e-843f-e18e34bafa79"), new Guid("c878736d-da07-4401-ab27-2743d4e035c5"), new Guid("8366834f-0278-46e2-8142-011813bda329") },
                    { new Guid("53aacaa7-d274-4531-81d3-6777c46cff21"), new Guid("c878736d-da07-4401-ab27-2743d4e035c5"), new Guid("6d342342-ea26-40f4-aa92-420f3a943603") },
                    { new Guid("6fcc262a-69ea-425a-a73b-cb457f3cf67c"), new Guid("c878736d-da07-4401-ab27-2743d4e035c5"), new Guid("baace2ca-c2c0-4cee-b129-53079d696059") },
                    { new Guid("7e2fd2dd-24f3-4cfb-9695-dcdaa91731c2"), new Guid("c878736d-da07-4401-ab27-2743d4e035c5"), new Guid("1afe4a9e-7121-4b34-89a6-8db6e0b6ddad") },
                    { new Guid("a6c67bc3-3381-47fa-bfc8-a0f192a51b4c"), new Guid("c878736d-da07-4401-ab27-2743d4e035c5"), new Guid("77b75ed9-e6d2-4d47-84c9-58af10e455c1") },
                    { new Guid("b746d17b-aa44-409a-91b1-cccdb08e5d21"), new Guid("c878736d-da07-4401-ab27-2743d4e035c5"), new Guid("7fdfa190-66d6-43be-b2af-dbbd45052828") },
                    { new Guid("de25dd37-a411-44cd-8924-5f34fcbc5b54"), new Guid("c878736d-da07-4401-ab27-2743d4e035c5"), new Guid("f0c1326b-0646-46f4-966f-c10caa9c931b") },
                    { new Guid("f72379f0-d8cb-4b21-935d-1ec35b8d4fe4"), new Guid("c878736d-da07-4401-ab27-2743d4e035c5"), new Guid("492f70ab-f1de-4de4-93b3-8602df66b05a") },
                    { new Guid("fa272a3c-33a7-465a-95e1-9a6dcd6f015c"), new Guid("c878736d-da07-4401-ab27-2743d4e035c5"), new Guid("533b7e3d-9cfd-4731-8dda-a1d5a86ff80a") }
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
                name: "IX_Track_AlbumId",
                table: "Track",
                column: "AlbumId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "Track");

            migrationBuilder.DropTable(
                name: "Albums");
        }
    }
}
