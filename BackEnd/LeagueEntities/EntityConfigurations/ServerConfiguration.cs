using LeagueEntities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeagueEntities.EntityConfigurations
{
    public class ServerConfiguration : IEntityTypeConfiguration<Server>
    {
        public void Configure(EntityTypeBuilder<Server> builder)
        {
            builder.HasMany(r => r.Matches)
                .WithOne(m => m.Server)
                .HasForeignKey(m => m.ServerID)
                .HasPrincipalKey(r => r.ID);

            builder.HasMany(r => r.Summoners)
                .WithOne(m => m.Server)
                .HasForeignKey(m => m.ServerID)
                .HasPrincipalKey(r => r.ID);

            builder.Property(r => r.ID)
                .UseIdentityColumn()
                .IsRequired();

            builder.Property(r => r.ServerName)
                .HasMaxLength(5)
                .IsRequired();

            builder.HasData(new Server[]
            {
               new Server
               {
                   ID = 1,
                   ServerName = "EUW1"
               },
               new Server
               {
                   ID = 2,
                   ServerName = "EUN1"
               }
            });
        }
    }
}
