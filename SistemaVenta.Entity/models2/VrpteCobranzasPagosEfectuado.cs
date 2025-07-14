using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrpteCobranzasPagosEfectuado
    {
        public string? TipoPersona { get; set; }
        public string DocumentoCobrarPagarPersonaCodigo { get; set; } = null!;
        public string DocumentoCobrarPagarPersonaNombre { get; set; } = null!;
        public DateTime ComprobanteFecha { get; set; }
        public string ComprobanteTipoAbreviacion { get; set; } = null!;
        public string ComprobanteNumero { get; set; } = null!;
        public decimal? DocPagoTotalSoles { get; set; }
        public decimal? DocPagoTotalDolares { get; set; }
        public string CajaCodigo { get; set; } = null!;
        public string CajaNombre { get; set; } = null!;
        public string ConceptoOperacionCodigo { get; set; } = null!;
        public string ConceptoOperacionDescripcion { get; set; } = null!;
        public string DocumentoCobrarPagarTipoAbreviacion { get; set; } = null!;
        public string DocumentoCobrarPagarNumero { get; set; } = null!;
        public string MedioDePagoNumero { get; set; } = null!;
        public string MedioDePagoTipoCodigo { get; set; } = null!;
        public string MedioDePagoTipoDescripcion { get; set; } = null!;
        public string? ItemComprobanteCuentaNumero { get; set; }
        public string ItemComprobanteGlosa { get; set; } = null!;
        public decimal? ItemComprobanteCargoSoles { get; set; }
        public decimal? ItemComprobanteAbonoSoles { get; set; }
        public decimal? ItemComprobanteCargoDolares { get; set; }
        public decimal? ItemComprobanteAbonoDolares { get; set; }
        public int CajaId { get; set; }
        public int ConceptoOperacionId { get; set; }
        public int MedioDePagoTipoId { get; set; }
        public int ComprobanteId { get; set; }
        public int? IdtipoPersona { get; set; }
        public int ComprobanteSucursalId { get; set; }
        public string? NumCp { get; set; }
        public string? DocumentoCobraPagarVendedorCodigo { get; set; }
        public string? DocumentoCobrarPagarVendedorNombre { get; set; }
        public string DocumentoResponsableCodigo { get; set; } = null!;
        public string DocumentoResponsableNombre { get; set; } = null!;
    }
}
