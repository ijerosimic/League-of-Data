using LeagueEntities.Models;
using LeagueServices.SummonerService.Dto;
using System.Collections.Generic;
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

        public static IQueryable<SummonerMatchesDetailsDto> MapSummonerMatchesToDetailsDto(
            this IQueryable<SummonerMatches> summonerMatches)
        {
            return summonerMatches
                .Select(x => new SummonerMatchesDetailsDto
                {
                    Kills = x.Kills,
                    Deaths = x.Deaths,
                    Assists = x.Assists,
                    KillParticipation = x.KillParticipation,
                    DamageDone = x.DamageDone,
                    GoldEarned = x.GoldEarned,
                    WardsPlaced = x.WardsPlaced,
                    Item1 = x.Item1,
                    Item2 = x.Item2,
                    Item3 = x.Item3,
                    Item4 = x.Item4,
                    Item5 = x.Item5,
                    Item6 = x.Item6,
                    Trinket = x.Trinket,
                    SummonerSpell = x.SummonerSpell,
                    SummonerSpell2 = x.SummonerSpell2,
                    KeystoneRune = x.KeystoneRune,
                    MinorRune = x.MinorRune,
                    Team = x.Team
                });
        }
    }
}
