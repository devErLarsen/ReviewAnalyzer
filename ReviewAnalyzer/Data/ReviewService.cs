using Azure;
using Azure.AI.TextAnalytics;
using Microsoft.EntityFrameworkCore;

namespace ReviewAnalyzer.Data;
public class ReviewService
{
    private static readonly string endpoint = "";
    private static readonly string key = "";
    private static readonly TextAnalyticsClient client = new TextAnalyticsClient(new Uri(endpoint), new AzureKeyCredential(key));
    private readonly IDbContextFactory<ApplicationDbContext> _contextFactory;

    public ReviewService(IDbContextFactory<ApplicationDbContext> contextFactory)
    {
        _contextFactory = contextFactory;
    }

    public IDbContextFactory<ApplicationDbContext> ContextFactory { get; }

    public async Task<bool> AddReview(Review review)
    {
        try
        {
            review.Sentiment = GetSentiment(review.Content);
            using var context = _contextFactory.CreateDbContext();
            await context.Reviews.AddAsync(review);
            await context.SaveChangesAsync();
        }
        catch (Exception)
        {
            return false;
        }
        return true;
    }

    public async Task<bool> CreateReviewItem(ReviewItem reviewItem)
    {
        try
        {
            using var context = _contextFactory.CreateDbContext();
            await context.ReviewItems.AddAsync(reviewItem);
            await context.SaveChangesAsync();
        }
        catch (Exception)
        {
            return false;
        }
        return true;
    }

    public async Task<List<ReviewItem>> GetReviewItems()
    {
        using var context = _contextFactory.CreateDbContext();
        var reviewItemsFromDb = await context.ReviewItems.ToListAsync<ReviewItem>();
        return reviewItemsFromDb;
    }

    public async Task<bool> DeleteReviewItemAsync(ReviewItem reviewItem)
    {
        try
        {
            using var context = _contextFactory.CreateDbContext();
            context.ReviewItems.Remove(reviewItem);
            await context.SaveChangesAsync();
        }
        catch (Exception) { return false; }
        return true;
    }

    private string GetSentiment(string document)
    {
        Response<DocumentSentiment> response = client.AnalyzeSentiment(document);
        DocumentSentiment docSentiment = response.Value;
        return docSentiment.Sentiment.ToString();
    }

    public async Task<Dictionary<string, Dictionary<string, double>>> getRapports()
    {
        using var context = _contextFactory.CreateDbContext();
        var reviewItems = await context.ReviewItems.ToArrayAsync<ReviewItem>();
        Dictionary<string, Dictionary<string, double>> allResults = new();
        foreach (var item in reviewItems)
        {
            var recordsFromDb = context.Reviews.Where(r => r.ReviewItemId == item.Id).ToList();
            Dictionary<string, double> result = new();
            foreach (var sentiment in SD.sentimentOptions)
            {
                result.Add(sentiment, recordsFromDb.Where(i => i.Sentiment == sentiment).Count());
            }
            allResults.Add(item.Name, result);
        }

        return await Task.FromResult<Dictionary<string, Dictionary<string, double>>>(allResults);
    }
}

