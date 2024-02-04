using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Domain;

public class Genre
{
    [Key]
    public int GenreId { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; }

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();

}