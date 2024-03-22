using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class PublisherConfiguration : IEntityTypeConfiguration<Publisher>
{
    public void Configure(EntityTypeBuilder<Publisher> builder)
    {
        builder.ToTable("Publishers").HasKey(p => p.Id);

        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.Name).HasColumnName("Name");
        builder.Property(p => p.Language).HasColumnName("Language");
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");

        builder.HasData(
            new Publisher() { Id = Guid.Parse("cbb7895d-a862-459c-9622-2a2f3f5be99e"), Name = "Can Yayınları", Language = "TR", CreatedDate = DateTime.UtcNow },
            new Publisher() { Id = Guid.Parse("65584687-00c3-4673-b2da-d7c287e12a7c"), Name = "Kapra Yayıncılık", Language = "TR", CreatedDate = DateTime.UtcNow },
            new Publisher() { Id = Guid.Parse("96946aaa-597d-4b96-a270-02a46204ebf6"), Name = "Alfa Yayınları", Language = "TR", CreatedDate = DateTime.UtcNow }
            );

        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
    }
}