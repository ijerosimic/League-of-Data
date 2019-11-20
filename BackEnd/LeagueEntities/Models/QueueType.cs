using System.Collections.Generic;

namespace LeagueEntities.Models
{
    public class QueueType
    {
        public int ID { get; set; }
        public string Description { get; set; }

        public ICollection<Match> Matches { get; set; }
        public ICollection<SummonerRankedLeague> SummonerRankedLeagues { get; set; }
    }
}
