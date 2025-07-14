using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ERutaVendedor
    {
        public int RutasId { get; set; }
        public int IdasignacionRutaZonaVendedor { get; set; }
        public string RutasDiaDeSemana { get; set; } = null!;
        public string RutasCodigo { get; set; } = null!;
    }
}
