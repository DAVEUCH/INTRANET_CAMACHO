using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VVehiculoDiaRutaZonaVisitum
    {
        public string DiaDeSemana { get; set; } = null!;
        public string CodigoVehiculo { get; set; } = null!;
        public string NombreVehiculo { get; set; } = null!;
        public int Idzona { get; set; }
    }
}
