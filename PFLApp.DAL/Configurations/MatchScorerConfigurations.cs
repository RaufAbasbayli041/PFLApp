using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PFLApp.DAL.Entity;

namespace PFLApp.DAL.Configurations
{
    public class MatchScorerConfigurations : IEntityTypeConfiguration<MatchScorer>
    {
        public void Configure(EntityTypeBuilder<MatchScorer> builder)
        {
            builder.HasOne(ms => ms.Match)
                   .WithMany(m => m.MatchScorers)
                   .HasForeignKey(ms => ms.MatchId);

            builder.HasOne(ms => ms.Player)
                   .WithMany()
                   .HasForeignKey(ms => ms.PlayerId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
