using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Domain.Entities;

public class Author
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string FirstName { get; set; }

    [Required]
    [MaxLength(100)]
    public string LastName { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public int BookId { get; set; }
    public virtual ICollection<Book> Books { get; set; }

    
}