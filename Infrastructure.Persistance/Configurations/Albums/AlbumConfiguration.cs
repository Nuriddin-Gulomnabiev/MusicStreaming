using Domain.Entities.Albums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistance.Configurations.Albums
{
    public class AlbumConfiguration : IEntityTypeConfiguration<Album>
    {
        public void Configure(EntityTypeBuilder<Album> builder)
        {
            builder.Property(p => p.Id).IsRequired();
            builder.Property(p => p.Name).HasMaxLength(50).IsRequired();
            builder.Property(p => p.Code).IsRequired().ValueGeneratedOnAdd();
            builder.Property(p => p.ReleaseDate).HasColumnType("date").IsRequired();

            builder.HasMany(p => p.Tracks).WithOne(t => t.Album).HasForeignKey(t => t.AlbumId);

            builder.HasData(
                new Album { Id = AlbumIdEnum._17, Name = "17", ReleaseDate = new DateTime(2020, 1, 1) },
                new Album { Id = AlbumIdEnum.WholeLottaRed, Name = "Whole Lotta Red", ReleaseDate = new DateTime(2020, 1, 1) },
                new Album { Id = AlbumIdEnum.RedWhite, Name = "RED & WHITE", ReleaseDate = new DateTime(2020, 1, 1) },
                new Album { Id = AlbumIdEnum.LifeOfPierre5, Name = "Life Of Pi'erre 5", ReleaseDate = new DateTime(2020, 1, 1) },
                new Album { Id = AlbumIdEnum.Divide, Name = "Divide", ReleaseDate = new DateTime(2017, 3, 3) },
                new Album { Id = AlbumIdEnum.Sweetener, Name = "Sweetener", ReleaseDate = new DateTime(2018, 8, 17) },
                new Album { Id = AlbumIdEnum.Scorpion, Name = "Scorpion", ReleaseDate = new DateTime(2018, 6, 29) },
                new Album { Id = AlbumIdEnum._1989, Name = "1989", ReleaseDate = new DateTime(2014, 10, 27) },
                new Album { Id = AlbumIdEnum._24KMagic, Name = "24K Magic", ReleaseDate = new DateTime(2016, 11, 18) },
                new Album { Id = AlbumIdEnum.Anti, Name = "Anti", ReleaseDate = new DateTime(2016, 1, 28) },
                new Album { Id = AlbumIdEnum.DAMN, Name = "DAMN.", ReleaseDate = new DateTime(2017, 4, 14) },
                new Album { Id = AlbumIdEnum.WhenWeAllFallAsleep, Name = "When We All Fall Asleep, Where Do We Go?", ReleaseDate = new DateTime(2019, 3, 29) },
                new Album { Id = AlbumIdEnum.Purpose, Name = "Purpose", ReleaseDate = new DateTime(2015, 11, 13) }
            );
        }

        internal static class AlbumIdEnum
        {
            public static Guid _17 = new Guid("fe024194-aad4-462a-8fbd-8dd7b4a2cd90");
            public static Guid WholeLottaRed = new Guid("c7b12644-83a9-4ccd-8418-808b11d9755e");
            public static Guid RedWhite = new Guid("62e05eec-dfed-462d-abfe-7489534fad8b");
            public static Guid LifeOfPierre5 = new Guid("f7c43f96-79e4-4244-b21b-8ac476e54495");
            public static Guid Scorpion = new Guid("bc5b6b69-c641-4105-a906-19b88dbbb4ae");
            public static Guid Divide = new Guid("e4b2c83d-384f-4d68-bbd0-ef8fdd9e9d25");
            public static Guid Sweetener = new Guid("5711de71-8cb5-4be9-984f-d1683760a9a6");
            public static Guid _1989 = new Guid("73c8af54-d09b-4ef7-b646-901e59b868ed");
            public static Guid _24KMagic = new Guid("cc37dd0a-7831-4b4b-babb-259b4d06598d");
            public static Guid Anti = new Guid("d9d9d08b-5422-4458-a4de-34ac03a5f52e");
            public static Guid DAMN = new Guid("89901ee5-7d1f-48a4-8e92-83a9b5c76f1e");
            public static Guid WhenWeAllFallAsleep = new Guid("c3e23e47-c858-4c1c-9000-bd3f4e8fb1f0");
            public static Guid Purpose = new Guid("8b9dcb0b-2f8d-4f0c-8645-0e8d588a4f5e");
        }
    }
}
