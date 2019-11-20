using LeagueDataAccess;
using LeagueServices.SummonerService.Dto;
using LeagueServices.SummonerService.QueryObjects;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using static LeagueServices.SummonerService.QueryObjects.SummonerDtoFilter;
using static LeagueServices.SummonerService.QueryObjects.SummonerRankedLeaguesFilter;

namespace LeagueServices.SummonerService
{
    public class GetSummonersService
    {
        readonly LeagueContext context;

        public GetSummonersService(
            LeagueContext context)
        {
            this.context = context;
        }

        public IQueryable<SummonerDto> GetSummoners(
           SummonerListFilterBy filterBy,
           string value)
        {
            return context.Summoners
                    .AsNoTracking()
                    .FilterSummonersBy(filterBy, value)
                    .MapSummonerToDto();
        }

        public IQueryable<SummonerDetailsDto> GetSummonerDetails(
            string summonerName)
        {
            var summoner = context.Summoners
                    .Include(x => x.SummonerRankedLeagues)
                    .AsNoTracking()
                    .Where(x => x.SummonerName.ToLower()
                            == summonerName.ToLower());

            if (summoner
                    .Select(x => x.SummonerRankedLeagues
                        .Any() == false)
                    .First())
                return summoner
                    .MapSummonerToDetailedDto();
            else
                return summoner
                     .Join(context.SummonerRankedLeagues
                       .Where(r => r.QueueTypeID
                         == (int)RankedLeagueQueueTypesEnum.RankedSolo5v5),
                    x => x.ID,
                    r => r.SummonerID,
                    (x, r) => new SummonerDetailsDto
                    {
                        ID = x.ID,
                        SummonerName = x.SummonerName,
                        SummonerLevel = x.SummonerLevel,
                        ServerName = x.Server.ServerName,
                        ProfileIconID = x.ProfileIconNumber,
                        SummonerChampionMasteryScore = x.ChampionMasteryScore,
                        RankedLeagueDivision = x.SummonerRankedLeagues.First().RankedLeagueDivision,
                        RankedLeagueTier = x.SummonerRankedLeagues.First().RankedLeagueTier,
                        LeaguePoints = x.SummonerRankedLeagues.First().LeaguePoints,
                        NumberOfWins = x.SummonerRankedLeagues.First().NumberOfWins
                    });
        }

        public IQueryable<SummonerMatchesDto> GetMostRecentMatchesBySummonerName(
            string summonerName,
            int count)
        {
            return context.SummonerMatches
                    .Where(x =>
                        x.Summoner.SummonerName.ToLower()
                        == summonerName.ToLower())
                    .Include(x => x.Match)
                        .ThenInclude(x => x.Map)
                    .MapSummonerMatchesToDto()
                    .OrderBy(x => x.MatchCreation)
                    .Take(count);
        }

        public IQueryable<SummonerChampionDto> GetTopChampionsBySummonerName(
            string summonerName,
            int count)
        {
            return context.SummonersChampionMasteries
                    .Where(x =>
                        x.Summoner.SummonerName.ToLower()
                        == summonerName.ToLower())
                    .Include(x => x.Champion)
                    .MapSummonerChampionsMasteryToDto()
                    .OrderBy(x => x.ChampionPoints)
                    .Take(count);
        }

        public IQueryable<SummonerRankedLeagueDto> GetRankedLeaguesBySummonerName(
            string summonerName)
        {
            return context.SummonerRankedLeagues
                     .Where(x =>
                         x.Summoner.SummonerName.ToLower()
                         == summonerName.ToLower())
                     .Include(x => x.QueueType)
                     .MapSummonerRankedLeagueToDto();
        }
    }
}
