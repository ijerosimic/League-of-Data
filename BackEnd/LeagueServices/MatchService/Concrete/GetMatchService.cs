using LeagueDataAccess;
using LeagueServices.MatchService.Dto;
using LeagueServices.MatchService.QueryObjects;
using LeagueServices.SummonerService.QueryObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeagueServices.MatchService.Concrete
{
    public class GetMatchService
    {
        readonly LeagueContext context;

        public GetMatchService(
            LeagueContext context)
        {
            this.context = context;
        }

        public MatchDetailsDto GetMatchDetails(
            int matchID)
        {
            var matches = context.Matches
                .AsNoTracking()
                .Where(x => x.ID == matchID)
                .Include(x => x.Map)
                .Include(x => x.QueueType)
                .Include(x => x.Server)
                .Include(x => x.SummonerMatches)
                .MapMatchToDetailedDto()
                .FirstOrDefault();

            matches.SummonerMatchDetails.AddRange(
                context.SummonerMatches
                .Where(x => x.MatchID == matchID)
                .MapSummonerMatchesToDetailsDto()
                .ToList());

            return matches;
        }
    }
}
