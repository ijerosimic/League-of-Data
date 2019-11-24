using LeagueEntities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace LeagueEntities.EntityConfigurations
{
    public class SummonersChampionMasteryConfiguration : IEntityTypeConfiguration<SummonerChampionMastery>
    {
        public void Configure(EntityTypeBuilder<SummonerChampionMastery> builder)
        {
            builder.HasKey(m => new { m.SummonerID, m.ChampionID });

            builder.Property(m => m.SummonerID)
              .HasMaxLength(100)
              .IsRequired();

            builder.Property(m => m.ChampionID)
                .IsRequired();

            builder.HasOne(m => m.Summoner)
                .WithMany(s => s.SummonerChampionMasteries)
                .HasForeignKey(m => m.SummonerID)
                .HasPrincipalKey(s => s.ID)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(m => m.Champion)
                .WithMany(c => c.SummonersChampionMasteries)
                .HasForeignKey(m => m.ChampionID)
                .HasPrincipalKey(c => c.ID)
                .OnDelete(DeleteBehavior.Restrict); 

            builder.Property(m => m.ID)
                .UseIdentityColumn()
                .IsRequired();

            builder.Property(m => m.ChampionLevel)
                .IsRequired();

            builder.Property(m => m.ChampionPoints)
                .IsRequired();

            //builder.HasData(new SummonerChampionMastery
            //{
            //    ID = 1,
            //    SummonerID = "T9CKkCvw9-rvYCGLYkvE8FnP-LbcucxCUTvOcRL6R6HsV84",
            //    ChampionID = 266,
            //    ChampionLevel = 3,
            //    ChampionPoints = 7558,
            //    TokensEarned = 0,
            //    LastPlayTime = new DateTime(1510372189000),
            //    ChampionPointsSinceLastLevel = 1558,
            //    ChampionPointsUntilNextLevel = 5042
            //});
        }
    }
}
