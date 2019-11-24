using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueEntities.Models
{
    public class Item
    {
        public Item()
        {
            SummonerMatchesItems = new HashSet<SummonerMatchesItems>();
        }

        public int ID { get; set; }
        public string ItemName { get; set; }

        public ICollection<SummonerMatchesItems> SummonerMatchesItems { get; set; }
    }
}
