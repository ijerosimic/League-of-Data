using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueEntities.Models
{
    public class Server
    {
        public Server()
        {
            Summoners = new HashSet<Summoner>();
            Matches = new HashSet<Match>();
        }

        public int ID { get; set; }
        public string ServerName { get; set; }

        public ICollection<Summoner> Summoners { get; set; }
        public ICollection<Match> Matches { get; set; }
    }
}
