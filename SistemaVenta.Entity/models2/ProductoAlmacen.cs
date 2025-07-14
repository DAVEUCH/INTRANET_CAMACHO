using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ProductoAlmacen
    {
        public int Pkid { get; set; }
        public int Idproducto { get; set; }
        public int Idalmacen { get; set; }
        public int IdseccionAlmacen { get; set; }
        public int Capacidad { get; set; }
        public int StockFisico { get; set; }
        public int StockContable { get; set; }
        public int StockPorEntregar { get; set; }
        public int StockPorRecibir { get; set; }
        public int TiempoDeEntrega { get; set; }
        public int FrecuenciaDeCompra { get; set; }
        public int TiempoDeSeguridad { get; set; }
        public decimal NivelReposicion { get; set; }
        public bool? Activo { get; set; }
        public int? CantidadMinima { get; set; }
        public int? StockMinimo { get; set; }
        public int? StockMaximo { get; set; }

        public virtual Almacen IdalmacenNavigation { get; set; } = null!;
        public virtual ProductoServicio IdproductoNavigation { get; set; } = null!;
        public virtual SeccionAlmacen IdseccionAlmacenNavigation { get; set; } = null!;
    }
}
