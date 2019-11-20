using System.Collections.Generic;

namespace LeagueEntities.Models
{
    public class Map
    {
        public int ID { get; set; }
        public string MapName { get; set; }

        public ICollection<Match> Matches { get; set; }
    }
}
