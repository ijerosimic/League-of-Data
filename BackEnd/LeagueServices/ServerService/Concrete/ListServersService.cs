using LeagueDataAccess;
using LeagueEntities.Models;
using System.Linq;

namespace LeagueServices.ServerService.Concrete
{
    public class ListServersService
    {
        readonly LeagueContext context;

        public ListServersService(LeagueContext context)
        {
            this.context = context;
        }

        public IQueryable<ServerDto> GetServers()
        {
            return context.Servers
                .Select(x =>
                    new ServerDto
                    {
                        ID = x.ID,
                        ServerName = x.ServerName
                    });
        }
    }
}
