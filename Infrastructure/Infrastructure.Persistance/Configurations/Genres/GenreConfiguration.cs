using Domain.Entities.Genres;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistance.Configurations.Genres
{
    public class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.Property(p => p.Id).IsRequired();
            builder.Property(p => p.Name).HasMaxLength(50).IsRequired();
            builder.Property(p => p.Code).IsRequired().ValueGeneratedOnAdd();

            builder.HasData(
                new Genre { Id = GenreIdEnum.Trap, Name = "Трэп" },
                new Genre { Id = GenreIdEnum.HipHop, Name = "Хип-Хоп" },
                new Genre { Id = GenreIdEnum.Emo, Name = "Эмо" },
                new Genre { Id = GenreIdEnum.CloudRap, Name = "Клауд-рэп" },
                new Genre { Id = GenreIdEnum.AlternativeRock, Name = "Альтернативный рок" },
                new Genre { Id = GenreIdEnum.Pop, Name = "Поп" },
                new Genre { Id = GenreIdEnum.RnB, Name = "R&B" },
                new Genre { Id = GenreIdEnum.RhythmAndBlues, Name = "Ритм-н-блюз" },
                new Genre { Id = GenreIdEnum.PopRock, Name = "Поп-рок" },
                new Genre { Id = GenreIdEnum.Country, Name = "Кантри" },
                new Genre { Id = GenreIdEnum.Folk, Name = "Фолк" },
                new Genre { Id = GenreIdEnum.Metal, Name = "Металл" },
                new Genre { Id = GenreIdEnum.Blues, Name = "Блюз" },
                new Genre { Id = GenreIdEnum.Jazz, Name = "Джаз" },
                new Genre { Id = GenreIdEnum.Disco, Name = "диско" },
                new Genre { Id = GenreIdEnum.Romance, Name = "романс" }
            );
        }

        internal static class GenreIdEnum
        {
            public static Guid Trap = new Guid("ae14797c-31cd-432a-b2de-b3db95a82ab4");
            public static Guid HipHop = new Guid("8745e56f-b335-43fe-bd10-bad6bead0892");
            public static Guid Emo = new Guid("baa56e06-9672-4118-aee3-4098cec4581e");
            public static Guid CloudRap = new Guid("2f044c88-a983-4cf5-bcc1-a5d7764507ed");
            public static Guid AlternativeRock = new Guid("e2a8929f-2190-4329-bae1-83b170a3677f");
            public static Guid Pop = new Guid("ac38a647-9bc3-4a14-ae64-8c50964e307d");
            public static Guid RnB = new Guid("da7a689b-5b29-4c88-91ad-b543ce614e12");
            public static Guid RhythmAndBlues = new Guid("d35e2479-8214-41f2-b6d6-59b892602f16");
            public static Guid PopRock = new Guid("8ff3eaba-b2c6-4a1b-96c9-0f611d17e8c6");
            public static Guid Country = new Guid("a579446d-0ca1-4aae-8cad-5126ab41c203");
            public static Guid Folk = new Guid("f13c6c62-c6e2-4a37-9c17-99c0e9d8db42");
            public static Guid Metal = new Guid("b56de1bf-2c8e-4d1f-a727-9a5ebc3d6b2f");
            public static Guid Blues = new Guid("f1344d39-707e-4a7f-82e7-0816c21206d8");
            public static Guid Jazz = new Guid("7fa5ae48-7ed7-42a7-bb2a-4f4d0e502d7a");
            public static Guid Disco = new Guid("68f6170a-12b9-4f32-9e83-c81c61ad29b6");
            public static Guid Romance = new Guid("8c9c6d68-01f0-4e97-9640-d7a633788f53");

        }
    }
}
