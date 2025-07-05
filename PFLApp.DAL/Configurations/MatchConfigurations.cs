using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PFLApp.DAL.Entity;

namespace PFLApp.DAL.Configurations
{
    internal class MatchConfigurations : IEntityTypeConfiguration<Match>
    {
        public void Configure(EntityTypeBuilder<Match> builder)
        {
            builder.HasOne(m => m.HomeTeam)
                   .WithMany()
                   .HasForeignKey(m => m.HomeTeamId)
                   .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(m => m.AwayTeam)
                     .WithMany()
                     .HasForeignKey(m => m.AwayTeamId)
                     .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
