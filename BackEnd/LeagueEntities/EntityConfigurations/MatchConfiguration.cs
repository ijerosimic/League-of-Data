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

            builder.HasData(new Match[]
            {
                new Match
                {
                    ID = 1,
                    SeasonNo = 5,
                    MatchDuration = 1804,
                    MatchCreation = DateTime.Now,
                    ServerID = 2,
                    GameMode = "CLASSIC",
                    GameType = "MATCHED_GAME",
                    MapID = 11,
                    QueueTypeID = 440
                },
                new Match
                {
                    ID = 2,
                    SeasonNo = 13,
                    MatchDuration = 2415,
                    MatchCreation = DateTime.Now,
                    ServerID = 2,
                    GameMode = "CLASSIC",
                    GameType = "MATCHED_GAME",
                    MapID = 11,
                    QueueTypeID = 440
                },
                new Match
                {
                    ID = 3,
                    SeasonNo = 13,
                    MatchDuration = 4151,
                    MatchCreation = DateTime.Now,
                    ServerID = 2,
                    GameMode = "CLASSIC",
                    GameType = "MATCHED_GAME",
                    MapID = 11,
                    QueueTypeID = 440
                },
                new Match
                {
                    ID = 4,
                    SeasonNo = 13,
                    MatchDuration = 2415,
                    MatchCreation = DateTime.Now,
                    ServerID = 2,
                    GameMode = "CLASSIC",
                    GameType = "MATCHED_GAME",
                    MapID = 11,
                    QueueTypeID = 440
                },
                new Match
                {
                    ID = 4,
                    SeasonNo = 13,
                    MatchDuration = 2415,
                    MatchCreation = DateTime.Now,
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
