using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

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
                name: "Tracks",
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
                    { new Guid("15e079b2-3209-4b63-b206-13545bae50ef"), new Guid("62e05eec-dfed-462d-abfe-7489534fad8b"), new Guid("ae14797c-31cd-432a-b2de-b3db95a82ab4") },
                    { new Guid("16a24bf7-eb35-4ebe-a1d8-bcfc06942248"), new Guid("62e05eec-dfed-462d-abfe-7489534fad8b"), new Guid("8745e56f-b335-43fe-bd10-bad6bead0892") },
                    { new Guid("312fe46e-7c2a-4165-851e-7103c27fb87a"), new Guid("c7b12644-83a9-4ccd-8418-808b11d9755e"), new Guid("ae14797c-31cd-432a-b2de-b3db95a82ab4") },
                    { new Guid("38032425-3ff4-49fe-9482-ef4bdb3dc406"), new Guid("fe024194-aad4-462a-8fbd-8dd7b4a2cd90"), new Guid("8745e56f-b335-43fe-bd10-bad6bead0892") },
                    { new Guid("475a485d-f36f-43c3-9aef-f664103fcdf9"), new Guid("62e05eec-dfed-462d-abfe-7489534fad8b"), new Guid("2f044c88-a983-4cf5-bcc1-a5d7764507ed") },
                    { new Guid("a6f8ecab-cc9e-44eb-b889-86ea1aff1a83"), new Guid("c7b12644-83a9-4ccd-8418-808b11d9755e"), new Guid("8745e56f-b335-43fe-bd10-bad6bead0892") },
                    { new Guid("e00dd346-b3f3-4945-9b10-48b65e0d40c7"), new Guid("fe024194-aad4-462a-8fbd-8dd7b4a2cd90"), new Guid("e2a8929f-2190-4329-bae1-83b170a3677f") },
                    { new Guid("f2f5e17e-f823-4341-9718-4b20102d608d"), new Guid("f7c43f96-79e4-4244-b21b-8ac476e54495"), new Guid("8745e56f-b335-43fe-bd10-bad6bead0892") },
                    { new Guid("fc0173b4-8aad-42f1-92a5-44a7a47ea5cd"), new Guid("fe024194-aad4-462a-8fbd-8dd7b4a2cd90"), new Guid("baa56e06-9672-4118-aee3-4098cec4581e") }
                });

            migrationBuilder.InsertData(
                table: "ArtistAlbums",
                columns: new[] { "Id", "AlbumId", "ArtistId" },
                values: new object[,]
                {
                    { new Guid("37bc9b8b-300a-423b-a744-7102834d2e5c"), new Guid("f7c43f96-79e4-4244-b21b-8ac476e54495"), new Guid("d3179697-703d-4ee8-998d-7674119309a5") },
                    { new Guid("882c67d3-b997-401e-b668-cdb0e1dfc8b5"), new Guid("c7b12644-83a9-4ccd-8418-808b11d9755e"), new Guid("a62f20f1-a42d-41cb-8c17-890cc61b4b14") },
                    { new Guid("ab753097-c69f-4fb4-b745-dae6acdbbc3f"), new Guid("fe024194-aad4-462a-8fbd-8dd7b4a2cd90"), new Guid("c878736d-da07-4401-ab27-2743d4e035c5") },
                    { new Guid("f909e04f-1052-4266-a7b5-133c53a68ef5"), new Guid("62e05eec-dfed-462d-abfe-7489534fad8b"), new Guid("03810320-12e9-435f-9d8b-473572074360") }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
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
                    { new Guid("00472d18-b6f4-4bff-8da5-8da6df82cfe1"), new Guid("c878736d-da07-4401-ab27-2743d4e035c5"), new Guid("492f70ab-f1de-4de4-93b3-8602df66b05a") },
                    { new Guid("06d85a87-8d2c-4290-a276-1888c909c177"), new Guid("c878736d-da07-4401-ab27-2743d4e035c5"), new Guid("533b7e3d-9cfd-4731-8dda-a1d5a86ff80a") },
                    { new Guid("2be88acb-fd9e-49d1-a37a-7c6640158982"), new Guid("c878736d-da07-4401-ab27-2743d4e035c5"), new Guid("baace2ca-c2c0-4cee-b129-53079d696059") },
                    { new Guid("2f3edcdc-2ee1-4dfa-9de4-714c8118efaa"), new Guid("c878736d-da07-4401-ab27-2743d4e035c5"), new Guid("8e22b0a3-063e-40ae-976e-5b06f762c8ce") },
                    { new Guid("3d81f7e8-7df1-4855-b67d-e922416d9b6d"), new Guid("c878736d-da07-4401-ab27-2743d4e035c5"), new Guid("8366834f-0278-46e2-8142-011813bda329") },
                    { new Guid("3e126816-068e-451e-b606-511cd1c302c7"), new Guid("c878736d-da07-4401-ab27-2743d4e035c5"), new Guid("6d342342-ea26-40f4-aa92-420f3a943603") },
                    { new Guid("50826b84-341a-42de-8e15-6517d4f24721"), new Guid("c878736d-da07-4401-ab27-2743d4e035c5"), new Guid("77b75ed9-e6d2-4d47-84c9-58af10e455c1") },
                    { new Guid("5ba69259-6bbe-4e04-95cc-f8f1a0c65862"), new Guid("c878736d-da07-4401-ab27-2743d4e035c5"), new Guid("84d5050b-a7b7-4c23-a2d1-93281183264a") },
                    { new Guid("794f09a9-a514-45a1-9cab-3af82404f939"), new Guid("c878736d-da07-4401-ab27-2743d4e035c5"), new Guid("1afe4a9e-7121-4b34-89a6-8db6e0b6ddad") },
                    { new Guid("d780ef77-daaf-4c07-b01d-88eebc4aadbe"), new Guid("c878736d-da07-4401-ab27-2743d4e035c5"), new Guid("7fdfa190-66d6-43be-b2af-dbbd45052828") },
                    { new Guid("f012c235-7fa7-47b3-a577-ae3b9246b22c"), new Guid("c878736d-da07-4401-ab27-2743d4e035c5"), new Guid("f0c1326b-0646-46f4-966f-c10caa9c931b") }
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
