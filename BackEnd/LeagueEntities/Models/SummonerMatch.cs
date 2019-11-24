using System.Collections.Generic;

namespace LeagueEntities.Models
{
    public class SummonerMatch
    {
        public SummonerMatch()
        {
            SummonerMatchesItems = new HashSet<SummonerMatchesItems>();
        }

        public int ID { get; set; }
        public string RoleName { get; set; }
        public string LaneName { get; set; }
        public int Kills { get; set; }
        public int Deaths { get; set; }
        public int Assists { get; set; }
        public int KillParticipation { get; set; }
        public decimal DamageDone { get; set; }
        public decimal GoldEarned { get; set; }
        public int WardsPlaced { get; set; }
        public int Item1 { get; set; }
        public int Item2 { get; set; }
        public int Item3 { get; set; }
        public int Item4 { get; set; }
        public int Item5 { get; set; }
        public int Item6 { get; set; }
        public string Trinket { get; set; }
        public string SummonerSpell1 { get; set; }
        public string SummonerSpell2 { get; set; }
        public string KeystoneRune { get; set; }
        public string MinorRune { get; set; }
        public string Team { get; set; }

        public int SummonerID { get; set; }
        public int ChampionID { get; set; }
        public int MatchID { get; set; }
        
        public Summoner Summoner { get; set; }
        public Champion Champion { get; set; }
        public Match Match { get; set; }
        public ICollection<SummonerMatchesItems> SummonerMatchesItems { get; set; }
    }
}
