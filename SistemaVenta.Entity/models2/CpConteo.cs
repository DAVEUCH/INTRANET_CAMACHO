using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class CpConteo
    {
        public int Pkid { get; set; }
        public string NumDocOrigen { get; set; } = null!;
        public string EstadoGeneracion { get; set; } = null!;
        public int Idalmacen { get; set; }

        public virtual Cp Pk { get; set; } = null!;
    }
}
