using LeagueEntities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace LeagueEntities.EntityConfigurations
{
    public class ChampionConfiguration : IEntityTypeConfiguration<Champion>
    {
        public void Configure(EntityTypeBuilder<Champion> builder)
        {
            builder.HasOne(c => c.ChampionStats)
                .WithOne(s => s.Champion)
                .HasForeignKey<ChampionStats>(s => s.ChampionID)
                .IsRequired(false); 

            builder.HasMany(c => c.SummonerMatches)
                .WithOne(sm => sm.Champion)
                .HasForeignKey(sm => sm.ChampionID)
                .HasPrincipalKey(c => c.ID);

            builder.Property(c => c.ChampionName)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(c => c.ChampionTitle)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(c => c.ChampionDescription)
                .HasMaxLength(500)
                .IsRequired();

            var champions = new List<Champion>();
            //for (var i = 1; i < 50; i++)
            //{
            //    champions.Add(new Champion
            //    {
            //        ID = i,
            //        ChampionName = "Champion " + i,
            //        ChampionDescription = "Desc",
            //        ChampionTitle = "Title",
            //    });
            //}

            champions.AddRange(new List<Champion>
            {
                new Champion
                {
                      ID = 266,
                    ChampionName = "Champion",
                    ChampionDescription = "Desc",
                    ChampionTitle = "Title",
                },
                new Champion
                {
                      ID = 103,
                    ChampionName = "Champion",
                    ChampionDescription = "Desc",
                    ChampionTitle = "Title",
                },
                new Champion
                {
                      ID = 12,
                    ChampionName = "Champion",
                    ChampionDescription = "Desc",
                    ChampionTitle = "Title",
                },
                new Champion
                {
                      ID = 32,
                    ChampionName = "Champion",
                    ChampionDescription = "Desc",
                    ChampionTitle = "Title",
                },
                new Champion
                {
                      ID = 164,
                    ChampionName = "Champion",
                    ChampionDescription = "Desc",
                    ChampionTitle = "Title",
                },
                new Champion
                {
                      ID = 42,
                    ChampionName = "Champion",
                    ChampionDescription = "Desc",
                    ChampionTitle = "Title",
                },
                new Champion
                {
                      ID = 131,
                    ChampionName = "Champion",
                    ChampionDescription = "Desc",
                    ChampionTitle = "Title",
                },
                new Champion
                {
                      ID = 9,
                    ChampionName = "Champion",
                    ChampionDescription = "Desc",
                    ChampionTitle = "Title",
                },
                new Champion
                {
                      ID = 79,
                    ChampionName = "Champion",
                    ChampionDescription = "Desc",
                    ChampionTitle = "Title",
                },
                new Champion
                {
                      ID = 420,
                    ChampionName = "Champion",
                    ChampionDescription = "Desc",
                    ChampionTitle = "Title",
                }
            });

            builder.HasData(champions);
        }
    }
}
