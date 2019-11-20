
namespace LeagueServices.SummonerService.Dto
{
    public class SummonerDetailsDto : SummonerDto
    {
        public SummonerDetailsDto()
        {
            RankedLeagueTier = "Unranked";
        }

        public int SummonerChampionMasteryScore { get; set; }
        public string RankedLeagueTier { get; set; }
        public int? RankedLeagueDivision { get; set; }
        public int? NumberOfWins { get; set; }
        public int? LeaguePoints { get; set; }
    }
}
