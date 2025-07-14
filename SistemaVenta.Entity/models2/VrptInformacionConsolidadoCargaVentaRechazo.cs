using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptInformacionConsolidadoCargaVentaRechazo
    {
        public DateTime ConsolidadoFecha { get; set; }
        public string ConsolidadoNumero { get; set; } = null!;
        public string ConsolidadoVehiculoCodigo { get; set; } = null!;
        public string ConsolidadoVehiculoNombre { get; set; } = null!;
        public DateTime ConsolidadoComprobanteFecha { get; set; }
        public string ConsolidadoComprobanteNumCp { get; set; } = null!;
        public string ConsolidadoComprobanteVendedorCodigo { get; set; } = null!;
        public string ConsolidadoComprobanteVendedorNombre { get; set; } = null!;
        public string? ConsolidadoComprobanteVendedorGrupoVentaCodigo { get; set; }
        public string? ConsolidadoComprobanteVendedorGrupoVentaNombre { get; set; }
        public string? ConsolidadoComprobanteVendedorFuerzaVentaCodigo { get; set; }
        public string? ConsolidadoComprobanteVendedorFuerzaVentaNombre { get; set; }
        public string ConsolidadoComprobanteProductoCodigo { get; set; } = null!;
        public string ConsolidadoComprobanteProductoDescripcion { get; set; } = null!;
        public string ConsolidadoComprobanteProductoUnidadBase { get; set; } = null!;
        public int ConsolidadoComprobanteProductoFactorReferencia { get; set; }
        public string ConsolidadoComprobanteProductoUnidadReferencia { get; set; } = null!;
        public int? ConsolidadoComprobanteCantidadVenta { get; set; }
        public int? ConsolidadoComprobanteCantidadDevolucion { get; set; }
        public decimal? ConsolidadoComprobanteMontoVenta { get; set; }
        public decimal? ConsolidadoComprobanteMontoDevolucion { get; set; }
        public string? ConsolidadoComprobanteAlmacenCodigo { get; set; }
        public string? ConsolidadoComprobanteAlmacenNombre { get; set; }
        public int? ConsolidadoComprobanteAlmacenId { get; set; }
        public int? ConsolidadoComprobanteVendedorFuerzaVentaId { get; set; }
        public int ConsolidadoComprobanteVendedorGrupoVentaId { get; set; }
        public int ConsolidadoComprobanteVendedorId { get; set; }
        public int ConsolidadoComprobanteVehiculoId { get; set; }
        public string Chofer { get; set; } = null!;
        public string ComprobanteMotivoAnulacionCodigo { get; set; } = null!;
    }
}
