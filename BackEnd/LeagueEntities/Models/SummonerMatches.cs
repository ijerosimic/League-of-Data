namespace LeagueEntities.Models
{
    public class SummonerMatches
    {
        public int ID { get; set; }
        public string RoleName { get; set; }
        public string LaneName { get; set; }
        public int SeasonNo { get; set; }
        public string ServerName { get; set; }

        public string SummonerID { get; set; }
        public int ChampionID { get; set; }
        public long MatchID { get; set; }
        
        public Summoner Summoner { get; set; }
        public Champion Champion { get; set; }
        public Match Match { get; set; }
    }
}
