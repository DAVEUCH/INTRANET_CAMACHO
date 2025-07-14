using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TipoPersona
    {
        public TipoPersona()
        {
            CptoOperacions = new HashSet<CptoOperacion>();
        }

        public int Pkid { get; set; }
        public string Nombre { get; set; } = null!;
        public bool Compras { get; set; }
        public bool Ventas { get; set; }
        public bool Inventario { get; set; }
        public bool Caja { get; set; }
        public bool Ninguno { get; set; }
        public string IdtipoAsociado { get; set; } = null!;

        public virtual ICollection<CptoOperacion> CptoOperacions { get; set; }
    }
}
