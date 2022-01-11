using System.ComponentModel.DataAnnotations;

namespace ReviewAnalyzer.Data;
public class ReviewItem
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
}

