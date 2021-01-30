using RSS_Feed.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace RSS_Feed.Services
{
    public class RssService : IRssService
    {
        /// <summary>
        /// Returns a list of inactive feeds if any according to daysInactive required
        /// </summary>
        /// <param name="rssFeeds"></param>
        /// <param name="daysInactive"></param>
        /// <returns></returns>
        public async Task<List<InactiveFeed>> ProcessFeeds(Dictionary<string, List<string>> rssFeeds, int daysInactive)
        {
            List<InactiveFeed> inactiveFeeds = new List<InactiveFeed>();

            foreach (KeyValuePair<string, List<string>> rssFeed in rssFeeds)
            {
                foreach (var uri in rssFeed.Value)
                {
                    var urlObj = new Uri(uri);
                    XmlReader reader = XmlReader.Create(uri);
                    SyndicationFeed feed = await Task.Run(() => SyndicationFeed.Load(reader));
                    reader.Close();
                    foreach (SyndicationItem item in feed.Items)
                    {
                        String subject = item.Title.Text;

                        DateTimeOffset PublishedDate = item.PublishDate;

                        int inactiveDays = (DateTime.Now - PublishedDate).Days;
                        if (inactiveDays >= daysInactive)
                        {
                            InactiveFeed inactiveFeed = new InactiveFeed()
                            {
                                Company = rssFeed.Key,
                                FeedTitle = item.Title.Text,
                                DaysInactive = inactiveDays
                            };
                            inactiveFeeds.Add(inactiveFeed);
                        }

                    }
                }

            }

            return inactiveFeeds;
        }
    }
}
