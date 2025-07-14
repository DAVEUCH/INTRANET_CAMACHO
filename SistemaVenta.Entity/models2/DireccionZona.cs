using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class DireccionZona
    {
        public int Idzona { get; set; }
        public int Idcliente { get; set; }
        public int Iddireccion { get; set; }
        public int Pkid { get; set; }
        public int OrdenVisita { get; set; }

        public virtual Persona IdclienteNavigation { get; set; } = null!;
        public virtual Direccion IddireccionNavigation { get; set; } = null!;
        public virtual Zona IdzonaNavigation { get; set; } = null!;
    }
}
