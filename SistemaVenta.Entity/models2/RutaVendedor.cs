using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class RutaVendedor
    {
        public RutaVendedor()
        {
            ZonaRutaVendedors = new HashSet<ZonaRutaVendedor>();
        }

        public int Pkid { get; set; }
        public int IdasignacionRutaZonaVendedor { get; set; }
        public string DiaDeSemana { get; set; } = null!;
        public string Codigo { get; set; } = null!;

        public virtual AsignacionRutaZonaVendedor IdasignacionRutaZonaVendedorNavigation { get; set; } = null!;
        public virtual ICollection<ZonaRutaVendedor> ZonaRutaVendedors { get; set; }
    }
}
