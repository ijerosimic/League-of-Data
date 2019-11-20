namespace LeagueEntities.Models
{
    public class ChampionTags
    {
        public int ID { get; set; }

        public int ChampionID { get; set; }
        public int TagID { get; set; }

        public Champion Champion { get; set; }
        public Tag Tag { get; set; }
    }
}
