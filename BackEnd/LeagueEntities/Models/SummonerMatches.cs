namespace LeagueEntities.Models
{
    public class SummonerMatches
    {
        public int ID { get; set; }
        public string RoleName { get; set; }
        public string LaneName { get; set; }
        public int SeasonNo { get; set; }
        public string ServerName { get; set; }

        public int SummonerID { get; set; }
        public int ChampionID { get; set; }
        public int MatchID { get; set; }
        
        public Summoner Summoner { get; set; }
        public Champion Champion { get; set; }
        public Match Match { get; set; }
    }
}
