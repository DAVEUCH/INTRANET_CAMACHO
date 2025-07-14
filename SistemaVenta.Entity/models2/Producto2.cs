using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Producto2
    {
        public int Pkid { get; set; }
        public int Idproducto { get; set; }
        public string CodigoEan { get; set; } = null!;
        public string CodigoDun { get; set; } = null!;
        public decimal PrecioReferencia { get; set; }
        public bool Bonificacion { get; set; }
        public int FactorDun { get; set; }

        public virtual ProductoServicio IdproductoNavigation { get; set; } = null!;
    }
}
