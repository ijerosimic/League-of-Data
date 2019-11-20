using System.Collections.Generic;
using System.Linq;
using LeagueDataAccess;
using LeagueEntities.Models;
using LeagueServices.ServerService;
using LeagueServices.ServerService.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace LeagueOfData.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServersController : ControllerBase
    {
        readonly LeagueContext context;

        public ServersController(
            LeagueContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<ServerDto> Get()
        {
            return new ListServersService(context)
                .GetServers()
                .ToList();
        }
    }
}
