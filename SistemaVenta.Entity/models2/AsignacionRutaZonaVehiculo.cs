using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class AsignacionRutaZonaVehiculo
    {
        public AsignacionRutaZonaVehiculo()
        {
            RutaVehiculos = new HashSet<RutaVehiculo>();
            ZonaVehiculos = new HashSet<ZonaVehiculo>();
        }

        public int Pkid { get; set; }
        public int Idvehiculo { get; set; }

        public virtual Vehiculo IdvehiculoNavigation { get; set; } = null!;
        public virtual ICollection<RutaVehiculo> RutaVehiculos { get; set; }
        public virtual ICollection<ZonaVehiculo> ZonaVehiculos { get; set; }
    }
}
