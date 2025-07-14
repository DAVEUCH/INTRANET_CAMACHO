using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptInformacionConsolidadoCargaNotasCredito
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
        public string ConsolidadoComprobanteVendedorCodigo { get; set; } = null!;
        public string ConsolidadoComprobanteVendedorNombre { get; set; } = null!;
        public string ConsolidadoComprobanteOrigenDestinoCodigo { get; set; } = null!;
        public string ConsolidadoComprobanteOrigenDestinoNombre { get; set; } = null!;
        public string ConsolidadoComprobanteDireccion { get; set; } = null!;
        public string ConsolidadoComprobanteDireccionEntrega { get; set; } = null!;
        public string ConsolidadoComprobanteZonaDescripcion { get; set; } = null!;
        public string ConsolidadoComprobanteZonaCodigo { get; set; } = null!;
        public bool ConsolidadoComprobanteCredito { get; set; }
        public bool ConsolidadoComprobanteAnulado { get; set; }
        public decimal ConsolidadoComprobanteMonto { get; set; }
        public decimal? ConsolidadoComprobanteMontoSoles { get; set; }
        public decimal? ConsolidadoComprobanteMontoDolares { get; set; }
        public int ConsolidadoComprobantePagoConCheque { get; set; }
        public string ConsolidadoComprobanteSeccion { get; set; } = null!;
        public int ConsolidadoComprobanteId { get; set; }
        public int ConsolidadoVehiculoId { get; set; }
        public int ConsolidadoComprobanteMonedaId { get; set; }
        public int ConsolidadoComprobanteVendedorId { get; set; }
        public int ConsolidadoId { get; set; }
    }
}
