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
        private DungeonBuddyDataSetTableAdapters.PlayersTableAdapter playerTableAdapter;
        public DBMain()
        {
            campaignTableAdapter = new DungeonBuddyDataSetTableAdapters.CampaignTableAdapter();
            playerTableAdapter = new DungeonBuddyDataSetTableAdapters.PlayersTableAdapter();
        }

        public void CreateCampaign(string title, string dm, string desc, DateTime date)
        {
            campaignTableAdapter.Insert(title, desc, dm, date);
        }

        public void CreatePlayer(int campaignID, string playerName, string size, string allign, string desc, string tag, int level, DateTime date, string race, string className)
        {
            playerTableAdapter.Insert(campaignID, playerName, size, allign, desc, tag, level, DateTime.Now, race, className);
        }
    }
}
