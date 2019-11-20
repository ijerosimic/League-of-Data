using LeagueEntities.Models;
using LeagueServices.SummonerService.Dto;
using System.Linq;

namespace LeagueServices.SummonerService.QueryObjects
{
    public static class SummonerMatchesMapper
    {
        public static IQueryable<SummonerMatchesDto> MapSummonerMatchesToDto(
            this IQueryable<SummonerMatches> summonerMatches)
        {
            return summonerMatches
                .Select(x => new SummonerMatchesDto
                {
                    MatchID = x.MatchID,
                    ChampionPlayed = x.Champion.ChampionName,
                    RoleName = x.RoleName,
                    LaneName = x.LaneName,
                    HasWon = true,
                    IsRanked = true,
                    MatchDuration = x.Match.MatchDuration,
                    MatchCreation = x.Match.MatchCreation,
                    GameMode = x.Match.GameMode,
                    GameType = x.Match.GameType,
                    MapName = x.Match.Map.MapName
                });
        }
    }
}
