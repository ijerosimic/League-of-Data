namespace LeagueEntities.Models
{
    public class SummonerRankedLeague
    {
        public int ID { get; set; }
        public string RankedLeagueName { get; set; }
        public string RankedLeagueTier { get; set; }
        public int RankedLeagueDivision { get; set; }
        public int NumberOfWins { get; set; }
        public int NumberOfLosses { get; set; }
        public bool HotStreak { get; set; }
        public bool IsVeteran { get; set; }
        public bool IsFreshBlood { get; set; }
        public bool IsInactive { get; set; }
        public int LeaguePoints { get; set; }

        public string SummonerID { get; set; }
        public int QueueTypeID { get; set; }

        public Summoner Summoner { get; set; }
        public QueueType QueueType { get; set; }
    }
}
