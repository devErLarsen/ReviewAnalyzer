using Microsoft.EntityFrameworkCore;

namespace ReviewAnalyzer.Data;
public class ApplicationDbContext : DbContext
{
    public DbSet<ReviewItem> ReviewItems { get; set; }
    public DbSet<Review> Reviews { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder) =>
        dbContextOptionsBuilder.UseSqlite("Data Source=Reviews.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        Random random = new();
        Review[] reviewsToSeed = new Review[69];
        ReviewItem reviewItemToSeed = new()
        {
            Id = 1,
            Name = "Test"
        };
        for (int i = 0; i < reviewsToSeed.Length; i++)
        {
            reviewsToSeed[i] = new Review
            {
                Id = i + 1,
                ReviewItemId = 1,
                Content = "Content is not important right now",
                Sentiment = SD.sentimentOptions[random.Next(0, 4)],
            };
        }
        modelBuilder.Entity<ReviewItem>().HasData(reviewItemToSeed);
        modelBuilder.Entity<Review>().HasData(reviewsToSeed);
    }
}

