using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Domain.Entities;

public class Book
{
    [Key]
    public int Id { get; set; }

    [MaxLength(255)]
    public string Title { get; set; }

    public int PublicationYear { get; set; }
    
    public int GenreId { get; set; }
    public Genre Genre { get; set; }

    public int AuthorId { get; set; }
    public virtual Author Author { get; set; }
}