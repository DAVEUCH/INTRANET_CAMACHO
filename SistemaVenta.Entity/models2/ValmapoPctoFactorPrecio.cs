using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ValmapoPctoFactorPrecio
    {
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string CodigoEan { get; set; } = null!;
        public string CodigoDun { get; set; } = null!;
        public string Gcas { get; set; } = null!;
        public string Expr1 { get; set; } = null!;
        public int Factor { get; set; }
        public decimal PrecioIncImpto { get; set; }
        public decimal CostoPromedioSoles { get; set; }
        public decimal CostoUltimaCompraSoles { get; set; }
        public bool Activo { get; set; }
    }
}
