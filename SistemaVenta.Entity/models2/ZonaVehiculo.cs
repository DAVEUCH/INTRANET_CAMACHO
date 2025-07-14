using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ZonaVehiculo
    {
        public int Pkid { get; set; }
        public int IdasignacionRutaZonaVehiculo { get; set; }
        public int Idzona { get; set; }

        public virtual AsignacionRutaZonaVehiculo IdasignacionRutaZonaVehiculoNavigation { get; set; } = null!;
        public virtual Zona IdzonaNavigation { get; set; } = null!;
    }
}
