using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Vendedor
    {
        public Vendedor()
        {
            AsignacionRutaZonaVendedors = new HashSet<AsignacionRutaZonaVendedor>();
            ItemFuerzaVentasVendedors = new HashSet<ItemFuerzaVentasVendedor>();
            Nopedidos = new HashSet<Nopedido>();
            VendedorCuotaVenta = new HashSet<VendedorCuotaVentum>();
        }

        public int Pkid { get; set; }
        public int IdgrupoVentas { get; set; }
        public bool FueraDeRuta { get; set; }
        public decimal ComisionVenta { get; set; }
        public decimal ComisionCobranza { get; set; }
        public int DiasDeGracia { get; set; }
        public int? Idsucursal { get; set; }

        public virtual GrupoVenta IdgrupoVentasNavigation { get; set; } = null!;
        public virtual Empleado Pk { get; set; } = null!;
        public virtual Vendedor1 Vendedor1 { get; set; } = null!;
        public virtual ICollection<AsignacionRutaZonaVendedor> AsignacionRutaZonaVendedors { get; set; }
        public virtual ICollection<ItemFuerzaVentasVendedor> ItemFuerzaVentasVendedors { get; set; }
        public virtual ICollection<Nopedido> Nopedidos { get; set; }
        public virtual ICollection<VendedorCuotaVentum> VendedorCuotaVenta { get; set; }
    }
}
