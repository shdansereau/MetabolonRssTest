using RSS_Feed.Data;
using RSS_Feed.Models;
using RSS_Feed.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace RSS_Feed
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            _repository = new FakeRepository();

        }

        public FakeRepository _repository { get; private set; }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // I always like to center my forms
            CenterToScreen();

            // Initializing combobox with selections
            cbFeeds.Items.Add("ALL");
            foreach (var feed in _repository.GetFeeds("ALL"))
            {
                cbFeeds.Items.Add(feed.Key);
            }

            cbFeeds.SelectedIndex = 0;
        }

        private async void btnGetInactiveFeeds_Click(object sender, EventArgs e)
        {
            // There could be a wait to get the data 
            lblCount.Text = "Getting feeds please wait...";

            IRssService service = new RssService();
            List<InactiveFeed> feeds = await service.ProcessFeeds(_repository.GetFeeds(cbFeeds.Text), Convert.ToInt32(nudDaysInactive.Value));
            LoadGrid(feeds);
        }

        public void LoadGrid(List<InactiveFeed> feeds)
        {
            dgvInactiveFeeds.DataSource = feeds;
            // Formatting the columns
            dgvInactiveFeeds.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvInactiveFeeds.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvInactiveFeeds.Columns[2].SortMode = DataGridViewColumnSortMode.Programmatic;

            lblCount.Text = feeds.Count.ToString();
        }

    }
}
