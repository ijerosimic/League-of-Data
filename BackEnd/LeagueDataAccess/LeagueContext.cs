using LeagueEntities.Models;
using LeagueEntities.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace LeagueDataAccess
{
    public class LeagueContext : DbContext
    {
        public LeagueContext()
        {
        }

        public LeagueContext(DbContextOptions<LeagueContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.EnableSensitiveDataLogging();
        }

        public DbSet<Summoner> Summoners { get; set; }
        public DbSet<SummonerChampionMastery> SummonersChampionMasteries { get; set; }
        public DbSet<Champion> Champions { get; set; }
        public DbSet<ChampionStats> ChampionsStats { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<SummonerMatches> SummonerMatches { get; set; }
        public DbSet<Map> Maps { get; set; }
        public DbSet<QueueType> QueueTypes { get; set; }
        public DbSet<SummonerRankedLeague> SummonerRankedLeagues { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<ChampionTags> ChampionTags { get; set; }
        public DbSet<Server> Servers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SummonerConfiguration());
            modelBuilder.ApplyConfiguration(new SummonersChampionMasteryConfiguration());
            modelBuilder.ApplyConfiguration(new ChampionConfiguration());
            modelBuilder.ApplyConfiguration(new ChampionStatsConfiguration());
            modelBuilder.ApplyConfiguration(new MatchConfiguration());
            modelBuilder.ApplyConfiguration(new SummonerMatchesConfiguration());
            modelBuilder.ApplyConfiguration(new MapConfiguration());
            modelBuilder.ApplyConfiguration(new QueueTypeConfiguration());
            modelBuilder.ApplyConfiguration(new TagConfiguration());
            modelBuilder.ApplyConfiguration(new SummonerRankedLeagueConfiguration());
            modelBuilder.ApplyConfiguration(new ChampionTagsConfiguration());
            modelBuilder.ApplyConfiguration(new ServerConfiguration());
        }
    }
}
