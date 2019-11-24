namespace LeagueServices.SummonerService.Dto
{
    public class MatchSummonerDetailsDto : SummonerMatchesDto
    {
        public int SummonerID { get; set; }
        public string SummonerName { get; set; }
        public string ChampionName { get; set; }
        public int CreepScore { get; set; }
        public int Kills { get; set; }
        public int Deaths { get; set; }
        public int Assists { get; set; }
        public int KillParticipation { get; set; }
        public decimal DamageDone { get; set; }
        public decimal GoldEarned { get; set; }
        public int WardsPlaced { get; set; }
        public int Item1 { get; set; }
        public int Item2 { get; set; }
        public int Item3 { get; set; }
        public int Item4 { get; set; }
        public int Item5 { get; set; }
        public int Item6 { get; set; }
        public string Trinket { get; set; }
        public string SummonerSpell { get; set; }
        public string SummonerSpell2 { get; set; }
        public string KeystoneRune { get; set; }
        public string MinorRune { get; set; }
        public string Team { get; set; }
    }
}
