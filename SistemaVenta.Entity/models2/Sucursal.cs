using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Sucursal
    {
        public Sucursal()
        {
            Almacens = new HashSet<Almacen>();
            Cajas = new HashSet<Caja>();
            Comisions = new HashSet<Comision>();
            Cps = new HashSet<Cp>();
            CuotaVenta = new HashSet<CuotaVentum>();
            ListaInventarios = new HashSet<ListaInventario>();
            SucursalBonificacions = new HashSet<SucursalBonificacion>();
            TipoCps = new HashSet<TipoCp>();
            VoucherContables = new HashSet<VoucherContable>();
        }

        public int Pkid { get; set; }
        public string Nombre { get; set; } = null!;
        public string Direccion { get; set; } = null!;
        public bool? Activo { get; set; }
        public string Codigo { get; set; } = null!;

        public virtual ICollection<Almacen> Almacens { get; set; }
        public virtual ICollection<Caja> Cajas { get; set; }
        public virtual ICollection<Comision> Comisions { get; set; }
        public virtual ICollection<Cp> Cps { get; set; }
        public virtual ICollection<CuotaVentum> CuotaVenta { get; set; }
        public virtual ICollection<ListaInventario> ListaInventarios { get; set; }
        public virtual ICollection<SucursalBonificacion> SucursalBonificacions { get; set; }
        public virtual ICollection<TipoCp> TipoCps { get; set; }
        public virtual ICollection<VoucherContable> VoucherContables { get; set; }
    }
}
