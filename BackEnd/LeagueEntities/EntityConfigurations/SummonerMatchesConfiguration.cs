using LeagueEntities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace LeagueEntities.EntityConfigurations
{
    public class SummonerMatchesConfiguration : IEntityTypeConfiguration<SummonerMatches>
    {
        public void Configure(EntityTypeBuilder<SummonerMatches> builder)
        {
            builder.HasKey(m => new { m.SummonerID, m.MatchID });

            builder.Property(m => m.SummonerID)
              .HasMaxLength(100)
              .IsRequired();

            builder.Property(m => m.MatchID)
                .IsRequired();

            builder.HasOne(m => m.Match)
                .WithMany(m => m.SummonerMatches)
                .HasForeignKey(m => m.MatchID)
                .HasPrincipalKey(m => m.ID)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(m => m.Summoner)
                .WithMany(s => s.SummonerMatches)
                .HasForeignKey(m => m.SummonerID)
                .HasPrincipalKey(s => s.ID)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(m => m.ID)
                .UseIdentityColumn()
                .IsRequired();

            builder.Property(m => m.ChampionID)
                .IsRequired();

            builder.Property(m => m.SeasonNo)
                .IsRequired();

            //    builder.HasData(new SummonerMatches[]
            //    {
            //        new SummonerMatches
            //        {
            //            ID = 1,
            //            MatchID = 2234518599,
            //            ChampionID = 266,
            //            SummonerID = "T9CKkCvw9-rvYCGLYkvE8FnP-LbcucxCUTvOcRL6R6HsV84",
            //            RoleName = "DUO_SUPPORT",
            //            LaneName = "NONE",
            //            SeasonNo = 13
            //        },
            //        new SummonerMatches
            //        {
            //            ID = 2,
            //            MatchID = 2234479397,
            //            ChampionID = 266,
            //            SummonerID = "T9CKkCvw9-rvYCGLYkvE8FnP-LbcucxCUTvOcRL6R6HsV84",
            //            RoleName = "NONE",
            //            LaneName = "JUNGLE",
            //            SeasonNo = 13
            //        }
            //    });
            //}
        }
    }
}
