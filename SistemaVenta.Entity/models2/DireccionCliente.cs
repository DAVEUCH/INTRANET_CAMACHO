using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class DireccionCliente
    {
        public int Pkid { get; set; }
        public int IdzonaReparto { get; set; }
        public decimal Longitud { get; set; }
        public decimal Latitud { get; set; }

        public virtual Direccion Pk { get; set; } = null!;
    }
}
