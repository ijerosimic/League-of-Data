using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LeagueDataAccess.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Champions",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChampionName = table.Column<string>(maxLength: 50, nullable: false),
                    ChampionTitle = table.Column<string>(maxLength: 50, nullable: false),
                    ChampionDescription = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Champions", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Maps",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MapName = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maps", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "QueueTypes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QueueTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Servers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServerName = table.Column<string>(maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TagName = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ChampionsStats",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResourceType = table.Column<string>(nullable: true),
                    Attack = table.Column<int>(nullable: false),
                    Defense = table.Column<int>(nullable: false),
                    Magic = table.Column<int>(nullable: false),
                    Difficulty = table.Column<int>(nullable: false),
                    HitPoints = table.Column<decimal>(nullable: false),
                    HitPointsPerLevel = table.Column<decimal>(nullable: false),
                    ManaPoints = table.Column<decimal>(nullable: false),
                    ManaPointsPerLevel = table.Column<decimal>(nullable: false),
                    MoveSpeed = table.Column<decimal>(nullable: false),
                    Armor = table.Column<decimal>(nullable: false),
                    ArmorPerLevel = table.Column<decimal>(nullable: false),
                    SpellBlock = table.Column<decimal>(nullable: false),
                    SpellBlockPerLevel = table.Column<decimal>(nullable: false),
                    AttackRange = table.Column<decimal>(nullable: false),
                    HitPointsRegen = table.Column<decimal>(nullable: false),
                    HitPointsRegenPerLevel = table.Column<decimal>(nullable: false),
                    ManaPointsRegen = table.Column<decimal>(nullable: false),
                    ManaPointsRegenPerLevel = table.Column<decimal>(nullable: false),
                    CritChance = table.Column<decimal>(nullable: false),
                    CritChancePerLevel = table.Column<decimal>(nullable: false),
                    AttackDamage = table.Column<decimal>(nullable: false),
                    AttackDamagePerLevel = table.Column<decimal>(nullable: false),
                    AttackSpeedOffset = table.Column<decimal>(nullable: false),
                    AttackSpeedPerLevel = table.Column<decimal>(nullable: false),
                    ChampionID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChampionsStats", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ChampionsStats_Champions_ChampionID",
                        column: x => x.ChampionID,
                        principalTable: "Champions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Matches",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeasonNo = table.Column<int>(nullable: false),
                    MatchDuration = table.Column<int>(nullable: false),
                    MatchCreation = table.Column<DateTime>(nullable: false),
                    GameMode = table.Column<string>(maxLength: 20, nullable: true),
                    GameType = table.Column<string>(maxLength: 20, nullable: true),
                    TotalKills = table.Column<int>(nullable: false),
                    TotalGold = table.Column<int>(nullable: false),
                    BlueTeamKills = table.Column<int>(nullable: false),
                    BlueTeamGold = table.Column<int>(nullable: false),
                    BlueTeamTurrets = table.Column<int>(nullable: false),
                    BlueTeamDragons = table.Column<int>(nullable: false),
                    BlueTeamBarons = table.Column<int>(nullable: false),
                    BlueTeamElderDragons = table.Column<int>(nullable: false),
                    RedTeamKills = table.Column<int>(nullable: false),
                    RedTeamGold = table.Column<int>(nullable: false),
                    RedTeamTurrets = table.Column<int>(nullable: false),
                    RedTeamDragons = table.Column<int>(nullable: false),
                    RedTeamBarons = table.Column<int>(nullable: false),
                    RedTeamElderDragons = table.Column<int>(nullable: false),
                    Winner = table.Column<string>(nullable: true),
                    ServerID = table.Column<int>(nullable: false),
                    MapID = table.Column<int>(nullable: false),
                    QueueTypeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Matches_Maps_MapID",
                        column: x => x.MapID,
                        principalTable: "Maps",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Matches_QueueTypes_QueueTypeID",
                        column: x => x.QueueTypeID,
                        principalTable: "QueueTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Matches_Servers_ServerID",
                        column: x => x.ServerID,
                        principalTable: "Servers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Summoners",
                columns: table => new
                {
                    ID = table.Column<int>(maxLength: 100, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SummonerName = table.Column<string>(maxLength: 100, nullable: false),
                    SummonerLevel = table.Column<int>(nullable: false),
                    Champion = table.Column<int>(nullable: false),
                    ChampionMasteryScore = table.Column<int>(nullable: false),
                    ProfileIconNumber = table.Column<int>(nullable: false),
                    ServerID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Summoners", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Summoners_Servers_ServerID",
                        column: x => x.ServerID,
                        principalTable: "Servers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChampionTags",
                columns: table => new
                {
                    ChampionID = table.Column<int>(nullable: false),
                    TagID = table.Column<int>(nullable: false),
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChampionTags", x => new { x.ChampionID, x.TagID });
                    table.ForeignKey(
                        name: "FK_ChampionTags_Champions_ChampionID",
                        column: x => x.ChampionID,
                        principalTable: "Champions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChampionTags_Tags_TagID",
                        column: x => x.TagID,
                        principalTable: "Tags",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SummonerMatches",
                columns: table => new
                {
                    SummonerID = table.Column<int>(maxLength: 100, nullable: false),
                    MatchID = table.Column<int>(nullable: false),
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(nullable: true),
                    LaneName = table.Column<string>(nullable: true),
                    Kills = table.Column<int>(nullable: false),
                    Deaths = table.Column<int>(nullable: false),
                    Assists = table.Column<int>(nullable: false),
                    KillParticipation = table.Column<int>(nullable: false),
                    DamageDone = table.Column<decimal>(nullable: false),
                    GoldEarned = table.Column<decimal>(nullable: false),
                    WardsPlaced = table.Column<int>(nullable: false),
                    Item1 = table.Column<int>(nullable: false),
                    Item2 = table.Column<int>(nullable: false),
                    Item3 = table.Column<int>(nullable: false),
                    Item4 = table.Column<int>(nullable: false),
                    Item5 = table.Column<int>(nullable: false),
                    Item6 = table.Column<int>(nullable: false),
                    Trinket = table.Column<string>(nullable: true),
                    SummonerSpell1 = table.Column<string>(nullable: true),
                    SummonerSpell2 = table.Column<string>(nullable: true),
                    KeystoneRune = table.Column<string>(nullable: true),
                    MinorRune = table.Column<string>(nullable: true),
                    Team = table.Column<string>(nullable: true),
                    ChampionID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SummonerMatches", x => new { x.SummonerID, x.MatchID });
                    table.UniqueConstraint("AK_SummonerMatches_ID", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SummonerMatches_Champions_ChampionID",
                        column: x => x.ChampionID,
                        principalTable: "Champions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SummonerMatches_Matches_MatchID",
                        column: x => x.MatchID,
                        principalTable: "Matches",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SummonerMatches_Summoners_SummonerID",
                        column: x => x.SummonerID,
                        principalTable: "Summoners",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SummonerRankedLeagues",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RankedLeagueName = table.Column<string>(nullable: true),
                    RankedLeagueTier = table.Column<string>(maxLength: 20, nullable: false),
                    RankedLeagueDivision = table.Column<int>(nullable: false),
                    NumberOfWins = table.Column<int>(nullable: false),
                    NumberOfLosses = table.Column<int>(nullable: false),
                    HotStreak = table.Column<bool>(nullable: false),
                    IsVeteran = table.Column<bool>(nullable: false),
                    IsFreshBlood = table.Column<bool>(nullable: false),
                    IsInactive = table.Column<bool>(nullable: false),
                    LeaguePoints = table.Column<int>(nullable: false),
                    SummonerID = table.Column<int>(maxLength: 100, nullable: false),
                    QueueTypeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SummonerRankedLeagues", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SummonerRankedLeagues_QueueTypes_QueueTypeID",
                        column: x => x.QueueTypeID,
                        principalTable: "QueueTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SummonerRankedLeagues_Summoners_SummonerID",
                        column: x => x.SummonerID,
                        principalTable: "Summoners",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SummonersChampionMasteries",
                columns: table => new
                {
                    SummonerID = table.Column<int>(maxLength: 100, nullable: false),
                    ChampionID = table.Column<int>(nullable: false),
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChampionLevel = table.Column<int>(nullable: false),
                    ChampionPoints = table.Column<int>(nullable: false),
                    TokensEarned = table.Column<int>(nullable: false),
                    LastPlayTime = table.Column<DateTime>(nullable: false),
                    ChampionPointsSinceLastLevel = table.Column<int>(nullable: false),
                    ChampionPointsUntilNextLevel = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SummonersChampionMasteries", x => new { x.SummonerID, x.ChampionID });
                    table.ForeignKey(
                        name: "FK_SummonersChampionMasteries_Champions_ChampionID",
                        column: x => x.ChampionID,
                        principalTable: "Champions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SummonersChampionMasteries_Summoners_SummonerID",
                        column: x => x.SummonerID,
                        principalTable: "Summoners",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SummonerMatchesItems",
                columns: table => new
                {
                    SummonerMatchID = table.Column<int>(nullable: false),
                    ItemID = table.Column<int>(nullable: false),
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SummonerMatchesItems", x => new { x.SummonerMatchID, x.ItemID });
                    table.ForeignKey(
                        name: "FK_SummonerMatchesItems_Items_SummonerMatchID",
                        column: x => x.SummonerMatchID,
                        principalTable: "Items",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SummonerMatchesItems_SummonerMatches_SummonerMatchID",
                        column: x => x.SummonerMatchID,
                        principalTable: "SummonerMatches",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Maps",
                columns: new[] { "ID", "MapName" },
                values: new object[,]
                {
                    { 11, "Summoner's Rift" },
                    { 3, "The Proving Grounds" },
                    { 4, "Twisted Treeline" },
                    { 12, "Howling Abyss" },
                    { 14, "Butcher's Bridge" }
                });

            migrationBuilder.InsertData(
                table: "QueueTypes",
                columns: new[] { "ID", "Description" },
                values: new object[,]
                {
                    { 420, "5v5 Ranked Solo games" },
                    { 400, "5v5 Draft Pick games" },
                    { 440, "5v5 Ranked Flex games" },
                    { 430, "5v5 Blind Pick games" }
                });

            migrationBuilder.InsertData(
                table: "Servers",
                columns: new[] { "ID", "ServerName" },
                values: new object[,]
                {
                    { 1, "EUW1" },
                    { 2, "EUN1" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "ID", "TagName" },
                values: new object[,]
                {
                    { 5, "Support" },
                    { 1, "Fighter" },
                    { 2, "Tank" },
                    { 3, "Mage" },
                    { 4, "Assasin" },
                    { 6, "Marksman" }
                });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "ID", "BlueTeamBarons", "BlueTeamDragons", "BlueTeamElderDragons", "BlueTeamGold", "BlueTeamKills", "BlueTeamTurrets", "GameMode", "GameType", "MapID", "MatchCreation", "MatchDuration", "QueueTypeID", "RedTeamBarons", "RedTeamDragons", "RedTeamElderDragons", "RedTeamGold", "RedTeamKills", "RedTeamTurrets", "SeasonNo", "ServerID", "TotalGold", "TotalKills", "Winner" },
                values: new object[,]
                {
                    { 1, 1, 5, 0, 88407, 71, 11, "CLASSIC", "MATCHED_GAME", 11, new DateTime(2019, 11, 28, 20, 51, 21, 228, DateTimeKind.Local).AddTicks(6548), 4240, 440, 1, 0, 0, 77988, 47, 3, 5, 2, 166395, 108, "Blue" },
                    { 2, 0, 0, 0, 0, 0, 0, "CLASSIC", "MATCHED_GAME", 11, new DateTime(2019, 11, 28, 20, 51, 21, 233, DateTimeKind.Local).AddTicks(208), 2415, 440, 0, 0, 0, 0, 0, 0, 13, 2, 0, 0, null },
                    { 3, 0, 0, 0, 0, 0, 0, "CLASSIC", "MATCHED_GAME", 11, new DateTime(2019, 11, 28, 20, 51, 21, 233, DateTimeKind.Local).AddTicks(312), 4151, 440, 0, 0, 0, 0, 0, 0, 13, 2, 0, 0, null },
                    { 4, 0, 0, 0, 0, 0, 0, "CLASSIC", "MATCHED_GAME", 11, new DateTime(2019, 11, 28, 20, 51, 21, 233, DateTimeKind.Local).AddTicks(322), 2415, 440, 0, 0, 0, 0, 0, 0, 13, 2, 0, 0, null },
                    { 5, 0, 0, 0, 0, 0, 0, "CLASSIC", "MATCHED_GAME", 11, new DateTime(2019, 11, 28, 20, 51, 21, 233, DateTimeKind.Local).AddTicks(327), 2415, 440, 0, 0, 0, 0, 0, 0, 13, 2, 0, 0, null }
                });

            migrationBuilder.InsertData(
                table: "Summoners",
                columns: new[] { "ID", "Champion", "ChampionMasteryScore", "ProfileIconNumber", "ServerID", "SummonerLevel", "SummonerName" },
                values: new object[,]
                {
                    { 1, 0, 0, 523, 1, 133, "golemko" },
                    { 2, 0, 0, 1450, 1, 48, "Peasant Slayer" },
                    { 3, 0, 0, 1459, 1, 99, "Shimeshugar" },
                    { 4, 0, 0, 4086, 1, 90, "Koomuch" },
                    { 5, 0, 0, 658, 1, 47, "ubnix" },
                    { 6, 0, 0, 3569, 1, 60, "Major Alexander" },
                    { 7, 0, 0, 3589, 1, 60, "Major Alexander" },
                    { 8, 0, 0, 3615, 1, 35, "Bongiorno" },
                    { 9, 0, 0, 3635, 1, 144, "Nocturno" },
                    { 10, 0, 0, 3670, 1, 188, "Broxah" }
                });

            migrationBuilder.InsertData(
                table: "SummonerMatches",
                columns: new[] { "SummonerID", "MatchID", "Assists", "ChampionID", "DamageDone", "Deaths", "GoldEarned", "ID", "Item1", "Item2", "Item3", "Item4", "Item5", "Item6", "KeystoneRune", "KillParticipation", "Kills", "LaneName", "MinorRune", "RoleName", "SummonerSpell1", "SummonerSpell2", "Team", "Trinket", "WardsPlaced" },
                values: new object[,]
                {
                    { 1, 1, 5, 266, 43.511m, 18, 21.523m, 1, 1001, 1004, 1005, 1007, 1038, 0, "Lethal Tempo", 0, 11, "BOTTOM", "Resolve", "DUO_MARKSMAN", null, null, "Blue", "Warding Totem", 14 },
                    { 2, 1, 5, 103, 43.511m, 18, 21.523m, 2, 1001, 1004, 1005, 1007, 1038, 0, "Lethal Tempo", 0, 11, "MID", "Resolve", "SOLO_MID", null, null, "Blue", "Warding Totem", 14 },
                    { 3, 1, 5, 12, 43.511m, 18, 21.523m, 3, 1001, 1004, 1005, 1007, 1038, 0, "Lethal Tempo", 0, 11, "BOTTOM", "Resolve", "DUO_SUPPORT", null, null, "Blue", "Warding Totem", 14 },
                    { 4, 1, 5, 32, 43.511m, 18, 21.523m, 4, 1001, 1004, 1005, 1007, 1038, 0, "Lethal Tempo", 0, 11, "JUNGLE", "Resolve", "SOLO_JUNGLE", null, null, "Blue", "Warding Totem", 14 },
                    { 5, 1, 5, 164, 43.511m, 18, 21.523m, 5, 1001, 1004, 1005, 1007, 1038, 0, "Lethal Tempo", 0, 11, "TOP", "Resolve", "SOLO_TOP", null, null, "Blue", "Warding Totem", 14 },
                    { 6, 1, 5, 42, 43.511m, 18, 21.523m, 6, 1001, 1004, 1005, 1007, 1038, 0, "Lethal Tempo", 0, 11, "BOTTOM", "Resolve", "DUO_MARKSMAN", null, null, "Red", "Warding Totem", 14 },
                    { 7, 1, 5, 131, 43.511m, 18, 21.523m, 7, 1001, 1004, 1005, 1007, 1038, 0, "Lethal Tempo", 0, 11, "MID", "Resolve", "SOLO_MID", null, null, "Red", "Warding Totem", 14 },
                    { 8, 1, 5, 9, 43.511m, 18, 21.523m, 8, 1001, 1004, 1005, 1007, 1038, 0, "Lethal Tempo", 0, 11, "BOTTOM", "Resolve", "DUO_SUPPORT", null, null, "Red", "Warding Totem", 14 },
                    { 9, 1, 5, 79, 43.511m, 18, 21.523m, 9, 1001, 1004, 1005, 1007, 1038, 0, "Lethal Tempo", 0, 11, "JUNGLE", "Resolve", "SOLO_JUNGLE", null, null, "Red", "Warding Totem", 14 },
                    { 10, 1, 5, 420, 43.511m, 18, 21.523m, 10, 1001, 1004, 1005, 1007, 1038, 0, "Lethal Tempo", 0, 11, "TOP", "Resolve", "SOLO_TOP", null, null, "Red", "Warding Totem", 14 }
                });

            migrationBuilder.InsertData(
                table: "SummonerRankedLeagues",
                columns: new[] { "ID", "HotStreak", "IsFreshBlood", "IsInactive", "IsVeteran", "LeaguePoints", "NumberOfLosses", "NumberOfWins", "QueueTypeID", "RankedLeagueDivision", "RankedLeagueName", "RankedLeagueTier", "SummonerID" },
                values: new object[,]
                {
                    { 1, false, false, false, true, 55, 122, 122, 420, 3, null, "PLATINUM", 1 },
                    { 2, false, false, false, false, 0, 33, 37, 420, 4, null, "PLATINUM", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChampionsStats_ChampionID",
                table: "ChampionsStats",
                column: "ChampionID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ChampionTags_TagID",
                table: "ChampionTags",
                column: "TagID");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_MapID",
                table: "Matches",
                column: "MapID");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_QueueTypeID",
                table: "Matches",
                column: "QueueTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_ServerID",
                table: "Matches",
                column: "ServerID");

            migrationBuilder.CreateIndex(
                name: "IX_SummonerMatches_ChampionID",
                table: "SummonerMatches",
                column: "ChampionID");

            migrationBuilder.CreateIndex(
                name: "IX_SummonerMatches_MatchID",
                table: "SummonerMatches",
                column: "MatchID");

            migrationBuilder.CreateIndex(
                name: "IX_SummonerRankedLeagues_QueueTypeID",
                table: "SummonerRankedLeagues",
                column: "QueueTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_SummonerRankedLeagues_SummonerID",
                table: "SummonerRankedLeagues",
                column: "SummonerID");

            migrationBuilder.CreateIndex(
                name: "IX_Summoners_ServerID",
                table: "Summoners",
                column: "ServerID");

            migrationBuilder.CreateIndex(
                name: "IX_SummonersChampionMasteries_ChampionID",
                table: "SummonersChampionMasteries",
                column: "ChampionID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChampionsStats");

            migrationBuilder.DropTable(
                name: "ChampionTags");

            migrationBuilder.DropTable(
                name: "SummonerMatchesItems");

            migrationBuilder.DropTable(
                name: "SummonerRankedLeagues");

            migrationBuilder.DropTable(
                name: "SummonersChampionMasteries");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "SummonerMatches");

            migrationBuilder.DropTable(
                name: "Champions");

            migrationBuilder.DropTable(
                name: "Matches");

            migrationBuilder.DropTable(
                name: "Summoners");

            migrationBuilder.DropTable(
                name: "Maps");

            migrationBuilder.DropTable(
                name: "QueueTypes");

            migrationBuilder.DropTable(
                name: "Servers");
        }
    }
}
