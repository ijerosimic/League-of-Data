using LeagueEntities.Models;
using LeagueServices.SummonerService.Dto;
using System.Linq;

namespace LeagueServices.SummonerService.QueryObjects
{
    public static class SummonersMapper
    {
        public static IQueryable<SummonerDto> MapSummonerToDto
            (this IQueryable<Summoner> summoners)
        {
            return summoners
                .Select(s => new SummonerDto
                {
                    ID = s.ID,
                    SummonerName = s.SummonerName,
                    SummonerLevel = s.SummonerLevel,
                    ProfileIconID = s.ProfileIconNumber,
                    ServerName = s.Server.ServerName
                });
        }

        public static IQueryable<SummonerDetailsDto> MapSummonerToDetailedDto
            (this IQueryable<Summoner> summoner)
        {
            return summoner
                .Select(x => new SummonerDetailsDto
                {
                    ID = x.ID,
                    SummonerName = x.SummonerName,
                    SummonerLevel = x.SummonerLevel,
                    ServerName = x.Server.ServerName,
                    ProfileIconID = x.ProfileIconNumber,
                    SummonerChampionMasteryScore = x.ChampionMasteryScore
                });
        }
    }
}
