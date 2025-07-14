using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EImpuestoProductoServicio
    {
        public int IdproductoServicio { get; set; }
        public int ImpuestosIdimpuesto { get; set; }
        public decimal ImpuestosPorcentajeImpuesto { get; set; }
        public bool ImpuestosInafecto { get; set; }
    }
}
