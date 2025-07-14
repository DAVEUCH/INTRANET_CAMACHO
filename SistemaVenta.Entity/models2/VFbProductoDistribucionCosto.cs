using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VFbProductoDistribucionCosto
    {
        public int Iddistribucion { get; set; }
        public int Idproducto { get; set; }
        public decimal? MontoSoles { get; set; }
    }
}
