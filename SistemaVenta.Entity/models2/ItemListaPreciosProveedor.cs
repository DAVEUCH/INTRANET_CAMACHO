using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemListaPreciosProveedor
    {
        public int Pkid { get; set; }
        public int IdlistaPreciosProveedor { get; set; }
        public int Idproducto { get; set; }
        public decimal Precio { get; set; }
        public decimal PrecioIncImpuesto { get; set; }
        public decimal DescuentoA { get; set; }
        public decimal DescuentoB { get; set; }
        public decimal DescuentoC { get; set; }
        public decimal DescuentoD { get; set; }
        public decimal PrecioNeto { get; set; }
        public decimal PrecioNetoImpto { get; set; }
        public DateTime FechaUltimaModificacion { get; set; }
        public int Idunidad { get; set; }
        public decimal? Margen { get; set; }
        public decimal? MargenPorcentual { get; set; }
        public bool? AplicaMargen { get; set; }

        public virtual ListaPreciosProveedor IdlistaPreciosProveedorNavigation { get; set; } = null!;
        public virtual ProductoServicio IdproductoNavigation { get; set; } = null!;
        public virtual Unidad IdunidadNavigation { get; set; } = null!;
    }
}
