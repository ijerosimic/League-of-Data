namespace LeagueServices.SummonerService
{
    public class SummonerRankedLeagueDto
    {
        public string QueueType { get; set; }
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
    }
}
