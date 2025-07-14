using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ProductoAuspiciador
    {
        public int Pkid { get; set; }
        public int Idproducto { get; set; }
        public int Idunidad { get; set; }
        public int Idbonificacion { get; set; }
        public bool IncluyeAfines { get; set; }
        public bool PorMonto { get; set; }
        public bool UnidadExclusiva { get; set; }
        public decimal Desde { get; set; }
        public decimal Hasta { get; set; }
        public decimal CondicionDeRango { get; set; }

        public virtual Bonificacion IdbonificacionNavigation { get; set; } = null!;
        public virtual Producto IdproductoNavigation { get; set; } = null!;
        public virtual Unidad IdunidadNavigation { get; set; } = null!;
    }
}
