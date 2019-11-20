using LeagueEntities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeagueEntities.EntityConfigurations
{
    public class MapConfiguration : IEntityTypeConfiguration<Map>
    {
        public void Configure(EntityTypeBuilder<Map> builder)
        {
            builder.HasMany(x => x.Matches)
                 .WithOne(m => m.Map)
                 .HasForeignKey(m => m.MapID)
                 .IsRequired();

            builder.Property(x => x.MapName)
                .HasMaxLength(100)
                .IsRequired();

            builder.HasData(new Map[] {
                new Map
                {
                    ID = 11,
                    MapName = "Summoner's Rift"
                },
                new Map
                {
                    ID = 3,
                    MapName = "The Proving Grounds"
                },
                new Map
                {
                    ID = 4,
                    MapName = "Twisted Treeline"
                },
                new Map
                {
                    ID = 12,
                    MapName = "Howling Abyss"
                },
                new Map
                {
                    ID = 14,
                    MapName = "Butcher's Bridge"
                }
            });
        }
    }
}
