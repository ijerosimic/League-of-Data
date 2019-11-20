using System;

namespace LeagueServices.SummonerService.Dto
{
    public class SummonerChampionDto
    {
        public int ID { get; set; }
        public string ChampionName { get; set; }
        public int ChampionLevel { get; set; }
        public int ChampionPoints { get; set; }
        public DateTime LastPlayTime { get; set; }
        public int ChampionImageID { get; set; }
    }
}
