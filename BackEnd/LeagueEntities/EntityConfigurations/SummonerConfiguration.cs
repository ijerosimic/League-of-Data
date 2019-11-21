using LeagueEntities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeagueEntities.EntityConfigurations
{
    public class SummonerConfiguration : IEntityTypeConfiguration<Summoner>
    {
        public void Configure(EntityTypeBuilder<Summoner> builder)
        {
            builder.Property(s => s.ID)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(s => s.SummonerName)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(s => s.SummonerLevel)
                .IsRequired();

            builder.Property(s => s.ServerID)
                .IsRequired();

            builder.HasData(
                new Summoner
                {
                    ID = 1,
                    SummonerName = "golemko",
                    SummonerLevel = 133,
                    ServerID = 1,
                    ProfileIconNumber = 523
                },
                new Summoner
                {
                    ID = 2,
                    SummonerName = "Peasant Slayer",
                    SummonerLevel = 48,
                    ServerID = 1,
                    ProfileIconNumber = 1450
                },
                new Summoner
                {
                    ID = 3,
                    SummonerName = "Shimeshugar",
                    SummonerLevel = 99,
                    ServerID = 1,
                    ProfileIconNumber = 1459
                },
                new Summoner
                {
                    ID = 4,
                    SummonerName = "Koomuch",
                    SummonerLevel = 90,
                    ServerID = 1,
                    ProfileIconNumber = 4086
                },
                new Summoner
                {
                    ID = 5,
                    SummonerName = "ubnix",
                    SummonerLevel = 47,
                    ServerID = 1,
                    ProfileIconNumber = 658
                },
                new Summoner
                {
                    ID = 6,
                    SummonerName = "Major Alexander",
                    SummonerLevel = 60,
                    ServerID = 1,
                    ProfileIconNumber = 3569
                },
                new Summoner
                {
                     ID = 7,
                     SummonerName = "Major Alexander",
                     SummonerLevel = 60,
                     ServerID = 1,
                     ProfileIconNumber = 3589
                },
                new Summoner
                {
                    ID = 8,
                    SummonerName = "Bongiorno",
                    SummonerLevel = 35,
                    ServerID = 1,
                    ProfileIconNumber = 3615
                },
                new Summoner
                {
                    ID = 9,
                    SummonerName = "Nocturno",
                    SummonerLevel = 144,
                    ServerID = 1,
                    ProfileIconNumber = 3635
                },
                new Summoner
                {
                    ID = 10,
                    SummonerName = "Broxah",
                    SummonerLevel = 188,
                    ServerID = 1,
                    ProfileIconNumber = 3670
                });
        }
    }
}
