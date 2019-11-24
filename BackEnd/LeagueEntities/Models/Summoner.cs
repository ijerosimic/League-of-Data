using System.Collections.Generic;

namespace LeagueEntities.Models
{
    public class Summoner
    {
        public Summoner()
        {
            SummonerChampionMasteries = new HashSet<SummonerChampionMastery>();
            SummonerRankedLeagues= new HashSet<SummonerRankedLeague>();
            SummonerMatches = new HashSet<SummonerMatch>();
        }

        public int ID { get; set; }
        public string SummonerName { get; set; }
        public int SummonerLevel { get; set; }
        public int Champion { get; set; }
        public int ChampionMasteryScore { get; set; }
        public int ProfileIconNumber { get; set; }

        public int ServerID { get; set; }

        public Server Server { get; set; }
        public ICollection<SummonerChampionMastery> SummonerChampionMasteries { get; set; }
        public ICollection<SummonerRankedLeague> SummonerRankedLeagues { get; set; }
        public ICollection<SummonerMatch> SummonerMatches { get; set; }
    }
}
