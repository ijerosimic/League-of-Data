using LeagueEntities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeagueEntities.EntityConfigurations
{
    public class ChampionConfiguration : IEntityTypeConfiguration<Champion>
    {
        public void Configure(EntityTypeBuilder<Champion> builder)
        {
            builder.HasOne(c => c.ChampionStats)
                .WithOne(s => s.Champion)
                .HasForeignKey<ChampionStats>(s => s.ChampionID)
                .IsRequired(false); 

            builder.HasMany(c => c.SummonerMatches)
                .WithOne(sm => sm.Champion)
                .HasForeignKey(sm => sm.ChampionID)
                .HasPrincipalKey(c => c.ID);

            builder.Property(c => c.ChampionName)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(c => c.ChampionTitle)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(c => c.ChampionDescription)
                .HasMaxLength(500)
                .IsRequired();
        }
    }
}
