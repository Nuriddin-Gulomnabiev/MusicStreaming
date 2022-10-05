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
                new Genre { Id = new Guid("ae14797c-31cd-432a-b2de-b3db95a82ab4"), Name = "Трэп" },
                new Genre { Id = new Guid("8745e56f-b335-43fe-bd10-bad6bead0892"), Name = "Хип-Хоп" },
                new Genre { Id = new Guid("baa56e06-9672-4118-aee3-4098cec4581e"), Name = "Эмо" },
                new Genre { Id = new Guid("2f044c88-a983-4cf5-bcc1-a5d7764507ed"), Name = "Клауд-рэп" },
                new Genre { Id = new Guid("e2a8929f-2190-4329-bae1-83b170a3677f"), Name = "Альтернативный рок" }
            );
        }
    }
}
