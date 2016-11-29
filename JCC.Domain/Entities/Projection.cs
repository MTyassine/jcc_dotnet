using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCC.Domain.Entities
{
    public class Projection
    {
        [Key]
        public int ProjectionId { get; set; }
        public DateTime horaire{get; set;}
        //foreign Key properties
        public int? CinemaId { get; set; }
        public virtual cinema Cinema { get; set; }
        //foreign Key properties
        public int? FilmId { get; set; }
        public virtual Film Film { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
}
}
