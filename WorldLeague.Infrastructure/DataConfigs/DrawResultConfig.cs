using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using WorldLeague.Domain.Entities;

namespace WorldLeague.Infrastructure.DataConfigs
{
    public class DrawResultConfig : IEntityTypeConfiguration<DrawResult>
    {
        public void Configure(EntityTypeBuilder<DrawResult> builder)
        {
            builder.ToTable("draw_results");
            builder.HasKey(q => q.Id);

            builder.OwnsMany(q => q.Groups, p =>
            {
                p.ToTable("draw_groups");
                p.HasKey(k => k.Id);
                p.OwnsMany(c => c.Teams, o =>
                {
                    o.ToTable("teams");
                    o.HasKey(k => k.Id);
                });
            });
        }
    }
}
