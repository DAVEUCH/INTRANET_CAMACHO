using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VCostoUltimaCompraAuxiliar
    {
        public DateTime Fecha { get; set; }
        public int Idproducto { get; set; }
        public decimal CostoUltimaCompraSoles { get; set; }
        public decimal CostoUltimaCompraDolares { get; set; }
    }
}
