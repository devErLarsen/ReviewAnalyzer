using Azure;
using Azure.AI.TextAnalytics;
using Microsoft.EntityFrameworkCore;

namespace ReviewAnalyzer.Data;
public class ReviewService
{
    private static readonly string endpoint = "<Your endpoint>";
    private static readonly string key = "<Your Key>";
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

    private string GetSentiment(string document)
    {
        Response<DocumentSentiment> response = client.AnalyzeSentiment(document);
        DocumentSentiment docSentiment = response.Value;
        return docSentiment.Sentiment.ToString();
    }
}

