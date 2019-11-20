using LeagueEntities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace LeagueEntities.EntityConfigurations
{
    public class MatchConfiguration : IEntityTypeConfiguration<Match>
    {
        public void Configure(EntityTypeBuilder<Match> builder)
        {
            builder.HasMany(m => m.SummonerMatches)
                .WithOne(sm => sm.Match)
                .HasForeignKey(sm => sm.MatchID)
                .HasPrincipalKey(m => m.ID);

            builder.HasOne(m => m.Server)
                .WithMany(s => s.Matches)
                .HasForeignKey(m => m.ServerID)
                .HasPrincipalKey(s => s.ID);

            builder.Property(m => m.ID)
                .IsRequired();

            builder.Property(m => m.ServerID)
                .IsRequired();

            builder.Property(m => m.MapID)
                .IsRequired();

            builder.Property(m => m.GameMode)
                .HasMaxLength(20);

            builder.Property(m => m.GameType)
                .HasMaxLength(20);

            builder.Property(m => m.GameVersion)
                .HasMaxLength(20);

            builder.HasData(new Match[]
            {
                new Match
                {
                    ID = 2234518599,
                    SeasonNo = 5,
                    MatchDuration = 1804,
                    MatchCreation = new DateTime(1438717661744),
                    GameVersion = "9.14.282.3231",
                    ServerID = 2,
                    GameMode = "CLASSIC",
                    GameType = "MATCHED_GAME",
                    MapID = 11,
                    QueueTypeID = 440
                },
                new Match
                {
                    ID = 2234479397,
                    SeasonNo = 13,
                    MatchDuration = 2415,
                    MatchCreation = new DateTime(1564310418265),
                    GameVersion = "9.14.282.3231",
                    ServerID = 2,
                    GameMode = "CLASSIC",
                    GameType = "MATCHED_GAME",
                    MapID = 11,
                    QueueTypeID = 440
                }
            });
        }
    }
}
