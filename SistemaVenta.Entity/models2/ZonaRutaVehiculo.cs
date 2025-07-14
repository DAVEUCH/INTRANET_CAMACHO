using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ZonaRutaVehiculo
    {
        public int Pkid { get; set; }
        public int IdrutaVehiculo { get; set; }
        public int Idzona { get; set; }
        public int? NumeroSemanas { get; set; }
        public DateTime? FechaInicio { get; set; }

        public virtual RutaVehiculo IdrutaVehiculoNavigation { get; set; } = null!;
        public virtual Zona IdzonaNavigation { get; set; } = null!;
    }
}
