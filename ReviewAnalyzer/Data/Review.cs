using System.ComponentModel.DataAnnotations;

namespace ReviewAnalyzer.Data;

public class Review
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    [MinLength(16, ErrorMessage = "Please enter a review of a least 16 characters.")]
    public string Content { get; set; }
    public string Sentiment { get; set; }

}

