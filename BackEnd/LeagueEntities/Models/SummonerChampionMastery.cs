using System;

namespace LeagueEntities.Models
{
    public class SummonerChampionMastery
    {
        public int ID { get; set; }
        public int ChampionLevel { get; set; }
        public int ChampionPoints { get; set; }
        public int TokensEarned { get; set; }
        public DateTime LastPlayTime { get; set; }
        public int ChampionPointsSinceLastLevel { get; set; }
        public int ChampionPointsUntilNextLevel { get; set; }

        public int SummonerID { get; set; }
        public int ChampionID { get; set; }

        public Summoner Summoner { get; set; }
        public Champion Champion { get; set; }
    }
}
