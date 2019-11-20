namespace LeagueEntities.Models
{
    public class ChampionStats
    {
        public int ID { get; set; }
        public string ResourceType { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Magic { get; set; }
        public int Difficulty { get; set; }
        public decimal HitPoints { get; set; }
        public decimal HitPointsPerLevel { get; set; }
        public decimal ManaPoints { get; set; }
        public decimal ManaPointsPerLevel { get; set; }
        public decimal MoveSpeed { get; set; }
        public decimal Armor { get; set; }
        public decimal ArmorPerLevel { get; set; }
        public decimal SpellBlock { get; set; }
        public decimal SpellBlockPerLevel { get; set; }
        public decimal AttackRange { get; set; }
        public decimal HitPointsRegen { get; set; }
        public decimal HitPointsRegenPerLevel { get; set; }
        public decimal ManaPointsRegen { get; set; }
        public decimal ManaPointsRegenPerLevel { get; set; }
        public decimal CritChance { get; set; }
        public decimal CritChancePerLevel { get; set; }
        public decimal AttackDamage { get; set; }
        public decimal AttackDamagePerLevel { get; set; }
        public decimal AttackSpeedOffset { get; set; }
        public decimal AttackSpeedPerLevel { get; set; }

        public int ChampionID { get; set; }

        public Champion Champion { get; set; }
    }
}
