using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class GrupoVenta
    {
        public GrupoVenta()
        {
            CpDistribucions = new HashSet<CpDistribucion>();
            GrupoVentasItemListaPrecios = new HashSet<GrupoVentasItemListaPrecio>();
            Vendedors = new HashSet<Vendedor>();
        }

        public int Pkid { get; set; }
        public int IdfuerzaVentas { get; set; }
        public int Idsupervisor { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Observacion { get; set; } = null!;

        public virtual FuerzaVenta IdfuerzaVentasNavigation { get; set; } = null!;
        public virtual Persona IdsupervisorNavigation { get; set; } = null!;
        public virtual ICollection<CpDistribucion> CpDistribucions { get; set; }
        public virtual ICollection<GrupoVentasItemListaPrecio> GrupoVentasItemListaPrecios { get; set; }
        public virtual ICollection<Vendedor> Vendedors { get; set; }
    }
}
