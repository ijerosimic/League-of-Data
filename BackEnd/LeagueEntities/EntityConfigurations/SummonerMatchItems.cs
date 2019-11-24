using LeagueEntities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeagueEntities.EntityConfigurations
{
    public class SummonerMatchesItemsCOnfiguration : IEntityTypeConfiguration<SummonerMatchesItems>
    {
        public void Configure(EntityTypeBuilder<SummonerMatchesItems> builder)
        {
            builder.HasKey(sm => new { sm.SummonerMatchID, sm.ItemID });

            builder.HasOne(sm => sm.SummonerMatch)
                .WithMany(s => s.SummonerMatchesItems)
                .HasForeignKey(sm => sm.SummonerMatchID)
                .HasPrincipalKey(s => s.ID);

            builder.HasOne(sm => sm.Item)
                  .WithMany(i => i.SummonerMatchesItems)
                  .HasForeignKey(sm => sm.SummonerMatchID)
                  .HasPrincipalKey(i => i.ID);

            builder.Property(sm => sm.ID)
                .UseIdentityColumn()
                .IsRequired();

            builder.Property(sm => sm.SummonerMatchID)
                .IsRequired();

            builder.Property(sm => sm.ItemID)
                .IsRequired();
        }
    }
}
