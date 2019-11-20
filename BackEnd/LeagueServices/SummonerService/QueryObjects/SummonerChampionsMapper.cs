using LeagueEntities.Models;
using LeagueServices.SummonerService.Dto;
using System.Linq;

namespace LeagueServices.SummonerService.QueryObjects
{
    public static class SummonerChampionsMapper
    {
        public static IQueryable<SummonerChampionDto> MapSummonerChampionsMasteryToDto(
            this IQueryable<SummonerChampionMastery> summonerChampionMastery)
        {
            return summonerChampionMastery
                .Select(x => new SummonerChampionDto
                {
                    ID = x.ID,
                    ChampionName = x.Champion.ChampionName,
                    ChampionLevel = x.ChampionLevel,
                    ChampionPoints = x.ChampionPoints,
                    LastPlayTime = x.LastPlayTime
                });
        }
    }
}
