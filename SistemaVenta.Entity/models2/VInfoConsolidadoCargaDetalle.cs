using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VInfoConsolidadoCargaDetalle
    {
        public string ConsolidadoNumero { get; set; } = null!;
        public string ConsolidadoCodigo { get; set; } = null!;
        public string ConsolidadoComprobanteProductoCodigo { get; set; } = null!;
        public string ConsolidadoComprobanteProductoDescripcion { get; set; } = null!;
        public string ConsolidadoComprobanteProductoUnidadBase { get; set; } = null!;
        public string ConsolidadoComprobanteProductoUnidadReferencia { get; set; } = null!;
        public int ConsolidadoComprobanteProductoFactorReferencia { get; set; }
        public int ConsolidadoComprobanteCantidad { get; set; }
        public bool ConsolidadoComprobanteBonificacion { get; set; }
        public DateTime ConsolidadoFecha { get; set; }
        public int ConsolidadoCargaId { get; set; }
        public decimal ConsolidadoItemPeso { get; set; }
    }
}
