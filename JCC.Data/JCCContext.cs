using JCC.Data.Configurations;
using JCC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCC.Data
{
    public class JCCContext : DbContext
    {
        public JCCContext()
            : base("Name=MyDBConnection")
        {
            //  Database.SetInitializer<MyFinanceContext>(new MyFinanceContextInitializer());
        }

        public DbSet<cinema> Cinemas { get; set; }
        public DbSet<Projection> Projections { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<Ticket> Tickets { get; set; }


        /*protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //If you want to remove all Convetions and work only with configuration :
            //  modelBuilder.Conventions.Remove<IncludeMetadataConvention>();
            modelBuilder.Configurations.Add(new cinemaConfiguration());
            modelBuilder.Configurations.Add(new ProjectionConfiguration());
            modelBuilder.Configurations.Add(new FilmConfiguration());

        }*/

    }

    


}
