using RSS_Feed.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RSS_Feed.Services
{
    public interface IRssService
    {
        Task<List<InactiveFeed>> ProcessFeeds(Dictionary<string, List<string>> rssFeeds, int daysInactive);
    }
}