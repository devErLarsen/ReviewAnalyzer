using Microsoft.EntityFrameworkCore;

namespace ReviewAnalyzer.Data;
public class ApplicationDbContext : DbContext
{
    public DbSet<Review> Reviews { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder) =>
        dbContextOptionsBuilder.UseSqlite("Data Source=Reviews.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        Random random = new();
        Review[] reviewsToSeed = new Review[69];
        for (int i = 0; i < reviewsToSeed.Length; i++)
        {
            reviewsToSeed[i] = new Review
            {
                Id = i + 1,
                Name = SD.reviewItems[0],
                Content = "Content is not important right now",
                Sentiment = SD.sentimentOptions[random.Next(0, 4)],
            };
        }
        modelBuilder.Entity<Review>().HasData(reviewsToSeed);
    }
}

