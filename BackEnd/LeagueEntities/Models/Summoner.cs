using System.Collections.Generic;

namespace LeagueEntities.Models
{
    public class Summoner
    {
        public string ID { get; set; }
        public string AccountID { get; set; }
        public string PuuID { get; set; }
        public string SummonerName { get; set; }
        public int SummonerLevel { get; set; }
        public int Champion { get; set; }
        public int ChampionMasteryScore { get; set; }
        public int ProfileIconNumber { get; set; }

        public int ServerID { get; set; }

        public Server Server { get; set; }
        public ICollection<SummonerChampionMastery> SummonersChampionMasteries { get; set; }
        public ICollection<SummonerRankedLeague> SummonerRankedLeagues { get; set; }
        public ICollection<SummonerMatches> SummonerMatches { get; set; }
    }
}
