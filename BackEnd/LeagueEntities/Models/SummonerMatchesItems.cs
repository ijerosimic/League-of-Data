using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueEntities.Models
{
    public class SummonerMatchesItems
    {
        public int ID { get; set; }

        public int SummonerMatchID { get; set; }
        public int ItemID { get; set; }

        public SummonerMatch SummonerMatch { get; set; }
        public Item Item { get; set; }
    }
}
