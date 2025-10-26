using Domain.Entities.Artists;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static Infrastructure.Persistance.Configurations.Albums.AlbumConfiguration;
using static Infrastructure.Persistance.Configurations.Artists.ArtistConfiguration;

namespace Infrastructure.Persistance.Configurations.Artists
{
    public class ArtistAlbumConfiguration : IEntityTypeConfiguration<ArtistAlbum>
    {
        public void Configure(EntityTypeBuilder<ArtistAlbum> builder)
        {
            builder.Property(p => p.Id).IsRequired();
            builder.Property(p => p.ArtistId).IsRequired();
            builder.Property(p => p.AlbumId).IsRequired();

            builder.HasOne(p => p.Artist).WithMany(p => p.ArtistAlbums).HasForeignKey(p => p.ArtistId);
            builder.HasOne(p => p.Album).WithMany(p => p.ArtistAlbums).HasForeignKey(p => p.AlbumId);

            builder.HasData(
                new ArtistAlbum { AlbumId = AlbumIdEnum._17, ArtistId = ArtistsIdEnum.XXXtentacion, Id = new Guid("f68e2d7c-8981-488a-9ac2-1c44f87d12f9") },
                new ArtistAlbum { AlbumId = AlbumIdEnum.WholeLottaRed, ArtistId = ArtistsIdEnum.PlayboiCarti, Id = new Guid("44252f96-d18b-4061-bb7e-8528bf2ca81b") },
                new ArtistAlbum { AlbumId = AlbumIdEnum.RedWhite, ArtistId = ArtistsIdEnum.LilUziVert, Id = new Guid("1fc50e93-9e47-4d8d-8d24-d6301ae5333d") },
                new ArtistAlbum { AlbumId = AlbumIdEnum.LifeOfPierre5, ArtistId = ArtistsIdEnum.PierreBourne, Id = new Guid("8931706a-4462-4205-a2a1-aecff5967d3e") },
                new ArtistAlbum { AlbumId = AlbumIdEnum.Scorpion, ArtistId = ArtistsIdEnum.Drake, Id = new Guid("9b9253bb-3c36-4dbe-b3b6-460a73b9d2ca") },
                new ArtistAlbum { AlbumId = AlbumIdEnum.Divide, ArtistId = ArtistsIdEnum.EdSheeran, Id = new Guid("5d312d8f-b4f0-4e3e-bb4d-2a5e0b0a5852") },
                new ArtistAlbum { AlbumId = AlbumIdEnum.Sweetener, ArtistId = ArtistsIdEnum.ArianaGrande, Id = new Guid("bd271556-b143-4767-a355-23b21b3c7463") },
                new ArtistAlbum { AlbumId = AlbumIdEnum._1989, ArtistId = ArtistsIdEnum.TaylorSwift, Id = new Guid("2026349a-fad9-4820-994e-fb4cf29694ff") },
                new ArtistAlbum { AlbumId = AlbumIdEnum._24KMagic, ArtistId = ArtistsIdEnum.BrunoMars, Id = new Guid("7885c9db-c6cb-44c2-be3e-ef8632fcbc4c") },
                new ArtistAlbum { AlbumId = AlbumIdEnum.Anti, ArtistId = ArtistsIdEnum.Rihanna, Id = new Guid("036d4d0b-dac8-466c-b818-808135398925") },
                new ArtistAlbum { AlbumId = AlbumIdEnum.DAMN, ArtistId = ArtistsIdEnum.KendrickLamar, Id = new Guid("0eeb26f2-b91c-4aa8-b802-40274b727f43") },
                new ArtistAlbum { AlbumId = AlbumIdEnum.WhenWeAllFallAsleep, ArtistId = ArtistsIdEnum.BillieEilish, Id = new Guid("07326b5b-2aff-4714-82a9-84752c4e5dfc") },
                new ArtistAlbum { AlbumId = AlbumIdEnum.Purpose, ArtistId = ArtistsIdEnum.JustinBieber, Id = new Guid("5a2a1672-8b86-4a4b-b991-a1d9b9a55f4f") }
            );
        }
    }
}
