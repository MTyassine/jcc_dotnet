using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JCC.Domain.Entities
{
    public class Ticket
    {
        [Key]
        public int TicketId { get; set; }
        //foreign Key properties
        public int? ProjectionId { get; set; }
        public virtual Projection projection { get; set; }
    }
}
