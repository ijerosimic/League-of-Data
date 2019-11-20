using System;

namespace LeagueServices.SummonerService.Dto
{
    public class SummonerMatchesDto
    {
        public long MatchID { get; set; }
        public string ChampionPlayed { get; set; }
        public string RoleName { get; set; }
        public string LaneName { get; set; }
        public bool HasWon { get; set; }
        public bool IsRanked { get; set; }
        public int MatchDuration { get; set; }
        public DateTime MatchCreation { get; set; }
        public string GameMode { get; set; }
        public string GameType { get; set; }
        public string MapName { get; set; }
    }
}
