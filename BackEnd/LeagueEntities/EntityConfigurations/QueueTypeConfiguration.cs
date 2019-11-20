using LeagueEntities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeagueEntities.EntityConfigurations
{
    public class QueueTypeConfiguration : IEntityTypeConfiguration<QueueType>
    {
        public void Configure(EntityTypeBuilder<QueueType> builder)
        {
            builder.HasMany(q => q.SummonerRankedLeagues)
                .WithOne(s => s.QueueType)
                .HasForeignKey(s => s.QueueTypeID)
                .IsRequired();

            builder.HasMany(q => q.Matches)
                .WithOne(m => m.QueueType)
                .HasForeignKey(m => m.QueueTypeID)
                .IsRequired();

            builder.Property(q => q.Description)
                .HasMaxLength(255)
                .IsRequired();

            builder.HasData(new QueueType[]
            {
                new QueueType
                {
                    ID = 440,
                    Description = "5v5 Ranked Flex games"
                },
                new QueueType
                {
                    ID = 430,
                    Description = "5v5 Blind Pick games"
                },
                new QueueType
                {
                    ID = 420,
                    Description = "5v5 Ranked Solo games"
                },
                new QueueType
                {
                    ID = 400,
                    Description = "5v5 Draft Pick games"
                }
            });
        }
    }
}
