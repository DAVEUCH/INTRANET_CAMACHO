using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrpteConsolidadoCargaDocPago
    {
        public string ConsolidadoNumero { get; set; } = null!;
        public DateTime ConsolidadoFecha { get; set; }
        public string ConsolidadoVehiculoCodigo { get; set; } = null!;
        public string ConsolidadoVehiculoNombre { get; set; } = null!;
        public string ConsolidadoVehiculoChoferCodigo { get; set; } = null!;
        public string ConsolidadoVehiculoChoferNombre { get; set; } = null!;
        public DateTime ConsolidadoComprobanteFecha { get; set; }
        public string ConsolidadoComprobanteTipoCpAbreviacion { get; set; } = null!;
        public string ConsolidadoComprobanteNumCp { get; set; } = null!;
        public string ConsolidadoComprobantePersonaCodigo { get; set; } = null!;
        public string ConsolidadoComprobantePersonaNombre { get; set; } = null!;
        public string ConsolidadoComprobanteDireccion { get; set; } = null!;
        public string ConsolidadoComprobanteDireccionEntrega { get; set; } = null!;
        public string ConsolidadoComprobanteVendedorCodigo { get; set; } = null!;
        public string ConsolidadoComprobanteVendedorNombre { get; set; } = null!;
        public string? ConsolidadoComprobanteZonaDescripcion { get; set; }
        public string? ConsolidadoComprobanteZonaCodgo { get; set; }
        public bool ConsolidadoComprobanteAnulado { get; set; }
        public bool ConsolidadoComprobanteCredito { get; set; }
        public decimal ConsolidadoComprobanteMonto { get; set; }
        public decimal? ConsolidadoComprobanteMontoAnulado { get; set; }
        public decimal? ConsolidadoComprobanteMontoSoles { get; set; }
        public decimal? ConsolidadoComprobanteMontoDolares { get; set; }
        public decimal? ConsolidadoComprobanteMontoSolesCredito { get; set; }
        public decimal? ConsolidadoComprobanteMontoDolaresCredito { get; set; }
        public decimal? ConsolidadoComprobanteMontoSolesContado { get; set; }
        public decimal? ConsolidadoComprobanteMontoDolaresContado { get; set; }
        public int ConsolidadoComprobantePagoConCheque { get; set; }
        public string ConsolidadoComprobanteSeccion { get; set; } = null!;
        public int ConsolidadoComprobanteId { get; set; }
        public int ConsolidadoVehiculoId { get; set; }
        public int ConsolidadoComprobanteMonedaId { get; set; }
        public int ConsolidadoComprobanteVendedorId { get; set; }
        public int ConsolidadoId { get; set; }
    }
}
