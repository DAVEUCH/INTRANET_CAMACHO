using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EPrestamoConsolidadoCarga
    {
        public int Id { get; set; }
        public int IdconsolidadoCarga { get; set; }
        public int Idprestamo { get; set; }
    }
}
