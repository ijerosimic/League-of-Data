using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueEntities.Models
{
    public class Server
    {
        public int ID { get; set; }
        public string ServerName { get; set; }

        public ICollection<Summoner> Summoners { get; set; }
        public ICollection<Match> Matches { get; set; }
    }
}
