using System.Collections.Generic;

namespace RSS_Feed.Data
{
    public interface IRepository
    {
        Dictionary<string, List<string>> GetFeeds(string filter);
    }
}