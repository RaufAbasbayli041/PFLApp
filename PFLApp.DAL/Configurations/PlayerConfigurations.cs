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
    public class PlayerConfigurations : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            builder.HasOne(p => p.Team)
                   .WithMany(t => t.Players)
                   .HasForeignKey(p => p.TeamId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
