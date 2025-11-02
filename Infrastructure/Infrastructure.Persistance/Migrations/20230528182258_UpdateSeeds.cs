using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Persistance.Migrations
{
    public partial class UpdateSeeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("03810320-12e9-435f-9d8b-473572074360"));

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("a62f20f1-a42d-41cb-8c17-890cc61b4b14"));

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("c878736d-da07-4401-ab27-2743d4e035c5"));

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("d3179697-703d-4ee8-998d-7674119309a5"));

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "CoverUrl", "IsActive", "Name", "ReleaseDate" },
                values: new object[,]
                {
                    { new Guid("5711de71-8cb5-4be9-984f-d1683760a9a6"), null, false, "Sweetener", new DateTime(2018, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("73c8af54-d09b-4ef7-b646-901e59b868ed"), null, false, "1989", new DateTime(2014, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("89901ee5-7d1f-48a4-8e92-83a9b5c76f1e"), null, false, "DAMN.", new DateTime(2017, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8b9dcb0b-2f8d-4f0c-8645-0e8d588a4f5e"), null, false, "Purpose", new DateTime(2015, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bc5b6b69-c641-4105-a906-19b88dbbb4ae"), null, false, "Scorpion", new DateTime(2018, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c3e23e47-c858-4c1c-9000-bd3f4e8fb1f0"), null, false, "When We All Fall Asleep, Where Do We Go?", new DateTime(2019, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cc37dd0a-7831-4b4b-babb-259b4d06598d"), null, false, "24K Magic", new DateTime(2016, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d9d9d08b-5422-4458-a4de-34ac03a5f52e"), null, false, "Anti", new DateTime(2016, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e4b2c83d-384f-4d68-bbd0-ef8fdd9e9d25"), null, false, "Divide", new DateTime(2017, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "Email", "IsActive", "Name", "Password" },
                values: new object[,]
                {
                    { new Guid("573a1d7c-694e-4f66-8905-8e528f137d27"), "rihanna@gmail.com", false, "Rihanna", "1111" },
                    { new Guid("640e13de-bd1e-4088-8651-44be51f2451d"), "brunomars@gmail.com", false, "Bruno Mars", "1111" },
                    { new Guid("81d19ab4-52a1-4e47-9766-2c7b682e89b3"), "justinbieber@gmail.com", false, "Justin Bieber", "1111" },
                    { new Guid("87f352c1-ef43-41fb-b5c1-3a46e51868b8"), "taylorswift@gmail.com", false, "Taylor Swift", "1111" },
                    { new Guid("8c22ffaa-6cb7-43c9-8f7f-4a204663df42"), "playboi@gmail.com", false, "Playboi Carti", "1111" },
                    { new Guid("90ac1df8-837d-42af-a40a-a0cbd28770fd"), "bourne@gmail.com", false, "Pi'erre Bourne", "1111" },
                    { new Guid("9b17852c-5733-494d-8c37-ecf91fbc668f"), "xxxtentacion@gmail.com", false, "XXXtentacion", "1111" },
                    { new Guid("a7ab352a-421d-4f78-9a5c-72d2cfa9c430"), "drake@gmail.com", false, "Drake", "1111" },
                    { new Guid("bcb0671f-572a-4495-b5df-3f2865e081b2"), "kendricklamar@gmail.com", false, "Kendrick Lamar", "1111" },
                    { new Guid("c90e2e7e-15d1-4a7c-8a8e-9f28e7f0c36f"), "beyonce@gmail.com", false, "Beyoncé", "1111" },
                    { new Guid("c9c8d64c-fa56-4e2e-b8ef-6e41d00735e1"), "liluzivert@gmail.com", false, "Lil Uzi Vert", "1111" },
                    { new Guid("d8956234-3e1b-4c14-ae78-9b7f1f598ef2"), "edsheeran@gmail.com", false, "Ed Sheeran", "1111" },
                    { new Guid("f024e3f8-cf68-4c48-b288-b04e9c8b30c2"), "arianagrande@gmail.com", false, "Ariana Grande", "1111" },
                    { new Guid("f2e16642-5d10-4195-8bc6-8b9dbb9dbd5a"), "billieeilish@gmail.com", false, "Billie Eilish", "1111" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "AlbumId", "IsActive", "Name" },
                values: new object[,]
                {
                    { new Guid("8ff3eaba-b2c6-4a1b-96c9-0f611d17e8c6"), null, false, "Поп-рок" },
                    { new Guid("ac38a647-9bc3-4a14-ae64-8c50964e307d"), null, false, "Поп" },
                    { new Guid("d35e2479-8214-41f2-b6d6-59b892602f16"), null, false, "Ритм-н-блюз" },
                    { new Guid("da7a689b-5b29-4c88-91ad-b543ce614e12"), null, false, "R&B" }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "AlbumId", "Duration", "IsActive", "Name" },
                values: new object[,]
                {
                    { new Guid("066d0b1d-b7c6-40b6-a48c-1f7b83084760"), new Guid("f7c43f96-79e4-4244-b21b-8ac476e54495"), 5.13m, true, "HULU" },
                    { new Guid("08d03e3d-0919-4c01-a6db-78c2abfc4d5e"), new Guid("c7b12644-83a9-4ccd-8418-808b11d9755e"), 0m, true, "Control" },
                    { new Guid("0a41a3fe-6f5d-4d23-9a34-34a11b5b438b"), new Guid("f7c43f96-79e4-4244-b21b-8ac476e54495"), 2.59m, true, "Amen" },
                    { new Guid("0e53296d-4f08-4a15-ae64-23a8f4e8d804"), new Guid("62e05eec-dfed-462d-abfe-7489534fad8b"), 0m, true, "Final Fantasy" },
                    { new Guid("15dc8b5e-f87e-4ee6-8f0b-6c1f1e2f5eb1"), new Guid("c7b12644-83a9-4ccd-8418-808b11d9755e"), 0m, true, "Punk Monk" },
                    { new Guid("190e4a84-462b-4a3e-90e4-9e25a826c4d3"), new Guid("62e05eec-dfed-462d-abfe-7489534fad8b"), 0m, true, "Glock in My Purse" },
                    { new Guid("1e4b79fc-4f83-44d2-95c4-35b69f62c3ab"), new Guid("62e05eec-dfed-462d-abfe-7489534fad8b"), 0m, true, "Hittin My Shoulder" },
                    { new Guid("262342b2-861e-4802-a54c-c84522188cd7"), new Guid("c7b12644-83a9-4ccd-8418-808b11d9755e"), 0m, true, "Teen" },
                    { new Guid("2d75a3c6-1e6b-4740-afaa-60e33bcb77e3"), new Guid("c7b12644-83a9-4ccd-8418-808b11d9755e"), 0m, true, "Die4Guy" },
                    { new Guid("2fb86013-0a56-4f2a-bd99-3fd4f4c1f1f3"), new Guid("f7c43f96-79e4-4244-b21b-8ac476e54495"), 0m, true, "4U" },
                    { new Guid("3d8e0d8f-8b9a-4f54-9e13-3a9d7db4ce41"), new Guid("62e05eec-dfed-462d-abfe-7489534fad8b"), 0m, true, "For Fun" },
                    { new Guid("3e4d4f4d-46f5-4716-9b8b-c355e66b8832"), new Guid("62e05eec-dfed-462d-abfe-7489534fad8b"), 0m, true, "Believe Me" },
                    { new Guid("3f3ef649-9e39-4bda-85e5-3d763f01c31e"), new Guid("f7c43f96-79e4-4244-b21b-8ac476e54495"), 3.12m, true, "Groceries" },
                    { new Guid("3fde47fd-c654-4124-bc46-88d3b9bfa4df"), new Guid("c7b12644-83a9-4ccd-8418-808b11d9755e"), 0m, true, "Not PLaying" },
                    { new Guid("41b26f20-69e4-43d2-8db4-76ed6a5028b3"), new Guid("f7c43f96-79e4-4244-b21b-8ac476e54495"), 3.07m, true, "42" },
                    { new Guid("4d60248e-d3f1-43e0-978f-356947c53e15"), new Guid("c7b12644-83a9-4ccd-8418-808b11d9755e"), 0m, true, "Vamp Anthem" },
                    { new Guid("4fca4e84-f34c-4b73-8a66-3d1566763a8a"), new Guid("f7c43f96-79e4-4244-b21b-8ac476e54495"), 4.33m, true, "Practice" },
                    { new Guid("5d146662-869d-477f-8f99-620ad1f3c1d1"), new Guid("c7b12644-83a9-4ccd-8418-808b11d9755e"), 0m, true, "Place" },
                    { new Guid("5e8eae8c-7d72-4dc0-9832-6ae82f5a42ed"), new Guid("c7b12644-83a9-4ccd-8418-808b11d9755e"), 0m, true, "Rockstar Made" },
                    { new Guid("61458d69-7f4a-406d-80e3-7ff0d65e7f5f"), new Guid("f7c43f96-79e4-4244-b21b-8ac476e54495"), 3.47m, true, "Sossboy 2 (feat. Lil Uzi Vert)" },
                    { new Guid("674a432f-3fd4-4b33-af25-82607c96a3f0"), new Guid("f7c43f96-79e4-4244-b21b-8ac476e54495"), 1.11m, true, "Intro" },
                    { new Guid("6a4b25d6-ae03-4aee-a442-af50945f1aee"), new Guid("f7c43f96-79e4-4244-b21b-8ac476e54495"), 5.00m, true, "Drunk And Nasty (feat. Sharc)" },
                    { new Guid("6b24c35d-8589-4d35-83be-dfc48f0c8a79"), new Guid("c7b12644-83a9-4ccd-8418-808b11d9755e"), 0m, true, "Over" },
                    { new Guid("6c9645b5-3f50-4a11-8be0-314a97c27eb8"), new Guid("c7b12644-83a9-4ccd-8418-808b11d9755e"), 0m, true, "JumpOutTheHouse" },
                    { new Guid("7541417e-d9db-45c5-95f3-146b6f43f523"), new Guid("f7c43f96-79e4-4244-b21b-8ac476e54495"), 4.27m, true, "40 Clip" },
                    { new Guid("82e5f6d3-1d4a-4bc2-96d0-2d8f7852bc7e"), new Guid("c7b12644-83a9-4ccd-8418-808b11d9755e"), 0m, true, "Metamorphosis" },
                    { new Guid("8842e1a3-18e2-4aa7-8b66-55150248a33a"), new Guid("c7b12644-83a9-4ccd-8418-808b11d9755e"), 0m, true, "Slay3r" },
                    { new Guid("8b9df2a6-df2f-4c52-83d3-03aeb745e3e3"), new Guid("f7c43f96-79e4-4244-b21b-8ac476e54495"), 4.19m, true, "YNS" },
                    { new Guid("96b13d9a-3a2d-4a61-9616-6f2f2a2e0de4"), new Guid("f7c43f96-79e4-4244-b21b-8ac476e54495"), 4.51m, true, "Retroville" },
                    { new Guid("997f8ae9-cc5d-4b19-9dd7-0f1d287106e9"), new Guid("c7b12644-83a9-4ccd-8418-808b11d9755e"), 0m, true, "ILoveUIHateU" },
                    { new Guid("9a38a1d3-91c6-4f0e-b5b9-7d9b542cdd15"), new Guid("62e05eec-dfed-462d-abfe-7489534fad8b"), 0m, true, "I Know" },
                    { new Guid("9b17852c-5733-494d-8c37-ecf91fbc668f"), new Guid("c7b12644-83a9-4ccd-8418-808b11d9755e"), 0m, true, "King Vamp" },
                    { new Guid("a3fe58cc-ba59-4e09-96a1-4f9e8f77f99b"), new Guid("62e05eec-dfed-462d-abfe-7489534fad8b"), 0m, true, "Flex Up" },
                    { new Guid("a633f860-97ce-4d9a-9960-2091db4aee78"), new Guid("c7b12644-83a9-4ccd-8418-808b11d9755e"), 0m, true, "Money And Drugs" },
                    { new Guid("b36a20bc-04a1-4c9c-8a07-5270d1526c7e"), new Guid("62e05eec-dfed-462d-abfe-7489534fad8b"), 0m, true, "Cigarette" },
                    { new Guid("b68c8431-5b79-4492-9f60-9f977fd471d7"), new Guid("f7c43f96-79e4-4244-b21b-8ac476e54495"), 3.10m, true, "Switching Lanes (feat. Playboi Carti)" },
                    { new Guid("b8fd88fb-647e-4130-83ed-801a9abf5e75"), new Guid("f7c43f96-79e4-4244-b21b-8ac476e54495"), 3.15m, true, "Butterfly" },
                    { new Guid("bea11ee9-0d72-4d56-b27c-33095a0787a7"), new Guid("f7c43f96-79e4-4244-b21b-8ac476e54495"), 3.08m, true, "Biology 101" },
                    { new Guid("bf9e77fd-3d3a-4a77-aae9-123d03b9a2e4"), new Guid("c7b12644-83a9-4ccd-8418-808b11d9755e"), 0m, true, "F33l Lik3 Dyin" },
                    { new Guid("c138c0a3-0dbd-4b9c-9533-d860bb4d1364"), new Guid("c7b12644-83a9-4ccd-8418-808b11d9755e"), 0m, true, "Sky" },
                    { new Guid("c878736d-da07-4401-ab27-2743d4e035c5"), new Guid("62e05eec-dfed-462d-abfe-7489534fad8b"), 0m, true, "Space Cadet" },
                    { new Guid("d1c9e7c7-ee5e-4ae7-8d5e-bdb94e10bcb9"), new Guid("c7b12644-83a9-4ccd-8418-808b11d9755e"), 0m, true, "Beno!" },
                    { new Guid("d48b865a-10ef-4f6e-aae9-58ef614fc16f"), new Guid("62e05eec-dfed-462d-abfe-7489534fad8b"), 0m, true, "Issa Hit" },
                    { new Guid("d982cc75-bcfc-4c66-8dd6-23b1e87866e5"), new Guid("c7b12644-83a9-4ccd-8418-808b11d9755e"), 0m, true, "On That Time" },
                    { new Guid("ddaa72b5-3a20-46d7-8c48-c6c7c9ea2564"), new Guid("c7b12644-83a9-4ccd-8418-808b11d9755e"), 0m, true, "Go2DaMoon" },
                    { new Guid("e43d89cd-398d-4dbb-99e6-789869f891f3"), new Guid("c7b12644-83a9-4ccd-8418-808b11d9755e"), 0m, true, "New Tank" },
                    { new Guid("e9481c7b-c007-46de-b706-4775c1d9c6de"), new Guid("c7b12644-83a9-4ccd-8418-808b11d9755e"), 0m, true, "@ MEH" },
                    { new Guid("f0a91ef7-1eaa-40d0-8273-0401bea48b5c"), new Guid("c7b12644-83a9-4ccd-8418-808b11d9755e"), 0m, true, "New N3on" },
                    { new Guid("f840d9d0-7ecf-4b7c-b4e6-50118a1f6712"), new Guid("f7c43f96-79e4-4244-b21b-8ac476e54495"), 4.24m, true, "Couch" },
                    { new Guid("f89c0c4d-59e4-4b9a-b95f-8c6d2fb4208b"), new Guid("c7b12644-83a9-4ccd-8418-808b11d9755e"), 0m, true, "Stop Breathing" }
                });

            migrationBuilder.UpdateData(
                table: "ArtistAlbums",
                keyColumn: "Id",
                keyValue: new Guid("30965a2d-b2eb-448b-bedb-56e56215f76f"),
                column: "ArtistId",
                value: new Guid("9b17852c-5733-494d-8c37-ecf91fbc668f"));

            migrationBuilder.UpdateData(
                table: "ArtistAlbums",
                keyColumn: "Id",
                keyValue: new Guid("86e9eb76-1f31-40b1-a655-6b7d6860a7bd"),
                column: "ArtistId",
                value: new Guid("8c22ffaa-6cb7-43c9-8f7f-4a204663df42"));

            migrationBuilder.UpdateData(
                table: "ArtistAlbums",
                keyColumn: "Id",
                keyValue: new Guid("87cb0a2e-63f3-491c-b164-eac43dd743f4"),
                column: "ArtistId",
                value: new Guid("c9c8d64c-fa56-4e2e-b8ef-6e41d00735e1"));

            migrationBuilder.UpdateData(
                table: "ArtistAlbums",
                keyColumn: "Id",
                keyValue: new Guid("994a42cd-1c68-4fdb-b2b1-f0e9f4ee44a5"),
                column: "ArtistId",
                value: new Guid("90ac1df8-837d-42af-a40a-a0cbd28770fd"));

            migrationBuilder.UpdateData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("034fe159-32db-4875-9131-6426134d2743"),
                column: "ArtistId",
                value: new Guid("9b17852c-5733-494d-8c37-ecf91fbc668f"));

            migrationBuilder.UpdateData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("062c2665-7591-4c78-82da-da9fe95f2277"),
                column: "ArtistId",
                value: new Guid("9b17852c-5733-494d-8c37-ecf91fbc668f"));

            migrationBuilder.UpdateData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("1227371f-f8cb-409c-ae62-9a864ce52d62"),
                column: "ArtistId",
                value: new Guid("9b17852c-5733-494d-8c37-ecf91fbc668f"));

            migrationBuilder.UpdateData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("1d7ace2e-de9c-492a-b535-723fb24975cb"),
                column: "ArtistId",
                value: new Guid("9b17852c-5733-494d-8c37-ecf91fbc668f"));

            migrationBuilder.UpdateData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("38d003fd-762e-410b-b93c-3b4ef2ec39ca"),
                column: "ArtistId",
                value: new Guid("9b17852c-5733-494d-8c37-ecf91fbc668f"));

            migrationBuilder.UpdateData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("960c53c2-d34a-4692-9f2b-6d6fd1015868"),
                column: "ArtistId",
                value: new Guid("9b17852c-5733-494d-8c37-ecf91fbc668f"));

            migrationBuilder.UpdateData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("983414b0-1371-4327-bd66-684afc8e3d05"),
                column: "ArtistId",
                value: new Guid("9b17852c-5733-494d-8c37-ecf91fbc668f"));

            migrationBuilder.UpdateData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("d033186f-8ab5-435e-9874-5238e141b148"),
                column: "ArtistId",
                value: new Guid("9b17852c-5733-494d-8c37-ecf91fbc668f"));

            migrationBuilder.UpdateData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("dc4036b5-d7ef-4788-8b33-e21b42374005"),
                column: "ArtistId",
                value: new Guid("9b17852c-5733-494d-8c37-ecf91fbc668f"));

            migrationBuilder.UpdateData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("dc96bf29-f981-4cfe-9777-a459d0ab69db"),
                column: "ArtistId",
                value: new Guid("9b17852c-5733-494d-8c37-ecf91fbc668f"));

            migrationBuilder.UpdateData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("de175c65-a3a6-4204-a1b2-318abe039cee"),
                column: "ArtistId",
                value: new Guid("9b17852c-5733-494d-8c37-ecf91fbc668f"));

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

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "AlbumId", "Duration", "IsActive", "Name" },
                values: new object[,]
                {
                    { new Guid("0a0e4f09-16b3-44d2-a545-c3f23a6bda9e"), new Guid("bc5b6b69-c641-4105-a906-19b88dbbb4ae"), 3.34m, true, "I'm Upset" },
                    { new Guid("1e41186e-c7b1-40ed-85c9-4e4c5b5c33b7"), new Guid("bc5b6b69-c641-4105-a906-19b88dbbb4ae"), 3.19m, true, "God's Plan" },
                    { new Guid("2a4b28e2-7a44-4716-8247-3b03d75e27d9"), new Guid("bc5b6b69-c641-4105-a906-19b88dbbb4ae"), 3.26m, true, "Peak" },
                    { new Guid("2e8f13db-8b78-4ff1-ba08-2e47abf35127"), new Guid("bc5b6b69-c641-4105-a906-19b88dbbb4ae"), 4.05m, true, "Don't Matter to Me" },
                    { new Guid("3a1a5599-ee9e-4786-88ea-57a0edf6e977"), new Guid("bc5b6b69-c641-4105-a906-19b88dbbb4ae"), 3.25m, true, "Mob Ties" },
                    { new Guid("3bc4e4a4-1b6f-4a53-89fc-6e62fdd442a9"), new Guid("bc5b6b69-c641-4105-a906-19b88dbbb4ae"), 3.02m, true, "Finesse" },
                    { new Guid("3cb2c0a8-1e79-4d6a-9b61-0af74c533787"), new Guid("bc5b6b69-c641-4105-a906-19b88dbbb4ae"), 3.04m, true, "Elevate" },
                    { new Guid("450cb1e3-ebc1-4dcb-a5a6-3e5e5db174d8"), new Guid("bc5b6b69-c641-4105-a906-19b88dbbb4ae"), 3.15m, true, "8 Out of 10" },
                    { new Guid("52a3a0db-7172-41a6-8a60-6e2533f3e5b0"), new Guid("bc5b6b69-c641-4105-a906-19b88dbbb4ae"), 4.49m, true, "After Dark" },
                    { new Guid("55e55f39-af4d-4d45-8e9a-8e5b9daaf2e4"), new Guid("bc5b6b69-c641-4105-a906-19b88dbbb4ae"), 2.37m, true, "That's How You Feel" },
                    { new Guid("64955a7c-30be-4c85-8d85-d36d487ed3d5"), new Guid("bc5b6b69-c641-4105-a906-19b88dbbb4ae"), 3.36m, true, "Sandra's Rose" },
                    { new Guid("71d0a71f-9e5e-4fbf-8be5-0b39a10781f2"), new Guid("bc5b6b69-c641-4105-a906-19b88dbbb4ae"), 3.37m, true, "In My Feelings" },
                    { new Guid("88f77e10-02c2-4182-a5e6-8946a84688a9"), new Guid("bc5b6b69-c641-4105-a906-19b88dbbb4ae"), 2.16m, true, "Survival" },
                    { new Guid("8fb522a4-80c7-4551-95e9-29b4282dc81a"), new Guid("bc5b6b69-c641-4105-a906-19b88dbbb4ae"), 4.07m, true, "Summer Games" },
                    { new Guid("a0c7644a-73b7-4b3a-b457-7e51e1f63a17"), new Guid("bc5b6b69-c641-4105-a906-19b88dbbb4ae"), 2.42m, true, "Blue Tint" },
                    { new Guid("a0fc64ff-fa2b-4d7d-9650-3a083ebdca24"), new Guid("bc5b6b69-c641-4105-a906-19b88dbbb4ae"), 3.39m, true, "Final Fantasy" },
                    { new Guid("ad85a600-f97a-42f0-a951-40b9a4b3c993"), new Guid("bc5b6b69-c641-4105-a906-19b88dbbb4ae"), 2.43m, true, "Can't Take a Joke" },
                    { new Guid("b75197d8-5d56-4b1d-8a5c-1a2c8c7b73d0"), new Guid("bc5b6b69-c641-4105-a906-19b88dbbb4ae"), 3.15m, true, "Talk Up" },
                    { new Guid("c0e4e1d2-0c43-41f1-952f-788496ab6f8f"), new Guid("bc5b6b69-c641-4105-a906-19b88dbbb4ae"), 3.27m, true, "Ratchet Happy Birthday" },
                    { new Guid("d65a624a-c81b-4ed1-af0a-8b27ac872e6e"), new Guid("bc5b6b69-c641-4105-a906-19b88dbbb4ae"), 4.22m, true, "Jaded" },
                    { new Guid("d8b23e3c-f1d1-47be-82b6-77a4c5e67f35"), new Guid("bc5b6b69-c641-4105-a906-19b88dbbb4ae"), 5.09m, true, "March 14" },
                    { new Guid("e1e8b1f7-0a07-428e-bc1d-c08dbd5c6744"), new Guid("bc5b6b69-c641-4105-a906-19b88dbbb4ae"), 3.46m, true, "Is There More" },
                    { new Guid("ed7f120f-0c7d-4bcf-a733-2b4de2a50b1b"), new Guid("bc5b6b69-c641-4105-a906-19b88dbbb4ae"), 3.58m, true, "Nonstop" },
                    { new Guid("f0d98d33-4c4f-4d87-9a5f-33fe7c1ab7a2"), new Guid("bc5b6b69-c641-4105-a906-19b88dbbb4ae"), 3.30m, true, "Nice for What" },
                    { new Guid("f52e7de3-46d6-40cc-9e67-3d28b1dd84d9"), new Guid("bc5b6b69-c641-4105-a906-19b88dbbb4ae"), 5.02m, true, "Emotionless" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: new Guid("5711de71-8cb5-4be9-984f-d1683760a9a6"));

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: new Guid("73c8af54-d09b-4ef7-b646-901e59b868ed"));

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: new Guid("89901ee5-7d1f-48a4-8e92-83a9b5c76f1e"));

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: new Guid("8b9dcb0b-2f8d-4f0c-8645-0e8d588a4f5e"));

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: new Guid("c3e23e47-c858-4c1c-9000-bd3f4e8fb1f0"));

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: new Guid("cc37dd0a-7831-4b4b-babb-259b4d06598d"));

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: new Guid("d9d9d08b-5422-4458-a4de-34ac03a5f52e"));

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: new Guid("e4b2c83d-384f-4d68-bbd0-ef8fdd9e9d25"));

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

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("573a1d7c-694e-4f66-8905-8e528f137d27"));

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("640e13de-bd1e-4088-8651-44be51f2451d"));

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("81d19ab4-52a1-4e47-9766-2c7b682e89b3"));

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("87f352c1-ef43-41fb-b5c1-3a46e51868b8"));

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("90ac1df8-837d-42af-a40a-a0cbd28770fd"));

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("9b17852c-5733-494d-8c37-ecf91fbc668f"));

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("a7ab352a-421d-4f78-9a5c-72d2cfa9c430"));

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("bcb0671f-572a-4495-b5df-3f2865e081b2"));

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("c90e2e7e-15d1-4a7c-8a8e-9f28e7f0c36f"));

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("c9c8d64c-fa56-4e2e-b8ef-6e41d00735e1"));

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("d8956234-3e1b-4c14-ae78-9b7f1f598ef2"));

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("f024e3f8-cf68-4c48-b288-b04e9c8b30c2"));

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("f2e16642-5d10-4195-8bc6-8b9dbb9dbd5a"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("8ff3eaba-b2c6-4a1b-96c9-0f611d17e8c6"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("ac38a647-9bc3-4a14-ae64-8c50964e307d"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("d35e2479-8214-41f2-b6d6-59b892602f16"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("da7a689b-5b29-4c88-91ad-b543ce614e12"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("066d0b1d-b7c6-40b6-a48c-1f7b83084760"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("0a0e4f09-16b3-44d2-a545-c3f23a6bda9e"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("0a41a3fe-6f5d-4d23-9a34-34a11b5b438b"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("0e53296d-4f08-4a15-ae64-23a8f4e8d804"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("190e4a84-462b-4a3e-90e4-9e25a826c4d3"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("1e41186e-c7b1-40ed-85c9-4e4c5b5c33b7"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("1e4b79fc-4f83-44d2-95c4-35b69f62c3ab"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("2a4b28e2-7a44-4716-8247-3b03d75e27d9"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("2e8f13db-8b78-4ff1-ba08-2e47abf35127"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("2fb86013-0a56-4f2a-bd99-3fd4f4c1f1f3"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("3a1a5599-ee9e-4786-88ea-57a0edf6e977"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("3bc4e4a4-1b6f-4a53-89fc-6e62fdd442a9"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("3cb2c0a8-1e79-4d6a-9b61-0af74c533787"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("3d8e0d8f-8b9a-4f54-9e13-3a9d7db4ce41"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("3e4d4f4d-46f5-4716-9b8b-c355e66b8832"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("3f3ef649-9e39-4bda-85e5-3d763f01c31e"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("41b26f20-69e4-43d2-8db4-76ed6a5028b3"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("450cb1e3-ebc1-4dcb-a5a6-3e5e5db174d8"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("4fca4e84-f34c-4b73-8a66-3d1566763a8a"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("52a3a0db-7172-41a6-8a60-6e2533f3e5b0"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("55e55f39-af4d-4d45-8e9a-8e5b9daaf2e4"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("61458d69-7f4a-406d-80e3-7ff0d65e7f5f"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("64955a7c-30be-4c85-8d85-d36d487ed3d5"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("674a432f-3fd4-4b33-af25-82607c96a3f0"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("6a4b25d6-ae03-4aee-a442-af50945f1aee"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("71d0a71f-9e5e-4fbf-8be5-0b39a10781f2"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("7541417e-d9db-45c5-95f3-146b6f43f523"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("88f77e10-02c2-4182-a5e6-8946a84688a9"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("8b9df2a6-df2f-4c52-83d3-03aeb745e3e3"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("8fb522a4-80c7-4551-95e9-29b4282dc81a"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("96b13d9a-3a2d-4a61-9616-6f2f2a2e0de4"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("9a38a1d3-91c6-4f0e-b5b9-7d9b542cdd15"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("a0c7644a-73b7-4b3a-b457-7e51e1f63a17"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("a0fc64ff-fa2b-4d7d-9650-3a083ebdca24"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("a3fe58cc-ba59-4e09-96a1-4f9e8f77f99b"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("ad85a600-f97a-42f0-a951-40b9a4b3c993"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("b36a20bc-04a1-4c9c-8a07-5270d1526c7e"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("b68c8431-5b79-4492-9f60-9f977fd471d7"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("b75197d8-5d56-4b1d-8a5c-1a2c8c7b73d0"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("b8fd88fb-647e-4130-83ed-801a9abf5e75"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("bea11ee9-0d72-4d56-b27c-33095a0787a7"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("c0e4e1d2-0c43-41f1-952f-788496ab6f8f"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("c878736d-da07-4401-ab27-2743d4e035c5"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("d48b865a-10ef-4f6e-aae9-58ef614fc16f"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("d65a624a-c81b-4ed1-af0a-8b27ac872e6e"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("d8b23e3c-f1d1-47be-82b6-77a4c5e67f35"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("e1e8b1f7-0a07-428e-bc1d-c08dbd5c6744"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("ed7f120f-0c7d-4bcf-a733-2b4de2a50b1b"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("f0d98d33-4c4f-4d87-9a5f-33fe7c1ab7a2"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("f52e7de3-46d6-40cc-9e67-3d28b1dd84d9"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("f840d9d0-7ecf-4b7c-b4e6-50118a1f6712"));

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: new Guid("bc5b6b69-c641-4105-a906-19b88dbbb4ae"));

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("8c22ffaa-6cb7-43c9-8f7f-4a204663df42"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("08d03e3d-0919-4c01-a6db-78c2abfc4d5e"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("15dc8b5e-f87e-4ee6-8f0b-6c1f1e2f5eb1"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("262342b2-861e-4802-a54c-c84522188cd7"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("2d75a3c6-1e6b-4740-afaa-60e33bcb77e3"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("3fde47fd-c654-4124-bc46-88d3b9bfa4df"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("4d60248e-d3f1-43e0-978f-356947c53e15"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("5d146662-869d-477f-8f99-620ad1f3c1d1"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("5e8eae8c-7d72-4dc0-9832-6ae82f5a42ed"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("6b24c35d-8589-4d35-83be-dfc48f0c8a79"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("6c9645b5-3f50-4a11-8be0-314a97c27eb8"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("82e5f6d3-1d4a-4bc2-96d0-2d8f7852bc7e"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("8842e1a3-18e2-4aa7-8b66-55150248a33a"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("997f8ae9-cc5d-4b19-9dd7-0f1d287106e9"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("9b17852c-5733-494d-8c37-ecf91fbc668f"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("a633f860-97ce-4d9a-9960-2091db4aee78"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("bf9e77fd-3d3a-4a77-aae9-123d03b9a2e4"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("c138c0a3-0dbd-4b9c-9533-d860bb4d1364"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("d1c9e7c7-ee5e-4ae7-8d5e-bdb94e10bcb9"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("d982cc75-bcfc-4c66-8dd6-23b1e87866e5"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("ddaa72b5-3a20-46d7-8c48-c6c7c9ea2564"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("e43d89cd-398d-4dbb-99e6-789869f891f3"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("e9481c7b-c007-46de-b706-4775c1d9c6de"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("f0a91ef7-1eaa-40d0-8273-0401bea48b5c"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("f89c0c4d-59e4-4b9a-b95f-8c6d2fb4208b"));

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "Code", "Email", "IsActive", "Name", "Password" },
                values: new object[,]
                {
                    { new Guid("03810320-12e9-435f-9d8b-473572074360"), 0, "liluzivert@gmail.com", false, "Lil Uzi Vert", "1111" },
                    { new Guid("a62f20f1-a42d-41cb-8c17-890cc61b4b14"), 0, "playboi@gmail.com", false, "Playboi Carti", "1111" },
                    { new Guid("c878736d-da07-4401-ab27-2743d4e035c5"), 0, "xxxtentacion@gmail.com", false, "XXXtentacion", "1111" },
                    { new Guid("d3179697-703d-4ee8-998d-7674119309a5"), 0, "bourne@gmail.com", false, "Pi'erre Bourne", "1111" }
                });

            migrationBuilder.UpdateData(
                table: "ArtistAlbums",
                keyColumn: "Id",
                keyValue: new Guid("30965a2d-b2eb-448b-bedb-56e56215f76f"),
                column: "ArtistId",
                value: new Guid("c878736d-da07-4401-ab27-2743d4e035c5"));

            migrationBuilder.UpdateData(
                table: "ArtistAlbums",
                keyColumn: "Id",
                keyValue: new Guid("86e9eb76-1f31-40b1-a655-6b7d6860a7bd"),
                column: "ArtistId",
                value: new Guid("a62f20f1-a42d-41cb-8c17-890cc61b4b14"));

            migrationBuilder.UpdateData(
                table: "ArtistAlbums",
                keyColumn: "Id",
                keyValue: new Guid("87cb0a2e-63f3-491c-b164-eac43dd743f4"),
                column: "ArtistId",
                value: new Guid("03810320-12e9-435f-9d8b-473572074360"));

            migrationBuilder.UpdateData(
                table: "ArtistAlbums",
                keyColumn: "Id",
                keyValue: new Guid("994a42cd-1c68-4fdb-b2b1-f0e9f4ee44a5"),
                column: "ArtistId",
                value: new Guid("d3179697-703d-4ee8-998d-7674119309a5"));

            migrationBuilder.UpdateData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("034fe159-32db-4875-9131-6426134d2743"),
                column: "ArtistId",
                value: new Guid("c878736d-da07-4401-ab27-2743d4e035c5"));

            migrationBuilder.UpdateData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("062c2665-7591-4c78-82da-da9fe95f2277"),
                column: "ArtistId",
                value: new Guid("c878736d-da07-4401-ab27-2743d4e035c5"));

            migrationBuilder.UpdateData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("1227371f-f8cb-409c-ae62-9a864ce52d62"),
                column: "ArtistId",
                value: new Guid("c878736d-da07-4401-ab27-2743d4e035c5"));

            migrationBuilder.UpdateData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("1d7ace2e-de9c-492a-b535-723fb24975cb"),
                column: "ArtistId",
                value: new Guid("c878736d-da07-4401-ab27-2743d4e035c5"));

            migrationBuilder.UpdateData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("38d003fd-762e-410b-b93c-3b4ef2ec39ca"),
                column: "ArtistId",
                value: new Guid("c878736d-da07-4401-ab27-2743d4e035c5"));

            migrationBuilder.UpdateData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("960c53c2-d34a-4692-9f2b-6d6fd1015868"),
                column: "ArtistId",
                value: new Guid("c878736d-da07-4401-ab27-2743d4e035c5"));

            migrationBuilder.UpdateData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("983414b0-1371-4327-bd66-684afc8e3d05"),
                column: "ArtistId",
                value: new Guid("c878736d-da07-4401-ab27-2743d4e035c5"));

            migrationBuilder.UpdateData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("d033186f-8ab5-435e-9874-5238e141b148"),
                column: "ArtistId",
                value: new Guid("c878736d-da07-4401-ab27-2743d4e035c5"));

            migrationBuilder.UpdateData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("dc4036b5-d7ef-4788-8b33-e21b42374005"),
                column: "ArtistId",
                value: new Guid("c878736d-da07-4401-ab27-2743d4e035c5"));

            migrationBuilder.UpdateData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("dc96bf29-f981-4cfe-9777-a459d0ab69db"),
                column: "ArtistId",
                value: new Guid("c878736d-da07-4401-ab27-2743d4e035c5"));

            migrationBuilder.UpdateData(
                table: "ArtistTracks",
                keyColumn: "Id",
                keyValue: new Guid("de175c65-a3a6-4204-a1b2-318abe039cee"),
                column: "ArtistId",
                value: new Guid("c878736d-da07-4401-ab27-2743d4e035c5"));
        }
    }
}
