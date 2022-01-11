using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReviewAnalyzer.Data;

public class Review
{
    [Key]
    public int Id { get; set; }
    [Range(1, int.MaxValue, ErrorMessage = "please pick an option")]
    public int ReviewItemId { get; set; }
    public ReviewItem? ReviewItem { get; set; }
    [Required]
    [MinLength(16, ErrorMessage = "Please enter a review of a least 16 characters.")]
    public string Content { get; set; }
    public string Sentiment { get; set; }

}

