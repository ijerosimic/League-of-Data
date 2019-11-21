using LeagueDataAccess;
using LeagueEntities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueTests.Seeders
{
    public static class SummonersSeeder
    {
        public static LeagueContext SeedDbWithFiveSummoners(
            this LeagueContext context)
        {
            context.Summoners.AddRange(
                new Summoner
                {
                    ID = 1,
                    SummonerName = "Peasant Slayer",
                    SummonerLevel = 48,
                    ServerID = 2,
                    ProfileIconNumber = 2
                },
                new Summoner
                {
                    ID =2,
                    SummonerName = "Shimeshugar",
                    SummonerLevel = 99,
                    ServerID = 1,
                    ProfileIconNumber = 2
                },
                new Summoner
                {
                    ID = 3,
                    SummonerName = "Koomuch",
                    SummonerLevel = 90,
                    ServerID = 1,
                    ProfileIconNumber = 2
                },
                new Summoner
                {
                    ID = 4,
                    SummonerName = "ubnix",
                    SummonerLevel = 47,
                    ServerID = 1,
                    ProfileIconNumber = 2
                },
                new Summoner
                {
                    ID = 5,
                    SummonerName = "Major Alexander",
                    SummonerLevel = 60,
                    ServerID = 2,
                    ProfileIconNumber = 2
                }
                );

            context.SaveChanges();

            return context;
        }
    }
}
