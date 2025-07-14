using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class AsignacionRutaZonaVendedor
    {
        public AsignacionRutaZonaVendedor()
        {
            RutaVendedors = new HashSet<RutaVendedor>();
            ZonaVendedors = new HashSet<ZonaVendedor>();
        }

        public int Pkid { get; set; }
        public int Idvendedor { get; set; }

        public virtual Vendedor IdvendedorNavigation { get; set; } = null!;
        public virtual ICollection<RutaVendedor> RutaVendedors { get; set; }
        public virtual ICollection<ZonaVendedor> ZonaVendedors { get; set; }
    }
}
