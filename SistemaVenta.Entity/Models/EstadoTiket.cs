using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenta.Entity.Models
{
    public partial class EstadoTiket
    {
        public EstadoTiket()
        {
            Tickets = new HashSet<Ticket>();
        }

        public int IdEstado { get; set; }
        public string? Descripcion { get; set; }
        public bool? EsActivo { get; set; }
        public DateTime? FechaRegistro { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
