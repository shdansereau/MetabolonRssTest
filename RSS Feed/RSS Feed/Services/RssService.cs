using RSS_Feed.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSS_Feed.Services
{
    public class RssService
    {
        /// <summary>
        /// Returns a list of inactive feeds if any according to daysInactive required
        /// </summary>
        /// <param name="rssFeeds"></param>
        /// <param name="daysInactive"></param>
        /// <returns></returns>
        public List<InactiveFeed> ProcessFeeds(Dictionary<string, List<string>> rssFeeds, int daysInactive)
        {
            List<InactiveFeed> inactiveFeeds = new List<InactiveFeed>();

            return inactiveFeeds;
        }
    }
}
