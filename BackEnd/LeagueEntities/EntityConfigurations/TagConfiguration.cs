using LeagueEntities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeagueEntities.EntityConfigurations
{
    public class TagConfiguration : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.Property(t => t.ID)
                .UseIdentityColumn()
                .IsRequired();

            builder.Property(t => t.TagName)
                .HasMaxLength(50)
                .IsRequired();

            builder.HasData(new Tag[]
            {
                new Tag
                {
                    ID = 1,
                    TagName = "Fighter"
                },
                new Tag
                {
                    ID = 2,
                    TagName = "Tank"
                },
                new Tag
                {
                    ID = 3,
                    TagName = "Mage"
                },
                new Tag
                {
                    ID = 4,
                    TagName = "Assasin"
                },
                new Tag
                {
                    ID = 5,
                    TagName = "Support"
                },
                new Tag
                {
                    ID = 6,
                    TagName = "Marksman"
                }
            });
        }
    }
}
