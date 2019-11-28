using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LeagueDataAccess.Migrations
{
    public partial class RemoveTeamFromTeamsStatColumnNamesInMatchTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BlueTeamBarons",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "BlueTeamDragons",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "BlueTeamElderDragons",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "BlueTeamGold",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "BlueTeamKills",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "BlueTeamTurrets",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "RedTeamBarons",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "RedTeamDragons",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "RedTeamElderDragons",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "RedTeamGold",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "RedTeamKills",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "RedTeamTurrets",
                table: "Matches");

            migrationBuilder.AddColumn<int>(
                name: "BlueBarons",
                table: "Matches",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BlueDragons",
                table: "Matches",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BlueGold",
                table: "Matches",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BlueKills",
                table: "Matches",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BlueTurrets",
                table: "Matches",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BluelderDragons",
                table: "Matches",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RedBarons",
                table: "Matches",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RedDragons",
                table: "Matches",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RedGold",
                table: "Matches",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RedKills",
                table: "Matches",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RedTurrets",
                table: "Matches",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RedlderDragons",
                table: "Matches",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "BlueBarons", "BlueDragons", "BlueGold", "BlueKills", "BlueTurrets", "MatchCreation", "RedBarons", "RedGold", "RedKills", "RedTurrets" },
                values: new object[] { 1, 5, 88407, 71, 11, new DateTime(2019, 11, 28, 22, 26, 8, 170, DateTimeKind.Local).AddTicks(6294), 1, 77988, 47, 3 });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "ID",
                keyValue: 2,
                column: "MatchCreation",
                value: new DateTime(2019, 11, 28, 22, 26, 8, 175, DateTimeKind.Local).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "ID",
                keyValue: 3,
                column: "MatchCreation",
                value: new DateTime(2019, 11, 28, 22, 26, 8, 175, DateTimeKind.Local).AddTicks(9059));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "ID",
                keyValue: 4,
                column: "MatchCreation",
                value: new DateTime(2019, 11, 28, 22, 26, 8, 175, DateTimeKind.Local).AddTicks(9069));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "ID",
                keyValue: 5,
                column: "MatchCreation",
                value: new DateTime(2019, 11, 28, 22, 26, 8, 175, DateTimeKind.Local).AddTicks(9075));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BlueBarons",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "BlueDragons",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "BlueGold",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "BlueKills",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "BlueTurrets",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "BluelderDragons",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "RedBarons",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "RedDragons",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "RedGold",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "RedKills",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "RedTurrets",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "RedlderDragons",
                table: "Matches");

            migrationBuilder.AddColumn<int>(
                name: "BlueTeamBarons",
                table: "Matches",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BlueTeamDragons",
                table: "Matches",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BlueTeamElderDragons",
                table: "Matches",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BlueTeamGold",
                table: "Matches",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BlueTeamKills",
                table: "Matches",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BlueTeamTurrets",
                table: "Matches",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RedTeamBarons",
                table: "Matches",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RedTeamDragons",
                table: "Matches",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RedTeamElderDragons",
                table: "Matches",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RedTeamGold",
                table: "Matches",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RedTeamKills",
                table: "Matches",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RedTeamTurrets",
                table: "Matches",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "BlueTeamBarons", "BlueTeamDragons", "BlueTeamGold", "BlueTeamKills", "BlueTeamTurrets", "MatchCreation", "RedTeamBarons", "RedTeamGold", "RedTeamKills", "RedTeamTurrets" },
                values: new object[] { 1, 5, 88407, 71, 11, new DateTime(2019, 11, 28, 20, 51, 21, 228, DateTimeKind.Local).AddTicks(6548), 1, 77988, 47, 3 });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "ID",
                keyValue: 2,
                column: "MatchCreation",
                value: new DateTime(2019, 11, 28, 20, 51, 21, 233, DateTimeKind.Local).AddTicks(208));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "ID",
                keyValue: 3,
                column: "MatchCreation",
                value: new DateTime(2019, 11, 28, 20, 51, 21, 233, DateTimeKind.Local).AddTicks(312));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "ID",
                keyValue: 4,
                column: "MatchCreation",
                value: new DateTime(2019, 11, 28, 20, 51, 21, 233, DateTimeKind.Local).AddTicks(322));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "ID",
                keyValue: 5,
                column: "MatchCreation",
                value: new DateTime(2019, 11, 28, 20, 51, 21, 233, DateTimeKind.Local).AddTicks(327));
        }
    }
}
