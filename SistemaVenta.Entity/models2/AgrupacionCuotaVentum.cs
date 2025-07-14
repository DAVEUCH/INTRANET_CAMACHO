using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class AgrupacionCuotaVentum
    {
        public AgrupacionCuotaVentum()
        {
            ProductoAgrupacionCuotaVenta = new HashSet<ProductoAgrupacionCuotaVentum>();
        }

        public int Pkid { get; set; }
        public int IdcuotaVenta { get; set; }
        public string Descripcion { get; set; } = null!;
        public string? Agrupacion { get; set; }

        public virtual CuotaVentum IdcuotaVentaNavigation { get; set; } = null!;
        public virtual ICollection<ProductoAgrupacionCuotaVentum> ProductoAgrupacionCuotaVenta { get; set; }
    }
}
