using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ProductoObsequio
    {
        public int Pkid { get; set; }
        public int Idproducto { get; set; }
        public int Idunidad { get; set; }
        public int Idbonificacion { get; set; }
        public int Cantidad { get; set; }
        public int CantidadMaxima { get; set; }
        public int CantidadMaximaPorCliente { get; set; }
        public DateTime Desde { get; set; }
        public DateTime Hasta { get; set; }
        public bool TieneStock { get; set; }
        public decimal Stock { get; set; }
        public bool TieneCantidadPorCliente { get; set; }

        public virtual Bonificacion IdbonificacionNavigation { get; set; } = null!;
        public virtual Producto IdproductoNavigation { get; set; } = null!;
        public virtual Unidad IdunidadNavigation { get; set; } = null!;
    }
}
