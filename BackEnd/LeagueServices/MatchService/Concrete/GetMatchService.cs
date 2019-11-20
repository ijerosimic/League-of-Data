using LeagueDataAccess;
using LeagueServices.MatchService.Dto;
using LeagueServices.MatchService.QueryObjects;
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

        public IQueryable<MatchDetailsDto> GetMatchDetails(
            long matchID)
        {
            return context.Matches
                .AsNoTracking()
                .Where(x => x.ID == matchID)
                .Include(x => x.Map)
                .Include(x => x.QueueType)
                .Include(x => x.Server)
                .MapMatchToDetailedDto();
        }
    }
}
