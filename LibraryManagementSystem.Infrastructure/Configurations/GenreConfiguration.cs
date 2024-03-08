using LibraryManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryManagementSystem.Infrastructure.Configurations;

public class GenreConfiguration : IEntityTypeConfiguration<Genre>
{
    public void Configure(EntityTypeBuilder<Genre> builder)
    {
        builder.HasData(
            new Genre { Id = 1, Name = "Science Fiction" },
            new Genre { Id = 2, Name = "Non-Fiction" },
            new Genre { Id = 3, Name = "Mystery" },
            new Genre { Id = 4, Name = "Fantasy" },
            new Genre { Id = 5, Name = "Historical Fiction" }
        );
    }
}