using LeagueEntities.Models;
using System.Linq;

namespace LeagueServices.SummonerService.QueryObjects
{
    public static class SummonerRankedLeagueMapper
    {
        public static IQueryable<SummonerRankedLeagueDto> MapSummonerRankedLeagueToDto(
            this IQueryable<SummonerRankedLeague> summonerRankedLeague)
        {
            return summonerRankedLeague
                .Select(x => new SummonerRankedLeagueDto
                {
                    QueueType = x.QueueType.Description,
                    RankedLeagueName = x.RankedLeagueName,
                    RankedLeagueTier = x.RankedLeagueTier,
                    RankedLeagueDivision = x.RankedLeagueDivision,
                    NumberOfWins = x.NumberOfWins,
                    NumberOfLosses = x.NumberOfLosses,
                    HotStreak = x.HotStreak,
                    IsVeteran = x.IsVeteran,
                    IsFreshBlood = x.IsFreshBlood,
                    IsInactive = x.IsInactive,
                    LeaguePoints = x.LeaguePoints
                });
        }
    }
}
