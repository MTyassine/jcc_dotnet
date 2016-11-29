using JCC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCC.Data.Configurations
{
    class FilmConfiguration : EntityTypeConfiguration<Film>
    {
        public FilmConfiguration()
        {
            {
                
                HasMany(p => p.Projections)
                    .WithOptional(c => c.Film)
                    .HasForeignKey(p => p.FilmId)
                    .WillCascadeOnDelete(false);

            }
        }
    }
}
