using System;
using System.Collections.Generic;

namespace LeagueEntities.Models
{
    public class Match
    {
        public Match()
        {
            SummonerMatches = new HashSet<SummonerMatch>();
        }

        public int ID { get; set; }
        public int SeasonNo { get; set; }
        public int MatchDuration { get; set; }
        public DateTime MatchCreation { get; set; }
        public string GameMode { get; set; }
        public string GameType { get; set; }
        public int TotalKills { get; set; }
        public int TotalGold { get; set; }
        public int BlueKills { get; set; }
        public int BlueGold { get; set; }
        public int BlueTurrets { get; set; }
        public int BlueDragons { get; set; }
        public int BlueBarons { get; set; }
        public int BlueElder { get; set; }
        public int RedKills { get; set; }
        public int RedGold { get; set; }
        public int RedTurrets { get; set; }
        public int RedDragons { get; set; }
        public int RedBarons { get; set; }
        public int RedElder { get; set; }
        public string Winner { get; set; }

        public int ServerID { get; set; }
        public int MapID { get; set; }
        public int QueueTypeID { get; set; }

        public Server Server { get; set; }
        public Map Map { get; set; }
        public QueueType QueueType { get; set; }
        public ICollection<SummonerMatch> SummonerMatches { get; set; }
    }
}
