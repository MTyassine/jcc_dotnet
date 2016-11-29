using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JCC.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace JCC.Data.Configurations
{
    class ProjectionConfiguration : EntityTypeConfiguration<Projection>
    {
        public ProjectionConfiguration()
        {
            {

                HasMany(p => p.Tickets)
                    .WithOptional(c => c.projection)
                    .HasForeignKey(p => p.ProjectionId)
                    .WillCascadeOnDelete(false);

            }
        }
    }
}
