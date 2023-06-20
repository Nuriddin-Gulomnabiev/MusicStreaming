using Domain.Entities.Artists;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistance.Configurations.Artists
{
    public class ArtistConfiguration : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            builder.Property(p => p.Id).IsRequired();
            builder.Property(p => p.Name).HasMaxLength(50).IsRequired();
            builder.Property(p => p.Code).IsRequired().ValueGeneratedOnAdd();
            builder.Property(p => p.Email).IsRequired();
            builder.Property(p => p.Password).IsRequired();

            builder.HasMany(p => p.Sessions).WithOne(t => t.Artist).HasForeignKey(t => t.ArtistId);

            builder.HasData(
                new Artist { Id = ArtistsIdEnum.XXXtentacion, Name = "XXXtentacion", Email = "xxxtentacion@gmail.com", Password = "1111" },
                new Artist { Id = ArtistsIdEnum.PlayboiCarti, Name = "Playboi Carti", Email = "playboi@gmail.com", Password = "1111" },
                new Artist { Id = ArtistsIdEnum.LilUziVert, Name = "Lil Uzi Vert", Email = "liluzivert@gmail.com", Password = "1111" },
                new Artist { Id = ArtistsIdEnum.PierreBourne, Name = "Pi'erre Bourne", Email = "bourne@gmail.com", Password = "1111" },
                new Artist { Id = ArtistsIdEnum.Beyonce, Name = "Beyoncé", Email = "beyonce@gmail.com", Password = "1111" },
                new Artist { Id = ArtistsIdEnum.EdSheeran, Name = "Ed Sheeran", Email = "edsheeran@gmail.com", Password = "1111" },
                new Artist { Id = ArtistsIdEnum.ArianaGrande, Name = "Ariana Grande", Email = "arianagrande@gmail.com", Password = "1111" },
                new Artist { Id = ArtistsIdEnum.Drake, Name = "Drake", Email = "drake@gmail.com", Password = "1111" },
                new Artist { Id = ArtistsIdEnum.TaylorSwift, Name = "Taylor Swift", Email = "taylorswift@gmail.com", Password = "1111" },
                new Artist { Id = ArtistsIdEnum.BrunoMars, Name = "Bruno Mars", Email = "brunomars@gmail.com", Password = "1111" },
                new Artist { Id = ArtistsIdEnum.Rihanna, Name = "Rihanna", Email = "rihanna@gmail.com", Password = "1111" },
                new Artist { Id = ArtistsIdEnum.KendrickLamar, Name = "Kendrick Lamar", Email = "kendricklamar@gmail.com", Password = "1111" },
                new Artist { Id = ArtistsIdEnum.BillieEilish, Name = "Billie Eilish", Email = "billieeilish@gmail.com", Password = "1111" },
                new Artist { Id = ArtistsIdEnum.JustinBieber, Name = "Justin Bieber", Email = "justinbieber@gmail.com", Password = "1111" }
            );
        }

        internal static class ArtistsIdEnum
        {
            public static readonly Guid XXXtentacion = new Guid("9b17852c-5733-494d-8c37-ecf91fbc668f");
            public static readonly Guid PlayboiCarti = new Guid("8c22ffaa-6cb7-43c9-8f7f-4a204663df42");
            public static readonly Guid LilUziVert = new Guid("c9c8d64c-fa56-4e2e-b8ef-6e41d00735e1");
            public static readonly Guid PierreBourne = new Guid("90ac1df8-837d-42af-a40a-a0cbd28770fd");
            public static readonly Guid Beyonce = new Guid("c90e2e7e-15d1-4a7c-8a8e-9f28e7f0c36f");
            public static readonly Guid EdSheeran = new Guid("d8956234-3e1b-4c14-ae78-9b7f1f598ef2");
            public static readonly Guid ArianaGrande = new Guid("f024e3f8-cf68-4c48-b288-b04e9c8b30c2");
            public static readonly Guid Drake = new Guid("a7ab352a-421d-4f78-9a5c-72d2cfa9c430");
            public static readonly Guid TaylorSwift = new Guid("87f352c1-ef43-41fb-b5c1-3a46e51868b8");
            public static readonly Guid BrunoMars = new Guid("640e13de-bd1e-4088-8651-44be51f2451d");
            public static readonly Guid Rihanna = new Guid("573a1d7c-694e-4f66-8905-8e528f137d27");
            public static readonly Guid KendrickLamar = new Guid("bcb0671f-572a-4495-b5df-3f2865e081b2");
            public static readonly Guid BillieEilish = new Guid("f2e16642-5d10-4195-8bc6-8b9dbb9dbd5a");
            public static readonly Guid JustinBieber = new Guid("81d19ab4-52a1-4e47-9766-2c7b682e89b3");
        }
    }
}
