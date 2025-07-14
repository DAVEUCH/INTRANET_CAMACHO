using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenta.Entity.Models
{
    public partial class Area
    {
        public Area()
        {
            Tickets = new HashSet<Ticket>();
            Usuarios = new HashSet<Usuario>();
        }

        public int IdArea { get; set; }
        public string? Descripcion { get; set; }
        public bool? EsActivo { get; set; }
        public DateTime? FechaRegistro { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
