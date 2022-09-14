using Domain.Entities.Albums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistance.Configurations.Albums
{
    public class AlbumConfiguration : IEntityTypeConfiguration<Album>
    {
        public void Configure(EntityTypeBuilder<Album> builder)
        {
            builder.ToTable("albums").HasKey("id");
            builder.Property(p => p.Id).IsRequired();
            builder.Property(p => p.Name).HasMaxLength(50).IsRequired();
            builder.Property(p => p.Code).IsRequired().ValueGeneratedOnAdd();
            builder.Property(p => p.ReleaseDate).HasColumnName("release_date").HasColumnType("date");
        }
    }
}
