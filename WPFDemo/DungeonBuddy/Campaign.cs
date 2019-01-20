using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonBuddy
{
    public class Campaign
    {
        private string _Title;
        private string _DM;
        private DateTime _Date;
        private string _Desc;

        public Campaign(string title, string dm, DateTime date, string desc)
        {
            _Title = title;
            _DM = dm;
            _Date = date;
            _Desc = desc;
        }
    }
}
