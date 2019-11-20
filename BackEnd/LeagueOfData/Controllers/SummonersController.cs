using System.Collections.Generic;
using System.Linq;
using LeagueDataAccess;
using LeagueServices.SummonerService;
using LeagueServices.SummonerService.Dto;
using Microsoft.AspNetCore.Mvc;
using static LeagueServices.SummonerService.QueryObjects.SummonerDtoFilter;

namespace LeagueOfData.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SummonersController : ControllerBase
    {
        readonly LeagueContext context;
        readonly GetSummonersService service;

        public SummonersController(
            LeagueContext context)
        {
            this.context = context;
            service = new GetSummonersService(context);
        }

        [HttpGet]
        public ActionResult<List<SummonerDto>> Get()
        {
            return service
              .GetSummoners(SummonerListFilterBy.NoFilter, null)
              .ToList();
        }

        [HttpGet("{summonerName}")]
        public IActionResult GetDetails(
            string summonerName)
        {
            if (summonerName is null)
                return BadRequest();

            var summoner = service
                .GetSummonerDetails(summonerName)
                .FirstOrDefault();

            if (summoner is null)
                return NotFound();

            return Ok(summoner);
        }

        [HttpGet("{summonerName}/matches/{lastNMatches}")]
        public IActionResult GetSummonerMatches(
           string summonerName,
           int lastNMatches = 10)
        {
            if (summonerName is null)
                return BadRequest();

            var matches = service
                .GetMostRecentMatchesBySummonerName(
                     summonerName, lastNMatches)
                .ToList();

            return Ok(matches);
        }
    }
}
