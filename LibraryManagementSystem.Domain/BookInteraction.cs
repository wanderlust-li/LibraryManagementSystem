using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementSystem.Domain;

public class BookInteraction
{
    public int BookInteractionId { get; set; }

    [ForeignKey("Book")]
    public int BookId { get; set; }
    public virtual Book Book { get; set; }

    [ForeignKey("Reader")]
    public int ReaderId { get; set; }
    public virtual Reader Reader { get; set; }

    public DateTime IssueDate { get; set; }
    public DateTime? ReturnDate { get; set; }
}