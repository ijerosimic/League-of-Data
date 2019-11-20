using LeagueEntities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeagueEntities.EntityConfigurations
{
    public class SummonerRankedLeagueConfiguration : IEntityTypeConfiguration<SummonerRankedLeague>
    {
        public void Configure(EntityTypeBuilder<SummonerRankedLeague> builder)
        {
            builder.Property(srl => srl.ID)
                .UseIdentityColumn()
                .IsRequired();

            builder.HasOne(srl => srl.Summoner)
                .WithMany(s => s.SummonerRankedLeagues)
                .HasForeignKey(srl => srl.SummonerID)
                .HasPrincipalKey(s => s.ID);

            builder.Property(srl => srl.SummonerID)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(srl => srl.RankedLeagueTier)
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(srl => srl.RankedLeagueDivision)
                .IsRequired();

            builder.HasData(new SummonerRankedLeague[]
            {
                new SummonerRankedLeague
                {
                    ID = 1,
                    SummonerID = "T9CKkCvw9-rvYCGLYkvE8FnP-LbcucxCUTvOcRL6R6HsV84",
                    HotStreak = false,
                    NumberOfWins = 122,
                    IsVeteran = true,
                    NumberOfLosses = 122,
                    RankedLeagueDivision = 3,
                    RankedLeagueTier = "PLATINUM",
                    IsFreshBlood = false,
                    IsInactive = false,
                    LeaguePoints = 55,
                    QueueTypeID = 420
                },
                new SummonerRankedLeague
                {
                    ID = 2,
                    SummonerID = "0sIa8mv2kdRhUicAKIb0pMCtA9eEYivCAfAW7ZGBZz5qlME0",
                    HotStreak = false,
                    NumberOfWins = 37,
                    IsVeteran = false,
                    NumberOfLosses = 33,
                    RankedLeagueDivision = 4,
                    RankedLeagueTier = "PLATINUM",
                    IsFreshBlood = false,
                    IsInactive = false,
                    LeaguePoints = 0,
                    QueueTypeID = 420
                }
            });
        }
    }
}
