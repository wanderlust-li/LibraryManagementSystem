using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Domain.Entities;

public class Genre
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; }
    
    
}