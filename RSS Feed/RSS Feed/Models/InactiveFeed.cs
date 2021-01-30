using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSS_Feed.Models
{
    /// <summary>
    /// Information about the inactive feed
    /// </summary>
    public class InactiveFeed
    {
        public string Company { get; set; }
        public string FeedTitle { get; set; }
        public int DaysInactive { get; set; }
    }
}
