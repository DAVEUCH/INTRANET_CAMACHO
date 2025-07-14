using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Monedum
    {
        public Monedum()
        {
            CargoAbonos = new HashSet<CargoAbono>();
            Clientes = new HashSet<Cliente>();
            ConciliacionBancaria = new HashSet<ConciliacionBancarium>();
            CpCajas = new HashSet<CpCaja>();
            CpOrdenPagos = new HashSet<CpOrdenPago>();
            Cps = new HashSet<Cp>();
            ItemConciliacionBancaria = new HashSet<ItemConciliacionBancarium>();
            LineaCreditoPorFuerzaVenta = new HashSet<LineaCreditoPorFuerzaVenta>();
            ListaPrecios = new HashSet<ListaPrecio>();
            ListaPreciosProveedors = new HashSet<ListaPreciosProveedor>();
            MovimientoCuentaBancos = new HashSet<MovimientoCuentaBanco>();
            Productos = new HashSet<Producto>();
            RangoAprobacionOrdenCompras = new HashSet<RangoAprobacionOrdenCompra>();
            TipoCambioFechas = new HashSet<TipoCambioFecha>();
        }

        public int Pkid { get; set; }
        public string Descripcion { get; set; } = null!;
        public string Simbolo { get; set; } = null!;
        public decimal TipoCambioCompra { get; set; }
        public decimal TipoCambioVenta { get; set; }
        public DateTime FechaTipoCambio { get; set; }
        public bool MonedaBase { get; set; }
        public string Codigo { get; set; } = null!;

        public virtual ICollection<CargoAbono> CargoAbonos { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<ConciliacionBancarium> ConciliacionBancaria { get; set; }
        public virtual ICollection<CpCaja> CpCajas { get; set; }
        public virtual ICollection<CpOrdenPago> CpOrdenPagos { get; set; }
        public virtual ICollection<Cp> Cps { get; set; }
        public virtual ICollection<ItemConciliacionBancarium> ItemConciliacionBancaria { get; set; }
        public virtual ICollection<LineaCreditoPorFuerzaVenta> LineaCreditoPorFuerzaVenta { get; set; }
        public virtual ICollection<ListaPrecio> ListaPrecios { get; set; }
        public virtual ICollection<ListaPreciosProveedor> ListaPreciosProveedors { get; set; }
        public virtual ICollection<MovimientoCuentaBanco> MovimientoCuentaBancos { get; set; }
        public virtual ICollection<Producto> Productos { get; set; }
        public virtual ICollection<RangoAprobacionOrdenCompra> RangoAprobacionOrdenCompras { get; set; }
        public virtual ICollection<TipoCambioFecha> TipoCambioFechas { get; set; }
    }
}
