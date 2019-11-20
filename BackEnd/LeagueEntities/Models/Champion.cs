using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueEntities.Models
{
    public class Champion
    {
        public int ID { get; set; }
        public string ChampionName { get; set; }
        public string ChampionTitle { get; set; }
        public string ChampionDescription { get; set; }

        public ChampionStats ChampionStats { get; set; }
        public ICollection<SummonerChampionMastery> SummonersChampionMasteries { get; set; }
        public ICollection<ChampionTags> ChampionTags { get; set; }
        public ICollection<SummonerMatches> SummonerMatches { get; set; }
    }
}
