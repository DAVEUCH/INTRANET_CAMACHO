using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class RutaVehiculo
    {
        public RutaVehiculo()
        {
            ZonaRutaVehiculos = new HashSet<ZonaRutaVehiculo>();
        }

        public int Pkid { get; set; }
        public int IdasignacionRutaZonaVehiculo { get; set; }
        public string DiaDeSemana { get; set; } = null!;
        public string Codigo { get; set; } = null!;

        public virtual AsignacionRutaZonaVehiculo IdasignacionRutaZonaVehiculoNavigation { get; set; } = null!;
        public virtual ICollection<ZonaRutaVehiculo> ZonaRutaVehiculos { get; set; }
    }
}
