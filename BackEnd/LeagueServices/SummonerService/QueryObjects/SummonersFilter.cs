using LeagueEntities.Models;
using LeagueServices.SummonerService.Dto;
using System;
using System.Linq;

namespace LeagueServices.SummonerService.QueryObjects
{
    public static class SummonerDtoFilter
    {
        public enum SummonerListFilterBy
        {
            NoFilter,
            Id,
            SummonerName,
            SummonerLevel,
            ServerID
        }

        public static IQueryable<Summoner> FilterSummonersBy(
            this IQueryable<Summoner> summoners,
            SummonerListFilterBy filterBy,
            string value)
        {
            ValidateInput(filterBy, value);

            if (string.IsNullOrWhiteSpace(value))
                return summoners;

            return filterBy switch
            {
                SummonerListFilterBy.NoFilter => summoners,
                SummonerListFilterBy.Id => summoners
                    .Where(s => s.ID == value),
                SummonerListFilterBy.SummonerName => summoners
                    .Where(s => s.SummonerName.ToLower().Contains(value.ToLower())),
                SummonerListFilterBy.SummonerLevel => summoners
                    .Where(s => s.SummonerLevel == Convert.ToInt32(value)),
                SummonerListFilterBy.ServerID => summoners
                    .Where(s => s.ServerID == Convert.ToInt32(value)),

                _ => throw new ArgumentOutOfRangeException
                        (nameof(FilterSummonersBy), filterBy, null),
            };
        }

        public static void ValidateInput(
            SummonerListFilterBy filterBy, string value)
        {
            switch (filterBy)
            {
                case SummonerListFilterBy.SummonerName:
                    if (string.IsNullOrWhiteSpace(value))
                        throw new ArgumentException(
                            nameof(filterBy),
                            "Cannot filter by summoner name if argument is null!");
                    break;
                case SummonerListFilterBy.ServerID:
                    if (int.TryParse(value, out _) == false)
                        throw new ArgumentException(
                            nameof(filterBy),
                            "Error converting string value server ID to integer!");
                    break;
                case SummonerListFilterBy.SummonerLevel:
                    if (int.TryParse(value, out _) == false)
                        throw new ArgumentException(
                            nameof(filterBy),
                            "Error converting string value summoner level to integer!");
                    break;
                default:
                    break;
            }
        }
    }
}

