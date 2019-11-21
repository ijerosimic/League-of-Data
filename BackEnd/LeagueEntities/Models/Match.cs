using System;
using System.Collections.Generic;

namespace LeagueEntities.Models
{
    public class Match
    {
        public int ID { get; set; }
        public int SeasonNo { get; set; }
        public int MatchDuration { get; set; }
        public DateTime MatchCreation { get; set; }
        public string GameMode { get; set; }
        public string GameType { get; set; }
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

        public int ServerID { get; set; }
        public int MapID { get; set; }
        public int QueueTypeID { get; set; }

        public Server Server { get; set; }
        public Map Map { get; set; }
        public QueueType QueueType { get; set; }
        public ICollection<SummonerMatches> SummonerMatches { get; set; }
    }
}
