using LeagueEntities.Models;
using LeagueServices.MatchService.Dto;
using System.Linq;

namespace LeagueServices.MatchService.QueryObjects
{
    public static class MatchesMapper
    {
        public static IQueryable<MatchDetailsDto> MapMatchToDetailedDto
        (this IQueryable<Match> summoner)
        {
            return summoner
                .Select(x => new MatchDetailsDto
                {
                    ID = x.ID,
                    SeasonNo = x.SeasonNo,
                    MatchDuration = x.MatchDuration,
                    MatchCreation = x.MatchCreation,
                    GameVersion = x.GameVersion,
                    GameMode = x.GameMode,
                    GameType = x.GameType,
                    MapName = x.Map.MapName,
                    QueueType = x.QueueType.Description,
                    ServerName = x.Server.ServerName
                });
        }
    }
}
