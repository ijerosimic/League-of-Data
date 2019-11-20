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
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeasonNo = table.Column<int>(nullable: false),
                    MatchDuration = table.Column<int>(nullable: false),
                    MatchCreation = table.Column<DateTime>(nullable: false),
                    GameVersion = table.Column<string>(maxLength: 20, nullable: true),
                    GameMode = table.Column<string>(maxLength: 20, nullable: true),
                    GameType = table.Column<string>(maxLength: 20, nullable: true),
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
                    ID = table.Column<string>(maxLength: 100, nullable: false),
                    AccountID = table.Column<string>(maxLength: 100, nullable: false),
                    PuuID = table.Column<string>(maxLength: 100, nullable: false),
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
                    SummonerID = table.Column<string>(maxLength: 100, nullable: false),
                    MatchID = table.Column<long>(nullable: false),
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(nullable: true),
                    LaneName = table.Column<string>(nullable: true),
                    SeasonNo = table.Column<int>(nullable: false),
                    ServerName = table.Column<string>(nullable: true),
                    ChampionID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SummonerMatches", x => new { x.SummonerID, x.MatchID });
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
                    SummonerID = table.Column<string>(maxLength: 100, nullable: false),
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
                    SummonerID = table.Column<string>(maxLength: 100, nullable: false),
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
                columns: new[] { "ID", "GameMode", "GameType", "GameVersion", "MapID", "MatchCreation", "MatchDuration", "QueueTypeID", "SeasonNo", "ServerID" },
                values: new object[,]
                {
                    { 2234518599L, "CLASSIC", "MATCHED_GAME", "9.14.282.3231", 11, new DateTime(1, 1, 2, 15, 57, 51, 766, DateTimeKind.Unspecified).AddTicks(1744), 1804, 440, 5, 2 },
                    { 2234479397L, "CLASSIC", "MATCHED_GAME", "9.14.282.3231", 11, new DateTime(1, 1, 2, 19, 27, 11, 41, DateTimeKind.Unspecified).AddTicks(8265), 2415, 440, 13, 2 }
                });

            migrationBuilder.InsertData(
                table: "Summoners",
                columns: new[] { "ID", "AccountID", "Champion", "ChampionMasteryScore", "ProfileIconNumber", "PuuID", "ServerID", "SummonerLevel", "SummonerName" },
                values: new object[,]
                {
                    { "V05Y-rXHSb-k4QVBqotnMg-h613l0FZ1nhHh6lZK1Hyq0FQ", "huDSrcdoL641P1Cl_qb5Fn482RmH8CSnTVGnvWaI2Tntsg", 0, 0, 554, "wUU6zHnRHoPANkg8Hu-GzpDu2kSWW-Q-DUJr5em-rGIje82tfkLPyNf-lBS-r27dxuiOTAg2TNUYYg", 1, 99, "Shimeshugar" },
                    { "-uVM7qgbYUtTbd9JwkAKguKkS6nj8jmm2fYPb2aOhT0N0sA", "rKb2TFXFSOzaV_HkOCjlnFMXF7kSAPTVXLGkfGxkLBKU8Q", 0, 0, 4086, "yQ4OOOwGe9cJXzndsssMNydOKKXqISSKrdY6L2xIPyDfy5CB1H-x6b4XTvwcfFWT6mvwL4rGFA7JFQ", 1, 90, "Koomuch" },
                    { "ICRohXMWj5jWzLJrxgH82_xYJypMhum3UG_ZkI9UecRJNWk", "E5vIgzYH88uYhb9LGTKuQG3IEoV8j9ny7pSP-ifKuWsx5Q", 0, 0, 658, "C_XMHirlQ00s1Mg01HdI054DL3OPXo0EYMWuHO0xhqJs11RtZOvjdjifCJnm3x3KfsG1uQ76vjeqWQ", 1, 47, "ubnix" },
                    { "T9CKkCvw9-rvYCGLYkvE8FnP-LbcucxCUTvOcRL6R6HsV84", "E5vIgzYH88uYhb9LGTKuQG3IEoV8j9ny7pSP-ifKuWsx5Q", 0, 0, 2, "rXHD2A-8BMKblRThMFtTGqWevjlg1X0qY55BbfI2p9D72KrU779EO2by4NHXhfkalED2bKX6_sbhMQ", 2, 133, "golemko" },
                    { "m7AAGJrMEY_BO-doJ_kS7WtUu1Y3Co4VZC6uwQhkn960LKg", "4gzX2nA07W0cRo07d2PzfwK8GsGsvnuhhhrl6nJmCiSh_HhsBaWzTF4B", 0, 0, 4, "IQ4P4RYUh2b9HKgQA7ToK-IFVOk7Om9Pgtu0zPRuRDcuq30DpWcMnGPfaVO-g_3_TfG9HXUnbjbmzg", 2, 48, "Peasant Slayer" },
                    { "0sIa8mv2kdRhUicAKIb0pMCtA9eEYivCAfAW7ZGBZz5qlME0", "_C6SbKcmVJlqt39rRSrezcQfQBbtF_AalXyoOpwK6Cl5wwkCj2tATFEt", 0, 0, 3, "fI3yFRsBsPj-M-BlsWxMRNQ15xjBVPx-af2DNhTma6F21r9231E-b61p36WyJ79ydFsIcqyZxNJcCg", 2, 60, "Major Alexander" }
                });

            migrationBuilder.InsertData(
                table: "SummonerRankedLeagues",
                columns: new[] { "ID", "HotStreak", "IsFreshBlood", "IsInactive", "IsVeteran", "LeaguePoints", "NumberOfLosses", "NumberOfWins", "QueueTypeID", "RankedLeagueDivision", "RankedLeagueName", "RankedLeagueTier", "SummonerID" },
                values: new object[] { 1, false, false, false, true, 55, 122, 122, 420, 3, null, "PLATINUM", "T9CKkCvw9-rvYCGLYkvE8FnP-LbcucxCUTvOcRL6R6HsV84" });

            migrationBuilder.InsertData(
                table: "SummonerRankedLeagues",
                columns: new[] { "ID", "HotStreak", "IsFreshBlood", "IsInactive", "IsVeteran", "LeaguePoints", "NumberOfLosses", "NumberOfWins", "QueueTypeID", "RankedLeagueDivision", "RankedLeagueName", "RankedLeagueTier", "SummonerID" },
                values: new object[] { 2, false, false, false, false, 0, 33, 37, 420, 4, null, "PLATINUM", "0sIa8mv2kdRhUicAKIb0pMCtA9eEYivCAfAW7ZGBZz5qlME0" });

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
                name: "SummonerMatches");

            migrationBuilder.DropTable(
                name: "SummonerRankedLeagues");

            migrationBuilder.DropTable(
                name: "SummonersChampionMasteries");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Matches");

            migrationBuilder.DropTable(
                name: "Champions");

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
