using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JCC.Domain.Entities
{
    public class cinema
    {   [Key]
        public int CinemaId { get; set; }
        public String nom { get; set; }
        public String localisation { get; set; }

        public virtual ICollection<Projection> Projections { get; set; }
    }
}
