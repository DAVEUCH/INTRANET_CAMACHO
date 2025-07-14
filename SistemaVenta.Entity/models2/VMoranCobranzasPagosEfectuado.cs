using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VMoranCobranzasPagosEfectuado
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
        public string? ItemComprobanteCuentaNumero { get; set; }
        public string ItemComprobanteGlosa { get; set; } = null!;
        public decimal? ItemComprobanteCargoSoles { get; set; }
        public decimal? ItemComprobanteAbonoSoles { get; set; }
        public decimal? ItemComprobanteCargoDolares { get; set; }
        public decimal? ItemComprobanteAbonoDolares { get; set; }
        public int CajaId { get; set; }
        public int ConceptoOperacionId { get; set; }
        public int ComprobanteId { get; set; }
        public int? IdtipoPersona { get; set; }
        public int ComprobanteSucursalId { get; set; }
        public string? NumCp { get; set; }
        public string? DocumentoCobraPagarVendedorCodigo { get; set; }
        public string? DocumentoCobrarPagarVendedorNombre { get; set; }
        public string DocumentoResponsableCodigo { get; set; } = null!;
        public string DocumentoResponsableNombre { get; set; } = null!;
        public DateTime? ComprobanteVentaFecha { get; set; }
        public string? ModalidadCreditoCodigo { get; set; }
        public int? ModalidadCreditoId { get; set; }
        public decimal? LineaCreditoTotal { get; set; }
        public decimal? LineaCreditoSaldo { get; set; }
        public string? LineaCreditoFuerzaVentasCodigo { get; set; }
        public decimal PagoSoles { get; set; }
        public decimal? DocumentoVentaTotal { get; set; }
        public decimal? Saldo { get; set; }
        public DateTime? ComprobanteVentaFechaVenc { get; set; }
        public DateTime? ComprobanteVentaFechaAceptacion { get; set; }
        public int? VendedorId { get; set; }
        public string? FuerzaVentasNombre { get; set; }
        public int? PersonaId { get; set; }
        public string? SupervisorCodigo { get; set; }
        public string? SupervisorNombre { get; set; }
        public int? SupervisorId { get; set; }
        public string? VendedorfuerzaCodigo { get; set; }
        public string? VendedorFuerzaNombre { get; set; }
        public int? VendedorFuerzaId { get; set; }
    }
}
