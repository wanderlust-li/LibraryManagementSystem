using LibraryManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Infrastructure.DatabaseContext;

public class LibraryManagementSystemContext : DbContext
{
    public LibraryManagementSystemContext(DbContextOptions<LibraryManagementSystemContext> options) : base(options)
    {
        
    }
    
    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Genre> Genres { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(LibraryManagementSystemContext).Assembly);
        
        base.OnModelCreating(modelBuilder);
    }
}