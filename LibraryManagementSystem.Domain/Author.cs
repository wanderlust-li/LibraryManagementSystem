using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Domain;

public class Author
{
    [Key]
    public int AuthorId { get; set; }

    [Required]
    [MaxLength(100)]
    public string FirstName { get; set; }

    [Required]
    [MaxLength(100)]
    public string LastName { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
    
}