using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSS_Feed.Data
{
    public class FakeRepository : IRepository
    {
        public Dictionary<string, List<string>> GetFeeds(string filter)
        {
            Dictionary<string, List<string>> rssFeeds = new Dictionary<string, List<string>>()
            {
                { "NPR", new List<string>(){ "https://feeds.npr.org/510312/podcast.xml" } },
                { "Megaphone FM", new List<string>(){ "https://feeds.megaphone.fm/unlocking-us", "https://feeds.megaphone.fm/WWO8086402096" } },
                { "Art 19", new List<string>(){ "http://rss.art19.com/the-daily" } },
                //{ "", new List<string>(){ "" } }

            };

            return rssFeeds.Where(f => f.Key == filter || filter.Equals("ALL"))
                .Select(f => f)
                .OrderBy(f => f.Key)
                .ToDictionary(k => k.Key, v => v.Value);
        }
    }
}
