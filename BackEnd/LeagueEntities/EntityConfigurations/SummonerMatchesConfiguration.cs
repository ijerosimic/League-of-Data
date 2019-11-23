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

            builder.HasData(new SummonerMatches[]
            {
                    new SummonerMatches
                    {
                        ID = 1,
                        MatchID = 1,
                        ChampionID = 266,
                        SummonerID = 1,
                        RoleName = "DUO_MARKSMAN",
                        LaneName = "BOTTOM",
                        Kills = 11,
                        Assists = 5,
                        Deaths = 18,
                        DamageDone = 43.511M,
                        GoldEarned = 21.523M,
                        WardsPlaced = 14,
                        KeystoneRune = "Lethal Tempo",
                        MinorRune = "Resolve",
                        Item1 = "Boots of Speed",
                        Item2 = "Infinity Edge",
                        Item3 = "BF Sword",
                        Item4 = "Statikk Shiv",
                        Item5 = "Essence Reaver",
                        Item6 = "Death's Dance",
                        Trinket = "Warding Totem",
                        Team = "Blue"
                    },
                    new SummonerMatches
                    {
                        ID = 2,
                        MatchID = 1,
                        ChampionID = 103,
                        SummonerID = 2,
                        RoleName = "SOLO_MID",
                        LaneName = "MID",
                         Kills = 11,
                        Assists = 5,
                        Deaths = 18,
                        DamageDone = 43.511M,
                        GoldEarned = 21.523M,
                        WardsPlaced = 14,
                        KeystoneRune = "Lethal Tempo",
                        MinorRune = "Resolve",
                        Item1 = "Boots of Speed",
                        Item2 = "Infinity Edge",
                        Item3 = "BF Sword",
                        Item4 = "Statikk Shiv",
                        Item5 = "Essence Reaver",
                        Item6 = "Death's Dance",
                        Trinket = "Warding Totem",
                        Team = "Blue"
                    },
                    new SummonerMatches
                    {
                        ID = 3,
                        MatchID = 1,
                        ChampionID = 12,
                        SummonerID = 3,
                        RoleName = "DUO_SUPPORT",
                        LaneName = "BOTTOM",
                         Kills = 11,
                        Assists = 5,
                        Deaths = 18,
                        DamageDone = 43.511M,
                        GoldEarned = 21.523M,
                        WardsPlaced = 14,
                        KeystoneRune = "Lethal Tempo",
                        MinorRune = "Resolve",
                        Item1 = "Boots of Speed",
                        Item2 = "Infinity Edge",
                        Item3 = "BF Sword",
                        Item4 = "Statikk Shiv",
                        Item5 = "Essence Reaver",
                        Item6 = "Death's Dance",
                        Trinket = "Warding Totem",
                        Team = "Blue"
                    },
                    new SummonerMatches
                    {
                        ID = 4,
                        MatchID = 1,
                        ChampionID = 32,
                        SummonerID = 4,
                        RoleName = "SOLO_JUNGLE",
                        LaneName = "JUNGLE",
                         Kills = 11,
                        Assists = 5,
                        Deaths = 18,
                        DamageDone = 43.511M,
                        GoldEarned = 21.523M,
                        WardsPlaced = 14,
                        KeystoneRune = "Lethal Tempo",
                        MinorRune = "Resolve",
                        Item1 = "Boots of Speed",
                        Item2 = "Infinity Edge",
                        Item3 = "BF Sword",
                        Item4 = "Statikk Shiv",
                        Item5 = "Essence Reaver",
                        Item6 = "Death's Dance",
                        Trinket = "Warding Totem",
                        Team = "Blue"
                    },
                    new SummonerMatches
                    {
                        ID = 5,
                        MatchID = 1,
                        ChampionID = 164,
                        SummonerID = 5,
                        RoleName = "SOLO_TOP",
                        LaneName = "TOP",
                         Kills = 11,
                        Assists = 5,
                        Deaths = 18,
                        DamageDone = 43.511M,
                        GoldEarned = 21.523M,
                        WardsPlaced = 14,
                        KeystoneRune = "Lethal Tempo",
                        MinorRune = "Resolve",
                        Item1 = "Boots of Speed",
                        Item2 = "Infinity Edge",
                        Item3 = "BF Sword",
                        Item4 = "Statikk Shiv",
                        Item5 = "Essence Reaver",
                        Item6 = "Death's Dance",
                        Trinket = "Warding Totem",
                        Team = "Blue"
                    },
                     new SummonerMatches
                    {
                        ID = 6,
                        MatchID = 1,
                        ChampionID = 42,
                        SummonerID = 6,
                        RoleName = "DUO_MARKSMAN",
                        LaneName = "BOTTOM",
                         Kills = 11,
                        Assists = 5,
                        Deaths = 18,
                        DamageDone = 43.511M,
                        GoldEarned = 21.523M,
                        WardsPlaced = 14,
                        KeystoneRune = "Lethal Tempo",
                        MinorRune = "Resolve",
                        Item1 = "Boots of Speed",
                        Item2 = "Infinity Edge",
                        Item3 = "BF Sword",
                        Item4 = "Statikk Shiv",
                        Item5 = "Essence Reaver",
                        Item6 = "Death's Dance",
                        Trinket = "Warding Totem",
                        Team = "Red"
                    },
                    new SummonerMatches
                    {
                        ID = 7,
                        MatchID = 1,
                        ChampionID = 131,
                        SummonerID = 7,
                        RoleName = "SOLO_MID",
                        LaneName = "MID",
                         Kills = 11,
                        Assists = 5,
                        Deaths = 18,
                        DamageDone = 43.511M,
                        GoldEarned = 21.523M,
                        WardsPlaced = 14,
                        KeystoneRune = "Lethal Tempo",
                        MinorRune = "Resolve",
                        Item1 = "Boots of Speed",
                        Item2 = "Infinity Edge",
                        Item3 = "BF Sword",
                        Item4 = "Statikk Shiv",
                        Item5 = "Essence Reaver",
                        Item6 = "Death's Dance",
                        Trinket = "Warding Totem",
                        Team = "Red"
                    },
                    new SummonerMatches
                    {
                        ID = 8,
                        MatchID = 1,
                        ChampionID = 9,
                        SummonerID = 8,
                        RoleName = "DUO_SUPPORT",
                        LaneName = "BOTTOM",
                         Kills = 11,
                        Assists = 5,
                        Deaths = 18,
                        DamageDone = 43.511M,
                        GoldEarned = 21.523M,
                        WardsPlaced = 14,
                        KeystoneRune = "Lethal Tempo",
                        MinorRune = "Resolve",
                        Item1 = "Boots of Speed",
                        Item2 = "Infinity Edge",
                        Item3 = "BF Sword",
                        Item4 = "Statikk Shiv",
                        Item5 = "Essence Reaver",
                        Item6 = "Death's Dance",
                        Trinket = "Warding Totem",
                        Team = "Red"
                    },
                    new SummonerMatches
                    {
                        ID = 9,
                        MatchID = 1,
                        ChampionID = 79,
                        SummonerID = 9,
                        RoleName = "SOLO_JUNGLE",
                        LaneName = "JUNGLE",
                         Kills = 11,
                        Assists = 5,
                        Deaths = 18,
                        DamageDone = 43.511M,
                        GoldEarned = 21.523M,
                        WardsPlaced = 14,
                        KeystoneRune = "Lethal Tempo",
                        MinorRune = "Resolve",
                        Item1 = "Boots of Speed",
                        Item2 = "Infinity Edge",
                        Item3 = "BF Sword",
                        Item4 = "Statikk Shiv",
                        Item5 = "Essence Reaver",
                        Item6 = "Death's Dance",
                        Trinket = "Warding Totem",
                        Team = "Red"
                    },
                    new SummonerMatches
                    {
                        ID = 10,
                        MatchID = 1,
                        ChampionID = 420,
                        SummonerID = 10,
                        RoleName = "SOLO_TOP",
                        LaneName = "TOP",
                         Kills = 11,
                        Assists = 5,
                        Deaths = 18,
                        DamageDone = 43.511M,
                        GoldEarned = 21.523M,
                        WardsPlaced = 14,
                        KeystoneRune = "Lethal Tempo",
                        MinorRune = "Resolve",
                        Item1 = "Boots of Speed",
                        Item2 = "Infinity Edge",
                        Item3 = "BF Sword",
                        Item4 = "Statikk Shiv",
                        Item5 = "Essence Reaver",
                        Item6 = "Death's Dance",
                        Trinket = "Warding Totem",
                        Team = "Red"
                    }
            });
        }
    }
}