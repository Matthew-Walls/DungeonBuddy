using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonBuddy.DungeonBuddyDataSetTableAdapters;

namespace DungeonBuddy
{
    public class DBMain
    {
        private DungeonBuddyDataSetTableAdapters.CampaignTableAdapter campaignTableAdapter;

        public DBMain()
        {
            campaignTableAdapter = new DungeonBuddyDataSetTableAdapters.CampaignTableAdapter();
        }

        public void CreateCampaign(string title, string dm, string desc, DateTime date)
        {
            campaignTableAdapter.Insert(title, desc, dm, date);
        }
    }
}
