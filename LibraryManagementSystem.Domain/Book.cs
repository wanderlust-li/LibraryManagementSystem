using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementSystem.Domain;

public class Book
{
    [Key]
    public int BookId { get; set; }

    [MaxLength(255)]
    public string Title { get; set; }

    public int PublicationYear { get; set; }

    [ForeignKey("Genre")]
    public int GenreId { get; set; }
    public Genre Genre { get; set; }

    public ICollection<Author> AuthorBooks { get; set; } = new List<Author>();
}