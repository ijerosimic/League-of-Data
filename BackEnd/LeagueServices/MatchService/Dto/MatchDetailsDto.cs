using LeagueServices.SummonerService.Dto;
using System;
using System.Collections.Generic;

namespace LeagueServices.MatchService.Dto
{
    public class MatchDetailsDto
    {
        public MatchDetailsDto()
        {
            SummonerDetails = new List<MatchSummonerDetailsDto>();
        }

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
        public int TotalKills { get; set; }
        public int TotalGold { get; set; }
        public int BlueTeamKills { get; set; }
        public int BlueTeamGold { get; set; }
        public int BlueTeamTurrets { get; set; }
        public int BlueTeamDragons { get; set; }
        public int BlueTeamBarons { get; set; }
        public int BlueTeamElderDragons { get; set; }
        public int RedTeamKills { get; set; }
        public int RedTeamGold { get; set; }
        public int RedTeamTurrets { get; set; }
        public int RedTeamDragons { get; set; }
        public int RedTeamBarons { get; set; }
        public int RedTeamElderDragons { get; set; }
        public string Winner { get; set; }
        public List<MatchSummonerDetailsDto> SummonerDetails { get; set; }
    }
}
