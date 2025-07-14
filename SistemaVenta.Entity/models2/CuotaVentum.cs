using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class CuotaVentum
    {
        public CuotaVentum()
        {
            AgrupacionCuotaVenta = new HashSet<AgrupacionCuotaVentum>();
            Comisions = new HashSet<Comision>();
            ItemCuotaVenta = new HashSet<ItemCuotaVentum>();
            VendedorCuotaVenta = new HashSet<VendedorCuotaVentum>();
        }

        public int Pkid { get; set; }
        public string Mes { get; set; } = null!;
        public string Año { get; set; } = null!;
        public string? Descripcion { get; set; }
        public int? IdSucursal { get; set; }

        public virtual Sucursal? IdSucursalNavigation { get; set; }
        public virtual ICollection<AgrupacionCuotaVentum> AgrupacionCuotaVenta { get; set; }
        public virtual ICollection<Comision> Comisions { get; set; }
        public virtual ICollection<ItemCuotaVentum> ItemCuotaVenta { get; set; }
        public virtual ICollection<VendedorCuotaVentum> VendedorCuotaVenta { get; set; }
    }
}
