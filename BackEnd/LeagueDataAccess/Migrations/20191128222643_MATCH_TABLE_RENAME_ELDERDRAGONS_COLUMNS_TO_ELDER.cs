using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LeagueDataAccess.Migrations
{
    public partial class MATCH_TABLE_RENAME_ELDERDRAGONS_COLUMNS_TO_ELDER : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BluelderDragons",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "RedlderDragons",
                table: "Matches");

            migrationBuilder.AddColumn<int>(
                name: "BlueElder",
                table: "Matches",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RedElder",
                table: "Matches",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "ID",
                keyValue: 1,
                column: "MatchCreation",
                value: new DateTime(2019, 11, 28, 23, 26, 42, 170, DateTimeKind.Local).AddTicks(6754));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "ID",
                keyValue: 2,
                column: "MatchCreation",
                value: new DateTime(2019, 11, 28, 23, 26, 42, 175, DateTimeKind.Local).AddTicks(2402));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "ID",
                keyValue: 3,
                column: "MatchCreation",
                value: new DateTime(2019, 11, 28, 23, 26, 42, 175, DateTimeKind.Local).AddTicks(2516));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "ID",
                keyValue: 4,
                column: "MatchCreation",
                value: new DateTime(2019, 11, 28, 23, 26, 42, 175, DateTimeKind.Local).AddTicks(2526));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "ID",
                keyValue: 5,
                column: "MatchCreation",
                value: new DateTime(2019, 11, 28, 23, 26, 42, 175, DateTimeKind.Local).AddTicks(2530));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BlueElder",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "RedElder",
                table: "Matches");

            migrationBuilder.AddColumn<int>(
                name: "BluelderDragons",
                table: "Matches",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RedlderDragons",
                table: "Matches",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "ID",
                keyValue: 1,
                column: "MatchCreation",
                value: new DateTime(2019, 11, 28, 22, 26, 8, 170, DateTimeKind.Local).AddTicks(6294));

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
    }
}
