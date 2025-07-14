using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ERutaVehiculo
    {
        public int RutasId { get; set; }
        public int IdasignacionRutaZonaVehiculo { get; set; }
        public string RutasDiaDeSemana { get; set; } = null!;
        public string RutasCodigo { get; set; } = null!;
    }
}
