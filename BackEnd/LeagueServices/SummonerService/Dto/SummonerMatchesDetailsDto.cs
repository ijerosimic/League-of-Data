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
        public string Item1 { get; set; }
        public string Item2 { get; set; }
        public string Item3 { get; set; }
        public string Item4 { get; set; }
        public string Item5 { get; set; }
        public string Item6 { get; set; }
        public string Trinket { get; set; }
        public string SummonerSpell { get; set; }
        public string SummonerSpell2 { get; set; }
        public string KeystoneRune { get; set; }
        public string MinorRune { get; set; }
        public string Team { get; set; }
    }
}
