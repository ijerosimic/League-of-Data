using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueServices.MatchService.Dto
{
    public class MatchDetailsDto
    {
        public long ID { get; set; }
        public int SeasonNo { get; set; }
        public int MatchDuration { get; set; }
        public DateTime MatchCreation { get; set; }
        public string GameVersion { get; set; }
        public string GameMode { get; set; }
        public string GameType { get; set; }
        public string MapName { get; set; }
        public string QueueType { get; set; }
        public string ServerName { get; set; }
    }
}
