using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenta.Entity.Models
{
    public partial class TipoSop
    {
        public TipoSop()
        {
            Tickets = new HashSet<Ticket>();
        }
        [Key]
        public int IdTipoSop { get; set; }
        public string? Descripcion { get; set; }
        public bool? EsActivo { get; set; }
        public DateTime? FechaRegistro { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
