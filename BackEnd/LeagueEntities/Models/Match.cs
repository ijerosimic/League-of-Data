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

        public int ServerID { get; set; }
        public int MapID { get; set; }
        public int QueueTypeID { get; set; }

        public Server Server { get; set; }
        public Map Map { get; set; }
        public QueueType QueueType { get; set; }
        public ICollection<SummonerMatches> SummonerMatches { get; set; }
    }
}
