using LeagueDataAccess;
using LeagueServices.MatchService.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace LeagueOfData.Controllers
{
    [Route("api/[controller]")]
    public class MatchesController : Controller
    {
        readonly LeagueContext context;
        readonly GetMatchService service;

        public MatchesController(
            LeagueContext context)
        {
            this.context = context;
            service = new GetMatchService(context);
        }

        [HttpGet("{matchID}")]
        public IActionResult GetDetails(long matchID)
        {
            if (matchID < 1)
                return BadRequest();

            var match = service
                .GetMatchDetails(matchID)
                .FirstOrDefault();

            if (match is null)
                return NotFound();

            return Ok(match);
        }
    }
}
