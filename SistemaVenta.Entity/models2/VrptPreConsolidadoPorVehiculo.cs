using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptPreConsolidadoPorVehiculo
    {
        public string EntidadNombre { get; set; } = null!;
        public string EntidadCodigo { get; set; } = null!;
        public string Entidad2Nombre { get; set; } = null!;
        public string Entidad2Codigo { get; set; } = null!;
        public string ConsolidadoComprobanteProductoCodigo { get; set; } = null!;
        public string ConsolidadoComprobanteProductoDescripcion { get; set; } = null!;
        public string ConsolidadoComprobanteProductoUnidadBase { get; set; } = null!;
        public string ConsolidadoComprobanteProductoUnidadReferencia { get; set; } = null!;
        public int ConsolidadoComprobanteProductoFactorReferencia { get; set; }
        public decimal ConsolidadoComprobanteCantidad { get; set; }
        public int ConsolidadoComprobantePeso { get; set; }
        public int ConsolidadoComprobanteVolumen { get; set; }
        public DateTime Fecha { get; set; }
        public int ConsolidadoComprobanteAlmacenId { get; set; }
    }
}
