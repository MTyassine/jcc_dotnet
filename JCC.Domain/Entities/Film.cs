
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCC.Domain.Entities
{
    public class Film
    {
        [Key]
        public int FilmId { get; set; }
        public String Nom{get; set;}

        public String realisateur{get; set;}
        public String origine{get; set;}
        public virtual ICollection<Projection> Projections { get; set; }
    }
}
