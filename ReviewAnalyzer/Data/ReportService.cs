using Microsoft.EntityFrameworkCore;

namespace ReviewAnalyzer.Data;
public class ReportService
{

    private readonly IDbContextFactory<ApplicationDbContext> _contextFactory;

    public ReportService(IDbContextFactory<ApplicationDbContext> contextFactory)
    {
        _contextFactory = contextFactory;
    }
    public Task<Dictionary<string, Dictionary<string, double>>> getRapports()
    {
        using var context = _contextFactory.CreateDbContext();
        Dictionary<string, Dictionary<string, double>> allResults = new();
        foreach(var item in SD.reviewItems)
        {
            var recordsFromDb = context.Reviews.Where(r => r.Name == item).ToList();
            Dictionary<string, double> result = new();
            foreach (var sentiment in SD.sentimentOptions)
            {
                result.Add(sentiment, recordsFromDb.Where(i => i.Sentiment == sentiment).Count());
            }
            allResults.Add(item, result);
        }
        
        return Task.FromResult<Dictionary<string, Dictionary<string, double>>>(allResults);
    }
}

