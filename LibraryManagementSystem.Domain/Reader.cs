using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Domain;

public class Reader
{
    [Key]
    public int ReaderId { get; set; }

    [Required]
    [MaxLength(100)]
    public string FirstName { get; set; }

    [Required]
    [MaxLength(100)]
    public string LastName { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    public virtual ICollection<BookInteraction> BookInteractions { get; set; } = new List<BookInteraction>();
}