using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Persistance.Migrations
{
    public partial class AdminTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AlbumGenres",
                keyColumn: "Id",
                keyValue: new Guid("15e079b2-3209-4b63-b206-13545bae50ef"));

            migrationBuilder.DeleteData(
                table: "AlbumGenres",
                keyColumn: "Id",
                keyValue: new Guid("16a24bf7-eb35-4ebe-a1d8-bcfc06942248"));

            migrationBuilder.DeleteData(
                table: "AlbumGenres",
                keyColumn: "Id",
                keyValue: new Guid("312fe46e-7c2a-4165-851e-7103c27fb87a"));

            migrationBuilder.DeleteData(
                table: "AlbumGenres",
                keyColumn: "Id",
                keyValue: new Guid("38032425-3ff4-49fe-9482-ef4bdb3dc406"));

            migrationBuilder.DeleteData(
                table: "AlbumGenres",
                keyColumn: "Id",
                keyValue: new Guid("475a485d-f36f-43c3-9aef-f664103fcdf9"));

            migrationBuilder.DeleteData(
                table: "AlbumGenres",
                keyColumn: "Id",
                keyValue: new Guid("a6f8ecab-cc9e-44eb-b889-86ea1aff1a83"));

            migrationBuilder.DeleteData(
                table: "AlbumGenres",
                keyColumn: "Id",
                keyValue: new Guid("e00dd346-b3f3-4945-9b10-48b65e0d40c7"));

            migrationBuilder.DeleteData(
                table: "AlbumGenres",
                keyColumn: "Id",
                keyValue: new Guid("f2f5e17e-f823-4341-9718-4b20102d608d"));

            migrationBuilder.DeleteData(
                table: "AlbumGenres",
                keyColumn: "Id",
                keyValue: new Guid("fc0173b4-8aad-42f1-92a5-44a7a47ea5cd"));

            migrationBuilder.DeleteData(
                table: "ArtistAlbums",
                keyColumn: "Id",
                keyValue: new Guid("37bc9b8b-300a-423b-a744-7102834d2e5c"));

            migrationBuilder.DeleteData(
                table: "ArtistAlbums",
                keyColumn: "Id",
                keyValue: new Guid("882c67d3-b997-401e-b668-cdb0e1dfc8b5"));

            migrationBuilder.DeleteData(
                table: "ArtistAlbums",
                keyColumn: "Id",
                keyValue: new Guid("ab753097-c69f-4fb4-b745-dae6acdbbc3f"));

            migrationBuilder.DeleteData(
                table: "ArtistAlbums",
                keyColumn: "Id",
                keyValue: new Guid("f909e04f-1052-4266-a7b5-133c53a68ef5"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("00472d18-b6f4-4bff-8da5-8da6df82cfe1"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("06d85a87-8d2c-4290-a276-1888c909c177"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("2be88acb-fd9e-49d1-a37a-7c6640158982"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("2f3edcdc-2ee1-4dfa-9de4-714c8118efaa"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("3d81f7e8-7df1-4855-b67d-e922416d9b6d"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("3e126816-068e-451e-b606-511cd1c302c7"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("50826b84-341a-42de-8e15-6517d4f24721"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("5ba69259-6bbe-4e04-95cc-f8f1a0c65862"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("794f09a9-a514-45a1-9cab-3af82404f939"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("d780ef77-daaf-4c07-b01d-88eebc4aadbe"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("f012c235-7fa7-47b3-a577-ae3b9246b22c"));

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
                    table.PrimaryKey("PK_Admin", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AccessToken", "FirstName", "LastName", "Login", "MiddleName", "Password", "RefreshToken" },
                values: new object[] { new Guid("b6c09286-5f65-450e-92d9-cc9048089488"), null, "Админ", "Админов", "admin", "Админович", "admin", null });

            migrationBuilder.InsertData(
                table: "AlbumGenres",
                columns: new[] { "Id", "AlbumId", "GenreId" },
                values: new object[,]
                {
                    { new Guid("19925006-4a04-4b32-95e5-c283547c4a99"), new Guid("62e05eec-dfed-462d-abfe-7489534fad8b"), new Guid("ae14797c-31cd-432a-b2de-b3db95a82ab4") },
                    { new Guid("335ad4a7-78c5-4774-a6ad-2083fc4384a3"), new Guid("c7b12644-83a9-4ccd-8418-808b11d9755e"), new Guid("8745e56f-b335-43fe-bd10-bad6bead0892") },
                    { new Guid("406c6f12-d205-42f2-bd59-98c2e80336ed"), new Guid("fe024194-aad4-462a-8fbd-8dd7b4a2cd90"), new Guid("8745e56f-b335-43fe-bd10-bad6bead0892") },
                    { new Guid("631b34b9-0615-4981-8572-c785af40474c"), new Guid("f7c43f96-79e4-4244-b21b-8ac476e54495"), new Guid("8745e56f-b335-43fe-bd10-bad6bead0892") },
                    { new Guid("687ca407-81da-4e21-bdcb-175150f9fbc8"), new Guid("62e05eec-dfed-462d-abfe-7489534fad8b"), new Guid("2f044c88-a983-4cf5-bcc1-a5d7764507ed") },
                    { new Guid("6ccef85d-6f33-4de8-ae65-170be59e564e"), new Guid("c7b12644-83a9-4ccd-8418-808b11d9755e"), new Guid("ae14797c-31cd-432a-b2de-b3db95a82ab4") },
                    { new Guid("8f019ec0-8607-4075-88d3-9a76a0c09086"), new Guid("fe024194-aad4-462a-8fbd-8dd7b4a2cd90"), new Guid("baa56e06-9672-4118-aee3-4098cec4581e") },
                    { new Guid("b22e669a-9c66-486d-b17d-a14c1a243e44"), new Guid("62e05eec-dfed-462d-abfe-7489534fad8b"), new Guid("8745e56f-b335-43fe-bd10-bad6bead0892") },
                    { new Guid("f016e467-2350-4479-9000-67895ae047de"), new Guid("fe024194-aad4-462a-8fbd-8dd7b4a2cd90"), new Guid("e2a8929f-2190-4329-bae1-83b170a3677f") }
                });

            migrationBuilder.InsertData(
                table: "ArtistAlbums",
                columns: new[] { "Id", "AlbumId", "ArtistId" },
                values: new object[,]
                {
                    { new Guid("23471132-60e9-46e0-8cac-812ac8e695dc"), new Guid("c7b12644-83a9-4ccd-8418-808b11d9755e"), new Guid("a62f20f1-a42d-41cb-8c17-890cc61b4b14") },
                    { new Guid("37d86067-916e-40ff-a643-e2b6377b8cfe"), new Guid("f7c43f96-79e4-4244-b21b-8ac476e54495"), new Guid("d3179697-703d-4ee8-998d-7674119309a5") },
                    { new Guid("a1e1be27-5a13-4994-9a39-488f88ec0bfd"), new Guid("62e05eec-dfed-462d-abfe-7489534fad8b"), new Guid("03810320-12e9-435f-9d8b-473572074360") },
                    { new Guid("a8b78b9f-26aa-439d-87f6-7eb58d2bba65"), new Guid("fe024194-aad4-462a-8fbd-8dd7b4a2cd90"), new Guid("c878736d-da07-4401-ab27-2743d4e035c5") }
                });

            migrationBuilder.InsertData(
                table: "ArtistTracks",
                columns: new[] { "Id", "ArtistId", "TrackId" },
                values: new object[,]
                {
                    { new Guid("244fa02f-6fb0-4e90-be90-4817dea4adff"), new Guid("c878736d-da07-4401-ab27-2743d4e035c5"), new Guid("7fdfa190-66d6-43be-b2af-dbbd45052828") },
                    { new Guid("4992f118-ede9-4952-82dc-33c7374d2106"), new Guid("c878736d-da07-4401-ab27-2743d4e035c5"), new Guid("1afe4a9e-7121-4b34-89a6-8db6e0b6ddad") },
                    { new Guid("59c55a67-b54b-4c12-81f8-ad2e457e353c"), new Guid("c878736d-da07-4401-ab27-2743d4e035c5"), new Guid("84d5050b-a7b7-4c23-a2d1-93281183264a") },
                    { new Guid("5a27607e-3b19-4d19-893e-cdbcba715385"), new Guid("c878736d-da07-4401-ab27-2743d4e035c5"), new Guid("533b7e3d-9cfd-4731-8dda-a1d5a86ff80a") },
                    { new Guid("93ab31f3-6b63-4b61-a3f7-00ba0ce3c393"), new Guid("c878736d-da07-4401-ab27-2743d4e035c5"), new Guid("77b75ed9-e6d2-4d47-84c9-58af10e455c1") },
                    { new Guid("98b6a498-246e-44d6-8fe2-23c024ea86ad"), new Guid("c878736d-da07-4401-ab27-2743d4e035c5"), new Guid("492f70ab-f1de-4de4-93b3-8602df66b05a") },
                    { new Guid("99e2083e-f4b3-4be1-8235-421fbaf57780"), new Guid("c878736d-da07-4401-ab27-2743d4e035c5"), new Guid("6d342342-ea26-40f4-aa92-420f3a943603") },
                    { new Guid("ba6f17cd-20fa-4740-a3e4-3d48b9ec9edc"), new Guid("c878736d-da07-4401-ab27-2743d4e035c5"), new Guid("f0c1326b-0646-46f4-966f-c10caa9c931b") },
                    { new Guid("c1fc22b2-401a-4c69-b66b-ec2cb4f20eb1"), new Guid("c878736d-da07-4401-ab27-2743d4e035c5"), new Guid("8e22b0a3-063e-40ae-976e-5b06f762c8ce") },
                    { new Guid("cb075f83-1a7c-4320-8f22-779da55b1c95"), new Guid("c878736d-da07-4401-ab27-2743d4e035c5"), new Guid("8366834f-0278-46e2-8142-011813bda329") },
                    { new Guid("d85cb043-aeb2-4d8d-bb54-37ac4d96411a"), new Guid("c878736d-da07-4401-ab27-2743d4e035c5"), new Guid("baace2ca-c2c0-4cee-b129-53079d696059") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DeleteData(
                table: "AlbumGenres",
                keyColumn: "Id",
                keyValue: new Guid("19925006-4a04-4b32-95e5-c283547c4a99"));

            migrationBuilder.DeleteData(
                table: "AlbumGenres",
                keyColumn: "Id",
                keyValue: new Guid("335ad4a7-78c5-4774-a6ad-2083fc4384a3"));

            migrationBuilder.DeleteData(
                table: "AlbumGenres",
                keyColumn: "Id",
                keyValue: new Guid("406c6f12-d205-42f2-bd59-98c2e80336ed"));

            migrationBuilder.DeleteData(
                table: "AlbumGenres",
                keyColumn: "Id",
                keyValue: new Guid("631b34b9-0615-4981-8572-c785af40474c"));

            migrationBuilder.DeleteData(
                table: "AlbumGenres",
                keyColumn: "Id",
                keyValue: new Guid("687ca407-81da-4e21-bdcb-175150f9fbc8"));

            migrationBuilder.DeleteData(
                table: "AlbumGenres",
                keyColumn: "Id",
                keyValue: new Guid("6ccef85d-6f33-4de8-ae65-170be59e564e"));

            migrationBuilder.DeleteData(
                table: "AlbumGenres",
                keyColumn: "Id",
                keyValue: new Guid("8f019ec0-8607-4075-88d3-9a76a0c09086"));

            migrationBuilder.DeleteData(
                table: "AlbumGenres",
                keyColumn: "Id",
                keyValue: new Guid("b22e669a-9c66-486d-b17d-a14c1a243e44"));

            migrationBuilder.DeleteData(
                table: "AlbumGenres",
                keyColumn: "Id",
                keyValue: new Guid("f016e467-2350-4479-9000-67895ae047de"));

            migrationBuilder.DeleteData(
                table: "ArtistAlbums",
                keyColumn: "Id",
                keyValue: new Guid("23471132-60e9-46e0-8cac-812ac8e695dc"));

            migrationBuilder.DeleteData(
                table: "ArtistAlbums",
                keyColumn: "Id",
                keyValue: new Guid("37d86067-916e-40ff-a643-e2b6377b8cfe"));

            migrationBuilder.DeleteData(
                table: "ArtistAlbums",
                keyColumn: "Id",
                keyValue: new Guid("a1e1be27-5a13-4994-9a39-488f88ec0bfd"));

            migrationBuilder.DeleteData(
                table: "ArtistAlbums",
                keyColumn: "Id",
                keyValue: new Guid("a8b78b9f-26aa-439d-87f6-7eb58d2bba65"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("244fa02f-6fb0-4e90-be90-4817dea4adff"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("4992f118-ede9-4952-82dc-33c7374d2106"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("59c55a67-b54b-4c12-81f8-ad2e457e353c"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("5a27607e-3b19-4d19-893e-cdbcba715385"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("93ab31f3-6b63-4b61-a3f7-00ba0ce3c393"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("98b6a498-246e-44d6-8fe2-23c024ea86ad"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("99e2083e-f4b3-4be1-8235-421fbaf57780"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("ba6f17cd-20fa-4740-a3e4-3d48b9ec9edc"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("c1fc22b2-401a-4c69-b66b-ec2cb4f20eb1"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("cb075f83-1a7c-4320-8f22-779da55b1c95"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("d85cb043-aeb2-4d8d-bb54-37ac4d96411a"));

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
        }
    }
}
