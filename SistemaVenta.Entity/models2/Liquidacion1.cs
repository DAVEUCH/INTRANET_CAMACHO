using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Liquidacion1
    {
        public string ConsolidadoNumCp { get; set; } = null!;
        public DateTime ConsolidadoFecha { get; set; }
        public string ConsolidadoVehiculoCodigo { get; set; } = null!;
        public string ConsolidadoVehiculoNombre { get; set; } = null!;
        public string ConsolidadoVehiculoChoferCodigo { get; set; } = null!;
        public string ConsolidadoVehiculoChoferNombre { get; set; } = null!;
        public DateTime ConsolidadoComprobanteFecha { get; set; }
        public string ConsolidadoComprobanteTipoCpAbreviacion { get; set; } = null!;
        public string ConsolidadoComprobanteNumCp { get; set; } = null!;
        public string ConsolidadoComprobanteSeccion { get; set; } = null!;
        public string ConsolidadoComprobanteVendedorCodigo { get; set; } = null!;
        public string ConsolidadoComprobanteVendedorNombre { get; set; } = null!;
        public string ConsolidadoComprobanteOrigenDestinoCodigo { get; set; } = null!;
        public string ConsolidadoComprobanteOrigenDestinoNombre { get; set; } = null!;
        public string ConsolidadoComprobanteDireccion { get; set; } = null!;
        public string ConsolidadoComprobanteDireccionEntrega { get; set; } = null!;
        public string? ConsolidadoComprobanteZonaDescripcion { get; set; }
        public string? ConsolidadoComprobanteZonaCodgo { get; set; }
        public bool ConsolidadoComprobanteCredito { get; set; }
        public decimal? ConsolidadoComprobanteMontoSoles { get; set; }
        public decimal? ConsolidadoComprobanteMontoDolares { get; set; }
        public int ConsolidadoId { get; set; }
        public decimal? MontoSolesCredito { get; set; }
        public decimal? MontoSolesContado { get; set; }
        public decimal? MontoDolaresCredito { get; set; }
        public decimal? MontoDolaresContado { get; set; }
        public decimal? MontoAnulado { get; set; }
        public int ConsolidadoVehiculoId { get; set; }
    }
}
