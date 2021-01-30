using System.ComponentModel;

namespace RSS_Feed.Models
{
    /// <summary>
    /// Information about the inactive feed
    /// </summary>
    public class InactiveFeed
    {
        public string Company { get; set; }

        [DisplayName("Feed Title")]
        public string FeedTitle { get; set; }

        [DisplayName("Days Inactive")]
        public int DaysInactive { get; set; }

        // Just incase it is needed to display on a combobox or something
        public override string ToString()
        {
            return FeedTitle;
        }
    }
}
