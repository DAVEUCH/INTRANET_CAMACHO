using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrpteCuentaCorrienteCajaDmaFreddyold
    {
        public DateTime ComprobanteFecha { get; set; }
        public string? Shora { get; set; }
        public string ComprobanteNumero { get; set; } = null!;
        public string ComprobanteTipoAbreviacion { get; set; } = null!;
        public string CajaCodigo { get; set; } = null!;
        public string CajaNombre { get; set; } = null!;
        public string ConceptoOperacionCodigo { get; set; } = null!;
        public string ConceptoOperacionDescripcion { get; set; } = null!;
        public string DocumentoCobrarPagarNumero { get; set; } = null!;
        public string? DocumentoCobrarPagarTipoAbreviacion { get; set; }
        public string DocumentoCobrarPagarPersonaCodigo { get; set; } = null!;
        public string DocumentoCobrarPagarPersonaNombre { get; set; } = null!;
        public string MedioDePagoNumero { get; set; } = null!;
        public string MedioDePagoTipoCodigo { get; set; } = null!;
        public string MedioDePagoTipoDescripcion { get; set; } = null!;
        public string ItemComprobanteCuentaNumero { get; set; } = null!;
        public string ItemComprobanteGlosa { get; set; } = null!;
        public decimal? ItemComprobanteCargoSoles { get; set; }
        public decimal? ItemComprobanteAbonoSoles { get; set; }
        public decimal? ItemComprobanteCargoDolares { get; set; }
        public decimal? ItemComprobanteAbonoDolares { get; set; }
        public int CajaId { get; set; }
        public int ConceptoOperacionId { get; set; }
        public int MedioDePagoTipoId { get; set; }
        public int ComprobanteId { get; set; }
        public string ComprobanteReferencia { get; set; } = null!;
        public int Idmoneda { get; set; }
    }
}
