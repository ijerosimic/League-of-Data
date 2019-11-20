using LeagueEntities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeagueEntities.EntityConfigurations
{
    public class ChampionTagsConfiguration : IEntityTypeConfiguration<ChampionTags>
    {
        public void Configure(EntityTypeBuilder<ChampionTags> builder)
        {
            builder.HasKey(ct => new { ct.ChampionID, ct.TagID });

            builder.HasOne(ct => ct.Champion)
                .WithMany(c => c.ChampionTags)
                .HasForeignKey(ct => ct.ChampionID)
                .HasPrincipalKey(c => c.ID);

            builder.HasOne(ct => ct.Tag)
                  .WithMany(t => t.ChampionTags)
                  .HasForeignKey(ct => ct.TagID)
                  .HasPrincipalKey(t => t.ID);

            builder.Property(ct => ct.ID)
                .UseIdentityColumn()
                .IsRequired();

            builder.Property(ct => ct.ChampionID)
                .IsRequired();

            builder.Property(ct => ct.TagID)
                .IsRequired();
        }
    }
}
