using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Persistance.Migrations
{
    public partial class RelationalTrackGenre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Genres_Albums_AlbumId",
                table: "Genres");

            migrationBuilder.DropTable(
                name: "AlbumGenres");

            migrationBuilder.DropIndex(
                name: "IX_Genres_AlbumId",
                table: "Genres");

            migrationBuilder.DeleteData(
                table: "ArtistAlbums",
                keyColumn: "Id",
                keyValue: new Guid("30965a2d-b2eb-448b-bedb-56e56215f76f"));

            migrationBuilder.DeleteData(
                table: "ArtistAlbums",
                keyColumn: "Id",
                keyValue: new Guid("86e9eb76-1f31-40b1-a655-6b7d6860a7bd"));

            migrationBuilder.DeleteData(
                table: "ArtistAlbums",
                keyColumn: "Id",
                keyValue: new Guid("87cb0a2e-63f3-491c-b164-eac43dd743f4"));

            migrationBuilder.DeleteData(
                table: "ArtistAlbums",
                keyColumn: "Id",
                keyValue: new Guid("994a42cd-1c68-4fdb-b2b1-f0e9f4ee44a5"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("03ddc79f-b1ba-4b5b-a8fc-a40c7bf41747"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("0698c4b9-be2b-4fe9-8dbe-8c12111c6605"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("0caf3d40-756b-46ff-8a45-3161a85a0872"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("1d76e33d-4885-4785-b1ff-75c8593834a4"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("2b189dd4-a8c3-4921-a361-f63c37eabb70"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("35b257fa-ee34-45ed-ad86-8347bc585dbc"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("506ea768-1c1c-402b-9ad6-e41af208f4d7"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("5de801cc-0029-4706-b03f-763f1868c228"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("6f2fc58d-1415-460b-b31f-b774d87425f3"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("79ed1f18-35ad-46e4-9d02-ab8b118b3fe3"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("83dd7c9d-630c-4a41-ba9d-fcfdf526a299"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("8aac4072-4ba8-4be3-95d8-193392e1591f"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("8fa88919-15b7-4fa2-a014-117a5e979ea2"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("970afdc7-7e88-4d7b-8bd8-73e2a4c86f25"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("97c79ba6-febc-4d53-9e2a-1c6fdb4f3a5a"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("ab93d52a-2279-49fd-9d89-aa0770931ae4"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("c30d6179-0407-487b-bfea-b543921d84c4"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("c543cb27-3040-4e6e-b420-ab34ac4cc925"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("c70bbcef-922f-44bc-b716-c07118510321"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("dae6391e-f96b-4807-86e8-94067b686ad2"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("ee325bd5-8b52-4c7d-8afe-5d19361e6b3b"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("ee34d371-d538-43a4-bd59-19f5faf67985"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("f8b9412d-9784-45f3-ad10-5b84d4014ab3"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("fea2789f-a50e-4274-8824-534a75491e98"));

            migrationBuilder.DropColumn(
                name: "AlbumId",
                table: "Genres");

            migrationBuilder.CreateTable(
                name: "TrackGenres",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    TrackId = table.Column<Guid>(type: "uuid", nullable: false),
                    GenreId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrackGenres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrackGenres_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrackGenres_Tracks_TrackId",
                        column: x => x.TrackId,
                        principalTable: "Tracks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ArtistAlbums",
                columns: new[] { "Id", "AlbumId", "ArtistId" },
                values: new object[,]
                {
                    { new Guid("036d4d0b-dac8-466c-b818-808135398925"), new Guid("d9d9d08b-5422-4458-a4de-34ac03a5f52e"), new Guid("573a1d7c-694e-4f66-8905-8e528f137d27") },
                    { new Guid("07326b5b-2aff-4714-82a9-84752c4e5dfc"), new Guid("c3e23e47-c858-4c1c-9000-bd3f4e8fb1f0"), new Guid("f2e16642-5d10-4195-8bc6-8b9dbb9dbd5a") },
                    { new Guid("0eeb26f2-b91c-4aa8-b802-40274b727f43"), new Guid("89901ee5-7d1f-48a4-8e92-83a9b5c76f1e"), new Guid("bcb0671f-572a-4495-b5df-3f2865e081b2") },
                    { new Guid("1fc50e93-9e47-4d8d-8d24-d6301ae5333d"), new Guid("62e05eec-dfed-462d-abfe-7489534fad8b"), new Guid("c9c8d64c-fa56-4e2e-b8ef-6e41d00735e1") },
                    { new Guid("2026349a-fad9-4820-994e-fb4cf29694ff"), new Guid("73c8af54-d09b-4ef7-b646-901e59b868ed"), new Guid("87f352c1-ef43-41fb-b5c1-3a46e51868b8") },
                    { new Guid("44252f96-d18b-4061-bb7e-8528bf2ca81b"), new Guid("c7b12644-83a9-4ccd-8418-808b11d9755e"), new Guid("8c22ffaa-6cb7-43c9-8f7f-4a204663df42") },
                    { new Guid("5a2a1672-8b86-4a4b-b991-a1d9b9a55f4f"), new Guid("8b9dcb0b-2f8d-4f0c-8645-0e8d588a4f5e"), new Guid("81d19ab4-52a1-4e47-9766-2c7b682e89b3") },
                    { new Guid("5d312d8f-b4f0-4e3e-bb4d-2a5e0b0a5852"), new Guid("e4b2c83d-384f-4d68-bbd0-ef8fdd9e9d25"), new Guid("d8956234-3e1b-4c14-ae78-9b7f1f598ef2") },
                    { new Guid("7885c9db-c6cb-44c2-be3e-ef8632fcbc4c"), new Guid("cc37dd0a-7831-4b4b-babb-259b4d06598d"), new Guid("640e13de-bd1e-4088-8651-44be51f2451d") },
                    { new Guid("8931706a-4462-4205-a2a1-aecff5967d3e"), new Guid("f7c43f96-79e4-4244-b21b-8ac476e54495"), new Guid("90ac1df8-837d-42af-a40a-a0cbd28770fd") },
                    { new Guid("9b9253bb-3c36-4dbe-b3b6-460a73b9d2ca"), new Guid("bc5b6b69-c641-4105-a906-19b88dbbb4ae"), new Guid("a7ab352a-421d-4f78-9a5c-72d2cfa9c430") },
                    { new Guid("bd271556-b143-4767-a355-23b21b3c7463"), new Guid("5711de71-8cb5-4be9-984f-d1683760a9a6"), new Guid("f024e3f8-cf68-4c48-b288-b04e9c8b30c2") },
                    { new Guid("f68e2d7c-8981-488a-9ac2-1c44f87d12f9"), new Guid("fe024194-aad4-462a-8fbd-8dd7b4a2cd90"), new Guid("9b17852c-5733-494d-8c37-ecf91fbc668f") }
                });

            migrationBuilder.InsertData(
                table: "ArtistTracks",
                columns: new[] { "Id", "ArtistId", "TrackId" },
                values: new object[,]
                {
                    { new Guid("012e5480-d34a-4072-962a-374bb02dd167"), new Guid("a7ab352a-421d-4f78-9a5c-72d2cfa9c430"), new Guid("a0c7644a-73b7-4b3a-b457-7e51e1f63a17") },
                    { new Guid("02db298d-ee20-4b81-a8f9-26cbb0b259b9"), new Guid("8c22ffaa-6cb7-43c9-8f7f-4a204663df42"), new Guid("e9481c7b-c007-46de-b706-4775c1d9c6de") },
                    { new Guid("04bd658f-c26d-421d-9a8e-13e8893fb144"), new Guid("a7ab352a-421d-4f78-9a5c-72d2cfa9c430"), new Guid("f0d98d33-4c4f-4d87-9a5f-33fe7c1ab7a2") },
                    { new Guid("0b9350a2-5db7-4215-8e3e-8f87e40e3527"), new Guid("90ac1df8-837d-42af-a40a-a0cbd28770fd"), new Guid("0a41a3fe-6f5d-4d23-9a34-34a11b5b438b") },
                    { new Guid("0c1081be-1b2a-45d1-80fd-f2c6d1a58d77"), new Guid("c9c8d64c-fa56-4e2e-b8ef-6e41d00735e1"), new Guid("3e4d4f4d-46f5-4716-9b8b-c355e66b8832") },
                    { new Guid("0e4b9f71-0d6e-4414-9dc9-3c1327a5b5d6"), new Guid("8c22ffaa-6cb7-43c9-8f7f-4a204663df42"), new Guid("2d75a3c6-1e6b-4740-afaa-60e33bcb77e3") },
                    { new Guid("0e9c4c45-0a19-4d44-a271-637a809755e3"), new Guid("8c22ffaa-6cb7-43c9-8f7f-4a204663df42"), new Guid("a633f860-97ce-4d9a-9960-2091db4aee78") },
                    { new Guid("0e9c766e-3711-487b-8f63-5b1a70179ecb"), new Guid("a7ab352a-421d-4f78-9a5c-72d2cfa9c430"), new Guid("ed7f120f-0c7d-4bcf-a733-2b4de2a50b1b") },
                    { new Guid("0f23192e-3d29-4d7b-bfc4-6cc7e8a1333e"), new Guid("c9c8d64c-fa56-4e2e-b8ef-6e41d00735e1"), new Guid("3d8e0d8f-8b9a-4f54-9e13-3a9d7db4ce41") },
                    { new Guid("11f13d23-1db2-4f64-bb43-4dc5674f9c0e"), new Guid("8c22ffaa-6cb7-43c9-8f7f-4a204663df42"), new Guid("6c9645b5-3f50-4a11-8be0-314a97c27eb8") },
                    { new Guid("159625cc-83fc-496c-997f-5f8e9ba95382"), new Guid("a7ab352a-421d-4f78-9a5c-72d2cfa9c430"), new Guid("88f77e10-02c2-4182-a5e6-8946a84688a9") },
                    { new Guid("1683c9f0-380f-45da-ad21-42e61a58e3c8"), new Guid("90ac1df8-837d-42af-a40a-a0cbd28770fd"), new Guid("f840d9d0-7ecf-4b7c-b4e6-50118a1f6712") },
                    { new Guid("18741c3f-fd9e-4b7f-876a-1e4eb6ff0ed0"), new Guid("8c22ffaa-6cb7-43c9-8f7f-4a204663df42"), new Guid("f0a91ef7-1eaa-40d0-8273-0401bea48b5c") },
                    { new Guid("1c0e4feb-1326-4d36-9ab5-cc492259f4a5"), new Guid("a7ab352a-421d-4f78-9a5c-72d2cfa9c430"), new Guid("52a3a0db-7172-41a6-8a60-6e2533f3e5b0") },
                    { new Guid("2626581d-14b3-48ca-a802-35d305acc305"), new Guid("a7ab352a-421d-4f78-9a5c-72d2cfa9c430"), new Guid("d8b23e3c-f1d1-47be-82b6-77a4c5e67f35") },
                    { new Guid("264ce9f9-14d1-4552-9b8c-459d1c6f3c24"), new Guid("a7ab352a-421d-4f78-9a5c-72d2cfa9c430"), new Guid("71d0a71f-9e5e-4fbf-8be5-0b39a10781f2") },
                    { new Guid("27fdca20-7677-44e3-b92b-2c4b0e7c2a88"), new Guid("8c22ffaa-6cb7-43c9-8f7f-4a204663df42"), new Guid("8842e1a3-18e2-4aa7-8b66-55150248a33a") },
                    { new Guid("31278f5b-7547-4943-8055-86cb35bb58b2"), new Guid("a7ab352a-421d-4f78-9a5c-72d2cfa9c430"), new Guid("3bc4e4a4-1b6f-4a53-89fc-6e62fdd442a9") },
                    { new Guid("3567e2e1-5a2b-4d3a-8497-208bf28843de"), new Guid("8c22ffaa-6cb7-43c9-8f7f-4a204663df42"), new Guid("c138c0a3-0dbd-4b9c-9533-d860bb4d1364") },
                    { new Guid("36087572-27b9-4526-b77e-9eb5ffaa804d"), new Guid("a7ab352a-421d-4f78-9a5c-72d2cfa9c430"), new Guid("8fb522a4-80c7-4551-95e9-29b4282dc81a") },
                    { new Guid("3922fa95-491e-403c-a782-1895aafde570"), new Guid("a7ab352a-421d-4f78-9a5c-72d2cfa9c430"), new Guid("64955a7c-30be-4c85-8d85-d36d487ed3d5") },
                    { new Guid("3b0d81da-0a1b-4a48-8df7-0b90a12284a9"), new Guid("8c22ffaa-6cb7-43c9-8f7f-4a204663df42"), new Guid("e43d89cd-398d-4dbb-99e6-789869f891f3") },
                    { new Guid("3c478396-1b97-491e-8d2c-4e53fe66a426"), new Guid("c9c8d64c-fa56-4e2e-b8ef-6e41d00735e1"), new Guid("0e53296d-4f08-4a15-ae64-23a8f4e8d804") },
                    { new Guid("3dd99d1e-e0f6-416e-b82d-60532b3c2546"), new Guid("a7ab352a-421d-4f78-9a5c-72d2cfa9c430"), new Guid("2e8f13db-8b78-4ff1-ba08-2e47abf35127") },
                    { new Guid("3df3ab31-c120-4689-b463-446c56f6dae9"), new Guid("a7ab352a-421d-4f78-9a5c-72d2cfa9c430"), new Guid("b75197d8-5d56-4b1d-8a5c-1a2c8c7b73d0") },
                    { new Guid("492f70ab-f1de-4de4-93b3-8602df66b05a"), new Guid("90ac1df8-837d-42af-a40a-a0cbd28770fd"), new Guid("41b26f20-69e4-43d2-8db4-76ed6a5028b3") },
                    { new Guid("4ef8889f-7b50-44b7-87b2-783cb166f5a9"), new Guid("8c22ffaa-6cb7-43c9-8f7f-4a204663df42"), new Guid("3fde47fd-c654-4124-bc46-88d3b9bfa4df") },
                    { new Guid("51b5fb42-0cf9-47c8-8e59-f6fe4175fe19"), new Guid("90ac1df8-837d-42af-a40a-a0cbd28770fd"), new Guid("674a432f-3fd4-4b33-af25-82607c96a3f0") },
                    { new Guid("51ec7c53-4fc9-4069-a689-1e26eef9f419"), new Guid("a7ab352a-421d-4f78-9a5c-72d2cfa9c430"), new Guid("0a0e4f09-16b3-44d2-a545-c3f23a6bda9e") },
                    { new Guid("55b1fefa-8770-4a1d-83cf-d5279a6f4628"), new Guid("a7ab352a-421d-4f78-9a5c-72d2cfa9c430"), new Guid("f52e7de3-46d6-40cc-9e67-3d28b1dd84d9") },
                    { new Guid("58660e66-4d3d-43cc-82c1-f10a8ce1569d"), new Guid("c9c8d64c-fa56-4e2e-b8ef-6e41d00735e1"), new Guid("1e4b79fc-4f83-44d2-95c4-35b69f62c3ab") },
                    { new Guid("5ff4e98e-87a1-4a37-85ab-520b76be11da"), new Guid("c9c8d64c-fa56-4e2e-b8ef-6e41d00735e1"), new Guid("d48b865a-10ef-4f6e-aae9-58ef614fc16f") },
                    { new Guid("6bb1b311-0d9e-449c-ad4c-d18ac8a1d72d"), new Guid("90ac1df8-837d-42af-a40a-a0cbd28770fd"), new Guid("066d0b1d-b7c6-40b6-a48c-1f7b83084760") },
                    { new Guid("6c1fa1fb-fb9d-4e13-ac53-23988ffd0456"), new Guid("a7ab352a-421d-4f78-9a5c-72d2cfa9c430"), new Guid("2a4b28e2-7a44-4716-8247-3b03d75e27d9") },
                    { new Guid("6d342342-ea26-40f4-aa92-420f3a943603"), new Guid("90ac1df8-837d-42af-a40a-a0cbd28770fd"), new Guid("61458d69-7f4a-406d-80e3-7ff0d65e7f5f") },
                    { new Guid("6d5e3a81-520f-4ff7-9ad9-b06d72c3cfd1"), new Guid("c9c8d64c-fa56-4e2e-b8ef-6e41d00735e1"), new Guid("9a38a1d3-91c6-4f0e-b5b9-7d9b542cdd15") },
                    { new Guid("71b7b68b-5631-416f-a43f-29a972ff82fd"), new Guid("8c22ffaa-6cb7-43c9-8f7f-4a204663df42"), new Guid("997f8ae9-cc5d-4b19-9dd7-0f1d287106e9") },
                    { new Guid("74d6b61c-58af-4503-8edf-4c2b80ad84c9"), new Guid("8c22ffaa-6cb7-43c9-8f7f-4a204663df42"), new Guid("5d146662-869d-477f-8f99-620ad1f3c1d1") },
                    { new Guid("75c9c365-0988-4944-857d-5d3c27a72869"), new Guid("a7ab352a-421d-4f78-9a5c-72d2cfa9c430"), new Guid("ad85a600-f97a-42f0-a951-40b9a4b3c993") },
                    { new Guid("76dec0a0-393c-43aa-81d5-2c6683dcfef2"), new Guid("a7ab352a-421d-4f78-9a5c-72d2cfa9c430"), new Guid("e1e8b1f7-0a07-428e-bc1d-c08dbd5c6744") },
                    { new Guid("77b75ed9-e6d2-4d47-84c9-58af10e455c1"), new Guid("90ac1df8-837d-42af-a40a-a0cbd28770fd"), new Guid("7541417e-d9db-45c5-95f3-146b6f43f523") },
                    { new Guid("7b8b6ab2-14b0-421f-bd9e-2da8c2407d9a"), new Guid("8c22ffaa-6cb7-43c9-8f7f-4a204663df42"), new Guid("f89c0c4d-59e4-4b9a-b95f-8c6d2fb4208b") },
                    { new Guid("7d50e2cc-a8bf-457b-b24d-cf8e62df4b18"), new Guid("a7ab352a-421d-4f78-9a5c-72d2cfa9c430"), new Guid("c0e4e1d2-0c43-41f1-952f-788496ab6f8f") },
                    { new Guid("7f576d25-73da-44af-8f3e-8bb7e8d8f605"), new Guid("8c22ffaa-6cb7-43c9-8f7f-4a204663df42"), new Guid("4d60248e-d3f1-43e0-978f-356947c53e15") },
                    { new Guid("7fdfa190-66d6-43be-b2af-dbbd45052828"), new Guid("90ac1df8-837d-42af-a40a-a0cbd28770fd"), new Guid("96b13d9a-3a2d-4a61-9616-6f2f2a2e0de4") },
                    { new Guid("84d5050b-a7b7-4c23-a2d1-93281183264a"), new Guid("90ac1df8-837d-42af-a40a-a0cbd28770fd"), new Guid("8b9df2a6-df2f-4c52-83d3-03aeb745e3e3") },
                    { new Guid("87da9d0b-c5b6-47ee-b6f1-1a8a3a165cfc"), new Guid("a7ab352a-421d-4f78-9a5c-72d2cfa9c430"), new Guid("d65a624a-c81b-4ed1-af0a-8b27ac872e6e") },
                    { new Guid("89a6cc4c-640c-4f4c-951b-10bbce402939"), new Guid("8c22ffaa-6cb7-43c9-8f7f-4a204663df42"), new Guid("5e8eae8c-7d72-4dc0-9832-6ae82f5a42ed") },
                    { new Guid("8b4c8223-5e6b-4e35-a3e1-8255797fd649"), new Guid("8c22ffaa-6cb7-43c9-8f7f-4a204663df42"), new Guid("bf9e77fd-3d3a-4a77-aae9-123d03b9a2e4") },
                    { new Guid("8e22b0a3-063e-40ae-976e-5b06f762c8ce"), new Guid("90ac1df8-837d-42af-a40a-a0cbd28770fd"), new Guid("4fca4e84-f34c-4b73-8a66-3d1566763a8a") },
                    { new Guid("917b0066-962f-41c5-8613-ca7142805c4a"), new Guid("a7ab352a-421d-4f78-9a5c-72d2cfa9c430"), new Guid("450cb1e3-ebc1-4dcb-a5a6-3e5e5db174d8") },
                    { new Guid("a7e6dd5f-d654-45ef-8f29-ccbc6c91e0a1"), new Guid("8c22ffaa-6cb7-43c9-8f7f-4a204663df42"), new Guid("d982cc75-bcfc-4c66-8dd6-23b1e87866e5") },
                    { new Guid("abf1ef6b-cf5e-4fb5-8f1e-22a8ab7b6c0d"), new Guid("8c22ffaa-6cb7-43c9-8f7f-4a204663df42"), new Guid("9b17852c-5733-494d-8c37-ecf91fbc668f") },
                    { new Guid("baace2ca-c2c0-4cee-b129-53079d696059"), new Guid("90ac1df8-837d-42af-a40a-a0cbd28770fd"), new Guid("bea11ee9-0d72-4d56-b27c-33095a0787a7") },
                    { new Guid("bc9bdc36-1d53-4fae-8d6e-60edf292c3f4"), new Guid("8c22ffaa-6cb7-43c9-8f7f-4a204663df42"), new Guid("15dc8b5e-f87e-4ee6-8f0b-6c1f1e2f5eb1") },
                    { new Guid("c0802ea6-d526-4fc2-a3b4-09f14b6706fc"), new Guid("8c22ffaa-6cb7-43c9-8f7f-4a204663df42"), new Guid("d1c9e7c7-ee5e-4ae7-8d5e-bdb94e10bcb9") },
                    { new Guid("c3e5bdc0-8a85-4013-9a7b-8e119a0fcb5a"), new Guid("8c22ffaa-6cb7-43c9-8f7f-4a204663df42"), new Guid("08d03e3d-0919-4c01-a6db-78c2abfc4d5e") },
                    { new Guid("c3e8c3a0-4db3-4f0c-83f9-32b499285a0a"), new Guid("c9c8d64c-fa56-4e2e-b8ef-6e41d00735e1"), new Guid("190e4a84-462b-4a3e-90e4-9e25a826c4d3") },
                    { new Guid("c878736d-da07-4401-ab27-2743d4e035c5"), new Guid("90ac1df8-837d-42af-a40a-a0cbd28770fd"), new Guid("2fb86013-0a56-4f2a-bd99-3fd4f4c1f1f3") },
                    { new Guid("cc6db5e7-8b8a-4dad-bb54-cf2b13ad1612"), new Guid("a7ab352a-421d-4f78-9a5c-72d2cfa9c430"), new Guid("3cb2c0a8-1e79-4d6a-9b61-0af74c533787") },
                    { new Guid("cd1b577a-b8e4-4f06-bde2-942b5ef09f92"), new Guid("90ac1df8-837d-42af-a40a-a0cbd28770fd"), new Guid("b8fd88fb-647e-4130-83ed-801a9abf5e75") },
                    { new Guid("cf6406db-f369-485c-aece-2bba9fc9c9be"), new Guid("8c22ffaa-6cb7-43c9-8f7f-4a204663df42"), new Guid("ddaa72b5-3a20-46d7-8c48-c6c7c9ea2564") },
                    { new Guid("d16be991-6408-486e-8f3b-75465cc0ae45"), new Guid("a7ab352a-421d-4f78-9a5c-72d2cfa9c430"), new Guid("3a1a5599-ee9e-4786-88ea-57a0edf6e977") },
                    { new Guid("d1c9e7c7-ee5e-4ae7-8d5e-bdb94e10bcb9"), new Guid("c9c8d64c-fa56-4e2e-b8ef-6e41d00735e1"), new Guid("c878736d-da07-4401-ab27-2743d4e035c5") },
                    { new Guid("d1ee8e53-2982-4d95-8728-23b13cbdd8c7"), new Guid("8c22ffaa-6cb7-43c9-8f7f-4a204663df42"), new Guid("6b24c35d-8589-4d35-83be-dfc48f0c8a79") },
                    { new Guid("d2ff6526-18be-4bb3-ba95-30361f7a2f4c"), new Guid("c9c8d64c-fa56-4e2e-b8ef-6e41d00735e1"), new Guid("a3fe58cc-ba59-4e09-96a1-4f9e8f77f99b") },
                    { new Guid("d64157a2-9257-4e0b-80f4-20f7e45a50a1"), new Guid("8c22ffaa-6cb7-43c9-8f7f-4a204663df42"), new Guid("262342b2-861e-4802-a54c-c84522188cd7") },
                    { new Guid("d9e1b86b-085e-4502-b591-13393b168dd7"), new Guid("a7ab352a-421d-4f78-9a5c-72d2cfa9c430"), new Guid("1e41186e-c7b1-40ed-85c9-4e4c5b5c33b7") },
                    { new Guid("df7520f7-0f08-43e2-8c0c-bf71e2a1b9bb"), new Guid("90ac1df8-837d-42af-a40a-a0cbd28770fd"), new Guid("3f3ef649-9e39-4bda-85e5-3d763f01c31e") },
                    { new Guid("dfcbe1df-6bbb-4741-9c2a-08e53d8056ee"), new Guid("a7ab352a-421d-4f78-9a5c-72d2cfa9c430"), new Guid("a0fc64ff-fa2b-4d7d-9650-3a083ebdca24") },
                    { new Guid("e34d2f2a-9f75-49e7-b0d9-128e0e4b7d4a"), new Guid("8c22ffaa-6cb7-43c9-8f7f-4a204663df42"), new Guid("82e5f6d3-1d4a-4bc2-96d0-2d8f7852bc7e") },
                    { new Guid("e7ce46f6-9b70-4a8e-9a0d-556536cd7832"), new Guid("c9c8d64c-fa56-4e2e-b8ef-6e41d00735e1"), new Guid("b36a20bc-04a1-4c9c-8a07-5270d1526c7e") },
                    { new Guid("ede1078f-0b6a-48d6-9822-b6d08a881cbb"), new Guid("90ac1df8-837d-42af-a40a-a0cbd28770fd"), new Guid("6a4b25d6-ae03-4aee-a442-af50945f1aee") },
                    { new Guid("f1c5c0a0-d2ab-4f1f-81bc-c9f19a459105"), new Guid("a7ab352a-421d-4f78-9a5c-72d2cfa9c430"), new Guid("55e55f39-af4d-4d45-8e9a-8e5b9daaf2e4") },
                    { new Guid("fd03453b-e8ec-4ba0-a4ea-33cea45c6a05"), new Guid("90ac1df8-837d-42af-a40a-a0cbd28770fd"), new Guid("b68c8431-5b79-4492-9f60-9f977fd471d7") }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "IsActive", "Name" },
                values: new object[,]
                {
                    { new Guid("68f6170a-12b9-4f32-9e83-c81c61ad29b6"), false, "диско" },
                    { new Guid("7fa5ae48-7ed7-42a7-bb2a-4f4d0e502d7a"), false, "Джаз" },
                    { new Guid("8c9c6d68-01f0-4e97-9640-d7a633788f53"), false, "романс" },
                    { new Guid("a579446d-0ca1-4aae-8cad-5126ab41c203"), false, "Кантри" },
                    { new Guid("b56de1bf-2c8e-4d1f-a727-9a5ebc3d6b2f"), false, "Металл" },
                    { new Guid("f1344d39-707e-4a7f-82e7-0816c21206d8"), false, "Блюз" },
                    { new Guid("f13c6c62-c6e2-4a37-9c17-99c0e9d8db42"), false, "Фолк" }
                });

            migrationBuilder.InsertData(
                table: "TrackGenres",
                columns: new[] { "Id", "GenreId", "TrackId" },
                values: new object[,]
                {
                    { new Guid("07be8c4b-ff7e-40ef-a3cd-82596cbac21f"), new Guid("2f044c88-a983-4cf5-bcc1-a5d7764507ed"), new Guid("6a4b25d6-ae03-4aee-a442-af50945f1aee") },
                    { new Guid("0ab8a68e-733e-4ad0-b46e-c7c8998e5052"), new Guid("8745e56f-b335-43fe-bd10-bad6bead0892"), new Guid("8e22b0a3-063e-40ae-976e-5b06f762c8ce") },
                    { new Guid("0b1532db-4092-4d96-92b3-47878d429d5d"), new Guid("d35e2479-8214-41f2-b6d6-59b892602f16"), new Guid("71d0a71f-9e5e-4fbf-8be5-0b39a10781f2") },
                    { new Guid("0d43b354-2efb-4e3b-b7dd-2a9a55d9b0ad"), new Guid("8745e56f-b335-43fe-bd10-bad6bead0892"), new Guid("f89c0c4d-59e4-4b9a-b95f-8c6d2fb4208b") },
                    { new Guid("0ef9c84d-b7b2-4c84-a0f9-72b9e6f4ff1e"), new Guid("da7a689b-5b29-4c88-91ad-b543ce614e12"), new Guid("066d0b1d-b7c6-40b6-a48c-1f7b83084760") },
                    { new Guid("11a5a5db-582d-4457-8e35-0bb97b416003"), new Guid("e2a8929f-2190-4329-bae1-83b170a3677f"), new Guid("b68c8431-5b79-4492-9f60-9f977fd471d7") },
                    { new Guid("12a8a33d-9832-401d-9c2b-8eaa0ed5a6c9"), new Guid("8ff3eaba-b2c6-4a1b-96c9-0f611d17e8c6"), new Guid("2a4b28e2-7a44-4716-8247-3b03d75e27d9") },
                    { new Guid("1463af8f-8936-4a64-8e18-97c2c61e2f50"), new Guid("2f044c88-a983-4cf5-bcc1-a5d7764507ed"), new Guid("7541417e-d9db-45c5-95f3-146b6f43f523") },
                    { new Guid("190f3ce0-ab80-476e-bf17-526679aa70c6"), new Guid("e2a8929f-2190-4329-bae1-83b170a3677f"), new Guid("b36a20bc-04a1-4c9c-8a07-5270d1526c7e") },
                    { new Guid("1a0be2f7-ebd0-4820-b5df-b903df5a3a4c"), new Guid("8745e56f-b335-43fe-bd10-bad6bead0892"), new Guid("5d146662-869d-477f-8f99-620ad1f3c1d1") },
                    { new Guid("1a665c94-60af-408f-9d10-d8b30f98e2c9"), new Guid("ac38a647-9bc3-4a14-ae64-8c50964e307d"), new Guid("066d0b1d-b7c6-40b6-a48c-1f7b83084760") },
                    { new Guid("1a831b10-9c17-4769-847e-04ad0f53a66f"), new Guid("baa56e06-9672-4118-aee3-4098cec4581e"), new Guid("e1e8b1f7-0a07-428e-bc1d-c08dbd5c6744") },
                    { new Guid("1a92d445-0da0-4dd4-ba7e-0ddc7b55b938"), new Guid("d35e2479-8214-41f2-b6d6-59b892602f16"), new Guid("77b75ed9-e6d2-4d47-84c9-58af10e455c1") },
                    { new Guid("1b08413b-41ea-4522-8e3a-ffb899641269"), new Guid("d35e2479-8214-41f2-b6d6-59b892602f16"), new Guid("c0e4e1d2-0c43-41f1-952f-788496ab6f8f") },
                    { new Guid("1e3d8f5f-70a7-4a2a-b37a-5e5ac95ddcf1"), new Guid("2f044c88-a983-4cf5-bcc1-a5d7764507ed"), new Guid("f0a91ef7-1eaa-40d0-8273-0401bea48b5c") },
                    { new Guid("1e63b551-5b84-4d3a-99d2-d1e2d564b0e4"), new Guid("ae14797c-31cd-432a-b2de-b3db95a82ab4"), new Guid("0a0e4f09-16b3-44d2-a545-c3f23a6bda9e") },
                    { new Guid("1f5508f1-7f66-47a0-ba3e-9823d1cfc7d4"), new Guid("baa56e06-9672-4118-aee3-4098cec4581e"), new Guid("b68c8431-5b79-4492-9f60-9f977fd471d7") },
                    { new Guid("23b3d97c-d843-4fe2-bf38-43e7b13510a6"), new Guid("8745e56f-b335-43fe-bd10-bad6bead0892"), new Guid("f0d98d33-4c4f-4d87-9a5f-33fe7c1ab7a2") },
                    { new Guid("23f3f0e2-5e7c-4a15-9749-9f8dc1e60363"), new Guid("e2a8929f-2190-4329-bae1-83b170a3677f"), new Guid("a0fc64ff-fa2b-4d7d-9650-3a083ebdca24") },
                    { new Guid("262342b2-861e-4802-a54c-c84522188cd7"), new Guid("baa56e06-9672-4118-aee3-4098cec4581e"), new Guid("8366834f-0278-46e2-8142-011813bda329") },
                    { new Guid("26a137b5-5e3e-4f85-aa19-8c1585e0c659"), new Guid("da7a689b-5b29-4c88-91ad-b543ce614e12"), new Guid("8fb522a4-80c7-4551-95e9-29b4282dc81a") },
                    { new Guid("279f3c02-c8fc-4d1c-aac1-6a198ac6db8f"), new Guid("d35e2479-8214-41f2-b6d6-59b892602f16"), new Guid("3f3ef649-9e39-4bda-85e5-3d763f01c31e") },
                    { new Guid("27d239b9-741f-4fd7-8a61-9571d6d695d3"), new Guid("d35e2479-8214-41f2-b6d6-59b892602f16"), new Guid("1e41186e-c7b1-40ed-85c9-4e4c5b5c33b7") },
                    { new Guid("2aa4d9a6-6c3a-4ae7-8e66-efea9f38fefb"), new Guid("8745e56f-b335-43fe-bd10-bad6bead0892"), new Guid("a3fe58cc-ba59-4e09-96a1-4f9e8f77f99b") },
                    { new Guid("2d9e29e5-ee9f-4c95-a1c5-8a2b61536c8c"), new Guid("d35e2479-8214-41f2-b6d6-59b892602f16"), new Guid("b8fd88fb-647e-4130-83ed-801a9abf5e75") },
                    { new Guid("2de48bb1-4b6b-434f-8e68-29f25c943b6e"), new Guid("ac38a647-9bc3-4a14-ae64-8c50964e307d"), new Guid("71d0a71f-9e5e-4fbf-8be5-0b39a10781f2") },
                    { new Guid("366f5fc0-1a5c-4f53-a875-11694b4bee14"), new Guid("8ff3eaba-b2c6-4a1b-96c9-0f611d17e8c6"), new Guid("3e4d4f4d-46f5-4716-9b8b-c355e66b8832") },
                    { new Guid("3d855b0d-3fc0-40d3-9a44-7dd2f2c82c7b"), new Guid("baa56e06-9672-4118-aee3-4098cec4581e"), new Guid("2fb86013-0a56-4f2a-bd99-3fd4f4c1f1f3") },
                    { new Guid("3e0e0e0f-4b1d-46c7-bdc0-97d0b5d7a6b6"), new Guid("8745e56f-b335-43fe-bd10-bad6bead0892"), new Guid("997f8ae9-cc5d-4b19-9dd7-0f1d287106e9") },
                    { new Guid("3e499541-7a02-49f1-8706-d5c638674b6f"), new Guid("da7a689b-5b29-4c88-91ad-b543ce614e12"), new Guid("ddaa72b5-3a20-46d7-8c48-c6c7c9ea2564") },
                    { new Guid("3e9e7a7e-1e8e-4a2f-9479-07e7fe3e79f4"), new Guid("d35e2479-8214-41f2-b6d6-59b892602f16"), new Guid("9b17852c-5733-494d-8c37-ecf91fbc668f") },
                    { new Guid("3f5c7d38-ae2d-4141-a4dd-fc4e41712446"), new Guid("2f044c88-a983-4cf5-bcc1-a5d7764507ed"), new Guid("0a41a3fe-6f5d-4d23-9a34-34a11b5b438b") },
                    { new Guid("46e8fe85-9e9d-4ab1-b711-2a100f9402c6"), new Guid("ae14797c-31cd-432a-b2de-b3db95a82ab4"), new Guid("8366834f-0278-46e2-8142-011813bda329") },
                    { new Guid("477b3eab-3e43-4d27-98c8-f58bfc0f7330"), new Guid("da7a689b-5b29-4c88-91ad-b543ce614e12"), new Guid("3e4d4f4d-46f5-4716-9b8b-c355e66b8832") },
                    { new Guid("4d6788dc-0be3-4ea5-8c6e-7b2dc2407314"), new Guid("ac38a647-9bc3-4a14-ae64-8c50964e307d"), new Guid("f52e7de3-46d6-40cc-9e67-3d28b1dd84d9") },
                    { new Guid("4e94e3cc-1330-4fe7-a5af-9f5ac0e4e5ea"), new Guid("e2a8929f-2190-4329-bae1-83b170a3677f"), new Guid("f840d9d0-7ecf-4b7c-b4e6-50118a1f6712") },
                    { new Guid("503cfce5-3704-4547-8a42-fec1c5e4a166"), new Guid("baa56e06-9672-4118-aee3-4098cec4581e"), new Guid("4fca4e84-f34c-4b73-8a66-3d1566763a8a") },
                    { new Guid("50f1e867-6d56-4916-9066-799f0edecb40"), new Guid("da7a689b-5b29-4c88-91ad-b543ce614e12"), new Guid("6d342342-ea26-40f4-aa92-420f3a943603") },
                    { new Guid("51b7b294-962d-4cd2-baf2-1582215b5082"), new Guid("da7a689b-5b29-4c88-91ad-b543ce614e12"), new Guid("52a3a0db-7172-41a6-8a60-6e2533f3e5b0") },
                    { new Guid("525613e6-503e-4cc1-bb25-5ff83133f9e3"), new Guid("8745e56f-b335-43fe-bd10-bad6bead0892"), new Guid("4fca4e84-f34c-4b73-8a66-3d1566763a8a") },
                    { new Guid("525d8507-7f9a-4082-86be-3b1899c6df7e"), new Guid("8745e56f-b335-43fe-bd10-bad6bead0892"), new Guid("8b9df2a6-df2f-4c52-83d3-03aeb745e3e3") },
                    { new Guid("54bfbf43-9a9c-4b4c-a54b-899437b107e9"), new Guid("8745e56f-b335-43fe-bd10-bad6bead0892"), new Guid("2e8f13db-8b78-4ff1-ba08-2e47abf35127") },
                    { new Guid("56b6b7b5-2c5f-4d69-b8a6-313c1e0ee6b0"), new Guid("baa56e06-9672-4118-aee3-4098cec4581e"), new Guid("d1c9e7c7-ee5e-4ae7-8d5e-bdb94e10bcb9") },
                    { new Guid("56f2c79b-9311-491c-9a0c-4c1b9c89c1e6"), new Guid("d35e2479-8214-41f2-b6d6-59b892602f16"), new Guid("ddaa72b5-3a20-46d7-8c48-c6c7c9ea2564") },
                    { new Guid("5ce186f4-df24-442f-9e56-27de705d7ee5"), new Guid("baa56e06-9672-4118-aee3-4098cec4581e"), new Guid("2e8f13db-8b78-4ff1-ba08-2e47abf35127") },
                    { new Guid("5e242dd1-dc8c-4b2c-abe4-5d201e5ad3f0"), new Guid("ac38a647-9bc3-4a14-ae64-8c50964e307d"), new Guid("997f8ae9-cc5d-4b19-9dd7-0f1d287106e9") },
                    { new Guid("5f2a76f3-b829-4441-93ae-17773ad2940f"), new Guid("da7a689b-5b29-4c88-91ad-b543ce614e12"), new Guid("55e55f39-af4d-4d45-8e9a-8e5b9daaf2e4") },
                    { new Guid("5f78d2d6-d193-4ad4-b36f-8361502fc9b3"), new Guid("8745e56f-b335-43fe-bd10-bad6bead0892"), new Guid("d1c9e7c7-ee5e-4ae7-8d5e-bdb94e10bcb9") },
                    { new Guid("64d3e476-f162-450d-9252-3f18be37c159"), new Guid("da7a689b-5b29-4c88-91ad-b543ce614e12"), new Guid("3f3ef649-9e39-4bda-85e5-3d763f01c31e") },
                    { new Guid("65e4a855-6a3a-4bc3-b091-69ab11f4e30a"), new Guid("2f044c88-a983-4cf5-bcc1-a5d7764507ed"), new Guid("2fb86013-0a56-4f2a-bd99-3fd4f4c1f1f3") },
                    { new Guid("6825e6e2-8b88-4e4e-b5e7-3b27e54e700d"), new Guid("2f044c88-a983-4cf5-bcc1-a5d7764507ed"), new Guid("f0c1326b-0646-46f4-966f-c10caa9c931b") },
                    { new Guid("6a6cfb98-f984-40bb-a1c9-ca209825ca57"), new Guid("ae14797c-31cd-432a-b2de-b3db95a82ab4"), new Guid("a3fe58cc-ba59-4e09-96a1-4f9e8f77f99b") },
                    { new Guid("6b37c63a-915d-4861-8a25-f94044df59b4"), new Guid("8745e56f-b335-43fe-bd10-bad6bead0892"), new Guid("6b24c35d-8589-4d35-83be-dfc48f0c8a79") },
                    { new Guid("6c9324e0-00d0-40a5-b2a7-847a7a8df5db"), new Guid("ae14797c-31cd-432a-b2de-b3db95a82ab4"), new Guid("9b17852c-5733-494d-8c37-ecf91fbc668f") },
                    { new Guid("6dd3d83e-0f2e-48d2-9346-2360c6885e13"), new Guid("e2a8929f-2190-4329-bae1-83b170a3677f"), new Guid("262342b2-861e-4802-a54c-c84522188cd7") },
                    { new Guid("71e71c89-9f9b-4144-8e13-dfcab515d15e"), new Guid("da7a689b-5b29-4c88-91ad-b543ce614e12"), new Guid("1e41186e-c7b1-40ed-85c9-4e4c5b5c33b7") },
                    { new Guid("7521a166-8be2-4f01-8bdc-b422ed175c3a"), new Guid("da7a689b-5b29-4c88-91ad-b543ce614e12"), new Guid("190e4a84-462b-4a3e-90e4-9e25a826c4d3") },
                    { new Guid("76a8ae2f-01e5-4d1a-8c08-5e85ac2895d1"), new Guid("e2a8929f-2190-4329-bae1-83b170a3677f"), new Guid("baace2ca-c2c0-4cee-b129-53079d696059") },
                    { new Guid("76ef7d5b-6b8d-4d1e-9b0e-fecb1d5f5e1b"), new Guid("2f044c88-a983-4cf5-bcc1-a5d7764507ed"), new Guid("e9481c7b-c007-46de-b706-4775c1d9c6de") },
                    { new Guid("7756d8b0-33cd-4ab5-9b59-d3f4e3a6b794"), new Guid("ac38a647-9bc3-4a14-ae64-8c50964e307d"), new Guid("61458d69-7f4a-406d-80e3-7ff0d65e7f5f") },
                    { new Guid("7a41b8b6-65c2-4f9d-ae3b-8699723e94e1"), new Guid("da7a689b-5b29-4c88-91ad-b543ce614e12"), new Guid("ad85a600-f97a-42f0-a951-40b9a4b3c993") },
                    { new Guid("7e07a96e-21d1-4d74-8a84-381e26a94283"), new Guid("8745e56f-b335-43fe-bd10-bad6bead0892"), new Guid("f840d9d0-7ecf-4b7c-b4e6-50118a1f6712") },
                    { new Guid("7f13e3b3-4db5-4b61-b0f9-59472b22300e"), new Guid("da7a689b-5b29-4c88-91ad-b543ce614e12"), new Guid("6a4b25d6-ae03-4aee-a442-af50945f1aee") },
                    { new Guid("843be9c5-0d1d-4c1e-b5df-6fc7b98a56be"), new Guid("e2a8929f-2190-4329-bae1-83b170a3677f"), new Guid("61458d69-7f4a-406d-80e3-7ff0d65e7f5f") },
                    { new Guid("88e692ac-2cc7-4f94-95e0-1e3e2e6d558f"), new Guid("e2a8929f-2190-4329-bae1-83b170a3677f"), new Guid("3a1a5599-ee9e-4786-88ea-57a0edf6e977") },
                    { new Guid("892b7a26-d0e3-4c83-8489-5a0860e67789"), new Guid("d35e2479-8214-41f2-b6d6-59b892602f16"), new Guid("82e5f6d3-1d4a-4bc2-96d0-2d8f7852bc7e") },
                    { new Guid("8a9784ad-72f9-4ee2-bc14-57298b3521a1"), new Guid("baa56e06-9672-4118-aee3-4098cec4581e"), new Guid("533b7e3d-9cfd-4731-8dda-a1d5a86ff80a") },
                    { new Guid("8d5d3fc6-d1dd-4f1e-8222-bd3e7f8752af"), new Guid("da7a689b-5b29-4c88-91ad-b543ce614e12"), new Guid("8b9df2a6-df2f-4c52-83d3-03aeb745e3e3") },
                    { new Guid("8e0a4da1-60b4-46f1-98a2-176a10ae8617"), new Guid("da7a689b-5b29-4c88-91ad-b543ce614e12"), new Guid("f0a91ef7-1eaa-40d0-8273-0401bea48b5c") },
                    { new Guid("9022b9a2-4df5-4b0b-bb43-44edc70d9a75"), new Guid("8ff3eaba-b2c6-4a1b-96c9-0f611d17e8c6"), new Guid("1afe4a9e-7121-4b34-89a6-8db6e0b6ddad") },
                    { new Guid("93a399e9-77d9-4cc0-b167-82eab63a307d"), new Guid("da7a689b-5b29-4c88-91ad-b543ce614e12"), new Guid("96b13d9a-3a2d-4a61-9616-6f2f2a2e0de4") },
                    { new Guid("93c8a9ef-1d09-47b2-8ad7-1487d8621e48"), new Guid("2f044c88-a983-4cf5-bcc1-a5d7764507ed"), new Guid("b68c8431-5b79-4492-9f60-9f977fd471d7") },
                    { new Guid("943041ab-1909-4978-8b5e-19d47fd262fc"), new Guid("8745e56f-b335-43fe-bd10-bad6bead0892"), new Guid("9a38a1d3-91c6-4f0e-b5b9-7d9b542cdd15") },
                    { new Guid("9485a2e3-ebb6-4ff1-a777-f951d7ae1b5f"), new Guid("8ff3eaba-b2c6-4a1b-96c9-0f611d17e8c6"), new Guid("3bc4e4a4-1b6f-4a53-89fc-6e62fdd442a9") },
                    { new Guid("976eb29b-9789-4c88-9531-1f5ea04f014d"), new Guid("ac38a647-9bc3-4a14-ae64-8c50964e307d"), new Guid("d65a624a-c81b-4ed1-af0a-8b27ac872e6e") },
                    { new Guid("9a549628-299e-4e3d-b0dd-83fc729e2a7f"), new Guid("2f044c88-a983-4cf5-bcc1-a5d7764507ed"), new Guid("f89c0c4d-59e4-4b9a-b95f-8c6d2fb4208b") },
                    { new Guid("9a78c563-0d0a-4b73-953a-70db9c8a763f"), new Guid("ae14797c-31cd-432a-b2de-b3db95a82ab4"), new Guid("ad85a600-f97a-42f0-a951-40b9a4b3c993") },
                    { new Guid("9a95c1fd-37be-4f3e-87b9-dba77be27335"), new Guid("8ff3eaba-b2c6-4a1b-96c9-0f611d17e8c6"), new Guid("bea11ee9-0d72-4d56-b27c-33095a0787a7") },
                    { new Guid("9c0fe2da-5de9-4e69-a201-45dcb2f21670"), new Guid("8745e56f-b335-43fe-bd10-bad6bead0892"), new Guid("c0e4e1d2-0c43-41f1-952f-788496ab6f8f") },
                    { new Guid("9e6483aa-6ae2-4bcf-b6a5-83a205de4a39"), new Guid("e2a8929f-2190-4329-bae1-83b170a3677f"), new Guid("3cb2c0a8-1e79-4d6a-9b61-0af74c533787") },
                    { new Guid("9e839674-91e6-4d4c-b1f7-27f85b0485e6"), new Guid("ac38a647-9bc3-4a14-ae64-8c50964e307d"), new Guid("c0e4e1d2-0c43-41f1-952f-788496ab6f8f") },
                    { new Guid("9f023dd2-3777-46c3-9f1a-5eaa3db71b2a"), new Guid("8745e56f-b335-43fe-bd10-bad6bead0892"), new Guid("d48b865a-10ef-4f6e-aae9-58ef614fc16f") },
                    { new Guid("a08dbb5b-4f35-4a6a-8ea7-1c2a9dc5e0c2"), new Guid("8745e56f-b335-43fe-bd10-bad6bead0892"), new Guid("08d03e3d-0919-4c01-a6db-78c2abfc4d5e") },
                    { new Guid("a0e5b65d-d8af-4e8e-995a-885cf3e8b54f"), new Guid("baa56e06-9672-4118-aee3-4098cec4581e"), new Guid("b8fd88fb-647e-4130-83ed-801a9abf5e75") },
                    { new Guid("a21f9e84-319c-4dcf-aa48-348ebae85d44"), new Guid("ae14797c-31cd-432a-b2de-b3db95a82ab4"), new Guid("674a432f-3fd4-4b33-af25-82607c96a3f0") },
                    { new Guid("a2c165bc-f6af-43d8-9f3b-9e822c287a8a"), new Guid("ac38a647-9bc3-4a14-ae64-8c50964e307d"), new Guid("533b7e3d-9cfd-4731-8dda-a1d5a86ff80a") },
                    { new Guid("a2fb5dca-6491-4e2f-8722-0a15bd849ab2"), new Guid("ae14797c-31cd-432a-b2de-b3db95a82ab4"), new Guid("c878736d-da07-4401-ab27-2743d4e035c5") },
                    { new Guid("a3bdaae9-7be6-4de5-9372-eda1b6a15b54"), new Guid("8ff3eaba-b2c6-4a1b-96c9-0f611d17e8c6"), new Guid("96b13d9a-3a2d-4a61-9616-6f2f2a2e0de4") },
                    { new Guid("a3dcd8fb-7373-4319-9864-53b8c936b168"), new Guid("ae14797c-31cd-432a-b2de-b3db95a82ab4"), new Guid("e1e8b1f7-0a07-428e-bc1d-c08dbd5c6744") },
                    { new Guid("a67673ae-6132-4d6f-89db-02442e46b1f6"), new Guid("baa56e06-9672-4118-aee3-4098cec4581e"), new Guid("8b9df2a6-df2f-4c52-83d3-03aeb745e3e3") },
                    { new Guid("a68d4322-cd9f-4373-8655-86274fd9825a"), new Guid("baa56e06-9672-4118-aee3-4098cec4581e"), new Guid("baace2ca-c2c0-4cee-b129-53079d696059") },
                    { new Guid("a7063d90-ec62-496d-9c8e-5eb24fb53b4c"), new Guid("8745e56f-b335-43fe-bd10-bad6bead0892"), new Guid("b8fd88fb-647e-4130-83ed-801a9abf5e75") },
                    { new Guid("a9479a49-80b9-4509-87a4-ae2f0fb636a1"), new Guid("8ff3eaba-b2c6-4a1b-96c9-0f611d17e8c6"), new Guid("2e8f13db-8b78-4ff1-ba08-2e47abf35127") },
                    { new Guid("aad041e9-d931-4f65-bb69-0a4003f518ef"), new Guid("ac38a647-9bc3-4a14-ae64-8c50964e307d"), new Guid("a633f860-97ce-4d9a-9960-2091db4aee78") },
                    { new Guid("ac927c84-62f7-4c8e-b2d7-61f1533efc3d"), new Guid("8745e56f-b335-43fe-bd10-bad6bead0892"), new Guid("3fde47fd-c654-4124-bc46-88d3b9bfa4df") },
                    { new Guid("afb1c5b7-8cd8-4407-a0fe-85c377b71b5a"), new Guid("baa56e06-9672-4118-aee3-4098cec4581e"), new Guid("c878736d-da07-4401-ab27-2743d4e035c5") },
                    { new Guid("b1837bcf-0c4e-4779-b78f-849a44129b91"), new Guid("ac38a647-9bc3-4a14-ae64-8c50964e307d"), new Guid("96b13d9a-3a2d-4a61-9616-6f2f2a2e0de4") },
                    { new Guid("b20e0670-556f-4519-8222-4e18dc44d980"), new Guid("e2a8929f-2190-4329-bae1-83b170a3677f"), new Guid("0e53296d-4f08-4a15-ae64-23a8f4e8d804") },
                    { new Guid("b2366c2b-c75f-415d-80f7-38f165d2858a"), new Guid("ac38a647-9bc3-4a14-ae64-8c50964e307d"), new Guid("52a3a0db-7172-41a6-8a60-6e2533f3e5b0") },
                    { new Guid("b3f51a7e-d1b1-4cc2-a11e-4feaa076f68d"), new Guid("8745e56f-b335-43fe-bd10-bad6bead0892"), new Guid("b75197d8-5d56-4b1d-8a5c-1a2c8c7b73d0") },
                    { new Guid("b4e5a75e-4a1a-48f2-9a52-91d74d8a92fe"), new Guid("8745e56f-b335-43fe-bd10-bad6bead0892"), new Guid("492f70ab-f1de-4de4-93b3-8602df66b05a") },
                    { new Guid("b5c7bba7-348a-486d-9b11-318f5bea3e54"), new Guid("baa56e06-9672-4118-aee3-4098cec4581e"), new Guid("e43d89cd-398d-4dbb-99e6-789869f891f3") },
                    { new Guid("b646a808-5560-4ebe-b4cc-40e65d6b7e1f"), new Guid("baa56e06-9672-4118-aee3-4098cec4581e"), new Guid("41b26f20-69e4-43d2-8db4-76ed6a5028b3") },
                    { new Guid("b6f3a791-4971-4b80-9ef9-48d56d61d4e1"), new Guid("baa56e06-9672-4118-aee3-4098cec4581e"), new Guid("bf9e77fd-3d3a-4a77-aae9-123d03b9a2e4") },
                    { new Guid("b798f794-d36c-4c2c-990b-db6034a9c9f7"), new Guid("ae14797c-31cd-432a-b2de-b3db95a82ab4"), new Guid("d48b865a-10ef-4f6e-aae9-58ef614fc16f") },
                    { new Guid("b8e67f7e-68b9-4e72-9797-01ef2c45ff4e"), new Guid("ac38a647-9bc3-4a14-ae64-8c50964e307d"), new Guid("84d5050b-a7b7-4c23-a2d1-93281183264a") },
                    { new Guid("b9f1f3e7-0cb0-4da3-936c-7b5bc5df3203"), new Guid("2f044c88-a983-4cf5-bcc1-a5d7764507ed"), new Guid("3cb2c0a8-1e79-4d6a-9b61-0af74c533787") },
                    { new Guid("be08bc16-6d2c-4f37-a9d0-116d25b7c7eb"), new Guid("baa56e06-9672-4118-aee3-4098cec4581e"), new Guid("7541417e-d9db-45c5-95f3-146b6f43f523") },
                    { new Guid("c0b142fe-12cc-4a6b-a6e1-56a1b1f60f9e"), new Guid("8745e56f-b335-43fe-bd10-bad6bead0892"), new Guid("6c9645b5-3f50-4a11-8be0-314a97c27eb8") },
                    { new Guid("c29733b1-f4be-4d0f-a297-6c07003abceb"), new Guid("e2a8929f-2190-4329-bae1-83b170a3677f"), new Guid("41b26f20-69e4-43d2-8db4-76ed6a5028b3") },
                    { new Guid("c2d56b4f-1968-42e0-b95c-ceb4cd976ffd"), new Guid("d35e2479-8214-41f2-b6d6-59b892602f16"), new Guid("8366834f-0278-46e2-8142-011813bda329") },
                    { new Guid("c6241a68-3dce-4372-9826-4e92eae77470"), new Guid("8745e56f-b335-43fe-bd10-bad6bead0892"), new Guid("a633f860-97ce-4d9a-9960-2091db4aee78") },
                    { new Guid("c7d963a3-29e9-4df7-99a5-5db95907125e"), new Guid("8ff3eaba-b2c6-4a1b-96c9-0f611d17e8c6"), new Guid("55e55f39-af4d-4d45-8e9a-8e5b9daaf2e4") },
                    { new Guid("c87ef999-0b3c-4e8e-a404-4875478fc4f9"), new Guid("baa56e06-9672-4118-aee3-4098cec4581e"), new Guid("0a41a3fe-6f5d-4d23-9a34-34a11b5b438b") },
                    { new Guid("c937ae9d-10fe-4f5e-b3e0-67d7e6b6a031"), new Guid("baa56e06-9672-4118-aee3-4098cec4581e"), new Guid("262342b2-861e-4802-a54c-c84522188cd7") },
                    { new Guid("c9c8d64c-fa56-4e2e-b8ef-6e41d00735e1"), new Guid("baa56e06-9672-4118-aee3-4098cec4581e"), new Guid("ed7f120f-0c7d-4bcf-a733-2b4de2a50b1b") },
                    { new Guid("cb5543f6-9636-4f56-99ff-d5a95768a48f"), new Guid("da7a689b-5b29-4c88-91ad-b543ce614e12"), new Guid("d8b23e3c-f1d1-47be-82b6-77a4c5e67f35") },
                    { new Guid("cd595a5f-9c5f-40b4-9c37-dcd25f4cc4f3"), new Guid("ac38a647-9bc3-4a14-ae64-8c50964e307d"), new Guid("3a1a5599-ee9e-4786-88ea-57a0edf6e977") },
                    { new Guid("d01a05ce-0e17-4a3a-aa77-f2d2dc3c9b0b"), new Guid("e2a8929f-2190-4329-bae1-83b170a3677f"), new Guid("2fb86013-0a56-4f2a-bd99-3fd4f4c1f1f3") },
                    { new Guid("d2a1ef9f-1b18-4d3f-b1a1-4c536289e048"), new Guid("8ff3eaba-b2c6-4a1b-96c9-0f611d17e8c6"), new Guid("64955a7c-30be-4c85-8d85-d36d487ed3d5") },
                    { new Guid("d3813771-6833-4643-a01b-74a9c27b2387"), new Guid("8ff3eaba-b2c6-4a1b-96c9-0f611d17e8c6"), new Guid("e43d89cd-398d-4dbb-99e6-789869f891f3") },
                    { new Guid("d43de40f-29de-461e-a741-85bfb18dc5b4"), new Guid("ae14797c-31cd-432a-b2de-b3db95a82ab4"), new Guid("a0c7644a-73b7-4b3a-b457-7e51e1f63a17") },
                    { new Guid("d4a52ea5-244b-4d60-9a4c-aa47e204b894"), new Guid("da7a689b-5b29-4c88-91ad-b543ce614e12"), new Guid("5e8eae8c-7d72-4dc0-9832-6ae82f5a42ed") },
                    { new Guid("d4b503c9-c7b7-4b0a-bcd9-7f365fcff476"), new Guid("baa56e06-9672-4118-aee3-4098cec4581e"), new Guid("1afe4a9e-7121-4b34-89a6-8db6e0b6ddad") },
                    { new Guid("d603b206-97f7-4b3a-9da4-69b6728b3a54"), new Guid("8ff3eaba-b2c6-4a1b-96c9-0f611d17e8c6"), new Guid("d982cc75-bcfc-4c66-8dd6-23b1e87866e5") },
                    { new Guid("d74afaf7-2e71-47d2-84f3-5e43c29b40e9"), new Guid("d35e2479-8214-41f2-b6d6-59b892602f16"), new Guid("bea11ee9-0d72-4d56-b27c-33095a0787a7") },
                    { new Guid("d95d97da-af4d-461e-8792-1a725c7ddaf2"), new Guid("e2a8929f-2190-4329-bae1-83b170a3677f"), new Guid("0a41a3fe-6f5d-4d23-9a34-34a11b5b438b") },
                    { new Guid("d9aa9e12-5af9-42c2-82cb-289ee99729b0"), new Guid("ac38a647-9bc3-4a14-ae64-8c50964e307d"), new Guid("3d8e0d8f-8b9a-4f54-9e13-3a9d7db4ce41") },
                    { new Guid("dc4a81a2-d933-4a9f-b34a-0877e4b9f109"), new Guid("2f044c88-a983-4cf5-bcc1-a5d7764507ed"), new Guid("c138c0a3-0dbd-4b9c-9533-d860bb4d1364") },
                    { new Guid("dc7b8c33-7ed3-4b0f-a832-05a5da656c8a"), new Guid("ae14797c-31cd-432a-b2de-b3db95a82ab4"), new Guid("55e55f39-af4d-4d45-8e9a-8e5b9daaf2e4") },
                    { new Guid("dcdb4c19-7bb1-4b24-9d29-b24eb5f2e8fc"), new Guid("da7a689b-5b29-4c88-91ad-b543ce614e12"), new Guid("bf9e77fd-3d3a-4a77-aae9-123d03b9a2e4") },
                    { new Guid("e1dcbca3-3e24-4a6c-824f-2eef4f6d03af"), new Guid("ac38a647-9bc3-4a14-ae64-8c50964e307d"), new Guid("3f3ef649-9e39-4bda-85e5-3d763f01c31e") },
                    { new Guid("e1e2c8f2-1c3c-4fcd-960a-0fc60d25f88e"), new Guid("8745e56f-b335-43fe-bd10-bad6bead0892"), new Guid("e9481c7b-c007-46de-b706-4775c1d9c6de") },
                    { new Guid("e2f8e2ac-05e9-4617-998d-3c548beec94b"), new Guid("8ff3eaba-b2c6-4a1b-96c9-0f611d17e8c6"), new Guid("0a0e4f09-16b3-44d2-a545-c3f23a6bda9e") },
                    { new Guid("e59107d1-96f1-4f79-a131-b59b13df1a33"), new Guid("e2a8929f-2190-4329-bae1-83b170a3677f"), new Guid("15dc8b5e-f87e-4ee6-8f0b-6c1f1e2f5eb1") },
                    { new Guid("e61e2b2b-2fa3-480a-80db-6bdcf107888f"), new Guid("ae14797c-31cd-432a-b2de-b3db95a82ab4"), new Guid("6c9645b5-3f50-4a11-8be0-314a97c27eb8") },
                    { new Guid("e6d4eefd-3f7b-4eaa-80ff-2ed468c6d91b"), new Guid("8745e56f-b335-43fe-bd10-bad6bead0892"), new Guid("4fca4e84-f34c-4b73-8a66-3d1566763a8a") },
                    { new Guid("e79eabdd-55ad-4c06-b2d0-bf4fd2e40db4"), new Guid("da7a689b-5b29-4c88-91ad-b543ce614e12"), new Guid("c138c0a3-0dbd-4b9c-9533-d860bb4d1364") },
                    { new Guid("e87c855e-6752-49d9-8a37-532e158d8774"), new Guid("2f044c88-a983-4cf5-bcc1-a5d7764507ed"), new Guid("61458d69-7f4a-406d-80e3-7ff0d65e7f5f") },
                    { new Guid("e99fe445-cf6e-4e3d-bc2f-cb30d1a3b59e"), new Guid("e2a8929f-2190-4329-bae1-83b170a3677f"), new Guid("3bc4e4a4-1b6f-4a53-89fc-6e62fdd442a9") },
                    { new Guid("eb5d6ac0-c9c5-4f32-9c67-0f64a7f99742"), new Guid("ae14797c-31cd-432a-b2de-b3db95a82ab4"), new Guid("450cb1e3-ebc1-4dcb-a5a6-3e5e5db174d8") },
                    { new Guid("ed396891-217d-4b44-8be3-02fe6dc59f53"), new Guid("e2a8929f-2190-4329-bae1-83b170a3677f"), new Guid("4d60248e-d3f1-43e0-978f-356947c53e15") },
                    { new Guid("eddb2b09-2e26-4fb3-84c6-0d4b3d59d9a5"), new Guid("baa56e06-9672-4118-aee3-4098cec4581e"), new Guid("2d75a3c6-1e6b-4740-afaa-60e33bcb77e3") },
                    { new Guid("ee7be5b8-f403-4126-ad89-8d7b1abb5ede"), new Guid("2f044c88-a983-4cf5-bcc1-a5d7764507ed"), new Guid("1e4b79fc-4f83-44d2-95c4-35b69f62c3ab") },
                    { new Guid("efd1e843-82da-4fc6-8681-06ad2140beae"), new Guid("ae14797c-31cd-432a-b2de-b3db95a82ab4"), new Guid("bea11ee9-0d72-4d56-b27c-33095a0787a7") },
                    { new Guid("f024e3f8-cf68-4c48-b288-b04e9c8b30c2"), new Guid("ae14797c-31cd-432a-b2de-b3db95a82ab4"), new Guid("88f77e10-02c2-4182-a5e6-8946a84688a9") },
                    { new Guid("f10c0af3-4441-4a13-aa3d-cc06b7047d79"), new Guid("8745e56f-b335-43fe-bd10-bad6bead0892"), new Guid("5e8eae8c-7d72-4dc0-9832-6ae82f5a42ed") },
                    { new Guid("f2592374-46a9-4591-a895-38139df28d45"), new Guid("d35e2479-8214-41f2-b6d6-59b892602f16"), new Guid("d65a624a-c81b-4ed1-af0a-8b27ac872e6e") },
                    { new Guid("f2e16642-5d10-4195-8bc6-8b9dbb9dbd5a"), new Guid("8745e56f-b335-43fe-bd10-bad6bead0892"), new Guid("88f77e10-02c2-4182-a5e6-8946a84688a9") },
                    { new Guid("f373e7b2-ae41-4400-96a4-bd6fdde4d42f"), new Guid("ae14797c-31cd-432a-b2de-b3db95a82ab4"), new Guid("f840d9d0-7ecf-4b7c-b4e6-50118a1f6712") },
                    { new Guid("f453e780-320c-4f0a-b8a2-1b2a1b4403e1"), new Guid("2f044c88-a983-4cf5-bcc1-a5d7764507ed"), new Guid("8842e1a3-18e2-4aa7-8b66-55150248a33a") },
                    { new Guid("f545d7b1-1737-4f6e-8e66-0fbf7bde9d2e"), new Guid("da7a689b-5b29-4c88-91ad-b543ce614e12"), new Guid("1afe4a9e-7121-4b34-89a6-8db6e0b6ddad") },
                    { new Guid("f5b439e2-6b55-4eb7-99ef-76c7df3463c0"), new Guid("e2a8929f-2190-4329-bae1-83b170a3677f"), new Guid("5d146662-869d-477f-8f99-620ad1f3c1d1") },
                    { new Guid("f67584d0-32b7-4ef1-9e61-6d79edcdf6b3"), new Guid("8745e56f-b335-43fe-bd10-bad6bead0892"), new Guid("6a4b25d6-ae03-4aee-a442-af50945f1aee") },
                    { new Guid("f6d0031d-7d3a-4f3c-a846-5fb1e520e615"), new Guid("d35e2479-8214-41f2-b6d6-59b892602f16"), new Guid("f0d98d33-4c4f-4d87-9a5f-33fe7c1ab7a2") },
                    { new Guid("f716e2e0-29ab-45e3-87ad-20a3f468bf18"), new Guid("8745e56f-b335-43fe-bd10-bad6bead0892"), new Guid("674a432f-3fd4-4b33-af25-82607c96a3f0") },
                    { new Guid("f81f4801-8f8c-4df3-8a55-7b7f288250f9"), new Guid("2f044c88-a983-4cf5-bcc1-a5d7764507ed"), new Guid("41b26f20-69e4-43d2-8db4-76ed6a5028b3") },
                    { new Guid("f8435370-7dab-42db-97d5-470a4f98f68c"), new Guid("e2a8929f-2190-4329-bae1-83b170a3677f"), new Guid("7541417e-d9db-45c5-95f3-146b6f43f523") },
                    { new Guid("f889ad0b-003b-4cc7-8b38-d21a3586d95f"), new Guid("ac38a647-9bc3-4a14-ae64-8c50964e307d"), new Guid("0e53296d-4f08-4a15-ae64-23a8f4e8d804") },
                    { new Guid("fc6c8ae5-2c7a-4e4a-9b26-0a9a6c6a3ae2"), new Guid("8745e56f-b335-43fe-bd10-bad6bead0892"), new Guid("0a0e4f09-16b3-44d2-a545-c3f23a6bda9e") },
                    { new Guid("ff7d4e14-2860-428d-a5de-02b1de33e8cc"), new Guid("8ff3eaba-b2c6-4a1b-96c9-0f611d17e8c6"), new Guid("7fdfa190-66d6-43be-b2af-dbbd45052828") }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "AlbumId", "Duration", "IsActive", "Name" },
                values: new object[,]
                {
                    { new Guid("04a709fb-85ac-4a7b-b675-4b92f9c540da"), new Guid("5711de71-8cb5-4be9-984f-d1683760a9a6"), 2.16m, true, "GoodnightNGo" },
                    { new Guid("063c93e9-5785-48ab-bd62-c52ea0c654b9"), new Guid("73c8af54-d09b-4ef7-b646-901e59b868ed"), 2.16m, true, "BadBlood" },
                    { new Guid("0645bf34-df24-4681-a088-3430ac64f013"), new Guid("c3e23e47-c858-4c1c-9000-bd3f4e8fb1f0"), 2.16m, true, "ilomilo" },
                    { new Guid("08613aac-be0b-48f2-ae01-c33bc68b12fe"), new Guid("89901ee5-7d1f-48a4-8e92-83a9b5c76f1e"), 2.16m, true, "HUMBLE" },
                    { new Guid("08711cd7-f5fe-47c8-9cd2-3fc5f22f93c3"), new Guid("5711de71-8cb5-4be9-984f-d1683760a9a6"), 2.16m, true, "TheLightIsComing" },
                    { new Guid("0dc97df0-976b-4816-be51-a2f491027c1a"), new Guid("89901ee5-7d1f-48a4-8e92-83a9b5c76f1e"), 2.16m, true, "PRIDE" },
                    { new Guid("10a03e67-246a-495c-8913-a1d6a9479d23"), new Guid("d9d9d08b-5422-4458-a4de-34ac03a5f52e"), 2.16m, true, "NeededMe" },
                    { new Guid("11320d49-4294-4e52-bf32-2381dfed3ac4"), new Guid("8b9dcb0b-2f8d-4f0c-8645-0e8d588a4f5e"), 2.16m, true, "Trust" },
                    { new Guid("1648caba-362b-4974-bcc5-78a4b241cc26"), new Guid("8b9dcb0b-2f8d-4f0c-8645-0e8d588a4f5e"), 2.16m, true, "Children" },
                    { new Guid("172b01ab-8169-4c04-b54e-7cbfcb8a0931"), new Guid("5711de71-8cb5-4be9-984f-d1683760a9a6"), 2.16m, true, "Raindrops" },
                    { new Guid("1c8296c3-6bae-4036-8cf9-58ea04038866"), new Guid("5711de71-8cb5-4be9-984f-d1683760a9a6"), 2.16m, true, "Everytime" },
                    { new Guid("231eb456-d1fb-4f25-a4a8-9c4c559e4c2f"), new Guid("cc37dd0a-7831-4b4b-babb-259b4d06598d"), 2.16m, true, "StraightUpAndDown" },
                    { new Guid("23533d5b-5e56-46f4-a5d3-4cc138696854"), new Guid("d9d9d08b-5422-4458-a4de-34ac03a5f52e"), 2.16m, true, "KissItBetter" },
                    { new Guid("251cf78c-9b90-4d8e-bcb5-0add3b3e7030"), new Guid("e4b2c83d-384f-4d68-bbd0-ef8fdd9e9d25"), 2.16m, true, "Happier" },
                    { new Guid("28f6e7d4-af28-48c8-8def-3bac2538cb45"), new Guid("e4b2c83d-384f-4d68-bbd0-ef8fdd9e9d25"), 2.16m, true, "NancyMulligan" },
                    { new Guid("2cacb4aa-113f-4acd-b677-816bae840b08"), new Guid("c3e23e47-c858-4c1c-9000-bd3f4e8fb1f0"), 2.16m, true, "mystrangeaddiction" },
                    { new Guid("32496198-3ed2-46d6-a0ce-5403983fcbca"), new Guid("d9d9d08b-5422-4458-a4de-34ac03a5f52e"), 2.16m, true, "NeverEnding" },
                    { new Guid("32ec0969-1493-4960-97a8-32c068ad95c7"), new Guid("73c8af54-d09b-4ef7-b646-901e59b868ed"), 2.16m, true, "I Know Places" },
                    { new Guid("342c4173-99cc-404f-82cb-e9672829926c"), new Guid("73c8af54-d09b-4ef7-b646-901e59b868ed"), 2.16m, true, "WelcomeToNewYork" },
                    { new Guid("361a2eef-a9b0-4b5e-9c00-9bacfb5341a2"), new Guid("c3e23e47-c858-4c1c-9000-bd3f4e8fb1f0"), 2.16m, true, "allthegoodgirlsgotohell" },
                    { new Guid("36584c54-91b8-42fb-af1d-19025d24c68c"), new Guid("89901ee5-7d1f-48a4-8e92-83a9b5c76f1e"), 2.16m, true, "LOYALTY" },
                    { new Guid("384e9aee-60f8-43ac-8c32-9ce084bf2003"), new Guid("89901ee5-7d1f-48a4-8e92-83a9b5c76f1e"), 2.16m, true, "GOD" },
                    { new Guid("38b6bae0-b77b-4547-9884-64ec9e9eaadc"), new Guid("8b9dcb0b-2f8d-4f0c-8645-0e8d588a4f5e"), 2.16m, true, "Company" },
                    { new Guid("38e68a81-9342-4cd5-ae18-b0e08b92a9c6"), new Guid("89901ee5-7d1f-48a4-8e92-83a9b5c76f1e"), 2.16m, true, "LOVE" },
                    { new Guid("3a67f4c9-f38f-4164-ac51-82dcf6b5bcbe"), new Guid("d9d9d08b-5422-4458-a4de-34ac03a5f52e"), 2.16m, true, "Higher" },
                    { new Guid("3b44f4ed-824b-4d78-ae64-937b1e43d741"), new Guid("5711de71-8cb5-4be9-984f-d1683760a9a6"), 2.16m, true, "Borderline" },
                    { new Guid("3c7b9e52-2e80-427a-a4f1-4a1cf80fd412"), new Guid("cc37dd0a-7831-4b4b-babb-259b4d06598d"), 2.16m, true, "That'sWhatILike" },
                    { new Guid("3ffcd571-109a-4732-9816-ec12eb52580e"), new Guid("5711de71-8cb5-4be9-984f-d1683760a9a6"), 2.16m, true, "NoTearsLefttoCry" },
                    { new Guid("40919dca-43b0-40fd-8d3e-f8054cfa3ef5"), new Guid("73c8af54-d09b-4ef7-b646-901e59b868ed"), 2.16m, true, "ShakeItOff" },
                    { new Guid("41863e97-3f34-4dab-8222-23494334fa4e"), new Guid("e4b2c83d-384f-4d68-bbd0-ef8fdd9e9d25"), 2.16m, true, "Barcelona" },
                    { new Guid("44eae267-b790-48d3-8304-0059c7f5652e"), new Guid("cc37dd0a-7831-4b4b-babb-259b4d06598d"), 2.16m, true, "Perm" },
                    { new Guid("454bfdb6-4922-45b8-bd0d-33c38da31735"), new Guid("c3e23e47-c858-4c1c-9000-bd3f4e8fb1f0"), 2.16m, true, "xanny" },
                    { new Guid("48b05998-fb99-4693-98af-af675b4ddf46"), new Guid("8b9dcb0b-2f8d-4f0c-8645-0e8d588a4f5e"), 2.16m, true, "LifeIsWorthLiving" },
                    { new Guid("4cb98d94-2541-45ec-a178-f32e4faf7ddf"), new Guid("c3e23e47-c858-4c1c-9000-bd3f4e8fb1f0"), 2.16m, true, "_8" },
                    { new Guid("512a02cb-3b12-4ba4-b959-af37747ef1e9"), new Guid("cc37dd0a-7831-4b4b-babb-259b4d06598d"), 2.16m, true, "Finesse" },
                    { new Guid("52126cb0-f858-4f29-bd76-fa480a15daf3"), new Guid("8b9dcb0b-2f8d-4f0c-8645-0e8d588a4f5e"), 2.16m, true, "NoPressure" },
                    { new Guid("52a6e6da-9d3e-4905-aa5e-a0745496d056"), new Guid("73c8af54-d09b-4ef7-b646-901e59b868ed"), 2.16m, true, "Style" },
                    { new Guid("554abc99-8c15-450d-93fd-34f6cc16bf8b"), new Guid("73c8af54-d09b-4ef7-b646-901e59b868ed"), 2.16m, true, "BlankSpace" },
                    { new Guid("5793b9c8-72ce-47c6-93ca-4c5c7f032b98"), new Guid("c3e23e47-c858-4c1c-9000-bd3f4e8fb1f0"), 2.16m, true, "wishyouweregay" },
                    { new Guid("5b6ab067-1e79-48bf-ac67-a4a478a64c15"), new Guid("d9d9d08b-5422-4458-a4de-34ac03a5f52e"), 2.16m, true, "Work" },
                    { new Guid("5c4f6bf2-34da-43de-a5e4-860992d8cdf4"), new Guid("89901ee5-7d1f-48a4-8e92-83a9b5c76f1e"), 2.16m, true, "ELEMENT" },
                    { new Guid("5cda7056-6608-4a10-b2ac-e4542a3a54c4"), new Guid("8b9dcb0b-2f8d-4f0c-8645-0e8d588a4f5e"), 2.16m, true, "BeenYou" },
                    { new Guid("5ec063e4-d881-4aff-9a1d-c588255094f8"), new Guid("e4b2c83d-384f-4d68-bbd0-ef8fdd9e9d25"), 2.16m, true, "WhatDoIKnow" },
                    { new Guid("5ec151a2-8644-4e89-923d-8003d5d4cbc1"), new Guid("5711de71-8cb5-4be9-984f-d1683760a9a6"), 2.16m, true, "Breathin" },
                    { new Guid("605a8a4a-8626-4f7a-8138-86597f0382ea"), new Guid("e4b2c83d-384f-4d68-bbd0-ef8fdd9e9d25"), 2.16m, true, "HowWouldYouFeelPaean" },
                    { new Guid("617a9867-2fcc-4d05-8bb8-857689a35b17"), new Guid("c3e23e47-c858-4c1c-9000-bd3f4e8fb1f0"), 2.16m, true, "badguy" },
                    { new Guid("6a5f1024-050b-432f-87cb-e9781c2da92f"), new Guid("e4b2c83d-384f-4d68-bbd0-ef8fdd9e9d25"), 2.16m, true, "CastleontheHill" },
                    { new Guid("6a9090f3-4cb1-457b-8341-8d95786e2f93"), new Guid("5711de71-8cb5-4be9-984f-d1683760a9a6"), 2.16m, true, "GodIsAWoman" },
                    { new Guid("6bf3e7d0-b9b1-475c-8cec-dcd2fb7746d3"), new Guid("73c8af54-d09b-4ef7-b646-901e59b868ed"), 2.16m, true, "OutOfTheWoods" },
                    { new Guid("6cd2e038-f910-471b-93dc-94d636675584"), new Guid("89901ee5-7d1f-48a4-8e92-83a9b5c76f1e"), 2.16m, true, "XXX" },
                    { new Guid("6daaee3d-1e84-4408-aff9-eb7c02a25b14"), new Guid("8b9dcb0b-2f8d-4f0c-8645-0e8d588a4f5e"), 2.16m, true, "WhereAreUNow" },
                    { new Guid("73968f68-af90-4cda-9be5-5c4cffc43dab"), new Guid("d9d9d08b-5422-4458-a4de-34ac03a5f52e"), 2.16m, true, "SameOlMistakes" },
                    { new Guid("76a23627-35c3-4bb8-b9dc-65badf5e63f1"), new Guid("cc37dd0a-7831-4b4b-babb-259b4d06598d"), 2.16m, true, "CallingAllMyLovelies" },
                    { new Guid("76d9e174-1e56-4e71-ab06-673753e381aa"), new Guid("8b9dcb0b-2f8d-4f0c-8645-0e8d588a4f5e"), 2.16m, true, "Sorry" },
                    { new Guid("785f9d64-0f05-4aea-90f4-cbbcd7c9b946"), new Guid("cc37dd0a-7831-4b4b-babb-259b4d06598d"), 2.16m, true, "24KMagic" },
                    { new Guid("7ac102ca-5e6f-41ee-acc0-6b0e7941a9fd"), new Guid("73c8af54-d09b-4ef7-b646-901e59b868ed"), 2.16m, true, "ThisLove" },
                    { new Guid("7b7345e4-8ac4-4dd4-a6c7-4bbd713494aa"), new Guid("8b9dcb0b-2f8d-4f0c-8645-0e8d588a4f5e"), 2.16m, true, "WhatDoYouMean" },
                    { new Guid("7ff0824a-e240-4ddd-bd2d-9406f6296b53"), new Guid("8b9dcb0b-2f8d-4f0c-8645-0e8d588a4f5e"), 2.16m, true, "LoveYourself" },
                    { new Guid("80890b51-f7e0-4302-882b-1e60a79d2315"), new Guid("89901ee5-7d1f-48a4-8e92-83a9b5c76f1e"), 2.16m, true, "DNA" },
                    { new Guid("85efc138-f29f-4d8e-9b05-da95bec1e203"), new Guid("c3e23e47-c858-4c1c-9000-bd3f4e8fb1f0"), 2.16m, true, "iloveyou" },
                    { new Guid("85f7c136-2ce9-4163-b01c-7beea05056a7"), new Guid("e4b2c83d-384f-4d68-bbd0-ef8fdd9e9d25"), 2.16m, true, "Eraser" },
                    { new Guid("88b66b3b-b3d2-42cd-90ec-39788d0dd512"), new Guid("cc37dd0a-7831-4b4b-babb-259b4d06598d"), 2.16m, true, "VersaceOnTheFloor" },
                    { new Guid("8a2165b8-f201-421c-87ae-03642914a34b"), new Guid("73c8af54-d09b-4ef7-b646-901e59b868ed"), 2.16m, true, "WildestDreams" },
                    { new Guid("8fa99920-8bd6-4da4-b530-fef34656fa2b"), new Guid("8b9dcb0b-2f8d-4f0c-8645-0e8d588a4f5e"), 2.16m, true, "NoSense" },
                    { new Guid("905917ab-51b5-402a-8367-9dc3256cf1f2"), new Guid("73c8af54-d09b-4ef7-b646-901e59b868ed"), 2.16m, true, "I Wish You Would" },
                    { new Guid("9154c3ac-6c9d-429c-a732-6bfe671b36fa"), new Guid("e4b2c83d-384f-4d68-bbd0-ef8fdd9e9d25"), 2.16m, true, "Dive" },
                    { new Guid("92efc2af-14aa-43e3-a8b3-ed5c38d76311"), new Guid("73c8af54-d09b-4ef7-b646-901e59b868ed"), 2.16m, true, "AllYouHadToDoWasStay" },
                    { new Guid("9371a131-4d36-4b46-8d1f-82a6f4763534"), new Guid("cc37dd0a-7831-4b4b-babb-259b4d06598d"), 2.16m, true, "Chunky" },
                    { new Guid("93dc2a4e-e14b-4fb8-84b5-ab244110e423"), new Guid("c3e23e47-c858-4c1c-9000-bd3f4e8fb1f0"), 2.16m, true, "listenbeforeigo" },
                    { new Guid("9484a78d-b1fd-401e-904d-4d9ba1e30fea"), new Guid("c3e23e47-c858-4c1c-9000-bd3f4e8fb1f0"), 2.16m, true, "goodbye" },
                    { new Guid("9a782ce1-740f-4009-ade0-d474616df4b4"), new Guid("e4b2c83d-384f-4d68-bbd0-ef8fdd9e9d25"), 2.16m, true, "SaveMyself" },
                    { new Guid("9b5b7d9e-10aa-4aa0-b08c-b8d2779ccdb9"), new Guid("89901ee5-7d1f-48a4-8e92-83a9b5c76f1e"), 2.16m, true, "FEEL" },
                    { new Guid("9b7ad1c8-fdd9-4b7a-891b-e7270998f885"), new Guid("8b9dcb0b-2f8d-4f0c-8645-0e8d588a4f5e"), 2.16m, true, "MarkMyWords" },
                    { new Guid("9eb5a8fa-911f-4310-901b-f50ff0bf7b39"), new Guid("e4b2c83d-384f-4d68-bbd0-ef8fdd9e9d25"), 2.16m, true, "HeartsDontBreakAroundHere" },
                    { new Guid("9fd0c929-c39e-4d21-aaf5-9b27058637e2"), new Guid("d9d9d08b-5422-4458-a4de-34ac03a5f52e"), 2.16m, true, "JamesJoint" },
                    { new Guid("a0c8d366-0d09-4d9c-9c54-e26517e258b7"), new Guid("5711de71-8cb5-4be9-984f-d1683760a9a6"), 2.16m, true, "Blazed" },
                    { new Guid("a5cc759d-14b1-4015-8593-7c47d80a4b17"), new Guid("5711de71-8cb5-4be9-984f-d1683760a9a6"), 2.16m, true, "Successful" },
                    { new Guid("a7edab83-5889-4e6a-9d2b-9a3fc504c29f"), new Guid("d9d9d08b-5422-4458-a4de-34ac03a5f52e"), 2.16m, true, "YeahImThOne" },
                    { new Guid("a9424a75-7dd3-4ddd-98d2-d7cd55fbbfc4"), new Guid("e4b2c83d-384f-4d68-bbd0-ef8fdd9e9d25"), 2.16m, true, "Perfect" },
                    { new Guid("a9620719-90e7-41b1-9517-4ecc81693c73"), new Guid("89901ee5-7d1f-48a4-8e92-83a9b5c76f1e"), 2.16m, true, "LUST" },
                    { new Guid("bc28acab-30c4-4cb4-9201-0958ac78c822"), new Guid("5711de71-8cb5-4be9-984f-d1683760a9a6"), 2.16m, true, "PeteDavidson" },
                    { new Guid("be25d676-8cdc-4e06-9294-586a7d37ff76"), new Guid("e4b2c83d-384f-4d68-bbd0-ef8fdd9e9d25"), 2.16m, true, "ShapeofYou" },
                    { new Guid("bf807e39-2791-4fa2-8dc3-64c145489720"), new Guid("cc37dd0a-7831-4b4b-babb-259b4d06598d"), 2.16m, true, "TooGoodToSayGoodbye" },
                    { new Guid("bfe235f7-3597-4ae5-9413-e8e831b1911e"), new Guid("d9d9d08b-5422-4458-a4de-34ac03a5f52e"), 2.16m, true, "Desperado" },
                    { new Guid("c25f19d4-883b-47a6-b2ba-05691f039db3"), new Guid("c3e23e47-c858-4c1c-9000-bd3f4e8fb1f0"), 2.16m, true, "youshouldseemeinacrown" },
                    { new Guid("c8dc0367-e04e-442e-bc2a-3b64c858d3cb"), new Guid("5711de71-8cb5-4be9-984f-d1683760a9a6"), 2.16m, true, "GetWellSoon" },
                    { new Guid("cea1e4bf-cc0c-44d7-992c-31b81dc72d74"), new Guid("e4b2c83d-384f-4d68-bbd0-ef8fdd9e9d25"), 2.16m, true, "New Man" },
                    { new Guid("cf295a6b-92c8-4dd8-9044-27607055dd3c"), new Guid("e4b2c83d-384f-4d68-bbd0-ef8fdd9e9d25"), 2.16m, true, "BibiaBeYeYe" },
                    { new Guid("cf50b71c-4055-4276-8f82-e9e91ce88049"), new Guid("c3e23e47-c858-4c1c-9000-bd3f4e8fb1f0"), 2.16m, true, "buryafriend" },
                    { new Guid("d3c49bac-f66f-41cd-ac63-46553f9d97d4"), new Guid("89901ee5-7d1f-48a4-8e92-83a9b5c76f1e"), 2.16m, true, "YAH" },
                    { new Guid("d41e2f9d-56a9-48a2-9003-cf0d1ecd91cb"), new Guid("e4b2c83d-384f-4d68-bbd0-ef8fdd9e9d25"), 2.16m, true, "GalwayGirl" },
                    { new Guid("d540bd3c-870a-4e1b-b575-80069b4dd27b"), new Guid("d9d9d08b-5422-4458-a4de-34ac03a5f52e"), 2.16m, true, "Consideration" },
                    { new Guid("d570d995-f615-42d7-9456-36a29a129d29"), new Guid("d9d9d08b-5422-4458-a4de-34ac03a5f52e"), 2.16m, true, "SexWithMe" },
                    { new Guid("d65c7a12-3a01-48c0-92b2-8a46fa0c3491"), new Guid("73c8af54-d09b-4ef7-b646-901e59b868ed"), 2.16m, true, "Clean" },
                    { new Guid("d89f6658-aa9a-46ba-bef9-35538a7129b5"), new Guid("89901ee5-7d1f-48a4-8e92-83a9b5c76f1e"), 2.16m, true, "BLOOD" },
                    { new Guid("d95f9b2b-bee0-4105-b0a8-680db66cd032"), new Guid("d9d9d08b-5422-4458-a4de-34ac03a5f52e"), 2.16m, true, "Woo" },
                    { new Guid("da1fcc3b-1841-4e3b-b75b-1292385ef9bf"), new Guid("8b9dcb0b-2f8d-4f0c-8645-0e8d588a4f5e"), 2.16m, true, "ILlShowYou" },
                    { new Guid("da8a67d5-ada2-47f8-8d17-7a8158e0ba79"), new Guid("5711de71-8cb5-4be9-984f-d1683760a9a6"), 2.16m, true, "Sweetener" },
                    { new Guid("db66bffc-e43b-4721-9fb3-30083ff12e4f"), new Guid("e4b2c83d-384f-4d68-bbd0-ef8fdd9e9d25"), 2.16m, true, "SupermarketFlowers" },
                    { new Guid("dc3a0d3f-204d-4efe-80c0-f590eb22baee"), new Guid("8b9dcb0b-2f8d-4f0c-8645-0e8d588a4f5e"), 2.16m, true, "Purpose" },
                    { new Guid("dd6be640-af8a-4190-8d2c-d0bb3198279f"), new Guid("8b9dcb0b-2f8d-4f0c-8645-0e8d588a4f5e"), 2.16m, true, "GetUsedToIt" },
                    { new Guid("ded32561-2dda-4d56-b31b-3fd357d0c459"), new Guid("d9d9d08b-5422-4458-a4de-34ac03a5f52e"), 2.16m, true, "LoveOnTheBrain" },
                    { new Guid("e0cfeeaa-d871-4352-b1bb-f0a3e222d0ae"), new Guid("5711de71-8cb5-4be9-984f-d1683760a9a6"), 2.16m, true, "R.E.M." },
                    { new Guid("e9dbaa64-3eca-4ffa-b8dc-44e4fa30a620"), new Guid("d9d9d08b-5422-4458-a4de-34ac03a5f52e"), 2.16m, true, "CloseToYou" },
                    { new Guid("ea4afb6e-40d3-43b7-bcb3-ffea7591cc82"), new Guid("8b9dcb0b-2f8d-4f0c-8645-0e8d588a4f5e"), 2.16m, true, "WeAre" },
                    { new Guid("eebee09c-ddc4-43c4-9e1e-95c14f2bb1fb"), new Guid("c3e23e47-c858-4c1c-9000-bd3f4e8fb1f0"), 2.16m, true, "whenthepartysover" },
                    { new Guid("f163d0c0-99b3-4ebd-be69-716b94f7d994"), new Guid("73c8af54-d09b-4ef7-b646-901e59b868ed"), 2.16m, true, "HowYouGetTheGirl" },
                    { new Guid("f25a4e62-4663-4aa4-a3f5-c2bc06af9b23"), new Guid("89901ee5-7d1f-48a4-8e92-83a9b5c76f1e"), 2.16m, true, "DUCKWORTH" },
                    { new Guid("f26435c7-9fed-4a89-b125-32cc89a4ae69"), new Guid("d9d9d08b-5422-4458-a4de-34ac03a5f52e"), 2.16m, true, "GoodNightGotham" },
                    { new Guid("f32391b1-d252-406f-a7f5-fe523c531e1d"), new Guid("c3e23e47-c858-4c1c-9000-bd3f4e8fb1f0"), 2.16m, true, "exclamationMark" },
                    { new Guid("f77fad81-b88d-45fa-abc7-6842b0642cca"), new Guid("d9d9d08b-5422-4458-a4de-34ac03a5f52e"), 2.16m, true, "Pose" },
                    { new Guid("f7ce6650-bcf4-4137-b8ac-f7c0e5bcb7cb"), new Guid("5711de71-8cb5-4be9-984f-d1683760a9a6"), 2.16m, true, "BetterOff" },
                    { new Guid("f90d17eb-8e83-4218-bdfd-807861a8e77a"), new Guid("89901ee5-7d1f-48a4-8e92-83a9b5c76f1e"), 2.16m, true, "FEAR" },
                    { new Guid("fa8b1dbc-ded8-4513-95a6-875e2d586270"), new Guid("8b9dcb0b-2f8d-4f0c-8645-0e8d588a4f5e"), 2.16m, true, "AllInIt" },
                    { new Guid("fcb99dc8-d3f3-4b11-93c1-b8356f4bd87d"), new Guid("8b9dcb0b-2f8d-4f0c-8645-0e8d588a4f5e"), 2.16m, true, "TheFeeling" }
                });

            migrationBuilder.InsertData(
                table: "ArtistTracks",
                columns: new[] { "Id", "ArtistId", "TrackId" },
                values: new object[,]
                {
                    { new Guid("00f17f0b-4a11-42e5-a273-e55dd10458b0"), new Guid("573a1d7c-694e-4f66-8905-8e528f137d27"), new Guid("e9dbaa64-3eca-4ffa-b8dc-44e4fa30a620") },
                    { new Guid("070bad5c-b58a-4d0a-8090-8ce1e30eb1d5"), new Guid("f024e3f8-cf68-4c48-b288-b04e9c8b30c2"), new Guid("08711cd7-f5fe-47c8-9cd2-3fc5f22f93c3") },
                    { new Guid("0edea616-8872-4f2b-ae54-42a2381e017e"), new Guid("573a1d7c-694e-4f66-8905-8e528f137d27"), new Guid("5b6ab067-1e79-48bf-ac67-a4a478a64c15") },
                    { new Guid("10bf0cb5-32b8-4302-84bc-f6d738ec51ee"), new Guid("d8956234-3e1b-4c14-ae78-9b7f1f598ef2"), new Guid("85f7c136-2ce9-4163-b01c-7beea05056a7") },
                    { new Guid("11816d03-0ca0-4255-8588-c1325226971c"), new Guid("f2e16642-5d10-4195-8bc6-8b9dbb9dbd5a"), new Guid("f32391b1-d252-406f-a7f5-fe523c531e1d") },
                    { new Guid("1270b1a2-6497-4aa6-98a6-f8dbc425a5c9"), new Guid("bcb0671f-572a-4495-b5df-3f2865e081b2"), new Guid("9b5b7d9e-10aa-4aa0-b08c-b8d2779ccdb9") },
                    { new Guid("1356c868-10d8-41b8-8b19-f0615a6b3867"), new Guid("d8956234-3e1b-4c14-ae78-9b7f1f598ef2"), new Guid("605a8a4a-8626-4f7a-8138-86597f0382ea") },
                    { new Guid("154a7390-0633-4759-9b61-cf3108ca0eb9"), new Guid("81d19ab4-52a1-4e47-9766-2c7b682e89b3"), new Guid("52126cb0-f858-4f29-bd76-fa480a15daf3") },
                    { new Guid("1c4df7ed-1e52-4d80-b0b7-28407d57346b"), new Guid("bcb0671f-572a-4495-b5df-3f2865e081b2"), new Guid("5c4f6bf2-34da-43de-a5e4-860992d8cdf4") },
                    { new Guid("1d823252-a0ce-4e57-b895-94c22a531ee5"), new Guid("640e13de-bd1e-4088-8651-44be51f2451d"), new Guid("44eae267-b790-48d3-8304-0059c7f5652e") },
                    { new Guid("203dc7c2-b104-4ca8-8880-b6f59d89ff6e"), new Guid("573a1d7c-694e-4f66-8905-8e528f137d27"), new Guid("32496198-3ed2-46d6-a0ce-5403983fcbca") },
                    { new Guid("2195d708-1bd7-4d91-a123-8bc12c9f1208"), new Guid("81d19ab4-52a1-4e47-9766-2c7b682e89b3"), new Guid("76d9e174-1e56-4e71-ab06-673753e381aa") },
                    { new Guid("23a980c1-08c2-4208-a5fe-093243f8a8c1"), new Guid("d8956234-3e1b-4c14-ae78-9b7f1f598ef2"), new Guid("5ec063e4-d881-4aff-9a1d-c588255094f8") },
                    { new Guid("23aaa60c-85cf-4c20-aebb-77a6c520d189"), new Guid("bcb0671f-572a-4495-b5df-3f2865e081b2"), new Guid("384e9aee-60f8-43ac-8c32-9ce084bf2003") },
                    { new Guid("266ac634-b69a-4f23-aab5-8038b126e99f"), new Guid("bcb0671f-572a-4495-b5df-3f2865e081b2"), new Guid("f25a4e62-4663-4aa4-a3f5-c2bc06af9b23") },
                    { new Guid("2b26decc-5803-4087-a94a-39f6754f5b44"), new Guid("f024e3f8-cf68-4c48-b288-b04e9c8b30c2"), new Guid("e0cfeeaa-d871-4352-b1bb-f0a3e222d0ae") },
                    { new Guid("2b9f516a-1ccc-45b0-862f-6c3190545674"), new Guid("87f352c1-ef43-41fb-b5c1-3a46e51868b8"), new Guid("8a2165b8-f201-421c-87ae-03642914a34b") },
                    { new Guid("2f0ce2f3-dac2-4c64-b685-4541938f0648"), new Guid("d8956234-3e1b-4c14-ae78-9b7f1f598ef2"), new Guid("9154c3ac-6c9d-429c-a732-6bfe671b36fa") },
                    { new Guid("30542646-2f2a-4a85-bd79-7ea65d4ad39c"), new Guid("87f352c1-ef43-41fb-b5c1-3a46e51868b8"), new Guid("32ec0969-1493-4960-97a8-32c068ad95c7") },
                    { new Guid("35242a23-4871-465f-81a5-2168942f0a1a"), new Guid("f024e3f8-cf68-4c48-b288-b04e9c8b30c2"), new Guid("6a9090f3-4cb1-457b-8341-8d95786e2f93") },
                    { new Guid("35a4b0be-a32d-403c-b28b-85c20931f93e"), new Guid("f2e16642-5d10-4195-8bc6-8b9dbb9dbd5a"), new Guid("4cb98d94-2541-45ec-a178-f32e4faf7ddf") },
                    { new Guid("37e84066-80b3-4909-ab33-35271de46a6b"), new Guid("f024e3f8-cf68-4c48-b288-b04e9c8b30c2"), new Guid("f7ce6650-bcf4-4137-b8ac-f7c0e5bcb7cb") },
                    { new Guid("3af96a6f-0c76-4e59-91c7-163d2a01561d"), new Guid("f2e16642-5d10-4195-8bc6-8b9dbb9dbd5a"), new Guid("85efc138-f29f-4d8e-9b05-da95bec1e203") },
                    { new Guid("3affc449-05bf-4c5e-be97-699f4dc2104b"), new Guid("640e13de-bd1e-4088-8651-44be51f2451d"), new Guid("231eb456-d1fb-4f25-a4a8-9c4c559e4c2f") },
                    { new Guid("3daab4ce-b61c-44e4-ac22-d9a635f6c522"), new Guid("bcb0671f-572a-4495-b5df-3f2865e081b2"), new Guid("d3c49bac-f66f-41cd-ac63-46553f9d97d4") },
                    { new Guid("400e8bc6-5bf3-40c6-ac6d-96828a975544"), new Guid("f024e3f8-cf68-4c48-b288-b04e9c8b30c2"), new Guid("c8dc0367-e04e-442e-bc2a-3b64c858d3cb") },
                    { new Guid("41c480e7-fb14-4ee5-835c-4e11257307fb"), new Guid("bcb0671f-572a-4495-b5df-3f2865e081b2"), new Guid("f90d17eb-8e83-4218-bdfd-807861a8e77a") },
                    { new Guid("435f5d12-6f61-4483-8063-1e763b677fb4"), new Guid("d8956234-3e1b-4c14-ae78-9b7f1f598ef2"), new Guid("6a5f1024-050b-432f-87cb-e9781c2da92f") },
                    { new Guid("4955190b-aa9c-46f3-8583-0bf2620888a2"), new Guid("81d19ab4-52a1-4e47-9766-2c7b682e89b3"), new Guid("48b05998-fb99-4693-98af-af675b4ddf46") },
                    { new Guid("4b5de087-d859-4eae-96d3-267b2bbbb93e"), new Guid("d8956234-3e1b-4c14-ae78-9b7f1f598ef2"), new Guid("251cf78c-9b90-4d8e-bcb5-0add3b3e7030") },
                    { new Guid("4bb062c5-c7c6-413d-aadb-abf17818e620"), new Guid("d8956234-3e1b-4c14-ae78-9b7f1f598ef2"), new Guid("a9424a75-7dd3-4ddd-98d2-d7cd55fbbfc4") },
                    { new Guid("4d5bab68-549e-4027-8e73-6322040b4e00"), new Guid("81d19ab4-52a1-4e47-9766-2c7b682e89b3"), new Guid("7ff0824a-e240-4ddd-bd2d-9406f6296b53") },
                    { new Guid("554accb2-60ca-4963-b13a-765920c11859"), new Guid("81d19ab4-52a1-4e47-9766-2c7b682e89b3"), new Guid("9b7ad1c8-fdd9-4b7a-891b-e7270998f885") },
                    { new Guid("55dd2f1c-ed65-46b1-b111-34fd7cf218ee"), new Guid("bcb0671f-572a-4495-b5df-3f2865e081b2"), new Guid("80890b51-f7e0-4302-882b-1e60a79d2315") },
                    { new Guid("56c53eee-e989-4f4f-8f8b-428bdae67b53"), new Guid("573a1d7c-694e-4f66-8905-8e528f137d27"), new Guid("bfe235f7-3597-4ae5-9413-e8e831b1911e") },
                    { new Guid("572a5449-c3ce-424e-9eb5-63e67b998e5b"), new Guid("f2e16642-5d10-4195-8bc6-8b9dbb9dbd5a"), new Guid("0645bf34-df24-4681-a088-3430ac64f013") },
                    { new Guid("59470b2d-49c5-44ee-a07b-2393c10b041e"), new Guid("f024e3f8-cf68-4c48-b288-b04e9c8b30c2"), new Guid("1c8296c3-6bae-4036-8cf9-58ea04038866") },
                    { new Guid("5a62cb61-ac5d-4ecc-b1b9-77ba9676ecc3"), new Guid("87f352c1-ef43-41fb-b5c1-3a46e51868b8"), new Guid("7ac102ca-5e6f-41ee-acc0-6b0e7941a9fd") },
                    { new Guid("5bbd9edb-8e03-4783-b785-ac8b0ce0ee0c"), new Guid("573a1d7c-694e-4f66-8905-8e528f137d27"), new Guid("3a67f4c9-f38f-4164-ac51-82dcf6b5bcbe") },
                    { new Guid("5d53ba14-b266-4375-af7a-99202ea4f6e4"), new Guid("87f352c1-ef43-41fb-b5c1-3a46e51868b8"), new Guid("f163d0c0-99b3-4ebd-be69-716b94f7d994") },
                    { new Guid("60d05c00-bb9b-4c67-ab8a-10759660fe7e"), new Guid("573a1d7c-694e-4f66-8905-8e528f137d27"), new Guid("d95f9b2b-bee0-4105-b0a8-680db66cd032") },
                    { new Guid("60e6c661-a7af-43dd-bdc9-01894f11f3da"), new Guid("d8956234-3e1b-4c14-ae78-9b7f1f598ef2"), new Guid("be25d676-8cdc-4e06-9294-586a7d37ff76") },
                    { new Guid("628d31d2-a8a0-4adb-b611-0d052b1c7af7"), new Guid("f024e3f8-cf68-4c48-b288-b04e9c8b30c2"), new Guid("5ec151a2-8644-4e89-923d-8003d5d4cbc1") },
                    { new Guid("65791d13-67df-4acc-8f5a-eba57d4c1c76"), new Guid("640e13de-bd1e-4088-8651-44be51f2451d"), new Guid("512a02cb-3b12-4ba4-b959-af37747ef1e9") },
                    { new Guid("65b036dc-635e-4e32-8b29-28d7b51b9732"), new Guid("f024e3f8-cf68-4c48-b288-b04e9c8b30c2"), new Guid("04a709fb-85ac-4a7b-b675-4b92f9c540da") },
                    { new Guid("65e79682-87a8-42e2-8b33-6e54cd0341c4"), new Guid("f024e3f8-cf68-4c48-b288-b04e9c8b30c2"), new Guid("bc28acab-30c4-4cb4-9201-0958ac78c822") },
                    { new Guid("6704e0b0-7df1-4965-844a-0f38c35ac4f8"), new Guid("81d19ab4-52a1-4e47-9766-2c7b682e89b3"), new Guid("5cda7056-6608-4a10-b2ac-e4542a3a54c4") },
                    { new Guid("68502be5-7b28-4fe8-9a71-f6cb9b816706"), new Guid("87f352c1-ef43-41fb-b5c1-3a46e51868b8"), new Guid("554abc99-8c15-450d-93fd-34f6cc16bf8b") },
                    { new Guid("68a89cf0-6649-42f1-a422-012bf51bc2f4"), new Guid("f024e3f8-cf68-4c48-b288-b04e9c8b30c2"), new Guid("a5cc759d-14b1-4015-8593-7c47d80a4b17") },
                    { new Guid("6a9fbbd6-aba4-4e25-828f-a4120d8df2d2"), new Guid("81d19ab4-52a1-4e47-9766-2c7b682e89b3"), new Guid("dd6be640-af8a-4190-8d2c-d0bb3198279f") },
                    { new Guid("6aeabfef-0467-4428-9f8b-8069e95f6c77"), new Guid("d8956234-3e1b-4c14-ae78-9b7f1f598ef2"), new Guid("d41e2f9d-56a9-48a2-9003-cf0d1ecd91cb") },
                    { new Guid("6d01d50b-aa37-412e-a739-e69fb3619bdc"), new Guid("81d19ab4-52a1-4e47-9766-2c7b682e89b3"), new Guid("fa8b1dbc-ded8-4513-95a6-875e2d586270") },
                    { new Guid("703d7b78-5d99-49f1-9e73-7acb8459b1d9"), new Guid("f024e3f8-cf68-4c48-b288-b04e9c8b30c2"), new Guid("172b01ab-8169-4c04-b54e-7cbfcb8a0931") },
                    { new Guid("70e9455e-c256-4ea5-8e75-cf1502dd703c"), new Guid("87f352c1-ef43-41fb-b5c1-3a46e51868b8"), new Guid("92efc2af-14aa-43e3-a8b3-ed5c38d76311") },
                    { new Guid("71ee88f0-7b48-496e-953a-1955b56a66b7"), new Guid("f2e16642-5d10-4195-8bc6-8b9dbb9dbd5a"), new Guid("454bfdb6-4922-45b8-bd0d-33c38da31735") },
                    { new Guid("730e65eb-ce68-45ed-84f0-6b269112966d"), new Guid("bcb0671f-572a-4495-b5df-3f2865e081b2"), new Guid("36584c54-91b8-42fb-af1d-19025d24c68c") },
                    { new Guid("732711e5-8895-44c1-b796-53e4e3269f5b"), new Guid("573a1d7c-694e-4f66-8905-8e528f137d27"), new Guid("23533d5b-5e56-46f4-a5d3-4cc138696854") },
                    { new Guid("7a81609b-af37-4af8-b2ef-a4c33a25bed7"), new Guid("87f352c1-ef43-41fb-b5c1-3a46e51868b8"), new Guid("905917ab-51b5-402a-8367-9dc3256cf1f2") },
                    { new Guid("7ab40740-74df-4352-a95e-691246eb222f"), new Guid("bcb0671f-572a-4495-b5df-3f2865e081b2"), new Guid("a9620719-90e7-41b1-9517-4ecc81693c73") },
                    { new Guid("7c744a17-7344-4430-9536-63f4d3348063"), new Guid("573a1d7c-694e-4f66-8905-8e528f137d27"), new Guid("d540bd3c-870a-4e1b-b575-80069b4dd27b") },
                    { new Guid("85bb99aa-9d9b-4e3a-97b2-8fb97b6137ed"), new Guid("f2e16642-5d10-4195-8bc6-8b9dbb9dbd5a"), new Guid("2cacb4aa-113f-4acd-b677-816bae840b08") },
                    { new Guid("8d029e45-dfa0-4337-9ee6-f471e2da1899"), new Guid("81d19ab4-52a1-4e47-9766-2c7b682e89b3"), new Guid("38b6bae0-b77b-4547-9884-64ec9e9eaadc") },
                    { new Guid("8e449ac4-29ae-46a5-b9a0-87992593185e"), new Guid("f2e16642-5d10-4195-8bc6-8b9dbb9dbd5a"), new Guid("93dc2a4e-e14b-4fb8-84b5-ab244110e423") },
                    { new Guid("936ffe00-8d77-46c8-ba0e-95bbbbe16500"), new Guid("87f352c1-ef43-41fb-b5c1-3a46e51868b8"), new Guid("d65c7a12-3a01-48c0-92b2-8a46fa0c3491") },
                    { new Guid("93c36e8a-144d-4ac9-a013-3037e633b18b"), new Guid("f2e16642-5d10-4195-8bc6-8b9dbb9dbd5a"), new Guid("c25f19d4-883b-47a6-b2ba-05691f039db3") },
                    { new Guid("94846b5a-866e-44b1-a8f2-3c424d9228f8"), new Guid("81d19ab4-52a1-4e47-9766-2c7b682e89b3"), new Guid("dc3a0d3f-204d-4efe-80c0-f590eb22baee") },
                    { new Guid("95bd8cb1-02ea-40eb-bf89-3bb4813543b4"), new Guid("f024e3f8-cf68-4c48-b288-b04e9c8b30c2"), new Guid("da8a67d5-ada2-47f8-8d17-7a8158e0ba79") },
                    { new Guid("95de138f-0a69-426f-8f5f-dfc2181a9c5d"), new Guid("81d19ab4-52a1-4e47-9766-2c7b682e89b3"), new Guid("1648caba-362b-4974-bcc5-78a4b241cc26") },
                    { new Guid("96f51fb8-66b3-483e-89e0-9388730acfdb"), new Guid("640e13de-bd1e-4088-8651-44be51f2451d"), new Guid("bf807e39-2791-4fa2-8dc3-64c145489720") },
                    { new Guid("97ff69a0-9113-4e22-8365-c67c8764cf22"), new Guid("f2e16642-5d10-4195-8bc6-8b9dbb9dbd5a"), new Guid("361a2eef-a9b0-4b5e-9c00-9bacfb5341a2") },
                    { new Guid("9841b6ce-c264-4edc-ad4c-31cc366c09a4"), new Guid("87f352c1-ef43-41fb-b5c1-3a46e51868b8"), new Guid("342c4173-99cc-404f-82cb-e9672829926c") },
                    { new Guid("99f4e048-be2e-4702-bbd0-d5ca7034eb1b"), new Guid("f024e3f8-cf68-4c48-b288-b04e9c8b30c2"), new Guid("3ffcd571-109a-4732-9816-ec12eb52580e") },
                    { new Guid("9ae984d3-af4c-43bb-9a44-c08baecbccba"), new Guid("d8956234-3e1b-4c14-ae78-9b7f1f598ef2"), new Guid("41863e97-3f34-4dab-8222-23494334fa4e") },
                    { new Guid("9c6a4902-3561-4ffd-8dd8-f02eac939b12"), new Guid("bcb0671f-572a-4495-b5df-3f2865e081b2"), new Guid("6cd2e038-f910-471b-93dc-94d636675584") },
                    { new Guid("9da2d1f5-a83f-499a-b6f9-9abdbffc54bb"), new Guid("d8956234-3e1b-4c14-ae78-9b7f1f598ef2"), new Guid("9a782ce1-740f-4009-ade0-d474616df4b4") },
                    { new Guid("9f5bbfcd-4383-419d-b22a-ac704204a7ee"), new Guid("87f352c1-ef43-41fb-b5c1-3a46e51868b8"), new Guid("6bf3e7d0-b9b1-475c-8cec-dcd2fb7746d3") },
                    { new Guid("a05bda5d-7d16-47da-a6cc-c6051be6bea1"), new Guid("573a1d7c-694e-4f66-8905-8e528f137d27"), new Guid("9fd0c929-c39e-4d21-aaf5-9b27058637e2") },
                    { new Guid("a09065d0-2be8-4094-a267-526738597853"), new Guid("f2e16642-5d10-4195-8bc6-8b9dbb9dbd5a"), new Guid("cf50b71c-4055-4276-8f82-e9e91ce88049") },
                    { new Guid("a09b3437-7569-4a89-8a13-219a1efae6d7"), new Guid("bcb0671f-572a-4495-b5df-3f2865e081b2"), new Guid("d89f6658-aa9a-46ba-bef9-35538a7129b5") },
                    { new Guid("a402d9a5-424c-4759-a6c8-563b94cc3664"), new Guid("f2e16642-5d10-4195-8bc6-8b9dbb9dbd5a"), new Guid("5793b9c8-72ce-47c6-93ca-4c5c7f032b98") },
                    { new Guid("a658ed79-9786-4de7-9d79-af0c4bc1a51d"), new Guid("81d19ab4-52a1-4e47-9766-2c7b682e89b3"), new Guid("11320d49-4294-4e52-bf32-2381dfed3ac4") },
                    { new Guid("a792c476-29c9-4ca5-b4a6-e4d3093a3a13"), new Guid("87f352c1-ef43-41fb-b5c1-3a46e51868b8"), new Guid("40919dca-43b0-40fd-8d3e-f8054cfa3ef5") },
                    { new Guid("a84ee843-332e-4b5e-a2b9-d92767d1c1f9"), new Guid("f2e16642-5d10-4195-8bc6-8b9dbb9dbd5a"), new Guid("617a9867-2fcc-4d05-8bb8-857689a35b17") },
                    { new Guid("abfa5816-669c-4442-a947-79dc5773cb29"), new Guid("640e13de-bd1e-4088-8651-44be51f2451d"), new Guid("9371a131-4d36-4b46-8d1f-82a6f4763534") },
                    { new Guid("aee5ac47-c514-422c-ad07-977cc91d33cc"), new Guid("d8956234-3e1b-4c14-ae78-9b7f1f598ef2"), new Guid("cea1e4bf-cc0c-44d7-992c-31b81dc72d74") },
                    { new Guid("afc8be46-b8b5-4b09-b6f6-26d0678ad598"), new Guid("640e13de-bd1e-4088-8651-44be51f2451d"), new Guid("88b66b3b-b3d2-42cd-90ec-39788d0dd512") },
                    { new Guid("bbd494c1-0ce6-4886-bdbb-0e291f8e3a1b"), new Guid("81d19ab4-52a1-4e47-9766-2c7b682e89b3"), new Guid("6daaee3d-1e84-4408-aff9-eb7c02a25b14") },
                    { new Guid("bdb42fee-edc1-4a9e-a1dc-e752fc8c77ac"), new Guid("573a1d7c-694e-4f66-8905-8e528f137d27"), new Guid("d570d995-f615-42d7-9456-36a29a129d29") },
                    { new Guid("c079d25c-ce0a-4f49-89f8-1e054852506c"), new Guid("d8956234-3e1b-4c14-ae78-9b7f1f598ef2"), new Guid("9eb5a8fa-911f-4310-901b-f50ff0bf7b39") },
                    { new Guid("c1008ac3-0ddc-47ae-8689-6657dfce1b01"), new Guid("bcb0671f-572a-4495-b5df-3f2865e081b2"), new Guid("0dc97df0-976b-4816-be51-a2f491027c1a") },
                    { new Guid("c31d1ffa-7f32-426a-90e4-9f3d997c28bb"), new Guid("640e13de-bd1e-4088-8651-44be51f2451d"), new Guid("3c7b9e52-2e80-427a-a4f1-4a1cf80fd412") },
                    { new Guid("c48ae4a3-1d3c-4487-bdfd-361f96817454"), new Guid("87f352c1-ef43-41fb-b5c1-3a46e51868b8"), new Guid("52a6e6da-9d3e-4905-aa5e-a0745496d056") },
                    { new Guid("c7f40952-b113-4351-8537-01e5fd3ebae9"), new Guid("81d19ab4-52a1-4e47-9766-2c7b682e89b3"), new Guid("ea4afb6e-40d3-43b7-bcb3-ffea7591cc82") },
                    { new Guid("c84b5757-2df3-4934-b3b3-58de2e3c0044"), new Guid("87f352c1-ef43-41fb-b5c1-3a46e51868b8"), new Guid("063c93e9-5785-48ab-bd62-c52ea0c654b9") },
                    { new Guid("c87d15f6-02ce-4101-8b3e-cfb30ff03969"), new Guid("bcb0671f-572a-4495-b5df-3f2865e081b2"), new Guid("38e68a81-9342-4cd5-ae18-b0e08b92a9c6") },
                    { new Guid("c8bf8fe9-ddfd-42c8-bda6-fddf301289a0"), new Guid("81d19ab4-52a1-4e47-9766-2c7b682e89b3"), new Guid("7b7345e4-8ac4-4dd4-a6c7-4bbd713494aa") },
                    { new Guid("c9215357-9122-4fa2-9c38-0eb275849f8a"), new Guid("d8956234-3e1b-4c14-ae78-9b7f1f598ef2"), new Guid("db66bffc-e43b-4721-9fb3-30083ff12e4f") },
                    { new Guid("d2f374a2-4e2b-44b8-95d5-c6af85ee2d2c"), new Guid("bcb0671f-572a-4495-b5df-3f2865e081b2"), new Guid("08613aac-be0b-48f2-ae01-c33bc68b12fe") },
                    { new Guid("d5d8b0c0-01f8-4546-a272-dd3ba425679f"), new Guid("573a1d7c-694e-4f66-8905-8e528f137d27"), new Guid("f77fad81-b88d-45fa-abc7-6842b0642cca") },
                    { new Guid("d6b3679e-e7b1-4625-8ab7-48771c70bb7a"), new Guid("81d19ab4-52a1-4e47-9766-2c7b682e89b3"), new Guid("8fa99920-8bd6-4da4-b530-fef34656fa2b") },
                    { new Guid("d83b9ba1-b86a-4b65-9f8d-eff70b55131a"), new Guid("573a1d7c-694e-4f66-8905-8e528f137d27"), new Guid("f26435c7-9fed-4a89-b125-32cc89a4ae69") },
                    { new Guid("dcd3027f-309e-4f11-906b-0b194351e0ce"), new Guid("d8956234-3e1b-4c14-ae78-9b7f1f598ef2"), new Guid("cf295a6b-92c8-4dd8-9044-27607055dd3c") },
                    { new Guid("dece33fd-e1e8-430f-b72c-fb5d9aa50c92"), new Guid("f2e16642-5d10-4195-8bc6-8b9dbb9dbd5a"), new Guid("9484a78d-b1fd-401e-904d-4d9ba1e30fea") },
                    { new Guid("df30f841-da2e-45b8-b0de-e20c2e77c4a5"), new Guid("573a1d7c-694e-4f66-8905-8e528f137d27"), new Guid("ded32561-2dda-4d56-b31b-3fd357d0c459") },
                    { new Guid("e73709de-84a4-4fa1-8425-4e9a35519772"), new Guid("f024e3f8-cf68-4c48-b288-b04e9c8b30c2"), new Guid("3b44f4ed-824b-4d78-ae64-937b1e43d741") },
                    { new Guid("eb86cede-29fd-4d70-8311-2952819337db"), new Guid("f024e3f8-cf68-4c48-b288-b04e9c8b30c2"), new Guid("a0c8d366-0d09-4d9c-9c54-e26517e258b7") },
                    { new Guid("ed102289-43e3-4f09-ac77-7586d8190d36"), new Guid("640e13de-bd1e-4088-8651-44be51f2451d"), new Guid("76a23627-35c3-4bb8-b9dc-65badf5e63f1") },
                    { new Guid("ee4a6bb5-5073-4507-a7fb-c4250c585deb"), new Guid("573a1d7c-694e-4f66-8905-8e528f137d27"), new Guid("10a03e67-246a-495c-8913-a1d6a9479d23") },
                    { new Guid("f39ba472-ebfe-4f7b-a08e-7e44de763a8d"), new Guid("f2e16642-5d10-4195-8bc6-8b9dbb9dbd5a"), new Guid("eebee09c-ddc4-43c4-9e1e-95c14f2bb1fb") },
                    { new Guid("f6405402-785d-478e-b808-1c429fd1e8db"), new Guid("81d19ab4-52a1-4e47-9766-2c7b682e89b3"), new Guid("da1fcc3b-1841-4e3b-b75b-1292385ef9bf") },
                    { new Guid("f6ecabb3-b4e8-4df9-8439-a629888cfc44"), new Guid("573a1d7c-694e-4f66-8905-8e528f137d27"), new Guid("a7edab83-5889-4e6a-9d2b-9a3fc504c29f") },
                    { new Guid("f80e4383-e550-4e30-8fb4-591ca146f31b"), new Guid("d8956234-3e1b-4c14-ae78-9b7f1f598ef2"), new Guid("28f6e7d4-af28-48c8-8def-3bac2538cb45") },
                    { new Guid("f8a1c865-eecc-4461-82b3-efbdec7a94a8"), new Guid("81d19ab4-52a1-4e47-9766-2c7b682e89b3"), new Guid("fcb99dc8-d3f3-4b11-93c1-b8356f4bd87d") },
                    { new Guid("facfb980-d1e8-4259-b86b-da451bfc3fe5"), new Guid("573a1d7c-694e-4f66-8905-8e528f137d27"), new Guid("73968f68-af90-4cda-9be5-5c4cffc43dab") },
                    { new Guid("fc502116-f60e-4663-b01a-5058d636d188"), new Guid("640e13de-bd1e-4088-8651-44be51f2451d"), new Guid("785f9d64-0f05-4aea-90f4-cbbcd7c9b946") }
                });

            migrationBuilder.InsertData(
                table: "TrackGenres",
                columns: new[] { "Id", "GenreId", "TrackId" },
                values: new object[,]
                {
                    { new Guid("00e154e8-5efb-4681-9b5d-8450c33227f5"), new Guid("da7a689b-5b29-4c88-91ad-b543ce614e12"), new Guid("93dc2a4e-e14b-4fb8-84b5-ab244110e423") },
                    { new Guid("0130e478-9027-4c0a-8294-f604d54e6620"), new Guid("e2a8929f-2190-4329-bae1-83b170a3677f"), new Guid("a9620719-90e7-41b1-9517-4ecc81693c73") },
                    { new Guid("023acdea-53b8-4426-b1d2-88c2a11e5118"), new Guid("e2a8929f-2190-4329-bae1-83b170a3677f"), new Guid("554abc99-8c15-450d-93fd-34f6cc16bf8b") },
                    { new Guid("059fb281-5577-4d86-ad9b-132ba61c6f10"), new Guid("68f6170a-12b9-4f32-9e83-c81c61ad29b6"), new Guid("0dc97df0-976b-4816-be51-a2f491027c1a") },
                    { new Guid("0631b438-bfa9-4693-b9fc-0118da1994b1"), new Guid("2f044c88-a983-4cf5-bcc1-a5d7764507ed"), new Guid("41863e97-3f34-4dab-8222-23494334fa4e") },
                    { new Guid("06d2c7d0-6967-49a2-9a2e-db47f37587ed"), new Guid("a579446d-0ca1-4aae-8cad-5126ab41c203"), new Guid("361a2eef-a9b0-4b5e-9c00-9bacfb5341a2") },
                    { new Guid("0807e8c7-214d-4e34-9b1b-6e1e65f1a124"), new Guid("a579446d-0ca1-4aae-8cad-5126ab41c203"), new Guid("d570d995-f615-42d7-9456-36a29a129d29") },
                    { new Guid("0a44e1a0-63e6-48ea-bc6e-293db8247f2d"), new Guid("2f044c88-a983-4cf5-bcc1-a5d7764507ed"), new Guid("6a5f1024-050b-432f-87cb-e9781c2da92f") },
                    { new Guid("0ce408df-0a77-49cf-b293-dd5c67460bbf"), new Guid("a579446d-0ca1-4aae-8cad-5126ab41c203"), new Guid("dd6be640-af8a-4190-8d2c-d0bb3198279f") },
                    { new Guid("0fc57dcf-3aca-4bc9-b98b-376dd82319c0"), new Guid("f13c6c62-c6e2-4a37-9c17-99c0e9d8db42"), new Guid("d41e2f9d-56a9-48a2-9003-cf0d1ecd91cb") },
                    { new Guid("1224809c-7b51-40bd-b958-4298f03cb8e1"), new Guid("e2a8929f-2190-4329-bae1-83b170a3677f"), new Guid("cf50b71c-4055-4276-8f82-e9e91ce88049") },
                    { new Guid("12fc8b0c-48a0-4e4d-b61a-5ad5fa2f4d3c"), new Guid("ac38a647-9bc3-4a14-ae64-8c50964e307d"), new Guid("5b6ab067-1e79-48bf-ac67-a4a478a64c15") },
                    { new Guid("148003d7-e4a6-404f-8b5e-a5aa56aa4d22"), new Guid("2f044c88-a983-4cf5-bcc1-a5d7764507ed"), new Guid("08711cd7-f5fe-47c8-9cd2-3fc5f22f93c3") },
                    { new Guid("158f29a6-4815-489f-8f23-8dc9c2996174"), new Guid("da7a689b-5b29-4c88-91ad-b543ce614e12"), new Guid("e0cfeeaa-d871-4352-b1bb-f0a3e222d0ae") },
                    { new Guid("18613a64-d7ec-4370-b768-f017d823de28"), new Guid("ac38a647-9bc3-4a14-ae64-8c50964e307d"), new Guid("0645bf34-df24-4681-a088-3430ac64f013") },
                    { new Guid("18ff88bb-27a7-40c3-a7bc-83fc93f766fe"), new Guid("da7a689b-5b29-4c88-91ad-b543ce614e12"), new Guid("cf295a6b-92c8-4dd8-9044-27607055dd3c") },
                    { new Guid("197cbfa2-7b5d-4cdb-b44b-0743a722e62d"), new Guid("e2a8929f-2190-4329-bae1-83b170a3677f"), new Guid("41863e97-3f34-4dab-8222-23494334fa4e") },
                    { new Guid("1cc3a5b2-f4ee-403a-b8e5-4d85f435aa5b"), new Guid("2f044c88-a983-4cf5-bcc1-a5d7764507ed"), new Guid("a9620719-90e7-41b1-9517-4ecc81693c73") },
                    { new Guid("1cff606f-2c20-4615-83c8-08241c19fa57"), new Guid("8ff3eaba-b2c6-4a1b-96c9-0f611d17e8c6"), new Guid("04a709fb-85ac-4a7b-b675-4b92f9c540da") },
                    { new Guid("1e69d074-5dff-4b91-b094-6e2bef32162a"), new Guid("7fa5ae48-7ed7-42a7-bb2a-4f4d0e502d7a"), new Guid("c8dc0367-e04e-442e-bc2a-3b64c858d3cb") },
                    { new Guid("1eb2fb88-26eb-4249-877b-cb6c727cdd0e"), new Guid("8745e56f-b335-43fe-bd10-bad6bead0892"), new Guid("f32391b1-d252-406f-a7f5-fe523c531e1d") },
                    { new Guid("2326697e-2ddf-4f2f-83bd-ec4ef7e51757"), new Guid("a579446d-0ca1-4aae-8cad-5126ab41c203"), new Guid("f90d17eb-8e83-4218-bdfd-807861a8e77a") },
                    { new Guid("23cff8e6-f54e-4694-8b4f-6d1810ca5ca8"), new Guid("8745e56f-b335-43fe-bd10-bad6bead0892"), new Guid("a0c8d366-0d09-4d9c-9c54-e26517e258b7") },
                    { new Guid("24af5938-a59e-4a92-9168-8bc7543d0ae7"), new Guid("f1344d39-707e-4a7f-82e7-0816c21206d8"), new Guid("d65c7a12-3a01-48c0-92b2-8a46fa0c3491") },
                    { new Guid("25cbf613-f4da-4690-a629-d0d7702f3bbe"), new Guid("2f044c88-a983-4cf5-bcc1-a5d7764507ed"), new Guid("23533d5b-5e56-46f4-a5d3-4cc138696854") },
                    { new Guid("262715cc-9916-4dfd-b0f9-936da772321b"), new Guid("b56de1bf-2c8e-4d1f-a727-9a5ebc3d6b2f"), new Guid("8fa99920-8bd6-4da4-b530-fef34656fa2b") },
                    { new Guid("26c663ea-9cfd-4c31-842e-a741ea6799f8"), new Guid("baa56e06-9672-4118-aee3-4098cec4581e"), new Guid("6daaee3d-1e84-4408-aff9-eb7c02a25b14") },
                    { new Guid("271b0a67-9268-4a7b-92fa-4846eca9aee3"), new Guid("da7a689b-5b29-4c88-91ad-b543ce614e12"), new Guid("f163d0c0-99b3-4ebd-be69-716b94f7d994") },
                    { new Guid("27409e8f-80e9-467b-8c58-172445437292"), new Guid("f13c6c62-c6e2-4a37-9c17-99c0e9d8db42"), new Guid("dd6be640-af8a-4190-8d2c-d0bb3198279f") },
                    { new Guid("276e5a2d-72c6-4f37-82eb-2a606e8896de"), new Guid("68f6170a-12b9-4f32-9e83-c81c61ad29b6"), new Guid("512a02cb-3b12-4ba4-b959-af37747ef1e9") },
                    { new Guid("2bc45f7a-a7bb-411b-bf1a-a716c143beae"), new Guid("ac38a647-9bc3-4a14-ae64-8c50964e307d"), new Guid("dc3a0d3f-204d-4efe-80c0-f590eb22baee") },
                    { new Guid("2bec9081-f915-4140-ac54-7ea8911582ad"), new Guid("a579446d-0ca1-4aae-8cad-5126ab41c203"), new Guid("32ec0969-1493-4960-97a8-32c068ad95c7") },
                    { new Guid("2c5759f0-b8f9-448d-ae59-75e54f9ce50d"), new Guid("a579446d-0ca1-4aae-8cad-5126ab41c203"), new Guid("bc28acab-30c4-4cb4-9201-0958ac78c822") },
                    { new Guid("2d4d783d-fa08-4501-84d6-51ac57f7eb5b"), new Guid("a579446d-0ca1-4aae-8cad-5126ab41c203"), new Guid("52126cb0-f858-4f29-bd76-fa480a15daf3") },
                    { new Guid("2db95364-b715-4f16-91f1-f2ca93c70017"), new Guid("d35e2479-8214-41f2-b6d6-59b892602f16"), new Guid("c25f19d4-883b-47a6-b2ba-05691f039db3") },
                    { new Guid("2df198b5-2c24-4686-a76a-99a46f418128"), new Guid("8c9c6d68-01f0-4e97-9640-d7a633788f53"), new Guid("4cb98d94-2541-45ec-a178-f32e4faf7ddf") },
                    { new Guid("2e026e13-c351-47f9-ba1e-982b88bd4844"), new Guid("8745e56f-b335-43fe-bd10-bad6bead0892"), new Guid("6daaee3d-1e84-4408-aff9-eb7c02a25b14") },
                    { new Guid("30c5a94b-3af1-4f09-be72-491f2c98de1c"), new Guid("8ff3eaba-b2c6-4a1b-96c9-0f611d17e8c6"), new Guid("38b6bae0-b77b-4547-9884-64ec9e9eaadc") },
                    { new Guid("3163b0ef-9360-403c-aaaf-2a6b447a871b"), new Guid("a579446d-0ca1-4aae-8cad-5126ab41c203"), new Guid("a9424a75-7dd3-4ddd-98d2-d7cd55fbbfc4") },
                    { new Guid("3196fcc9-89fe-4c6c-b858-73445d9ab15f"), new Guid("a579446d-0ca1-4aae-8cad-5126ab41c203"), new Guid("9a782ce1-740f-4009-ade0-d474616df4b4") },
                    { new Guid("3213ca3b-8c3e-4c75-8826-c06a77ad96ec"), new Guid("7fa5ae48-7ed7-42a7-bb2a-4f4d0e502d7a"), new Guid("a5cc759d-14b1-4015-8593-7c47d80a4b17") },
                    { new Guid("324ab2cf-acf6-4d8c-8e82-783e1c3bf12e"), new Guid("ae14797c-31cd-432a-b2de-b3db95a82ab4"), new Guid("342c4173-99cc-404f-82cb-e9672829926c") },
                    { new Guid("32fdd9e5-990e-4c76-bcc9-baebea5275d9"), new Guid("e2a8929f-2190-4329-bae1-83b170a3677f"), new Guid("9371a131-4d36-4b46-8d1f-82a6f4763534") },
                    { new Guid("338ecb09-90d3-4961-bd02-a214ee847dc8"), new Guid("2f044c88-a983-4cf5-bcc1-a5d7764507ed"), new Guid("1648caba-362b-4974-bcc5-78a4b241cc26") },
                    { new Guid("351be438-db4c-4478-bf4a-a2da02db4b63"), new Guid("b56de1bf-2c8e-4d1f-a727-9a5ebc3d6b2f"), new Guid("a7edab83-5889-4e6a-9d2b-9a3fc504c29f") },
                    { new Guid("37d06094-adca-4c3a-9cc7-80d863c1cc94"), new Guid("baa56e06-9672-4118-aee3-4098cec4581e"), new Guid("a0c8d366-0d09-4d9c-9c54-e26517e258b7") },
                    { new Guid("3802e654-9638-43b9-a62d-e37c7eb91767"), new Guid("baa56e06-9672-4118-aee3-4098cec4581e"), new Guid("a9620719-90e7-41b1-9517-4ecc81693c73") },
                    { new Guid("3cea2fa4-4bba-4a91-8420-7a52a0345f08"), new Guid("b56de1bf-2c8e-4d1f-a727-9a5ebc3d6b2f"), new Guid("251cf78c-9b90-4d8e-bcb5-0add3b3e7030") },
                    { new Guid("3df6f9d7-3ebd-422a-b1b4-caace59c5b01"), new Guid("da7a689b-5b29-4c88-91ad-b543ce614e12"), new Guid("5c4f6bf2-34da-43de-a5e4-860992d8cdf4") },
                    { new Guid("404a6fea-99ec-42f4-8689-84d20eab2e42"), new Guid("ac38a647-9bc3-4a14-ae64-8c50964e307d"), new Guid("5c4f6bf2-34da-43de-a5e4-860992d8cdf4") },
                    { new Guid("408c2c74-0194-4f18-a636-5f66e1e1d941"), new Guid("b56de1bf-2c8e-4d1f-a727-9a5ebc3d6b2f"), new Guid("c8dc0367-e04e-442e-bc2a-3b64c858d3cb") },
                    { new Guid("40ce9960-6014-4aeb-8292-52bb81d96adf"), new Guid("f13c6c62-c6e2-4a37-9c17-99c0e9d8db42"), new Guid("384e9aee-60f8-43ac-8c32-9ce084bf2003") },
                    { new Guid("40fd22b6-06ff-43ae-9777-c500eefa8212"), new Guid("f1344d39-707e-4a7f-82e7-0816c21206d8"), new Guid("c8dc0367-e04e-442e-bc2a-3b64c858d3cb") },
                    { new Guid("42ca3202-7f73-4097-aebf-b81aa421e2c6"), new Guid("d35e2479-8214-41f2-b6d6-59b892602f16"), new Guid("04a709fb-85ac-4a7b-b675-4b92f9c540da") },
                    { new Guid("441d18f8-749a-489c-be3f-a97411de9181"), new Guid("8c9c6d68-01f0-4e97-9640-d7a633788f53"), new Guid("1c8296c3-6bae-4036-8cf9-58ea04038866") },
                    { new Guid("4812e51c-cf75-419e-b1c8-a05f99622427"), new Guid("ae14797c-31cd-432a-b2de-b3db95a82ab4"), new Guid("172b01ab-8169-4c04-b54e-7cbfcb8a0931") },
                    { new Guid("49282b08-259b-40c1-ac19-e4acad0057a7"), new Guid("a579446d-0ca1-4aae-8cad-5126ab41c203"), new Guid("da8a67d5-ada2-47f8-8d17-7a8158e0ba79") },
                    { new Guid("4aa2d34e-cc93-4857-adbd-e830de085378"), new Guid("ae14797c-31cd-432a-b2de-b3db95a82ab4"), new Guid("ded32561-2dda-4d56-b31b-3fd357d0c459") },
                    { new Guid("4ceab309-27f7-43d9-8fd8-1f8443a6b36c"), new Guid("7fa5ae48-7ed7-42a7-bb2a-4f4d0e502d7a"), new Guid("fcb99dc8-d3f3-4b11-93c1-b8356f4bd87d") },
                    { new Guid("4f1a30f2-c3a8-4dbe-ac18-56f6a0a3c657"), new Guid("68f6170a-12b9-4f32-9e83-c81c61ad29b6"), new Guid("40919dca-43b0-40fd-8d3e-f8054cfa3ef5") },
                    { new Guid("4fe14143-b4b0-4b67-b47e-d67f61f5eac7"), new Guid("8ff3eaba-b2c6-4a1b-96c9-0f611d17e8c6"), new Guid("88b66b3b-b3d2-42cd-90ec-39788d0dd512") },
                    { new Guid("51373859-041a-49d0-af5e-697b8473e1ce"), new Guid("2f044c88-a983-4cf5-bcc1-a5d7764507ed"), new Guid("d3c49bac-f66f-41cd-ac63-46553f9d97d4") },
                    { new Guid("514c5a17-c279-4425-b428-a480c943a27f"), new Guid("d35e2479-8214-41f2-b6d6-59b892602f16"), new Guid("88b66b3b-b3d2-42cd-90ec-39788d0dd512") },
                    { new Guid("51788cfd-baab-4b09-99e8-01206b839b42"), new Guid("8745e56f-b335-43fe-bd10-bad6bead0892"), new Guid("08613aac-be0b-48f2-ae01-c33bc68b12fe") },
                    { new Guid("530aa234-08dc-439c-9b08-f41b00d71638"), new Guid("baa56e06-9672-4118-aee3-4098cec4581e"), new Guid("063c93e9-5785-48ab-bd62-c52ea0c654b9") },
                    { new Guid("560376ea-8e86-4a62-bf34-c20b796288f1"), new Guid("8745e56f-b335-43fe-bd10-bad6bead0892"), new Guid("2cacb4aa-113f-4acd-b677-816bae840b08") },
                    { new Guid("560f12c0-6a08-4bd7-82e8-b60a16bf23d2"), new Guid("2f044c88-a983-4cf5-bcc1-a5d7764507ed"), new Guid("3b44f4ed-824b-4d78-ae64-937b1e43d741") },
                    { new Guid("5610eb96-ed33-4df2-952a-d505a4c2d9de"), new Guid("2f044c88-a983-4cf5-bcc1-a5d7764507ed"), new Guid("9371a131-4d36-4b46-8d1f-82a6f4763534") },
                    { new Guid("59318713-ee64-485d-bd0f-811cecb87f36"), new Guid("8745e56f-b335-43fe-bd10-bad6bead0892"), new Guid("605a8a4a-8626-4f7a-8138-86597f0382ea") },
                    { new Guid("5a6bacc2-0519-4c8f-b53e-d91487cd4d23"), new Guid("8c9c6d68-01f0-4e97-9640-d7a633788f53"), new Guid("9eb5a8fa-911f-4310-901b-f50ff0bf7b39") },
                    { new Guid("5c77279c-d031-4c40-85b2-03990f80ffcc"), new Guid("f13c6c62-c6e2-4a37-9c17-99c0e9d8db42"), new Guid("8fa99920-8bd6-4da4-b530-fef34656fa2b") },
                    { new Guid("5f98833c-cec5-4fe1-a9d4-5ce1a1a72a9c"), new Guid("da7a689b-5b29-4c88-91ad-b543ce614e12"), new Guid("52a6e6da-9d3e-4905-aa5e-a0745496d056") },
                    { new Guid("60c69394-51cf-4844-a0f4-940807d2b598"), new Guid("d35e2479-8214-41f2-b6d6-59b892602f16"), new Guid("6a9090f3-4cb1-457b-8341-8d95786e2f93") },
                    { new Guid("61b3603b-f95a-4f9f-9dc5-23bebe24f56c"), new Guid("d35e2479-8214-41f2-b6d6-59b892602f16"), new Guid("7ff0824a-e240-4ddd-bd2d-9406f6296b53") },
                    { new Guid("61ed8324-ae4b-4896-ad9a-a949a71862a6"), new Guid("da7a689b-5b29-4c88-91ad-b543ce614e12"), new Guid("f7ce6650-bcf4-4137-b8ac-f7c0e5bcb7cb") },
                    { new Guid("62abe485-352d-40b6-8c86-ad93570b54c5"), new Guid("8745e56f-b335-43fe-bd10-bad6bead0892"), new Guid("785f9d64-0f05-4aea-90f4-cbbcd7c9b946") },
                    { new Guid("63457022-d786-4aa3-a4b2-3af80a2410d7"), new Guid("d35e2479-8214-41f2-b6d6-59b892602f16"), new Guid("cf295a6b-92c8-4dd8-9044-27607055dd3c") },
                    { new Guid("63b3be9c-2cfa-40f8-9e62-2c4e65052126"), new Guid("da7a689b-5b29-4c88-91ad-b543ce614e12"), new Guid("be25d676-8cdc-4e06-9294-586a7d37ff76") },
                    { new Guid("648685f2-6195-435e-85ff-450b53ce7304"), new Guid("7fa5ae48-7ed7-42a7-bb2a-4f4d0e502d7a"), new Guid("76a23627-35c3-4bb8-b9dc-65badf5e63f1") },
                    { new Guid("64a73d9d-80b9-4fcf-b240-f958b6c2d900"), new Guid("f13c6c62-c6e2-4a37-9c17-99c0e9d8db42"), new Guid("9a782ce1-740f-4009-ade0-d474616df4b4") },
                    { new Guid("65837291-1f4d-4269-9467-5e5fe5d743d6"), new Guid("baa56e06-9672-4118-aee3-4098cec4581e"), new Guid("d3c49bac-f66f-41cd-ac63-46553f9d97d4") },
                    { new Guid("65d6aa10-f355-41df-9183-37980eed51bd"), new Guid("f1344d39-707e-4a7f-82e7-0816c21206d8"), new Guid("92efc2af-14aa-43e3-a8b3-ed5c38d76311") },
                    { new Guid("675e8a90-607d-48b8-b5fe-5b346bf30dce"), new Guid("8ff3eaba-b2c6-4a1b-96c9-0f611d17e8c6"), new Guid("10a03e67-246a-495c-8913-a1d6a9479d23") },
                    { new Guid("6816dcc5-068f-4827-956e-a82ac75f9b43"), new Guid("2f044c88-a983-4cf5-bcc1-a5d7764507ed"), new Guid("3a67f4c9-f38f-4164-ac51-82dcf6b5bcbe") },
                    { new Guid("68dad198-a5fa-4c78-9cb0-3e08d1c3f706"), new Guid("da7a689b-5b29-4c88-91ad-b543ce614e12"), new Guid("3c7b9e52-2e80-427a-a4f1-4a1cf80fd412") },
                    { new Guid("6987d252-cc2e-4e92-8c8c-d0e4393b4db1"), new Guid("e2a8929f-2190-4329-bae1-83b170a3677f"), new Guid("8a2165b8-f201-421c-87ae-03642914a34b") },
                    { new Guid("6a14d0a2-a8f8-4671-bbbd-a4b3b855e687"), new Guid("8c9c6d68-01f0-4e97-9640-d7a633788f53"), new Guid("0dc97df0-976b-4816-be51-a2f491027c1a") },
                    { new Guid("6a9a76a4-453c-4299-bfb8-c2c0d78a75d5"), new Guid("f13c6c62-c6e2-4a37-9c17-99c0e9d8db42"), new Guid("9b5b7d9e-10aa-4aa0-b08c-b8d2779ccdb9") },
                    { new Guid("6ab0441a-7135-44c3-b4a3-52ed1d19082b"), new Guid("baa56e06-9672-4118-aee3-4098cec4581e"), new Guid("fa8b1dbc-ded8-4513-95a6-875e2d586270") },
                    { new Guid("6be52214-518b-4230-970f-6a2d165ded9f"), new Guid("baa56e06-9672-4118-aee3-4098cec4581e"), new Guid("9371a131-4d36-4b46-8d1f-82a6f4763534") },
                    { new Guid("6d08e917-6ffd-40bc-8756-85b4f966e41c"), new Guid("8ff3eaba-b2c6-4a1b-96c9-0f611d17e8c6"), new Guid("5cda7056-6608-4a10-b2ac-e4542a3a54c4") },
                    { new Guid("6d0e6dca-d069-47b9-939e-ec15800fda4f"), new Guid("ae14797c-31cd-432a-b2de-b3db95a82ab4"), new Guid("bf807e39-2791-4fa2-8dc3-64c145489720") },
                    { new Guid("6e451202-3d3a-40b1-a342-33f376f6d35a"), new Guid("baa56e06-9672-4118-aee3-4098cec4581e"), new Guid("da1fcc3b-1841-4e3b-b75b-1292385ef9bf") },
                    { new Guid("6f7ea324-feca-488c-ada8-09be1d64a088"), new Guid("68f6170a-12b9-4f32-9e83-c81c61ad29b6"), new Guid("eebee09c-ddc4-43c4-9e1e-95c14f2bb1fb") },
                    { new Guid("70443590-26b2-4885-bdea-0fa0151907df"), new Guid("ae14797c-31cd-432a-b2de-b3db95a82ab4"), new Guid("5ec063e4-d881-4aff-9a1d-c588255094f8") },
                    { new Guid("72f7123f-5120-4ea4-be80-c09da23fb071"), new Guid("d35e2479-8214-41f2-b6d6-59b892602f16"), new Guid("6bf3e7d0-b9b1-475c-8cec-dcd2fb7746d3") },
                    { new Guid("73314cd9-4b3d-4429-9abe-2a7db9d1c3f5"), new Guid("da7a689b-5b29-4c88-91ad-b543ce614e12"), new Guid("38e68a81-9342-4cd5-ae18-b0e08b92a9c6") },
                    { new Guid("7342525b-b3a2-4bfc-ae40-04aa3c3794d1"), new Guid("f13c6c62-c6e2-4a37-9c17-99c0e9d8db42"), new Guid("92efc2af-14aa-43e3-a8b3-ed5c38d76311") },
                    { new Guid("7342d8d8-86aa-4742-8847-074ecaf5b07b"), new Guid("8745e56f-b335-43fe-bd10-bad6bead0892"), new Guid("fa8b1dbc-ded8-4513-95a6-875e2d586270") },
                    { new Guid("73c80c70-8a28-4151-9119-fd995f1201ee"), new Guid("7fa5ae48-7ed7-42a7-bb2a-4f4d0e502d7a"), new Guid("40919dca-43b0-40fd-8d3e-f8054cfa3ef5") },
                    { new Guid("740958ee-6e90-4acd-b69c-96e3be8bd23e"), new Guid("ac38a647-9bc3-4a14-ae64-8c50964e307d"), new Guid("f7ce6650-bcf4-4137-b8ac-f7c0e5bcb7cb") },
                    { new Guid("7496ecfd-002f-4785-bf3c-0f380a98d82a"), new Guid("b56de1bf-2c8e-4d1f-a727-9a5ebc3d6b2f"), new Guid("92efc2af-14aa-43e3-a8b3-ed5c38d76311") },
                    { new Guid("75c230b3-68eb-4d7d-b3d6-b708ab51016c"), new Guid("e2a8929f-2190-4329-bae1-83b170a3677f"), new Guid("454bfdb6-4922-45b8-bd0d-33c38da31735") },
                    { new Guid("766ac47f-a9a2-4be1-b009-2766a826388a"), new Guid("7fa5ae48-7ed7-42a7-bb2a-4f4d0e502d7a"), new Guid("ea4afb6e-40d3-43b7-bcb3-ffea7591cc82") },
                    { new Guid("7709be92-a995-4111-a405-fae7204da545"), new Guid("d35e2479-8214-41f2-b6d6-59b892602f16"), new Guid("7ac102ca-5e6f-41ee-acc0-6b0e7941a9fd") },
                    { new Guid("7d723b1e-9def-4a34-9172-d82c13e870c5"), new Guid("2f044c88-a983-4cf5-bcc1-a5d7764507ed"), new Guid("cf50b71c-4055-4276-8f82-e9e91ce88049") },
                    { new Guid("7dab7752-52d0-48db-84f4-0a5b7b13a08e"), new Guid("da7a689b-5b29-4c88-91ad-b543ce614e12"), new Guid("bfe235f7-3597-4ae5-9413-e8e831b1911e") },
                    { new Guid("7ed241d6-7a63-4c27-b421-a79860f1a6ce"), new Guid("68f6170a-12b9-4f32-9e83-c81c61ad29b6"), new Guid("cea1e4bf-cc0c-44d7-992c-31b81dc72d74") },
                    { new Guid("80ff2e33-15f4-469b-af9d-b20c1c54a1f8"), new Guid("ac38a647-9bc3-4a14-ae64-8c50964e307d"), new Guid("454bfdb6-4922-45b8-bd0d-33c38da31735") },
                    { new Guid("81617f3f-092b-43e6-8ccb-7acbed3ff301"), new Guid("8c9c6d68-01f0-4e97-9640-d7a633788f53"), new Guid("512a02cb-3b12-4ba4-b959-af37747ef1e9") },
                    { new Guid("8311dde4-8772-46fa-97ce-f85cca38604e"), new Guid("e2a8929f-2190-4329-bae1-83b170a3677f"), new Guid("08711cd7-f5fe-47c8-9cd2-3fc5f22f93c3") },
                    { new Guid("846353a3-21b6-409e-b5fb-213d861907a8"), new Guid("8ff3eaba-b2c6-4a1b-96c9-0f611d17e8c6"), new Guid("c25f19d4-883b-47a6-b2ba-05691f039db3") },
                    { new Guid("852290eb-892a-405d-a78b-2e285907f5d5"), new Guid("e2a8929f-2190-4329-bae1-83b170a3677f"), new Guid("e9dbaa64-3eca-4ffa-b8dc-44e4fa30a620") },
                    { new Guid("864b5154-4a3b-4f7c-bb04-864afceb1a60"), new Guid("baa56e06-9672-4118-aee3-4098cec4581e"), new Guid("3b44f4ed-824b-4d78-ae64-937b1e43d741") },
                    { new Guid("87e3425b-88c2-43e9-a17d-928814810b3f"), new Guid("7fa5ae48-7ed7-42a7-bb2a-4f4d0e502d7a"), new Guid("0dc97df0-976b-4816-be51-a2f491027c1a") },
                    { new Guid("880f80b7-d379-4108-9dac-8fcf9077a7e7"), new Guid("f13c6c62-c6e2-4a37-9c17-99c0e9d8db42"), new Guid("361a2eef-a9b0-4b5e-9c00-9bacfb5341a2") },
                    { new Guid("8818b5a8-9273-44ab-abc1-f2f78c1bdc8e"), new Guid("ae14797c-31cd-432a-b2de-b3db95a82ab4"), new Guid("85f7c136-2ce9-4163-b01c-7beea05056a7") },
                    { new Guid("891b384a-547e-4874-a3d5-4ab389362d3a"), new Guid("68f6170a-12b9-4f32-9e83-c81c61ad29b6"), new Guid("d65c7a12-3a01-48c0-92b2-8a46fa0c3491") },
                    { new Guid("898f8644-3a9e-458d-b6fa-df3f9b5988df"), new Guid("2f044c88-a983-4cf5-bcc1-a5d7764507ed"), new Guid("617a9867-2fcc-4d05-8bb8-857689a35b17") },
                    { new Guid("8bdaba8e-ecf5-4959-8b54-ebc44f5e5dde"), new Guid("8ff3eaba-b2c6-4a1b-96c9-0f611d17e8c6"), new Guid("d570d995-f615-42d7-9456-36a29a129d29") },
                    { new Guid("8d45754b-d9f5-40a4-8742-114afd2e2b8b"), new Guid("ae14797c-31cd-432a-b2de-b3db95a82ab4"), new Guid("d89f6658-aa9a-46ba-bef9-35538a7129b5") },
                    { new Guid("8d4d73cc-0786-46da-89e8-474a85ad11b2"), new Guid("e2a8929f-2190-4329-bae1-83b170a3677f"), new Guid("7b7345e4-8ac4-4dd4-a6c7-4bbd713494aa") },
                    { new Guid("8e9f3348-da01-41b2-a380-3ccb25acd585"), new Guid("2f044c88-a983-4cf5-bcc1-a5d7764507ed"), new Guid("8a2165b8-f201-421c-87ae-03642914a34b") },
                    { new Guid("8eb3cfdc-7d4a-4c99-9397-c5310c8103d4"), new Guid("68f6170a-12b9-4f32-9e83-c81c61ad29b6"), new Guid("1c8296c3-6bae-4036-8cf9-58ea04038866") },
                    { new Guid("90954774-3fd3-4a97-a137-dfd7875d961f"), new Guid("baa56e06-9672-4118-aee3-4098cec4581e"), new Guid("85f7c136-2ce9-4163-b01c-7beea05056a7") },
                    { new Guid("91231815-a53c-482c-ae3a-39a1687c7ea3"), new Guid("f1344d39-707e-4a7f-82e7-0816c21206d8"), new Guid("8fa99920-8bd6-4da4-b530-fef34656fa2b") },
                    { new Guid("91d5882e-cd12-44b3-9dd2-9c56ce091fb1"), new Guid("8c9c6d68-01f0-4e97-9640-d7a633788f53"), new Guid("40919dca-43b0-40fd-8d3e-f8054cfa3ef5") },
                    { new Guid("9241a317-2a40-4acd-ad9f-70d9189ca084"), new Guid("f1344d39-707e-4a7f-82e7-0816c21206d8"), new Guid("ea4afb6e-40d3-43b7-bcb3-ffea7591cc82") },
                    { new Guid("929569fd-bc78-4d28-85bd-d3874b2d2155"), new Guid("8ff3eaba-b2c6-4a1b-96c9-0f611d17e8c6"), new Guid("6a9090f3-4cb1-457b-8341-8d95786e2f93") },
                    { new Guid("93648c12-a28c-445f-96d0-6118b226afe5"), new Guid("ae14797c-31cd-432a-b2de-b3db95a82ab4"), new Guid("785f9d64-0f05-4aea-90f4-cbbcd7c9b946") },
                    { new Guid("93d8c9cd-01bb-4760-b973-87219522f59a"), new Guid("ac38a647-9bc3-4a14-ae64-8c50964e307d"), new Guid("e0cfeeaa-d871-4352-b1bb-f0a3e222d0ae") },
                    { new Guid("953502ce-b7c9-4426-970a-a32103599dfc"), new Guid("8745e56f-b335-43fe-bd10-bad6bead0892"), new Guid("3a67f4c9-f38f-4164-ac51-82dcf6b5bcbe") },
                    { new Guid("98c33efa-35d3-4c44-835e-4d73d158e4b4"), new Guid("f1344d39-707e-4a7f-82e7-0816c21206d8"), new Guid("73968f68-af90-4cda-9be5-5c4cffc43dab") },
                    { new Guid("98eccc18-bd1e-4f3b-9aba-93bd2517e8aa"), new Guid("f13c6c62-c6e2-4a37-9c17-99c0e9d8db42"), new Guid("a7edab83-5889-4e6a-9d2b-9a3fc504c29f") },
                    { new Guid("991a473e-b0ce-41e1-b74b-33f108115465"), new Guid("b56de1bf-2c8e-4d1f-a727-9a5ebc3d6b2f"), new Guid("5793b9c8-72ce-47c6-93ca-4c5c7f032b98") },
                    { new Guid("9cb07e46-7f8b-4b22-a38e-c38eb7fed786"), new Guid("baa56e06-9672-4118-aee3-4098cec4581e"), new Guid("9fd0c929-c39e-4d21-aaf5-9b27058637e2") },
                    { new Guid("a335c94f-bf10-4f7f-bab3-6e0c2f281a12"), new Guid("da7a689b-5b29-4c88-91ad-b543ce614e12"), new Guid("f26435c7-9fed-4a89-b125-32cc89a4ae69") },
                    { new Guid("a364b329-f408-4466-99f1-a0ac36bc78f8"), new Guid("baa56e06-9672-4118-aee3-4098cec4581e"), new Guid("617a9867-2fcc-4d05-8bb8-857689a35b17") },
                    { new Guid("a440699c-1d8e-4a51-81a2-cd2338348bd1"), new Guid("a579446d-0ca1-4aae-8cad-5126ab41c203"), new Guid("9b5b7d9e-10aa-4aa0-b08c-b8d2779ccdb9") },
                    { new Guid("a4a2ab6f-ff72-4f0f-806a-10eec3680688"), new Guid("f13c6c62-c6e2-4a37-9c17-99c0e9d8db42"), new Guid("bc28acab-30c4-4cb4-9201-0958ac78c822") },
                    { new Guid("a609e653-e097-410e-b001-54ec5c77ca55"), new Guid("8745e56f-b335-43fe-bd10-bad6bead0892"), new Guid("85f7c136-2ce9-4163-b01c-7beea05056a7") },
                    { new Guid("a64e4069-fb6d-49c4-9335-a1537129235a"), new Guid("f1344d39-707e-4a7f-82e7-0816c21206d8"), new Guid("251cf78c-9b90-4d8e-bcb5-0add3b3e7030") },
                    { new Guid("a6779590-f3da-4990-98e4-8a892efcccd2"), new Guid("ae14797c-31cd-432a-b2de-b3db95a82ab4"), new Guid("48b05998-fb99-4693-98af-af675b4ddf46") },
                    { new Guid("a7510a3f-967b-4b13-8903-2aebf43e152d"), new Guid("8c9c6d68-01f0-4e97-9640-d7a633788f53"), new Guid("11320d49-4294-4e52-bf32-2381dfed3ac4") },
                    { new Guid("a83e4b75-e54d-4f7a-aeac-13627aa4119c"), new Guid("a579446d-0ca1-4aae-8cad-5126ab41c203"), new Guid("231eb456-d1fb-4f25-a4a8-9c4c559e4c2f") },
                    { new Guid("a9abbfb3-f0e7-4a8a-be7c-b1bb1e92c6d0"), new Guid("7fa5ae48-7ed7-42a7-bb2a-4f4d0e502d7a"), new Guid("5793b9c8-72ce-47c6-93ca-4c5c7f032b98") },
                    { new Guid("ab802659-069e-42ac-9089-95293c1d28c1"), new Guid("d35e2479-8214-41f2-b6d6-59b892602f16"), new Guid("a9424a75-7dd3-4ddd-98d2-d7cd55fbbfc4") },
                    { new Guid("ac8c7b21-8a8d-40ca-99c0-d1b5850effad"), new Guid("ac38a647-9bc3-4a14-ae64-8c50964e307d"), new Guid("7b7345e4-8ac4-4dd4-a6c7-4bbd713494aa") },
                    { new Guid("aeb0bfeb-0b9d-42c6-8d26-6d1e2cfadc47"), new Guid("ac38a647-9bc3-4a14-ae64-8c50964e307d"), new Guid("9154c3ac-6c9d-429c-a732-6bfe671b36fa") },
                    { new Guid("b0307687-dae2-4fe4-9c5f-b818ce1b6a87"), new Guid("ae14797c-31cd-432a-b2de-b3db95a82ab4"), new Guid("08613aac-be0b-48f2-ae01-c33bc68b12fe") },
                    { new Guid("b2387db4-e4f4-4d75-a50c-1867f85dd49c"), new Guid("68f6170a-12b9-4f32-9e83-c81c61ad29b6"), new Guid("32496198-3ed2-46d6-a0ce-5403983fcbca") },
                    { new Guid("b2939f34-0b4b-4cc3-8518-74ab57751d88"), new Guid("8745e56f-b335-43fe-bd10-bad6bead0892"), new Guid("905917ab-51b5-402a-8367-9dc3256cf1f2") },
                    { new Guid("b3525a2c-a391-4ac4-8e25-6da915eb0a1b"), new Guid("68f6170a-12b9-4f32-9e83-c81c61ad29b6"), new Guid("ea4afb6e-40d3-43b7-bcb3-ffea7591cc82") },
                    { new Guid("b4aa0c45-50aa-4436-90f7-6fdbfc0c9463"), new Guid("f13c6c62-c6e2-4a37-9c17-99c0e9d8db42"), new Guid("da8a67d5-ada2-47f8-8d17-7a8158e0ba79") },
                    { new Guid("b6cca443-9e95-46bb-a5b3-d0164494162b"), new Guid("a579446d-0ca1-4aae-8cad-5126ab41c203"), new Guid("6bf3e7d0-b9b1-475c-8cec-dcd2fb7746d3") },
                    { new Guid("b7341058-2934-402a-8952-5c02f6bf6139"), new Guid("ac38a647-9bc3-4a14-ae64-8c50964e307d"), new Guid("44eae267-b790-48d3-8304-0059c7f5652e") },
                    { new Guid("b8c14f39-f970-4435-b82e-d777ccd7d825"), new Guid("a579446d-0ca1-4aae-8cad-5126ab41c203"), new Guid("10a03e67-246a-495c-8913-a1d6a9479d23") },
                    { new Guid("b99b57fc-57f6-45cd-a0a8-61072a83f57b"), new Guid("b56de1bf-2c8e-4d1f-a727-9a5ebc3d6b2f"), new Guid("32ec0969-1493-4960-97a8-32c068ad95c7") },
                    { new Guid("baa8e740-1cb9-4226-8aee-7b103cc1d1a6"), new Guid("baa56e06-9672-4118-aee3-4098cec4581e"), new Guid("2cacb4aa-113f-4acd-b677-816bae840b08") },
                    { new Guid("bab5df6e-7768-4c5b-9d90-471977fcd6cb"), new Guid("b56de1bf-2c8e-4d1f-a727-9a5ebc3d6b2f"), new Guid("36584c54-91b8-42fb-af1d-19025d24c68c") },
                    { new Guid("bb71c6a6-8b16-47fe-b68e-3f1ef41ddff7"), new Guid("7fa5ae48-7ed7-42a7-bb2a-4f4d0e502d7a"), new Guid("251cf78c-9b90-4d8e-bcb5-0add3b3e7030") },
                    { new Guid("bc17ac7d-ac3d-48a3-8631-8bf387a91bc6"), new Guid("8c9c6d68-01f0-4e97-9640-d7a633788f53"), new Guid("32496198-3ed2-46d6-a0ce-5403983fcbca") },
                    { new Guid("bc225b92-9fca-44ab-b1f5-c02f32fea448"), new Guid("d35e2479-8214-41f2-b6d6-59b892602f16"), new Guid("5cda7056-6608-4a10-b2ac-e4542a3a54c4") },
                    { new Guid("bd7a52c8-ba27-4b27-ada8-f781fe006385"), new Guid("da7a689b-5b29-4c88-91ad-b543ce614e12"), new Guid("dc3a0d3f-204d-4efe-80c0-f590eb22baee") },
                    { new Guid("bdba4590-4c38-4a9e-8e62-e8f41f60dbf8"), new Guid("8745e56f-b335-43fe-bd10-bad6bead0892"), new Guid("3ffcd571-109a-4732-9816-ec12eb52580e") },
                    { new Guid("be38c34e-7843-45f4-9da1-9a7ee8b4a28c"), new Guid("8ff3eaba-b2c6-4a1b-96c9-0f611d17e8c6"), new Guid("6bf3e7d0-b9b1-475c-8cec-dcd2fb7746d3") },
                    { new Guid("c0405293-c079-41ed-bfc8-bf2668058459"), new Guid("8ff3eaba-b2c6-4a1b-96c9-0f611d17e8c6"), new Guid("6cd2e038-f910-471b-93dc-94d636675584") },
                    { new Guid("c0bbc10e-cacd-4573-8154-b84cbada6afa"), new Guid("e2a8929f-2190-4329-bae1-83b170a3677f"), new Guid("dc3a0d3f-204d-4efe-80c0-f590eb22baee") },
                    { new Guid("c1037ab7-de62-442f-9757-6d1d8901ddc1"), new Guid("ae14797c-31cd-432a-b2de-b3db95a82ab4"), new Guid("5ec151a2-8644-4e89-923d-8003d5d4cbc1") },
                    { new Guid("c19b71a5-3ad4-48c4-983e-a606a29c8fee"), new Guid("8c9c6d68-01f0-4e97-9640-d7a633788f53"), new Guid("fcb99dc8-d3f3-4b11-93c1-b8356f4bd87d") },
                    { new Guid("c2ec252f-bcb4-4773-b757-cc41f6c6809a"), new Guid("2f044c88-a983-4cf5-bcc1-a5d7764507ed"), new Guid("554abc99-8c15-450d-93fd-34f6cc16bf8b") },
                    { new Guid("c325d7b2-0e68-4c45-be43-3e3ef9eb8281"), new Guid("ac38a647-9bc3-4a14-ae64-8c50964e307d"), new Guid("f163d0c0-99b3-4ebd-be69-716b94f7d994") },
                    { new Guid("c3d6e611-9bdb-4368-a89c-b1b5762bd4fb"), new Guid("8ff3eaba-b2c6-4a1b-96c9-0f611d17e8c6"), new Guid("9b5b7d9e-10aa-4aa0-b08c-b8d2779ccdb9") },
                    { new Guid("c6c38341-b1b8-4bfb-ac5b-ae6a6ee7d9be"), new Guid("8745e56f-b335-43fe-bd10-bad6bead0892"), new Guid("342c4173-99cc-404f-82cb-e9672829926c") },
                    { new Guid("c705da26-2c59-4f22-9b13-e3f1cbe0b969"), new Guid("e2a8929f-2190-4329-bae1-83b170a3677f"), new Guid("d3c49bac-f66f-41cd-ac63-46553f9d97d4") },
                    { new Guid("c74566f6-781d-4bbe-ac37-03fd614915d0"), new Guid("8745e56f-b335-43fe-bd10-bad6bead0892"), new Guid("d540bd3c-870a-4e1b-b575-80069b4dd27b") },
                    { new Guid("c7c21788-a411-41f0-a1bf-394bbeb946f3"), new Guid("8ff3eaba-b2c6-4a1b-96c9-0f611d17e8c6"), new Guid("85efc138-f29f-4d8e-9b05-da95bec1e203") },
                    { new Guid("c8d6cc85-9640-4632-a418-bfbb64531d3f"), new Guid("b56de1bf-2c8e-4d1f-a727-9a5ebc3d6b2f"), new Guid("f25a4e62-4663-4aa4-a3f5-c2bc06af9b23") },
                    { new Guid("caecd05e-6810-4f60-bbd6-a8f1740abb28"), new Guid("e2a8929f-2190-4329-bae1-83b170a3677f"), new Guid("9154c3ac-6c9d-429c-a732-6bfe671b36fa") },
                    { new Guid("cbffc7b8-d96f-4cc0-87a5-6c307fdc99f9"), new Guid("7fa5ae48-7ed7-42a7-bb2a-4f4d0e502d7a"), new Guid("32496198-3ed2-46d6-a0ce-5403983fcbca") },
                    { new Guid("ccbe33eb-cd44-4de7-a9dd-7f0cc9224f48"), new Guid("d35e2479-8214-41f2-b6d6-59b892602f16"), new Guid("d95f9b2b-bee0-4105-b0a8-680db66cd032") },
                    { new Guid("ccfc275f-f595-4580-8168-ad582dd9ae2e"), new Guid("8ff3eaba-b2c6-4a1b-96c9-0f611d17e8c6"), new Guid("28f6e7d4-af28-48c8-8def-3bac2538cb45") },
                    { new Guid("d069c05b-4a40-4f2c-9959-e401d8460f39"), new Guid("d35e2479-8214-41f2-b6d6-59b892602f16"), new Guid("38e68a81-9342-4cd5-ae18-b0e08b92a9c6") },
                    { new Guid("d2b51b76-e58e-436f-923e-348f89118783"), new Guid("f1344d39-707e-4a7f-82e7-0816c21206d8"), new Guid("76a23627-35c3-4bb8-b9dc-65badf5e63f1") },
                    { new Guid("d376c721-a9f4-43e4-aad5-2b4e6ccb2fce"), new Guid("8ff3eaba-b2c6-4a1b-96c9-0f611d17e8c6"), new Guid("7ac102ca-5e6f-41ee-acc0-6b0e7941a9fd") },
                    { new Guid("d6650198-e3fc-4c35-bb5b-dd73354c0f5b"), new Guid("ae14797c-31cd-432a-b2de-b3db95a82ab4"), new Guid("d540bd3c-870a-4e1b-b575-80069b4dd27b") },
                    { new Guid("d94b9365-87a2-400a-80a7-b2b7f61ab635"), new Guid("8745e56f-b335-43fe-bd10-bad6bead0892"), new Guid("9b7ad1c8-fdd9-4b7a-891b-e7270998f885") },
                    { new Guid("dba3e222-c3bb-4968-a010-d07d8e67a98b"), new Guid("b56de1bf-2c8e-4d1f-a727-9a5ebc3d6b2f"), new Guid("76a23627-35c3-4bb8-b9dc-65badf5e63f1") },
                    { new Guid("dbd2abc0-8921-4efb-ad6d-f5751706a3be"), new Guid("a579446d-0ca1-4aae-8cad-5126ab41c203"), new Guid("9484a78d-b1fd-401e-904d-4d9ba1e30fea") },
                    { new Guid("dc438c1d-b131-48b5-bb0d-72f2aa2c418c"), new Guid("ac38a647-9bc3-4a14-ae64-8c50964e307d"), new Guid("f26435c7-9fed-4a89-b125-32cc89a4ae69") },
                    { new Guid("dccc418f-ebe9-472a-94a0-e0c8f00e77f1"), new Guid("d35e2479-8214-41f2-b6d6-59b892602f16"), new Guid("5c4f6bf2-34da-43de-a5e4-860992d8cdf4") },
                    { new Guid("ddbf2171-4f2c-4c9f-ba46-6f12c978ddf4"), new Guid("ac38a647-9bc3-4a14-ae64-8c50964e307d"), new Guid("554abc99-8c15-450d-93fd-34f6cc16bf8b") },
                    { new Guid("de2ca510-40b0-4358-be2a-701d13edf858"), new Guid("baa56e06-9672-4118-aee3-4098cec4581e"), new Guid("3a67f4c9-f38f-4164-ac51-82dcf6b5bcbe") },
                    { new Guid("df660d51-f7f5-4529-9736-497aeb6c0ae1"), new Guid("ae14797c-31cd-432a-b2de-b3db95a82ab4"), new Guid("9b7ad1c8-fdd9-4b7a-891b-e7270998f885") },
                    { new Guid("e007f8ef-dac7-4088-9d46-ba1dc4bccb4b"), new Guid("f1344d39-707e-4a7f-82e7-0816c21206d8"), new Guid("5793b9c8-72ce-47c6-93ca-4c5c7f032b98") },
                    { new Guid("e0eb7395-1873-4e3b-aad8-1283592638a6"), new Guid("da7a689b-5b29-4c88-91ad-b543ce614e12"), new Guid("76d9e174-1e56-4e71-ab06-673753e381aa") },
                    { new Guid("e13245f7-83e8-416c-a49d-c3d03d81c45e"), new Guid("da7a689b-5b29-4c88-91ad-b543ce614e12"), new Guid("c25f19d4-883b-47a6-b2ba-05691f039db3") },
                    { new Guid("e15d789e-a0b5-4912-af82-6b939f8ed6a0"), new Guid("b56de1bf-2c8e-4d1f-a727-9a5ebc3d6b2f"), new Guid("dd6be640-af8a-4190-8d2c-d0bb3198279f") },
                    { new Guid("e227e860-b35b-473b-af15-bcd6c7de8fd8"), new Guid("f1344d39-707e-4a7f-82e7-0816c21206d8"), new Guid("a5cc759d-14b1-4015-8593-7c47d80a4b17") },
                    { new Guid("e4ffbd0f-76ff-4b52-98e6-693c220e4a39"), new Guid("ae14797c-31cd-432a-b2de-b3db95a82ab4"), new Guid("f32391b1-d252-406f-a7f5-fe523c531e1d") },
                    { new Guid("e6a298d2-db45-4ba0-b120-004529216c55"), new Guid("ae14797c-31cd-432a-b2de-b3db95a82ab4"), new Guid("11320d49-4294-4e52-bf32-2381dfed3ac4") },
                    { new Guid("e7c4de10-7fbe-4fdc-b9b2-486c9661fc5f"), new Guid("ae14797c-31cd-432a-b2de-b3db95a82ab4"), new Guid("905917ab-51b5-402a-8367-9dc3256cf1f2") },
                    { new Guid("e938b9da-5a49-4476-8ea1-7d5a3d7773b6"), new Guid("d35e2479-8214-41f2-b6d6-59b892602f16"), new Guid("f77fad81-b88d-45fa-abc7-6842b0642cca") },
                    { new Guid("ecfe62a3-0e7c-454b-8f56-1c198a63a1a9"), new Guid("ae14797c-31cd-432a-b2de-b3db95a82ab4"), new Guid("4cb98d94-2541-45ec-a178-f32e4faf7ddf") },
                    { new Guid("ef5d1f16-c991-4c82-b42b-0871d8e7062a"), new Guid("e2a8929f-2190-4329-bae1-83b170a3677f"), new Guid("3b44f4ed-824b-4d78-ae64-937b1e43d741") },
                    { new Guid("f09965dc-dc37-4fa7-835b-fe5f79f08393"), new Guid("b56de1bf-2c8e-4d1f-a727-9a5ebc3d6b2f"), new Guid("da8a67d5-ada2-47f8-8d17-7a8158e0ba79") },
                    { new Guid("f139f0d6-a1c4-468a-b87e-44740df37a73"), new Guid("2f044c88-a983-4cf5-bcc1-a5d7764507ed"), new Guid("7b7345e4-8ac4-4dd4-a6c7-4bbd713494aa") },
                    { new Guid("f149570a-5bbe-4862-ba08-88a0184aaa01"), new Guid("ac38a647-9bc3-4a14-ae64-8c50964e307d"), new Guid("41863e97-3f34-4dab-8222-23494334fa4e") },
                    { new Guid("f24e701e-9ade-4bc2-a0fa-22cc40b887b0"), new Guid("baa56e06-9672-4118-aee3-4098cec4581e"), new Guid("db66bffc-e43b-4721-9fb3-30083ff12e4f") },
                    { new Guid("f25380e3-d362-472f-b56a-fd0a13aaad60"), new Guid("d35e2479-8214-41f2-b6d6-59b892602f16"), new Guid("93dc2a4e-e14b-4fb8-84b5-ab244110e423") },
                    { new Guid("f31d8810-8f42-442f-9580-972d92e63723"), new Guid("e2a8929f-2190-4329-bae1-83b170a3677f"), new Guid("23533d5b-5e56-46f4-a5d3-4cc138696854") },
                    { new Guid("f3e307ae-5d38-4fda-9140-a541a6960760"), new Guid("ac38a647-9bc3-4a14-ae64-8c50964e307d"), new Guid("38e68a81-9342-4cd5-ae18-b0e08b92a9c6") },
                    { new Guid("f48a8b13-5bbd-40e0-9016-d49e6cf961b7"), new Guid("8745e56f-b335-43fe-bd10-bad6bead0892"), new Guid("80890b51-f7e0-4302-882b-1e60a79d2315") },
                    { new Guid("f7884b02-1364-478d-9d34-14e3452d8f21"), new Guid("68f6170a-12b9-4f32-9e83-c81c61ad29b6"), new Guid("fcb99dc8-d3f3-4b11-93c1-b8356f4bd87d") },
                    { new Guid("f84440cf-bbec-4848-87c3-9a9b017aceac"), new Guid("8ff3eaba-b2c6-4a1b-96c9-0f611d17e8c6"), new Guid("a9424a75-7dd3-4ddd-98d2-d7cd55fbbfc4") },
                    { new Guid("f9aae558-a2d0-470c-8768-f88cf63607d2"), new Guid("7fa5ae48-7ed7-42a7-bb2a-4f4d0e502d7a"), new Guid("d65c7a12-3a01-48c0-92b2-8a46fa0c3491") },
                    { new Guid("fd8d3b7e-aada-455c-b3cf-0468ea83515f"), new Guid("baa56e06-9672-4118-aee3-4098cec4581e"), new Guid("342c4173-99cc-404f-82cb-e9672829926c") },
                    { new Guid("fdac907a-c0dd-4601-9360-9260f7cb0337"), new Guid("f13c6c62-c6e2-4a37-9c17-99c0e9d8db42"), new Guid("32ec0969-1493-4960-97a8-32c068ad95c7") },
                    { new Guid("fedc5890-2a0c-40fc-a9dd-e3c51cca332a"), new Guid("f1344d39-707e-4a7f-82e7-0816c21206d8"), new Guid("36584c54-91b8-42fb-af1d-19025d24c68c") },
                    { new Guid("ff6201ea-e727-4db7-9cc2-c7625dbfab00"), new Guid("f13c6c62-c6e2-4a37-9c17-99c0e9d8db42"), new Guid("231eb456-d1fb-4f25-a4a8-9c4c559e4c2f") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TrackGenres_GenreId",
                table: "TrackGenres",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_TrackGenres_TrackId",
                table: "TrackGenres",
                column: "TrackId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TrackGenres");

            migrationBuilder.DeleteData(
                table: "ArtistAlbums",
                keyColumn: "Id",
                keyValue: new Guid("036d4d0b-dac8-466c-b818-808135398925"));

            migrationBuilder.DeleteData(
                table: "ArtistAlbums",
                keyColumn: "Id",
                keyValue: new Guid("07326b5b-2aff-4714-82a9-84752c4e5dfc"));

            migrationBuilder.DeleteData(
                table: "ArtistAlbums",
                keyColumn: "Id",
                keyValue: new Guid("0eeb26f2-b91c-4aa8-b802-40274b727f43"));

            migrationBuilder.DeleteData(
                table: "ArtistAlbums",
                keyColumn: "Id",
                keyValue: new Guid("1fc50e93-9e47-4d8d-8d24-d6301ae5333d"));

            migrationBuilder.DeleteData(
                table: "ArtistAlbums",
                keyColumn: "Id",
                keyValue: new Guid("2026349a-fad9-4820-994e-fb4cf29694ff"));

            migrationBuilder.DeleteData(
                table: "ArtistAlbums",
                keyColumn: "Id",
                keyValue: new Guid("44252f96-d18b-4061-bb7e-8528bf2ca81b"));

            migrationBuilder.DeleteData(
                table: "ArtistAlbums",
                keyColumn: "Id",
                keyValue: new Guid("5a2a1672-8b86-4a4b-b991-a1d9b9a55f4f"));

            migrationBuilder.DeleteData(
                table: "ArtistAlbums",
                keyColumn: "Id",
                keyValue: new Guid("5d312d8f-b4f0-4e3e-bb4d-2a5e0b0a5852"));

            migrationBuilder.DeleteData(
                table: "ArtistAlbums",
                keyColumn: "Id",
                keyValue: new Guid("7885c9db-c6cb-44c2-be3e-ef8632fcbc4c"));

            migrationBuilder.DeleteData(
                table: "ArtistAlbums",
                keyColumn: "Id",
                keyValue: new Guid("8931706a-4462-4205-a2a1-aecff5967d3e"));

            migrationBuilder.DeleteData(
                table: "ArtistAlbums",
                keyColumn: "Id",
                keyValue: new Guid("9b9253bb-3c36-4dbe-b3b6-460a73b9d2ca"));

            migrationBuilder.DeleteData(
                table: "ArtistAlbums",
                keyColumn: "Id",
                keyValue: new Guid("bd271556-b143-4767-a355-23b21b3c7463"));

            migrationBuilder.DeleteData(
                table: "ArtistAlbums",
                keyColumn: "Id",
                keyValue: new Guid("f68e2d7c-8981-488a-9ac2-1c44f87d12f9"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("00f17f0b-4a11-42e5-a273-e55dd10458b0"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("012e5480-d34a-4072-962a-374bb02dd167"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("02db298d-ee20-4b81-a8f9-26cbb0b259b9"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("04bd658f-c26d-421d-9a8e-13e8893fb144"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("070bad5c-b58a-4d0a-8090-8ce1e30eb1d5"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("0b9350a2-5db7-4215-8e3e-8f87e40e3527"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("0c1081be-1b2a-45d1-80fd-f2c6d1a58d77"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("0e4b9f71-0d6e-4414-9dc9-3c1327a5b5d6"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("0e9c4c45-0a19-4d44-a271-637a809755e3"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("0e9c766e-3711-487b-8f63-5b1a70179ecb"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("0edea616-8872-4f2b-ae54-42a2381e017e"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("0f23192e-3d29-4d7b-bfc4-6cc7e8a1333e"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("10bf0cb5-32b8-4302-84bc-f6d738ec51ee"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("11816d03-0ca0-4255-8588-c1325226971c"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("11f13d23-1db2-4f64-bb43-4dc5674f9c0e"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("1270b1a2-6497-4aa6-98a6-f8dbc425a5c9"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("1356c868-10d8-41b8-8b19-f0615a6b3867"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("154a7390-0633-4759-9b61-cf3108ca0eb9"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("159625cc-83fc-496c-997f-5f8e9ba95382"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("1683c9f0-380f-45da-ad21-42e61a58e3c8"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("18741c3f-fd9e-4b7f-876a-1e4eb6ff0ed0"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("1c0e4feb-1326-4d36-9ab5-cc492259f4a5"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("1c4df7ed-1e52-4d80-b0b7-28407d57346b"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("1d823252-a0ce-4e57-b895-94c22a531ee5"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("203dc7c2-b104-4ca8-8880-b6f59d89ff6e"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("2195d708-1bd7-4d91-a123-8bc12c9f1208"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("23a980c1-08c2-4208-a5fe-093243f8a8c1"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("23aaa60c-85cf-4c20-aebb-77a6c520d189"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("2626581d-14b3-48ca-a802-35d305acc305"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("264ce9f9-14d1-4552-9b8c-459d1c6f3c24"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("266ac634-b69a-4f23-aab5-8038b126e99f"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("27fdca20-7677-44e3-b92b-2c4b0e7c2a88"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("2b26decc-5803-4087-a94a-39f6754f5b44"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("2b9f516a-1ccc-45b0-862f-6c3190545674"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("2f0ce2f3-dac2-4c64-b685-4541938f0648"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("30542646-2f2a-4a85-bd79-7ea65d4ad39c"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("31278f5b-7547-4943-8055-86cb35bb58b2"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("35242a23-4871-465f-81a5-2168942f0a1a"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("3567e2e1-5a2b-4d3a-8497-208bf28843de"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("35a4b0be-a32d-403c-b28b-85c20931f93e"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("36087572-27b9-4526-b77e-9eb5ffaa804d"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("37e84066-80b3-4909-ab33-35271de46a6b"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("3922fa95-491e-403c-a782-1895aafde570"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("3af96a6f-0c76-4e59-91c7-163d2a01561d"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("3affc449-05bf-4c5e-be97-699f4dc2104b"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("3b0d81da-0a1b-4a48-8df7-0b90a12284a9"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("3c478396-1b97-491e-8d2c-4e53fe66a426"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("3daab4ce-b61c-44e4-ac22-d9a635f6c522"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("3dd99d1e-e0f6-416e-b82d-60532b3c2546"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("3df3ab31-c120-4689-b463-446c56f6dae9"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("400e8bc6-5bf3-40c6-ac6d-96828a975544"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("41c480e7-fb14-4ee5-835c-4e11257307fb"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("435f5d12-6f61-4483-8063-1e763b677fb4"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("492f70ab-f1de-4de4-93b3-8602df66b05a"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("4955190b-aa9c-46f3-8583-0bf2620888a2"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("4b5de087-d859-4eae-96d3-267b2bbbb93e"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("4bb062c5-c7c6-413d-aadb-abf17818e620"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("4d5bab68-549e-4027-8e73-6322040b4e00"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("4ef8889f-7b50-44b7-87b2-783cb166f5a9"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("51b5fb42-0cf9-47c8-8e59-f6fe4175fe19"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("51ec7c53-4fc9-4069-a689-1e26eef9f419"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("554accb2-60ca-4963-b13a-765920c11859"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("55b1fefa-8770-4a1d-83cf-d5279a6f4628"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("55dd2f1c-ed65-46b1-b111-34fd7cf218ee"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("56c53eee-e989-4f4f-8f8b-428bdae67b53"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("572a5449-c3ce-424e-9eb5-63e67b998e5b"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("58660e66-4d3d-43cc-82c1-f10a8ce1569d"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("59470b2d-49c5-44ee-a07b-2393c10b041e"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("5a62cb61-ac5d-4ecc-b1b9-77ba9676ecc3"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("5bbd9edb-8e03-4783-b785-ac8b0ce0ee0c"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("5d53ba14-b266-4375-af7a-99202ea4f6e4"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("5ff4e98e-87a1-4a37-85ab-520b76be11da"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("60d05c00-bb9b-4c67-ab8a-10759660fe7e"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("60e6c661-a7af-43dd-bdc9-01894f11f3da"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("628d31d2-a8a0-4adb-b611-0d052b1c7af7"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("65791d13-67df-4acc-8f5a-eba57d4c1c76"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("65b036dc-635e-4e32-8b29-28d7b51b9732"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("65e79682-87a8-42e2-8b33-6e54cd0341c4"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("6704e0b0-7df1-4965-844a-0f38c35ac4f8"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("68502be5-7b28-4fe8-9a71-f6cb9b816706"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("68a89cf0-6649-42f1-a422-012bf51bc2f4"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("6a9fbbd6-aba4-4e25-828f-a4120d8df2d2"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("6aeabfef-0467-4428-9f8b-8069e95f6c77"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("6bb1b311-0d9e-449c-ad4c-d18ac8a1d72d"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("6c1fa1fb-fb9d-4e13-ac53-23988ffd0456"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("6d01d50b-aa37-412e-a739-e69fb3619bdc"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("6d342342-ea26-40f4-aa92-420f3a943603"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("6d5e3a81-520f-4ff7-9ad9-b06d72c3cfd1"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("703d7b78-5d99-49f1-9e73-7acb8459b1d9"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("70e9455e-c256-4ea5-8e75-cf1502dd703c"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("71b7b68b-5631-416f-a43f-29a972ff82fd"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("71ee88f0-7b48-496e-953a-1955b56a66b7"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("730e65eb-ce68-45ed-84f0-6b269112966d"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("732711e5-8895-44c1-b796-53e4e3269f5b"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("74d6b61c-58af-4503-8edf-4c2b80ad84c9"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("75c9c365-0988-4944-857d-5d3c27a72869"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("76dec0a0-393c-43aa-81d5-2c6683dcfef2"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("77b75ed9-e6d2-4d47-84c9-58af10e455c1"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("7a81609b-af37-4af8-b2ef-a4c33a25bed7"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("7ab40740-74df-4352-a95e-691246eb222f"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("7b8b6ab2-14b0-421f-bd9e-2da8c2407d9a"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("7c744a17-7344-4430-9536-63f4d3348063"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("7d50e2cc-a8bf-457b-b24d-cf8e62df4b18"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("7f576d25-73da-44af-8f3e-8bb7e8d8f605"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("7fdfa190-66d6-43be-b2af-dbbd45052828"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("84d5050b-a7b7-4c23-a2d1-93281183264a"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("85bb99aa-9d9b-4e3a-97b2-8fb97b6137ed"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("87da9d0b-c5b6-47ee-b6f1-1a8a3a165cfc"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("89a6cc4c-640c-4f4c-951b-10bbce402939"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("8b4c8223-5e6b-4e35-a3e1-8255797fd649"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("8d029e45-dfa0-4337-9ee6-f471e2da1899"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("8e22b0a3-063e-40ae-976e-5b06f762c8ce"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("8e449ac4-29ae-46a5-b9a0-87992593185e"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("917b0066-962f-41c5-8613-ca7142805c4a"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("936ffe00-8d77-46c8-ba0e-95bbbbe16500"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("93c36e8a-144d-4ac9-a013-3037e633b18b"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("94846b5a-866e-44b1-a8f2-3c424d9228f8"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("95bd8cb1-02ea-40eb-bf89-3bb4813543b4"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("95de138f-0a69-426f-8f5f-dfc2181a9c5d"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("96f51fb8-66b3-483e-89e0-9388730acfdb"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("97ff69a0-9113-4e22-8365-c67c8764cf22"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("9841b6ce-c264-4edc-ad4c-31cc366c09a4"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("99f4e048-be2e-4702-bbd0-d5ca7034eb1b"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("9ae984d3-af4c-43bb-9a44-c08baecbccba"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("9c6a4902-3561-4ffd-8dd8-f02eac939b12"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("9da2d1f5-a83f-499a-b6f9-9abdbffc54bb"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("9f5bbfcd-4383-419d-b22a-ac704204a7ee"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("a05bda5d-7d16-47da-a6cc-c6051be6bea1"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("a09065d0-2be8-4094-a267-526738597853"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("a09b3437-7569-4a89-8a13-219a1efae6d7"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("a402d9a5-424c-4759-a6c8-563b94cc3664"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("a658ed79-9786-4de7-9d79-af0c4bc1a51d"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("a792c476-29c9-4ca5-b4a6-e4d3093a3a13"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("a7e6dd5f-d654-45ef-8f29-ccbc6c91e0a1"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("a84ee843-332e-4b5e-a2b9-d92767d1c1f9"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("abf1ef6b-cf5e-4fb5-8f1e-22a8ab7b6c0d"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("abfa5816-669c-4442-a947-79dc5773cb29"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("aee5ac47-c514-422c-ad07-977cc91d33cc"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("afc8be46-b8b5-4b09-b6f6-26d0678ad598"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("baace2ca-c2c0-4cee-b129-53079d696059"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("bbd494c1-0ce6-4886-bdbb-0e291f8e3a1b"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("bc9bdc36-1d53-4fae-8d6e-60edf292c3f4"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("bdb42fee-edc1-4a9e-a1dc-e752fc8c77ac"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("c079d25c-ce0a-4f49-89f8-1e054852506c"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("c0802ea6-d526-4fc2-a3b4-09f14b6706fc"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("c1008ac3-0ddc-47ae-8689-6657dfce1b01"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("c31d1ffa-7f32-426a-90e4-9f3d997c28bb"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("c3e5bdc0-8a85-4013-9a7b-8e119a0fcb5a"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("c3e8c3a0-4db3-4f0c-83f9-32b499285a0a"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("c48ae4a3-1d3c-4487-bdfd-361f96817454"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("c7f40952-b113-4351-8537-01e5fd3ebae9"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("c84b5757-2df3-4934-b3b3-58de2e3c0044"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("c878736d-da07-4401-ab27-2743d4e035c5"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("c87d15f6-02ce-4101-8b3e-cfb30ff03969"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("c8bf8fe9-ddfd-42c8-bda6-fddf301289a0"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("c9215357-9122-4fa2-9c38-0eb275849f8a"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("cc6db5e7-8b8a-4dad-bb54-cf2b13ad1612"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("cd1b577a-b8e4-4f06-bde2-942b5ef09f92"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("cf6406db-f369-485c-aece-2bba9fc9c9be"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("d16be991-6408-486e-8f3b-75465cc0ae45"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("d1c9e7c7-ee5e-4ae7-8d5e-bdb94e10bcb9"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("d1ee8e53-2982-4d95-8728-23b13cbdd8c7"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("d2f374a2-4e2b-44b8-95d5-c6af85ee2d2c"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("d2ff6526-18be-4bb3-ba95-30361f7a2f4c"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("d5d8b0c0-01f8-4546-a272-dd3ba425679f"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("d64157a2-9257-4e0b-80f4-20f7e45a50a1"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("d6b3679e-e7b1-4625-8ab7-48771c70bb7a"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("d83b9ba1-b86a-4b65-9f8d-eff70b55131a"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("d9e1b86b-085e-4502-b591-13393b168dd7"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("dcd3027f-309e-4f11-906b-0b194351e0ce"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("dece33fd-e1e8-430f-b72c-fb5d9aa50c92"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("df30f841-da2e-45b8-b0de-e20c2e77c4a5"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("df7520f7-0f08-43e2-8c0c-bf71e2a1b9bb"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("dfcbe1df-6bbb-4741-9c2a-08e53d8056ee"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("e34d2f2a-9f75-49e7-b0d9-128e0e4b7d4a"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("e73709de-84a4-4fa1-8425-4e9a35519772"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("e7ce46f6-9b70-4a8e-9a0d-556536cd7832"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("eb86cede-29fd-4d70-8311-2952819337db"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("ed102289-43e3-4f09-ac77-7586d8190d36"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("ede1078f-0b6a-48d6-9822-b6d08a881cbb"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("ee4a6bb5-5073-4507-a7fb-c4250c585deb"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("f1c5c0a0-d2ab-4f1f-81bc-c9f19a459105"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("f39ba472-ebfe-4f7b-a08e-7e44de763a8d"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("f6405402-785d-478e-b808-1c429fd1e8db"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("f6ecabb3-b4e8-4df9-8439-a629888cfc44"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("f80e4383-e550-4e30-8fb4-591ca146f31b"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("f8a1c865-eecc-4461-82b3-efbdec7a94a8"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("facfb980-d1e8-4259-b86b-da451bfc3fe5"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("fc502116-f60e-4663-b01a-5058d636d188"));

            migrationBuilder.DeleteData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("fd03453b-e8ec-4ba0-a4ea-33cea45c6a05"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("68f6170a-12b9-4f32-9e83-c81c61ad29b6"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("7fa5ae48-7ed7-42a7-bb2a-4f4d0e502d7a"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("8c9c6d68-01f0-4e97-9640-d7a633788f53"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("a579446d-0ca1-4aae-8cad-5126ab41c203"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("b56de1bf-2c8e-4d1f-a727-9a5ebc3d6b2f"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f1344d39-707e-4a7f-82e7-0816c21206d8"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f13c6c62-c6e2-4a37-9c17-99c0e9d8db42"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("04a709fb-85ac-4a7b-b675-4b92f9c540da"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("063c93e9-5785-48ab-bd62-c52ea0c654b9"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("0645bf34-df24-4681-a088-3430ac64f013"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("08613aac-be0b-48f2-ae01-c33bc68b12fe"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("08711cd7-f5fe-47c8-9cd2-3fc5f22f93c3"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("0dc97df0-976b-4816-be51-a2f491027c1a"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("10a03e67-246a-495c-8913-a1d6a9479d23"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("11320d49-4294-4e52-bf32-2381dfed3ac4"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("1648caba-362b-4974-bcc5-78a4b241cc26"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("172b01ab-8169-4c04-b54e-7cbfcb8a0931"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("1c8296c3-6bae-4036-8cf9-58ea04038866"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("231eb456-d1fb-4f25-a4a8-9c4c559e4c2f"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("23533d5b-5e56-46f4-a5d3-4cc138696854"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("251cf78c-9b90-4d8e-bcb5-0add3b3e7030"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("28f6e7d4-af28-48c8-8def-3bac2538cb45"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("2cacb4aa-113f-4acd-b677-816bae840b08"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("32496198-3ed2-46d6-a0ce-5403983fcbca"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("32ec0969-1493-4960-97a8-32c068ad95c7"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("342c4173-99cc-404f-82cb-e9672829926c"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("361a2eef-a9b0-4b5e-9c00-9bacfb5341a2"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("36584c54-91b8-42fb-af1d-19025d24c68c"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("384e9aee-60f8-43ac-8c32-9ce084bf2003"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("38b6bae0-b77b-4547-9884-64ec9e9eaadc"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("38e68a81-9342-4cd5-ae18-b0e08b92a9c6"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("3a67f4c9-f38f-4164-ac51-82dcf6b5bcbe"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("3b44f4ed-824b-4d78-ae64-937b1e43d741"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("3c7b9e52-2e80-427a-a4f1-4a1cf80fd412"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("3ffcd571-109a-4732-9816-ec12eb52580e"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("40919dca-43b0-40fd-8d3e-f8054cfa3ef5"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("41863e97-3f34-4dab-8222-23494334fa4e"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("44eae267-b790-48d3-8304-0059c7f5652e"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("454bfdb6-4922-45b8-bd0d-33c38da31735"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("48b05998-fb99-4693-98af-af675b4ddf46"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("4cb98d94-2541-45ec-a178-f32e4faf7ddf"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("512a02cb-3b12-4ba4-b959-af37747ef1e9"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("52126cb0-f858-4f29-bd76-fa480a15daf3"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("52a6e6da-9d3e-4905-aa5e-a0745496d056"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("554abc99-8c15-450d-93fd-34f6cc16bf8b"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("5793b9c8-72ce-47c6-93ca-4c5c7f032b98"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("5b6ab067-1e79-48bf-ac67-a4a478a64c15"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("5c4f6bf2-34da-43de-a5e4-860992d8cdf4"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("5cda7056-6608-4a10-b2ac-e4542a3a54c4"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("5ec063e4-d881-4aff-9a1d-c588255094f8"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("5ec151a2-8644-4e89-923d-8003d5d4cbc1"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("605a8a4a-8626-4f7a-8138-86597f0382ea"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("617a9867-2fcc-4d05-8bb8-857689a35b17"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("6a5f1024-050b-432f-87cb-e9781c2da92f"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("6a9090f3-4cb1-457b-8341-8d95786e2f93"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("6bf3e7d0-b9b1-475c-8cec-dcd2fb7746d3"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("6cd2e038-f910-471b-93dc-94d636675584"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("6daaee3d-1e84-4408-aff9-eb7c02a25b14"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("73968f68-af90-4cda-9be5-5c4cffc43dab"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("76a23627-35c3-4bb8-b9dc-65badf5e63f1"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("76d9e174-1e56-4e71-ab06-673753e381aa"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("785f9d64-0f05-4aea-90f4-cbbcd7c9b946"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("7ac102ca-5e6f-41ee-acc0-6b0e7941a9fd"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("7b7345e4-8ac4-4dd4-a6c7-4bbd713494aa"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("7ff0824a-e240-4ddd-bd2d-9406f6296b53"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("80890b51-f7e0-4302-882b-1e60a79d2315"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("85efc138-f29f-4d8e-9b05-da95bec1e203"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("85f7c136-2ce9-4163-b01c-7beea05056a7"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("88b66b3b-b3d2-42cd-90ec-39788d0dd512"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("8a2165b8-f201-421c-87ae-03642914a34b"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("8fa99920-8bd6-4da4-b530-fef34656fa2b"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("905917ab-51b5-402a-8367-9dc3256cf1f2"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("9154c3ac-6c9d-429c-a732-6bfe671b36fa"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("92efc2af-14aa-43e3-a8b3-ed5c38d76311"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("9371a131-4d36-4b46-8d1f-82a6f4763534"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("93dc2a4e-e14b-4fb8-84b5-ab244110e423"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("9484a78d-b1fd-401e-904d-4d9ba1e30fea"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("9a782ce1-740f-4009-ade0-d474616df4b4"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("9b5b7d9e-10aa-4aa0-b08c-b8d2779ccdb9"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("9b7ad1c8-fdd9-4b7a-891b-e7270998f885"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("9eb5a8fa-911f-4310-901b-f50ff0bf7b39"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("9fd0c929-c39e-4d21-aaf5-9b27058637e2"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("a0c8d366-0d09-4d9c-9c54-e26517e258b7"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("a5cc759d-14b1-4015-8593-7c47d80a4b17"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("a7edab83-5889-4e6a-9d2b-9a3fc504c29f"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("a9424a75-7dd3-4ddd-98d2-d7cd55fbbfc4"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("a9620719-90e7-41b1-9517-4ecc81693c73"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("bc28acab-30c4-4cb4-9201-0958ac78c822"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("be25d676-8cdc-4e06-9294-586a7d37ff76"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("bf807e39-2791-4fa2-8dc3-64c145489720"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("bfe235f7-3597-4ae5-9413-e8e831b1911e"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("c25f19d4-883b-47a6-b2ba-05691f039db3"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("c8dc0367-e04e-442e-bc2a-3b64c858d3cb"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("cea1e4bf-cc0c-44d7-992c-31b81dc72d74"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("cf295a6b-92c8-4dd8-9044-27607055dd3c"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("cf50b71c-4055-4276-8f82-e9e91ce88049"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("d3c49bac-f66f-41cd-ac63-46553f9d97d4"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("d41e2f9d-56a9-48a2-9003-cf0d1ecd91cb"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("d540bd3c-870a-4e1b-b575-80069b4dd27b"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("d570d995-f615-42d7-9456-36a29a129d29"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("d65c7a12-3a01-48c0-92b2-8a46fa0c3491"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("d89f6658-aa9a-46ba-bef9-35538a7129b5"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("d95f9b2b-bee0-4105-b0a8-680db66cd032"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("da1fcc3b-1841-4e3b-b75b-1292385ef9bf"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("da8a67d5-ada2-47f8-8d17-7a8158e0ba79"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("db66bffc-e43b-4721-9fb3-30083ff12e4f"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("dc3a0d3f-204d-4efe-80c0-f590eb22baee"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("dd6be640-af8a-4190-8d2c-d0bb3198279f"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("ded32561-2dda-4d56-b31b-3fd357d0c459"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("e0cfeeaa-d871-4352-b1bb-f0a3e222d0ae"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("e9dbaa64-3eca-4ffa-b8dc-44e4fa30a620"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("ea4afb6e-40d3-43b7-bcb3-ffea7591cc82"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("eebee09c-ddc4-43c4-9e1e-95c14f2bb1fb"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("f163d0c0-99b3-4ebd-be69-716b94f7d994"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("f25a4e62-4663-4aa4-a3f5-c2bc06af9b23"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("f26435c7-9fed-4a89-b125-32cc89a4ae69"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("f32391b1-d252-406f-a7f5-fe523c531e1d"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("f77fad81-b88d-45fa-abc7-6842b0642cca"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("f7ce6650-bcf4-4137-b8ac-f7c0e5bcb7cb"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("f90d17eb-8e83-4218-bdfd-807861a8e77a"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("fa8b1dbc-ded8-4513-95a6-875e2d586270"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("fcb99dc8-d3f3-4b11-93c1-b8356f4bd87d"));

            migrationBuilder.AddColumn<Guid>(
                name: "AlbumId",
                table: "Genres",
                type: "uuid",
                nullable: true);

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
                    { new Guid("30965a2d-b2eb-448b-bedb-56e56215f76f"), new Guid("fe024194-aad4-462a-8fbd-8dd7b4a2cd90"), new Guid("9b17852c-5733-494d-8c37-ecf91fbc668f") },
                    { new Guid("86e9eb76-1f31-40b1-a655-6b7d6860a7bd"), new Guid("c7b12644-83a9-4ccd-8418-808b11d9755e"), new Guid("8c22ffaa-6cb7-43c9-8f7f-4a204663df42") },
                    { new Guid("87cb0a2e-63f3-491c-b164-eac43dd743f4"), new Guid("62e05eec-dfed-462d-abfe-7489534fad8b"), new Guid("c9c8d64c-fa56-4e2e-b8ef-6e41d00735e1") },
                    { new Guid("994a42cd-1c68-4fdb-b2b1-f0e9f4ee44a5"), new Guid("f7c43f96-79e4-4244-b21b-8ac476e54495"), new Guid("90ac1df8-837d-42af-a40a-a0cbd28770fd") }
                });

            migrationBuilder.InsertData(
                table: "ArtistTracks",
                columns: new[] { "Id", "ArtistId", "TrackId" },
                values: new object[,]
                {
                    { new Guid("03ddc79f-b1ba-4b5b-a8fc-a40c7bf41747"), new Guid("8c22ffaa-6cb7-43c9-8f7f-4a204663df42"), new Guid("bf9e77fd-3d3a-4a77-aae9-123d03b9a2e4") },
                    { new Guid("0698c4b9-be2b-4fe9-8dbe-8c12111c6605"), new Guid("8c22ffaa-6cb7-43c9-8f7f-4a204663df42"), new Guid("82e5f6d3-1d4a-4bc2-96d0-2d8f7852bc7e") },
                    { new Guid("0caf3d40-756b-46ff-8a45-3161a85a0872"), new Guid("8c22ffaa-6cb7-43c9-8f7f-4a204663df42"), new Guid("f0a91ef7-1eaa-40d0-8273-0401bea48b5c") },
                    { new Guid("1d76e33d-4885-4785-b1ff-75c8593834a4"), new Guid("8c22ffaa-6cb7-43c9-8f7f-4a204663df42"), new Guid("e43d89cd-398d-4dbb-99e6-789869f891f3") },
                    { new Guid("2b189dd4-a8c3-4921-a361-f63c37eabb70"), new Guid("8c22ffaa-6cb7-43c9-8f7f-4a204663df42"), new Guid("997f8ae9-cc5d-4b19-9dd7-0f1d287106e9") },
                    { new Guid("35b257fa-ee34-45ed-ad86-8347bc585dbc"), new Guid("8c22ffaa-6cb7-43c9-8f7f-4a204663df42"), new Guid("9b17852c-5733-494d-8c37-ecf91fbc668f") },
                    { new Guid("506ea768-1c1c-402b-9ad6-e41af208f4d7"), new Guid("8c22ffaa-6cb7-43c9-8f7f-4a204663df42"), new Guid("e9481c7b-c007-46de-b706-4775c1d9c6de") },
                    { new Guid("5de801cc-0029-4706-b03f-763f1868c228"), new Guid("8c22ffaa-6cb7-43c9-8f7f-4a204663df42"), new Guid("8842e1a3-18e2-4aa7-8b66-55150248a33a") },
                    { new Guid("6f2fc58d-1415-460b-b31f-b774d87425f3"), new Guid("8c22ffaa-6cb7-43c9-8f7f-4a204663df42"), new Guid("6b24c35d-8589-4d35-83be-dfc48f0c8a79") },
                    { new Guid("79ed1f18-35ad-46e4-9d02-ab8b118b3fe3"), new Guid("8c22ffaa-6cb7-43c9-8f7f-4a204663df42"), new Guid("4d60248e-d3f1-43e0-978f-356947c53e15") },
                    { new Guid("83dd7c9d-630c-4a41-ba9d-fcfdf526a299"), new Guid("8c22ffaa-6cb7-43c9-8f7f-4a204663df42"), new Guid("5e8eae8c-7d72-4dc0-9832-6ae82f5a42ed") },
                    { new Guid("8aac4072-4ba8-4be3-95d8-193392e1591f"), new Guid("8c22ffaa-6cb7-43c9-8f7f-4a204663df42"), new Guid("d1c9e7c7-ee5e-4ae7-8d5e-bdb94e10bcb9") },
                    { new Guid("8fa88919-15b7-4fa2-a014-117a5e979ea2"), new Guid("8c22ffaa-6cb7-43c9-8f7f-4a204663df42"), new Guid("262342b2-861e-4802-a54c-c84522188cd7") },
                    { new Guid("970afdc7-7e88-4d7b-8bd8-73e2a4c86f25"), new Guid("8c22ffaa-6cb7-43c9-8f7f-4a204663df42"), new Guid("2d75a3c6-1e6b-4740-afaa-60e33bcb77e3") },
                    { new Guid("97c79ba6-febc-4d53-9e2a-1c6fdb4f3a5a"), new Guid("8c22ffaa-6cb7-43c9-8f7f-4a204663df42"), new Guid("6c9645b5-3f50-4a11-8be0-314a97c27eb8") },
                    { new Guid("ab93d52a-2279-49fd-9d89-aa0770931ae4"), new Guid("8c22ffaa-6cb7-43c9-8f7f-4a204663df42"), new Guid("a633f860-97ce-4d9a-9960-2091db4aee78") },
                    { new Guid("c30d6179-0407-487b-bfea-b543921d84c4"), new Guid("8c22ffaa-6cb7-43c9-8f7f-4a204663df42"), new Guid("08d03e3d-0919-4c01-a6db-78c2abfc4d5e") },
                    { new Guid("c543cb27-3040-4e6e-b420-ab34ac4cc925"), new Guid("8c22ffaa-6cb7-43c9-8f7f-4a204663df42"), new Guid("15dc8b5e-f87e-4ee6-8f0b-6c1f1e2f5eb1") },
                    { new Guid("c70bbcef-922f-44bc-b716-c07118510321"), new Guid("8c22ffaa-6cb7-43c9-8f7f-4a204663df42"), new Guid("d982cc75-bcfc-4c66-8dd6-23b1e87866e5") },
                    { new Guid("dae6391e-f96b-4807-86e8-94067b686ad2"), new Guid("8c22ffaa-6cb7-43c9-8f7f-4a204663df42"), new Guid("c138c0a3-0dbd-4b9c-9533-d860bb4d1364") },
                    { new Guid("ee325bd5-8b52-4c7d-8afe-5d19361e6b3b"), new Guid("8c22ffaa-6cb7-43c9-8f7f-4a204663df42"), new Guid("f89c0c4d-59e4-4b9a-b95f-8c6d2fb4208b") },
                    { new Guid("ee34d371-d538-43a4-bd59-19f5faf67985"), new Guid("8c22ffaa-6cb7-43c9-8f7f-4a204663df42"), new Guid("5d146662-869d-477f-8f99-620ad1f3c1d1") },
                    { new Guid("f8b9412d-9784-45f3-ad10-5b84d4014ab3"), new Guid("8c22ffaa-6cb7-43c9-8f7f-4a204663df42"), new Guid("3fde47fd-c654-4124-bc46-88d3b9bfa4df") },
                    { new Guid("fea2789f-a50e-4274-8824-534a75491e98"), new Guid("8c22ffaa-6cb7-43c9-8f7f-4a204663df42"), new Guid("ddaa72b5-3a20-46d7-8c48-c6c7c9ea2564") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Genres_AlbumId",
                table: "Genres",
                column: "AlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_AlbumGenres_AlbumId",
                table: "AlbumGenres",
                column: "AlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_AlbumGenres_GenreId",
                table: "AlbumGenres",
                column: "GenreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Genres_Albums_AlbumId",
                table: "Genres",
                column: "AlbumId",
                principalTable: "Albums",
                principalColumn: "Id");
        }
    }
}
