using LeagueEntities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeagueEntities.EntityConfigurations
{
    public class ChampionStatsConfiguration : IEntityTypeConfiguration<ChampionStats>
    {
        public void Configure(EntityTypeBuilder<ChampionStats> builder)
        {
            builder.Property(cs => cs.ID)
                .UseIdentityColumn()
                .IsRequired();
        }
    }
}
