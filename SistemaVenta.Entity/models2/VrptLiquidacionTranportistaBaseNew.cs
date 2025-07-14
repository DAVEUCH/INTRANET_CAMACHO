using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptLiquidacionTranportistaBaseNew
    {
        public string LiquidacionTransportistaNumero { get; set; } = null!;
        public DateTime LiquidacionTransportistaFecha { get; set; }
        public string LiquidacionTransportistaResponsableCodigo { get; set; } = null!;
        public string LiquidacionTransportistaResponsableNombre { get; set; } = null!;
        public decimal? LiquidacionTransportistaMontoSoles { get; set; }
        public decimal? LiquidacionTransportistaMontoDolares { get; set; }
        public string ConsolidadoNumCp { get; set; } = null!;
        public string ConsolidadoVehiculoCodigo { get; set; } = null!;
        public string ConsolidadoVehiculoNombre { get; set; } = null!;
        public string ConsolidadoVehiculoChoferCodigo { get; set; } = null!;
        public string ConsolidadoVehiculoChoferNombre { get; set; } = null!;
        public DateTime ConsolidadoComprobanteFecha { get; set; }
        public string ConsolidadoComprobanteTipoCpAbreviacion { get; set; } = null!;
        public string ConsolidadoComprobanteNumCp { get; set; } = null!;
        public string ConsolidadoComprobanteOrigenDestinoCodigo { get; set; } = null!;
        public string ConsolidadoComprobanteOrigenDestinoNombre { get; set; } = null!;
        public string ConsolidadoComprobanteDireccionEntrega { get; set; } = null!;
        public string ConsolidadoComprobanteVendedorCodigo { get; set; } = null!;
        public string ConsolidadoComprobanteVendedorNombre { get; set; } = null!;
        public decimal? ConsolidadoComprobanteMonto { get; set; }
        public decimal? ConsolidadoMontoVentaContado { get; set; }
        public decimal? ConsolidadoMontoVentaCredito { get; set; }
        public decimal? ConsolidadoMontoVentaContadoAnulado { get; set; }
        public decimal? ConsolidadoMontoVentaCreditoAnulado { get; set; }
        public decimal? ConsolidadoMontoNotaCreditoContado { get; set; }
        public decimal? ConsolidadoMontoNotaCreditoCredito { get; set; }
        public decimal? ConsolidadoMontoCobranzaActivo { get; set; }
        public int ConsolidadoMontoGastos { get; set; }
        public int ConsolidadoComprobantePagoConCheque { get; set; }
        public string ConsolidadoComprobanteSeccion { get; set; } = null!;
        public string ConsolidadoComprobanteSubSeccion { get; set; } = null!;
        public int ConsolidadoComprobanteId { get; set; }
        public int ConsolidadoComprobanteMonedaId { get; set; }
        public int ConsolidadoId { get; set; }
        public int ConsolidadoVehiculoId { get; set; }
        public int ConsolidadoComprobanteVendedorId { get; set; }
        public int LiquidacionTransportistaId { get; set; }
    }
}
