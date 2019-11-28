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
                    BlueTeamKills = x.BlueKills,
                    BlueTeamGold = x.BlueGold,
                    BlueTeamTurrets = x.BlueTurrets,
                    BlueTeamDragons = x.BlueDragons,
                    BlueTeamBarons = x.BlueBarons,
                    BlueTeamElderDragons = x.BlueElder,
                    RedTeamKills = x.RedKills,
                    RedTeamGold = x.RedGold,
                    RedTeamTurrets = x.RedTurrets,
                    RedTeamDragons = x.RedDragons,
                    RedTeamBarons = x.RedBarons,
                    RedTeamElderDragons = x.RedElder,
                    Winner = x.Winner
                });
        }
    }
}
