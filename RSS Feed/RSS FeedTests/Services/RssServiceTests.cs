using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RSS_Feed.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RSS_Feed.Services.Tests
{
    [TestClass()]
    public class RssServiceTests
    {
        [TestMethod()]
        public void ProcessFeedsTest()
        {
            // Arrange
            List<InactiveFeed> inactiveFeeds = new List<InactiveFeed>()
            {
                new InactiveFeed
                {
                    Company = "Test Company 1",
                    FeedTitle = "Test Title 1",
                    DaysInactive = 7
                },
                new InactiveFeed
                {
                    Company = "Test Company 2",
                    FeedTitle = "Test Title 2",
                    DaysInactive = 8
                }
            };

            Mock<IRssService> mock = new Mock<IRssService>();
            mock.Setup(m => m.ProcessFeeds(It.IsAny<Dictionary<string, List<string>>>(), It.IsAny<int>())).ReturnsAsync(inactiveFeeds);


            // Act
            Task<List<InactiveFeed>> results = mock.Object.ProcessFeeds(new Dictionary<string, List<string>>(), 5);

            // Assery
            Assert.AreEqual(2, results.Result.Count);
        }

    }
}