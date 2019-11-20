﻿// <auto-generated />
using System;
using LeagueDataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LeagueDataAccess.Migrations
{
    [DbContext(typeof(LeagueContext))]
    [Migration("20191120221539_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0-preview3.19554.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LeagueEntities.Models.Champion", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ChampionDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("ChampionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("ChampionTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("ID");

                    b.ToTable("Champions");
                });

            modelBuilder.Entity("LeagueEntities.Models.ChampionStats", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Armor")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ArmorPerLevel")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Attack")
                        .HasColumnType("int");

                    b.Property<decimal>("AttackDamage")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("AttackDamagePerLevel")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("AttackRange")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("AttackSpeedOffset")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("AttackSpeedPerLevel")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ChampionID")
                        .HasColumnType("int");

                    b.Property<decimal>("CritChance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("CritChancePerLevel")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Defense")
                        .HasColumnType("int");

                    b.Property<int>("Difficulty")
                        .HasColumnType("int");

                    b.Property<decimal>("HitPoints")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("HitPointsPerLevel")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("HitPointsRegen")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("HitPointsRegenPerLevel")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Magic")
                        .HasColumnType("int");

                    b.Property<decimal>("ManaPoints")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ManaPointsPerLevel")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ManaPointsRegen")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ManaPointsRegenPerLevel")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MoveSpeed")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ResourceType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("SpellBlock")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SpellBlockPerLevel")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.HasIndex("ChampionID")
                        .IsUnique();

                    b.ToTable("ChampionsStats");
                });

            modelBuilder.Entity("LeagueEntities.Models.ChampionTags", b =>
                {
                    b.Property<int>("ChampionID")
                        .HasColumnType("int");

                    b.Property<int>("TagID")
                        .HasColumnType("int");

                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("ChampionID", "TagID");

                    b.HasIndex("TagID");

                    b.ToTable("ChampionTags");
                });

            modelBuilder.Entity("LeagueEntities.Models.Map", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MapName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("ID");

                    b.ToTable("Maps");

                    b.HasData(
                        new
                        {
                            ID = 11,
                            MapName = "Summoner's Rift"
                        },
                        new
                        {
                            ID = 3,
                            MapName = "The Proving Grounds"
                        },
                        new
                        {
                            ID = 4,
                            MapName = "Twisted Treeline"
                        },
                        new
                        {
                            ID = 12,
                            MapName = "Howling Abyss"
                        },
                        new
                        {
                            ID = 14,
                            MapName = "Butcher's Bridge"
                        });
                });

            modelBuilder.Entity("LeagueEntities.Models.Match", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GameMode")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("GameType")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("GameVersion")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<int>("MapID")
                        .HasColumnType("int");

                    b.Property<DateTime>("MatchCreation")
                        .HasColumnType("datetime2");

                    b.Property<int>("MatchDuration")
                        .HasColumnType("int");

                    b.Property<int>("QueueTypeID")
                        .HasColumnType("int");

                    b.Property<int>("SeasonNo")
                        .HasColumnType("int");

                    b.Property<int>("ServerID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("MapID");

                    b.HasIndex("QueueTypeID");

                    b.HasIndex("ServerID");

                    b.ToTable("Matches");

                    b.HasData(
                        new
                        {
                            ID = 2234518599L,
                            GameMode = "CLASSIC",
                            GameType = "MATCHED_GAME",
                            GameVersion = "9.14.282.3231",
                            MapID = 11,
                            MatchCreation = new DateTime(1, 1, 2, 15, 57, 51, 766, DateTimeKind.Unspecified).AddTicks(1744),
                            MatchDuration = 1804,
                            QueueTypeID = 440,
                            SeasonNo = 5,
                            ServerID = 2
                        },
                        new
                        {
                            ID = 2234479397L,
                            GameMode = "CLASSIC",
                            GameType = "MATCHED_GAME",
                            GameVersion = "9.14.282.3231",
                            MapID = 11,
                            MatchCreation = new DateTime(1, 1, 2, 19, 27, 11, 41, DateTimeKind.Unspecified).AddTicks(8265),
                            MatchDuration = 2415,
                            QueueTypeID = 440,
                            SeasonNo = 13,
                            ServerID = 2
                        });
                });

            modelBuilder.Entity("LeagueEntities.Models.QueueType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("ID");

                    b.ToTable("QueueTypes");

                    b.HasData(
                        new
                        {
                            ID = 440,
                            Description = "5v5 Ranked Flex games"
                        },
                        new
                        {
                            ID = 430,
                            Description = "5v5 Blind Pick games"
                        },
                        new
                        {
                            ID = 420,
                            Description = "5v5 Ranked Solo games"
                        },
                        new
                        {
                            ID = 400,
                            Description = "5v5 Draft Pick games"
                        });
                });

            modelBuilder.Entity("LeagueEntities.Models.Server", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ServerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(5)")
                        .HasMaxLength(5);

                    b.HasKey("ID");

                    b.ToTable("Servers");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            ServerName = "EUW1"
                        },
                        new
                        {
                            ID = 2,
                            ServerName = "EUN1"
                        });
                });

            modelBuilder.Entity("LeagueEntities.Models.Summoner", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("AccountID")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("Champion")
                        .HasColumnType("int");

                    b.Property<int>("ChampionMasteryScore")
                        .HasColumnType("int");

                    b.Property<int>("ProfileIconNumber")
                        .HasColumnType("int");

                    b.Property<string>("PuuID")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("ServerID")
                        .HasColumnType("int");

                    b.Property<int>("SummonerLevel")
                        .HasColumnType("int");

                    b.Property<string>("SummonerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("ID");

                    b.HasIndex("ServerID");

                    b.ToTable("Summoners");

                    b.HasData(
                        new
                        {
                            ID = "T9CKkCvw9-rvYCGLYkvE8FnP-LbcucxCUTvOcRL6R6HsV84",
                            AccountID = "E5vIgzYH88uYhb9LGTKuQG3IEoV8j9ny7pSP-ifKuWsx5Q",
                            Champion = 0,
                            ChampionMasteryScore = 0,
                            ProfileIconNumber = 2,
                            PuuID = "rXHD2A-8BMKblRThMFtTGqWevjlg1X0qY55BbfI2p9D72KrU779EO2by4NHXhfkalED2bKX6_sbhMQ",
                            ServerID = 2,
                            SummonerLevel = 133,
                            SummonerName = "golemko"
                        },
                        new
                        {
                            ID = "m7AAGJrMEY_BO-doJ_kS7WtUu1Y3Co4VZC6uwQhkn960LKg",
                            AccountID = "4gzX2nA07W0cRo07d2PzfwK8GsGsvnuhhhrl6nJmCiSh_HhsBaWzTF4B",
                            Champion = 0,
                            ChampionMasteryScore = 0,
                            ProfileIconNumber = 4,
                            PuuID = "IQ4P4RYUh2b9HKgQA7ToK-IFVOk7Om9Pgtu0zPRuRDcuq30DpWcMnGPfaVO-g_3_TfG9HXUnbjbmzg",
                            ServerID = 2,
                            SummonerLevel = 48,
                            SummonerName = "Peasant Slayer"
                        },
                        new
                        {
                            ID = "V05Y-rXHSb-k4QVBqotnMg-h613l0FZ1nhHh6lZK1Hyq0FQ",
                            AccountID = "huDSrcdoL641P1Cl_qb5Fn482RmH8CSnTVGnvWaI2Tntsg",
                            Champion = 0,
                            ChampionMasteryScore = 0,
                            ProfileIconNumber = 554,
                            PuuID = "wUU6zHnRHoPANkg8Hu-GzpDu2kSWW-Q-DUJr5em-rGIje82tfkLPyNf-lBS-r27dxuiOTAg2TNUYYg",
                            ServerID = 1,
                            SummonerLevel = 99,
                            SummonerName = "Shimeshugar"
                        },
                        new
                        {
                            ID = "-uVM7qgbYUtTbd9JwkAKguKkS6nj8jmm2fYPb2aOhT0N0sA",
                            AccountID = "rKb2TFXFSOzaV_HkOCjlnFMXF7kSAPTVXLGkfGxkLBKU8Q",
                            Champion = 0,
                            ChampionMasteryScore = 0,
                            ProfileIconNumber = 4086,
                            PuuID = "yQ4OOOwGe9cJXzndsssMNydOKKXqISSKrdY6L2xIPyDfy5CB1H-x6b4XTvwcfFWT6mvwL4rGFA7JFQ",
                            ServerID = 1,
                            SummonerLevel = 90,
                            SummonerName = "Koomuch"
                        },
                        new
                        {
                            ID = "ICRohXMWj5jWzLJrxgH82_xYJypMhum3UG_ZkI9UecRJNWk",
                            AccountID = "E5vIgzYH88uYhb9LGTKuQG3IEoV8j9ny7pSP-ifKuWsx5Q",
                            Champion = 0,
                            ChampionMasteryScore = 0,
                            ProfileIconNumber = 658,
                            PuuID = "C_XMHirlQ00s1Mg01HdI054DL3OPXo0EYMWuHO0xhqJs11RtZOvjdjifCJnm3x3KfsG1uQ76vjeqWQ",
                            ServerID = 1,
                            SummonerLevel = 47,
                            SummonerName = "ubnix"
                        },
                        new
                        {
                            ID = "0sIa8mv2kdRhUicAKIb0pMCtA9eEYivCAfAW7ZGBZz5qlME0",
                            AccountID = "_C6SbKcmVJlqt39rRSrezcQfQBbtF_AalXyoOpwK6Cl5wwkCj2tATFEt",
                            Champion = 0,
                            ChampionMasteryScore = 0,
                            ProfileIconNumber = 3,
                            PuuID = "fI3yFRsBsPj-M-BlsWxMRNQ15xjBVPx-af2DNhTma6F21r9231E-b61p36WyJ79ydFsIcqyZxNJcCg",
                            ServerID = 2,
                            SummonerLevel = 60,
                            SummonerName = "Major Alexander"
                        });
                });

            modelBuilder.Entity("LeagueEntities.Models.SummonerChampionMastery", b =>
                {
                    b.Property<string>("SummonerID")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("ChampionID")
                        .HasColumnType("int");

                    b.Property<int>("ChampionLevel")
                        .HasColumnType("int");

                    b.Property<int>("ChampionPoints")
                        .HasColumnType("int");

                    b.Property<int>("ChampionPointsSinceLastLevel")
                        .HasColumnType("int");

                    b.Property<int>("ChampionPointsUntilNextLevel")
                        .HasColumnType("int");

                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("LastPlayTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("TokensEarned")
                        .HasColumnType("int");

                    b.HasKey("SummonerID", "ChampionID");

                    b.HasIndex("ChampionID");

                    b.ToTable("SummonersChampionMasteries");
                });

            modelBuilder.Entity("LeagueEntities.Models.SummonerMatches", b =>
                {
                    b.Property<string>("SummonerID")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<long>("MatchID")
                        .HasColumnType("bigint");

                    b.Property<int>("ChampionID")
                        .HasColumnType("int");

                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LaneName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SeasonNo")
                        .HasColumnType("int");

                    b.Property<string>("ServerName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SummonerID", "MatchID");

                    b.HasIndex("ChampionID");

                    b.HasIndex("MatchID");

                    b.ToTable("SummonerMatches");
                });

            modelBuilder.Entity("LeagueEntities.Models.SummonerRankedLeague", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("HotStreak")
                        .HasColumnType("bit");

                    b.Property<bool>("IsFreshBlood")
                        .HasColumnType("bit");

                    b.Property<bool>("IsInactive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsVeteran")
                        .HasColumnType("bit");

                    b.Property<int>("LeaguePoints")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfLosses")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfWins")
                        .HasColumnType("int");

                    b.Property<int>("QueueTypeID")
                        .HasColumnType("int");

                    b.Property<int>("RankedLeagueDivision")
                        .HasColumnType("int");

                    b.Property<string>("RankedLeagueName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RankedLeagueTier")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("SummonerID")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("ID");

                    b.HasIndex("QueueTypeID");

                    b.HasIndex("SummonerID");

                    b.ToTable("SummonerRankedLeagues");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            HotStreak = false,
                            IsFreshBlood = false,
                            IsInactive = false,
                            IsVeteran = true,
                            LeaguePoints = 55,
                            NumberOfLosses = 122,
                            NumberOfWins = 122,
                            QueueTypeID = 420,
                            RankedLeagueDivision = 3,
                            RankedLeagueTier = "PLATINUM",
                            SummonerID = "T9CKkCvw9-rvYCGLYkvE8FnP-LbcucxCUTvOcRL6R6HsV84"
                        },
                        new
                        {
                            ID = 2,
                            HotStreak = false,
                            IsFreshBlood = false,
                            IsInactive = false,
                            IsVeteran = false,
                            LeaguePoints = 0,
                            NumberOfLosses = 33,
                            NumberOfWins = 37,
                            QueueTypeID = 420,
                            RankedLeagueDivision = 4,
                            RankedLeagueTier = "PLATINUM",
                            SummonerID = "0sIa8mv2kdRhUicAKIb0pMCtA9eEYivCAfAW7ZGBZz5qlME0"
                        });
                });

            modelBuilder.Entity("LeagueEntities.Models.Tag", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TagName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("ID");

                    b.ToTable("Tags");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            TagName = "Fighter"
                        },
                        new
                        {
                            ID = 2,
                            TagName = "Tank"
                        },
                        new
                        {
                            ID = 3,
                            TagName = "Mage"
                        },
                        new
                        {
                            ID = 4,
                            TagName = "Assasin"
                        },
                        new
                        {
                            ID = 5,
                            TagName = "Support"
                        },
                        new
                        {
                            ID = 6,
                            TagName = "Marksman"
                        });
                });

            modelBuilder.Entity("LeagueEntities.Models.ChampionStats", b =>
                {
                    b.HasOne("LeagueEntities.Models.Champion", "Champion")
                        .WithOne("ChampionStats")
                        .HasForeignKey("LeagueEntities.Models.ChampionStats", "ChampionID");
                });

            modelBuilder.Entity("LeagueEntities.Models.ChampionTags", b =>
                {
                    b.HasOne("LeagueEntities.Models.Champion", "Champion")
                        .WithMany("ChampionTags")
                        .HasForeignKey("ChampionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LeagueEntities.Models.Tag", "Tag")
                        .WithMany("ChampionTags")
                        .HasForeignKey("TagID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LeagueEntities.Models.Match", b =>
                {
                    b.HasOne("LeagueEntities.Models.Map", "Map")
                        .WithMany("Matches")
                        .HasForeignKey("MapID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LeagueEntities.Models.QueueType", "QueueType")
                        .WithMany("Matches")
                        .HasForeignKey("QueueTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LeagueEntities.Models.Server", "Server")
                        .WithMany("Matches")
                        .HasForeignKey("ServerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LeagueEntities.Models.Summoner", b =>
                {
                    b.HasOne("LeagueEntities.Models.Server", "Server")
                        .WithMany("Summoners")
                        .HasForeignKey("ServerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LeagueEntities.Models.SummonerChampionMastery", b =>
                {
                    b.HasOne("LeagueEntities.Models.Champion", "Champion")
                        .WithMany("SummonersChampionMasteries")
                        .HasForeignKey("ChampionID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("LeagueEntities.Models.Summoner", "Summoner")
                        .WithMany("SummonersChampionMasteries")
                        .HasForeignKey("SummonerID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("LeagueEntities.Models.SummonerMatches", b =>
                {
                    b.HasOne("LeagueEntities.Models.Champion", "Champion")
                        .WithMany("SummonerMatches")
                        .HasForeignKey("ChampionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LeagueEntities.Models.Match", "Match")
                        .WithMany("SummonerMatches")
                        .HasForeignKey("MatchID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("LeagueEntities.Models.Summoner", "Summoner")
                        .WithMany("SummonerMatches")
                        .HasForeignKey("SummonerID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("LeagueEntities.Models.SummonerRankedLeague", b =>
                {
                    b.HasOne("LeagueEntities.Models.QueueType", "QueueType")
                        .WithMany("SummonerRankedLeagues")
                        .HasForeignKey("QueueTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LeagueEntities.Models.Summoner", "Summoner")
                        .WithMany("SummonerRankedLeagues")
                        .HasForeignKey("SummonerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
