using JCC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCC.Data.Configurations
{
    public class cinemaConfiguration : EntityTypeConfiguration<cinema>
    {
        public cinemaConfiguration()
        {

            HasMany(p => p.Projections)  
                .WithOptional(c => c.Cinema)
                .HasForeignKey(p => p.CinemaId)
                .WillCascadeOnDelete(false);
        }
    }

}

