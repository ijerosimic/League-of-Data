using LeagueEntities.Models;
using LeagueServices.MatchService.Dto;
using LeagueServices.SummonerService.QueryObjects;
using System.Linq;

namespace LeagueServices.MatchService.QueryObjects
{
    public static class MatchesMapper
    {
        public static IQueryable<MatchDetailsDto> MapMatchToDetailedDto
        (this IQueryable<Match> match)
        {
            return match
                .Select(x => new MatchDetailsDto
                {
                    ID = x.ID,
                    SeasonNo = x.SeasonNo,
                    MatchDuration = x.MatchDuration,
                    MatchCreation = x.MatchCreation,
                    GameMode = x.GameMode,
                    GameType = x.GameType,
                    MapName = x.Map.MapName,
                    QueueType = x.QueueType.Description,
                    ServerName = x.Server.ServerName,
                    TotalKills = x.TotalKills,
                    TotalGold = x.TotalGold,
                    BlueTeamKills = x.BlueTeamKills,
                    BlueTeamGold = x.BlueTeamGold,
                    BlueTeamTurrets = x.BlueTeamTurrets,
                    BlueTeamDragons = x.BlueTeamDragons,
                    BlueTeamBarons = x.BlueTeamBarons,
                    BlueTeamElderDragons = x.BlueTeamElderDragons,
                    RedTeamKills = x.RedTeamKills,
                    RedTeamGold = x.RedTeamGold,
                    RedTeamTurrets = x.RedTeamTurrets,
                    RedTeamDragons = x.RedTeamDragons,
                    RedTeamBarons = x.RedTeamBarons,
                    RedTeamElderDragons = x.RedTeamElderDragons,
                    Winner = x.Winner
                });
        }
    }
}
